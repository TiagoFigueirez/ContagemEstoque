using System;
using System.IO;
using System.Windows.Forms;

namespace ContagemEstoque.Helpers
{
    public static class FileHelper
    {
        private static readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ContagemEstoque";

        public static string SelecionarArquivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title= "Selecionar arquivo",
                Filter = "Arquivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        public static string SelecionarDiretorio(string fileName)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult res = folderBrowserDialog.ShowDialog();

                if (res == DialogResult.OK)
                {
                    string diretorio = folderBrowserDialog.SelectedPath;

                    return Path.Combine(diretorio, fileName);
                }

                return null;
            }
        }

        public static bool Salvar()
        {
            string filePathSave = SelecionarArquivo();

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(filePathSave);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
                           
        public static string CarregarArquivo()
        {
            if(!File.Exists(filePath))
                return null;

            string getFilePath = File.ReadAllText(filePath);

            return getFilePath;
        }
    }
}
