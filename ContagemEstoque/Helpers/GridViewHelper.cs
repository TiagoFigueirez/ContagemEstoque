using ContagemEstoque.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ContagemEstoque.Helpers
{
    public static class GridViewHelper
    {
        public static void FormatarGridView(DataGridView gridProdutos)
        {
            gridProdutos.EnableHeadersVisualStyles = false;
            gridProdutos.BorderStyle = BorderStyle.None;
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToResizeRows = false;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            gridProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        public static void CarregarGridView(DataGridView gridProdutos, List<ProdutoModel> produtoContados)
        {
            if (produtoContados.Count > 0)
            {
                int ultimaLinha;

                DataTable tabela = FormatarDataTable.CriarTabela(produtoContados);

                gridProdutos.DataSource = tabela;

                ultimaLinha = gridProdutos.Rows.Count - 1;

                if (ultimaLinha > 0)
                {
                    gridProdutos.FirstDisplayedScrollingRowIndex = ultimaLinha;
                    gridProdutos.Rows[ultimaLinha].Selected = true;
                    gridProdutos.CurrentCell = gridProdutos.Rows[ultimaLinha].Cells[0];

                }

                foreach (DataGridViewColumn column in gridProdutos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
