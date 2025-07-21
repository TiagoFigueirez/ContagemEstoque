using ComponentFactory.Krypton.Toolkit;
using ContagemEstoque.Helpers;
using ContagemEstoque.Models;
using ContagemEstoque.Services;
using ContagemEstoque.Services.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContagemEstoque
{
    public partial class FrmMenuPrincipal : KryptonForm
    {
        private string codigo;
        private List<ProdutoModel> produtoContados = new List<ProdutoModel>();

        //interfaces
        private readonly IProdutoService _produtoService;
        private readonly IExcelService _excelService;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();
            _excelService = new ExcelService();
        }

        private void FrmMenuPrincipal_Load(object sender, System.EventArgs e)
        {
            GridViewHelper.FormatarGridView(dgvProdutos);
        }

        private void LerCodigoBarras(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    var produto = _produtoService.TratarCodigoBarras(codigo, out string erro, produtoContados.Count);

                    txtCodigoDeBarras.Clear();
                    codigo = "";

                    if (produto != null)
                    {
                        var produtoExistente = _produtoService.ConsultarProduto(produtoContados, produto);

                        if (produtoExistente == null)
                        {
                            produtoContados.Add(produto);
                            GridViewHelper.CarregarGridView(dgvProdutos, produtoContados);
                        }
                        else
                        {
                            produtoExistente.Quantidade++;
                            GridViewHelper.CarregarGridView(dgvProdutos, produtoContados);
                        }
                    }
                    else
                    {
                        MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        codigo = "";
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Falha ao ler o código tente novamente !", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoDeBarras.Clear();
                txtCodigoDeBarras.Focus();
            }

            codigo += e.KeyChar;

        }
        private void GerarRelatorio(object sender, EventArgs e)
        {
            string arquivoExtrairDados = FileHelper.SelecionarArquivo();

            _excelService.ExtrairDadosExcel(arquivoExtrairDados, produtoContados);

        }

        private void ZerarContagem(object sender, EventArgs e)
        {
            if (produtoContados.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja realmente remover zerar a lista ?",
                                                     "Atenção", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    produtoContados.Clear();
                    dgvProdutos.DataSource = null;
                    txtCodigoDeBarras.Focus();
                }
            }
        }

        private void ExcluirProduto(object sender, System.EventArgs e)
        {
            if (dgvProdutos.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedCells[0].Value);

                DialogResult result = MessageBox.Show("Deseja realmente remover o item?",
                                                     "Atenção", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var produtoExcluido = _produtoService.RemoverProduto(produtoContados, id);

                    if (produtoExcluido != null)
                    {
                        MessageBox.Show("Produto Excluido !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridViewHelper.CarregarGridView(dgvProdutos, produtoContados);
                        txtCodigoDeBarras.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir produto !", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    txtCodigoDeBarras.Focus();
                }
            }
        }

    }
}
