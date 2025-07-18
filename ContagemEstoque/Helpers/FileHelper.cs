using System.Windows.Forms;

namespace ContagemEstoque.Helpers
{
    public static class FileHelper
    {
        public static string SelecionarArquivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title="Selecionar arquivo",
                Filter = "Arquivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }
    }
}
