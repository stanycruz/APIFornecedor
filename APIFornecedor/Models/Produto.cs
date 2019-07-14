using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoProduto IdTipoProduto { get; set; }
        public string Especificacao { get; set; }
        public bool Ativo { get; set; }
        public IList<CatalogoMaterial> CatalogosMateriais { get; set; }

        public Produto()
        {
            CatalogosMateriais = new List<CatalogoMaterial>();
        }
    }
}