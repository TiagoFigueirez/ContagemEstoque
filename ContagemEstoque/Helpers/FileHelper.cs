using System;
using System.IO;
using System.Windows.Forms;

namespace ContagemEstoque.Helpers
{
    public static class FileHelper
    {
        private static readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\caminho.txt";

        public static string SelecionarArquivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecionar arquivo",
                Filter = "Arquivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        public static string CarregarRelatorioExistente()
        {
            string caminhoArq = CarregarArquivo();
            string arq = Path.Combine(caminhoArq, $"Relatorio_{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx");

            if (File.Exists(arq))
            {
                return arq;
            }
            else
            {
                return null;
            }
        }

        public static string SelecionarDiretorio(string fileName = null)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult res = folderBrowserDialog.ShowDialog();

                if (res == DialogResult.OK && fileName != null)
                {
                    string diretorio = folderBrowserDialog.SelectedPath;

                    return Path.Combine(diretorio, fileName);
                }
                else if (res == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }

                return null;
            }
        }

        public static bool Salvar()
        {
            string filePathSave = SelecionarDiretorio();

            try
            {
                if (filePathSave != null)
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine(filePathSave);
                    }
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static string CarregarArquivo()
        {
            try
            {
                string getFilePath = File.ReadAllText(filePath);

                if (getFilePath == "\r\n")
                {
                    return null;
                }

                return getFilePath;
            }
            catch
            {
                return null;
            }

        }
    }
}
