using ComponentFactory.Krypton.Toolkit;
using ContagemEstoque.Helpers;
using ContagemEstoque.Models;
using ContagemEstoque.Services;
using ContagemEstoque.Services.Interface;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ContagemEstoque
{
    public partial class FrmMenuPrincipal : KryptonForm
    {
        private string codigo;
        private List<ProdutoModel> produtoContados = new List<ProdutoModel>();

        //interfaces
        private readonly IProdutoService _produtoService;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();
        }

        private void FrmMenuPrincipal_Load(object sender, System.EventArgs e)
        {
            FormatarGridView();
        }

        private void LerCodigoBarras(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            codigo += e.KeyChar;

            if (e.KeyChar == (char)13)
            {
                var produto = _produtoService.TratarCodigoBarras(codigo, out string erro, produtoContados.Count);
                
                txtCodigoDeBarras.Clear();
                codigo = "";

                if (produto != null)
                {
                    var produtoExistente = _produtoService.ConsultarProduto(produtoContados, produto);

                    if(produtoExistente == null)
                    {
                        produtoContados.Add(produto);
                        CarregarGridView();
                    }
                    else
                    {
                        produtoExistente.Quantidade++;
                        CarregarGridView();
                    }

                }
                else
                {
                    MessageBox.Show(erro, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            
        }

        private void CarregarGridView()
        {
            int ultimaLinha;

            DataTable tabela = FormatarDataTable.CriarTabela(produtoContados);

            dgvProdutos.DataSource = tabela;

            ultimaLinha = dgvProdutos.Rows.Count - 1;

            if (ultimaLinha > 0)
            {
                dgvProdutos.FirstDisplayedScrollingRowIndex = ultimaLinha;
                dgvProdutos.Rows[ultimaLinha].Selected = true;
                dgvProdutos.CurrentCell = dgvProdutos.Rows[ultimaLinha].Cells[0];

            }

            foreach (DataGridViewColumn column in dgvProdutos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void FormatarGridView()
        {
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.BorderStyle = BorderStyle.None;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

        }

    }
}
