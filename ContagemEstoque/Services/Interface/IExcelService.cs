using ContagemEstoque.Models;
using System.Collections.Generic;

namespace ContagemEstoque.Services.Interface
{
    public interface IExcelService
    {
        List<ProdutoModel> ExtrairDadosExcel(string caminhoArq);
    }
}
