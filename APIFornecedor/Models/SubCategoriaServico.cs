using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class SubCategoriaServico
    {
        public int CategoriaId { get; set; }
        public int Nome { get; set; }
        public IList<TipoServico> TiposServicos { get; set; }

        public SubCategoriaServico()
        {
            TiposServicos = new List<TipoServico>();
        }
    }
}