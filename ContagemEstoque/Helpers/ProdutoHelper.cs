using ContagemEstoque.Models;
using System.Collections.Generic;

namespace ContagemEstoque.Helpers
{
    public static class ProdutoHelper
    {
        public static List<ProdutoModel>RenumerarId(List<ProdutoModel> produtos)
        {
            int id = 1;

            foreach (ProdutoModel model in produtos)
            {
                model.Id = id;

                id++;
            }
            return produtos;
        }
    }
}
