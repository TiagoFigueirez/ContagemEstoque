using ComponentFactory.Krypton.Toolkit;
using ContagemEstoque.Helpers;
using System.Windows.Forms;

namespace ContagemEstoque.Viwes
{
    public partial class frmAddFilePathSave : KryptonForm
    {
        public frmAddFilePathSave()
        {
            InitializeComponent();
        }

        private void frmAddFilePathSave_Load(object sender, System.EventArgs e)
        {
            TextoForLblShowPath();
        }

        private void SelecionarPasta(object sender, System.EventArgs e)
        {
            bool SavePath = FileHelper.Salvar();

            if (SavePath)
            {
                MessageBox.Show("Caminho selecionado com sucesso !", "Sucesso !");
                TextoForLblShowPath();
            }
        }

        private void TextoForLblShowPath()
        {
            string filePath = FileHelper.CarregarArquivo();

            lblShowPath.Text = filePath == null ?
                               "Caminho para salvar arquivo não selecionado" :
                               $"Pasta para salvar relatorio: \n{filePath}";
        }
    }
}
