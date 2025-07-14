using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ContagemEstoque.Helpers
{
    public static class FormatarDataTable
    {
        public static DataTable CriarTabela<T>(List<T> itens) where T : class
        {
            //pega o nome da classe e retorna-o como string
            var tabela = new DataTable(typeof(T).Name);

            //pegar as propriedades da classe e armazena em um array
            PropertyInfo[] propriedades = typeof(T).GetProperties();

            foreach (var prop in propriedades)
            {
                //pega o tipo de coluna e trata nulos
                Type tipoColuna = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                //adiciona uma coluna com base no nome da propriedade
                tabela.Columns.Add(prop.Name, tipoColuna);
            }

            foreach(T item in itens)
            {
                //cria um array de objetos para armazena os dados do obj seu tamanho e a quantidade de props
                var valores = new object[propriedades.Length];

                for (int i = 0; i < propriedades.Length; i++)
                {
                    //cria uma linha a partir do array armazenando cada prop do obj nas unudades do array
                    valores[i] = propriedades[i].GetValue(item, null)?? DBNull.Value;
                }
                //adiciona a linha na tabela
                tabela.Rows.Add(valores);
            }

            return tabela;
        }
    }
}
