using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Servico
    {
        public int CatalogoServicoId { get; set; }
        public string Descricao { get; set; }
        public TipoServico IdTipoServico { get; set; }
    }
}
