using ContagemEstoque.Models;
using System.Collections.Generic;

namespace ContagemEstoque.Services.Interface
{
    public interface IProdutoService
    {
        ProdutoModel TratarCodigoBarras(string codigoLido, out string messagemErro, int LastId);
        ProdutoModel ConsultarProduto(List<ProdutoModel> produtos, ProdutoModel produto);
    }
}
