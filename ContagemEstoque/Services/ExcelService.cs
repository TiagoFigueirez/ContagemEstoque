using ClosedXML.Excel;
using ContagemEstoque.Models;
using ContagemEstoque.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ContagemEstoque.Services
{
    public class ExcelService : IExcelService
    {
        public List<ProdutoModel>ExtrairDadosExcel(string caminhoArq)
        {
            var produtosExtraidos = new List<ProdutoModel>();
            
            using(var workbook = new XLWorkbook(caminhoArq))
            {
                var planilha = workbook.Worksheet(2);
                var cabecalhos = planilha.Row(2).
                                          Cells().
                                          Select(c => c.Value.ToString()).
                                          ToList();

                var indices = new Dictionary<string, int>
                {
                    ["Produto"] = cabecalhos.IndexOf("Produto") + 1,
                    ["Lote"] = cabecalhos.IndexOf("Lote") + 1,
                    ["Data Validad"] = cabecalhos.IndexOf("Data Validad") + 1,
                    ["Saldo 1a.U.M."] = cabecalhos.IndexOf("Saldo 1a.U.M.") + 1,
                };

                foreach(var linha in planilha.RangeUsed().RowsUsed().Skip(2))
                {
                    var produto = new ProdutoModel(
                          0,
                          linha.Cell(indices["Produto"]).GetString(),
                          linha.Cell(indices["Lote"]).GetString(),
                          linha.Cell(indices["Data Validad"]).GetString(),
                          int.TryParse(linha.Cell(indices["Saldo 1a.U.M."]).GetString(), out int resultado) ? resultado : 1
                    );

                        var produtoExistente = produtosExtraidos.FirstOrDefault(p => p.Codigo == produto.Codigo
                                                                                && p.Lote == produto.Lote);
                        if(produtoExistente != null)
                        {
                            produtoExistente.Quantidade = produto.Quantidade >  1 ? 
                                                          produtoExistente.Quantidade + 
                                                          produto.Quantidade : 
                                                          produtoExistente.Quantidade++;
                        }
                        else
                        {
                            produtosExtraidos.Add(produto);
                        }
                    }
                }
                
            
            return produtosExtraidos;
        }
    }
}
