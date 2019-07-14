using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public SubCategoriaServico IdSubCategoriaServico { get; set; }
        public IList<Servico> Servicos { get; set; }

        public TipoServico()
        {
            Servicos = new List<Servico>();
        }
    }
}