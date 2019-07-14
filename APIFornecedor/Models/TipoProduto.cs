using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class TipoProduto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public SubCategoriaProduto IdSubCategoriaProduto { get; set; }
        public int TpUnidadeMedida { get; set; }
        public IList<Produto> Produtos { get; set; }

        public TipoProduto()
        {
            Produtos = new List<Produto>();
        }
    }
}