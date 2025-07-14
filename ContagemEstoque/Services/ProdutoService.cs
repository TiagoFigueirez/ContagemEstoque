using ContagemEstoque.Models;
using ContagemEstoque.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ContagemEstoque.Services
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoModel TratarCodigoBarras(string codigoLido, out string messagemErro, int LastId)
        {
            var produto = codigoLido.Split(' ');

            if (!VerificarProduto(produto, out messagemErro))
            {
                return null;
            }

            ProdutoModel produtoTratado = new ProdutoModel(LastId + 1, produto[0], produto[1], produto[2], 1);
            return produtoTratado;
        }

        public ProdutoModel ConsultarProduto(List<ProdutoModel> produtos, ProdutoModel produto)
        {
            var produtoExistente = produtos.FirstOrDefault(p => p.Codigo == produto.Codigo
                                                            && p.Lote == produto.Lote);

            return produtoExistente;
        }

        private bool VerificarProduto(string[] produto, out string erro)
        {
            erro = null;

            if (produto[2].Length > 7)
            {
                erro = "Falha ao ler o codigo tente novamente !";
                return false;
            }

            return true;
        }
    }
}
