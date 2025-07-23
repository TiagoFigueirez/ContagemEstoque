using ClosedXML.Excel;
using ContagemEstoque.Helpers;
using ContagemEstoque.Models;
using ContagemEstoque.Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ContagemEstoque.Services
{
    public class ExcelService : IExcelService
    {
        public List<ProdutoModel> produtosExtraidos = new List<ProdutoModel>();

        public void ExtrairDadosExcel(string caminhoArq, List<ProdutoModel> produtos)
        {           
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

             GerarRelatorio(produtos);
        }

        private void GerarRelatorio(List<ProdutoModel> produtos)
        {
            var caminhoArq = FileHelper.CarregarArquivo();
            Path.Combine(caminhoArq, $"Relatorio_{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var planilha = workbook.Worksheets.Add("Relatorio");

                planilha.Cell(1, 1).Value = "Codigo";
                planilha.Cell(1, 2).Value = "Lote";
                planilha.Cell(1, 3).Value = "Data Validade";
                planilha.Cell(1, 4).Value = "Qtde Estoque";
                planilha.Cell(1, 5).Value = "Qtde Sistema";
                planilha.Cell(1, 6).Value = "Resultado";

                for(int i = 0;  i < produtos.Count; i++)
                {
                    var produto = produtos[i];
                    int linha = i + 2;

                    var encontrarProduto = produtosExtraidos.FirstOrDefault(p => p.Codigo == produto.Codigo
                                                    && p.Lote == produto.Lote);

                    if(encontrarProduto != null)
                    {
                        planilha.Cell(linha, 1).Value = produto.Codigo;
                        planilha.Cell(linha, 2).Value = produto.Lote;
                        planilha.Cell(linha, 3).Value = produto.DataValidade;
                        planilha.Cell(linha, 4).Value = produto.Quantidade;
                        planilha.Cell(linha, 5).Value = encontrarProduto.Quantidade;

                        planilha.Cell(linha, 6).Value =
                            produto.Quantidade - encontrarProduto.Quantidade != 0 ?
                            (produto.Quantidade - encontrarProduto.Quantidade < 0 ?
                            $"Falta no estoque: {(produto.Quantidade - encontrarProduto.Quantidade)* - 1}" :
                            $"Falta no sistema: {produto.Quantidade - encontrarProduto.Quantidade}") :
                            "OK";
                    }
                    else
                    {
                        planilha.Cell(linha, 1).Value = produto.Codigo;
                        planilha.Cell(linha, 2).Value = produto.Lote;
                        planilha.Cell(linha, 3).Value = produto.DataValidade;
                        planilha.Cell(linha, 4).Value = produto.Quantidade;
                        planilha.Cell(linha, 5).Value = 0;
                        planilha.Cell(linha, 6).Value = $"Falta no sistema: {produto.Quantidade}";
            }

                }

                planilha.Columns().AdjustToContents();
                workbook.SaveAs(caminhoArq);

                Process.Start(caminhoArq);

            }
                
        }
    }
}
