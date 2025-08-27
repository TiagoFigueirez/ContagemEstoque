using ContagemEstoque.Models;
using System.Collections.Generic;

namespace ContagemEstoque.Services.Interface
{
    public interface IExcelService
    {
        void RelatorioFinal(string caminhoArq, List<ProdutoModel> produtos);
        void SalvarContagem(string caminhoArq, List<ProdutoModel> produtos);
        List<ProdutoModel> CarregarRelatorio(string caminhoArq);
    }
}
