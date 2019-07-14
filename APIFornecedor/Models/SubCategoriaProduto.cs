using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class SubCategoriaProduto
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public IList<TipoProduto> TiposProdutos { get; set; }

        public SubCategoriaProduto()
        {
            TiposProdutos = new List<TipoProduto>();
        }
    }
}