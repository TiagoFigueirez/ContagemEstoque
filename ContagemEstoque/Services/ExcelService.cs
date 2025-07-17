using ClosedXML.Excel;
using ContagemEstoque.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContagemEstoque.Services
{
    public class ExcelService
    {
        public List<ProdutoModel>ExtrairDadosExcel(string caminhoArq)
        {
            var ProdutosExtraidos = new List<ProdutoModel>();
            
            using(var workbook = new XLWorkbook(caminhoArq))
            {
                var planilha = workbook.Worksheet(2);
                var cabecalhos = planilha.Row(1).
                                          Cells().
                                          Select(c => c.Value.ToString()).ToList();

                var indices = new Dictionary<string, int>
                {
                    ["Produto"] = cabecalhos.IndexOf("Produto") + 1,
                    ["Lote"] = cabecalhos.IndexOf("Lote") + 1,
                    ["Data Validad"] = cabecalhos.IndexOf("Data Validad") + 1,
                    ["Saldo 1a.U.M."] = cabecalhos.IndexOf("Saldo 1a.U.M.") + 1,
                };

                return ProdutosExtraidos;   
            }
        }
    }
}
