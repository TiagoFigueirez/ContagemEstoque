using ContagemEstoque.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContagemEstoque.Helpers
{
    public static class ProdutoHelper
    {
        public static List<ProdutoModel>RenumerarId(List<ProdutoModel> produtos)
        {
            int id = 1;

            foreach (ProdutoModel model in produtos)
            {
                model.Id = id;

                id++;
            }
            return produtos;
        }

        public static List<ProdutoModel> TratarProdutosPuxados(List<ProdutoModel> produtosPuxados, List<ProdutoModel> produtos)
        {
            foreach(var iten in produtosPuxados)
            {
                var produto = produtos.FirstOrDefault(p => p.Codigo == iten.Codigo && p.Lote == iten.Lote);

                if (produto == null)
                {
                    produtos.Add(produto);
                }
            }

            return produtos;
        }
    }
}
