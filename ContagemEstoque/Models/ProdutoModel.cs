namespace ContagemEstoque.Models
{
    public class ProdutoModel
    {
        public ProdutoModel(int id, string codigo, string lote, string dataValidade, int quantidade)
        {
            Id = id;
            Codigo = codigo;
            Lote = lote;
            DataValidade = dataValidade;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Lote { get; set; }
        public string DataValidade { get; set; }
        public int Quantidade { get; set; }
    }
}
