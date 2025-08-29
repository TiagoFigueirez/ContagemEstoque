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

            ProdutoModel produtoTratado = new ProdutoModel(LastId + 1, produto[0].Trim(), produto[1], produto[2], 1);
            return produtoTratado;
        }

        public ProdutoModel ConsultarProduto(List<ProdutoModel> produtos, ProdutoModel produto)
        {
            var produtoExistente = produtos.FirstOrDefault(p => p.Codigo == produto.Codigo
                                                            && p.Lote == produto.Lote);

            return produtoExistente;
        }

        public ProdutoModel RemoverProduto(List<ProdutoModel> produtos, int id)
        {
            var produtoExistente = produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExistente != null)
            {
                produtos.Remove(produtoExistente);
                RenumerarContador(produtos);
            }

            return produtoExistente;
        }
        private void RenumerarContador(List<ProdutoModel> produtos)
        {
            if (produtos.Count > 0)
            {
                int renumerador = 1;

                foreach (var produto in produtos)
                {
                    produto.Id = renumerador;
                    renumerador++;
                }
            }
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
