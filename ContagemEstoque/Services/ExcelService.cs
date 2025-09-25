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
        public Dictionary<string, string> mapeamento = new Dictionary<string, string>() {
            ["Codigo"] = "Codigo",
            ["Lote"] = "Lote",
            ["Validade"] = "Data Validade",
            ["Quantidade"] = "Qtde Estoque"
        };

        //este metodo e responsavel por emitir o relatorio com a analise do estoque em excel
        public void RelatorioFinal(string caminhoArq, List<ProdutoModel> produtos)
        {
            
            var mapeamentoRelatorioFinal = new Dictionary<string, string>
            {
                ["Codigo"] = "Produto",
                ["Lote"] = "Lote",
                ["Validade"] = "Data Validad",
                ["Quantidade"] = "Saldo 1a.U.M."
            };

            produtosExtraidos = LerDados(caminhoArq, mapeamentoRelatorioFinal, 2, 2);

            caminhoArq = FileHelper.CarregarArquivo();
            var arquivo = Path.Combine(caminhoArq, $"Relatorio_{DateTime.Today.ToString("dd-MM-yyyy")}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var planilha = workbook.Worksheets.Add("Relatorio");

                GerarPlanilha(produtos, planilha, true);
                workbook.SaveAs(arquivo);

                Process.Start(arquivo);
            }
        }

        public List<ProdutoModel> CarregarRelatorio(string caminhoArq)
        {
            caminhoArq = FileHelper.CarregarRelatorioExistente();
            produtosExtraidos = LerDados(caminhoArq, mapeamento);

            return produtosExtraidos;
        }

        public bool SalvarContagem(string caminhoArq, List<ProdutoModel> produtos)
        {
            var arquivo = Path.Combine(caminhoArq, $"Contagem_{DateTime.Today.ToString("dd-MM-yyyy")}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var planilha = workbook.Worksheets.Add("Relatorio");

                GerarPlanilha(produtos, planilha);
                workbook.SaveAs(arquivo);

                var arqSave = FileHelper.VerificarArquivoSalvo(arquivo);

                if (arqSave != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private List<ProdutoModel> LerDados(string caminhoArq, Dictionary<string,string> indiceCabecalho, 
                                            int iniciallinha = 1, int numPlanilha = 1)
        {
            using (var workbook = new XLWorkbook(caminhoArq))
            {
                int id = 1;
                List<ProdutoModel> produtosExtraidos = new List<ProdutoModel>();

                var planilha = workbook.Worksheet(numPlanilha);
                var cabecalhos = planilha.Row(iniciallinha).
                                          Cells().
                                          Select(c => c.Value.ToString()).
                                          ToList();

                var indices = new Dictionary<string, int>();

                foreach (var campo in indiceCabecalho)
                {
                    var nomeCabecalho = campo.Value;
                    var indice = cabecalhos.IndexOf(nomeCabecalho);

                    if (indice >= 0)
                        indices[campo.Key] = indice + 1;
                }

                foreach (var linha in planilha.RangeUsed().RowsUsed().Skip(iniciallinha))
                {
                   
                    var codigo = linha.Cell(indices["Codigo"]).GetString();
                    var lote = linha.Cell(indices["Lote"]).GetString();
                    var validade = linha.Cell(indices["Validade"]).GetString();
                    var saldoTexto = linha.Cell(indices["Quantidade"]).GetString();

                    int quantidade = int.TryParse(saldoTexto, out int q) ? q : 0;

                    var produto = new ProdutoModel(id, codigo, lote, validade, quantidade);
                    id++;

                    var produtoExistente = produtosExtraidos.FirstOrDefault(p => p.Codigo == produto.Codigo
                                                                            && p.Lote == produto.Lote);

                    if (produtoExistente != null)
                    {
                        produtoExistente.Quantidade += (produto.Quantidade > 1 ? produto.Quantidade : 1);
                    }
                    else
                    {
                        produtosExtraidos.Add(produto);
                    }

                }

                return produtosExtraidos;
            }
        }        
        
        private void GerarPlanilha(List<ProdutoModel> produtos, IXLWorksheet planilha, bool analise = false)
        {
            planilha.Cell(1, 1).Value = "Codigo";
            planilha.Cell(1, 2).Value = "Lote";
            planilha.Cell(1, 3).Value = "Data Validade";
            planilha.Cell(1, 4).Value = "Qtde Estoque";

            if (analise)
            {
                planilha.Cell(1, 5).Value = "Qtde Sistema";
                planilha.Cell(1, 6).Value = "Resultado";
            }

            for(int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                int linha = i + 2;

                planilha.Cell(linha, 1).Value = produto.Codigo;
                planilha.Cell(linha, 2).Value = produto.Lote;
                planilha.Cell(linha, 3).Value = produto.DataValidade;
                planilha.Cell(linha, 4).Value = produto.Quantidade;

                if (analise)
                {
                    var produtoExistente = produtosExtraidos.FirstOrDefault(p => p.Codigo == produto.Codigo 
                                                                            && p.Lote == produto.Lote);
                    int qtdSistema = produtoExistente?.Quantidade ?? 0;
                    int diferenca = produto.Quantidade - qtdSistema;

                    planilha.Cell(linha, 5).Value = qtdSistema;
                    planilha.Cell(linha, 6).Value =
                        diferenca == 0 ? "OK" :
                        diferenca < 0 ? $"Falta no estoque {-diferenca}" :
                        $"Falta no Sistema: {diferenca}";
                }
            }
            planilha.Columns().AdjustToContents();
        }
    }
}
