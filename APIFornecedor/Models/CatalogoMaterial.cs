using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class CatalogoMaterial
    {
        public int Id { get; set; }
        public int Empresa { get; set; }
        public Produto IdProduto { get; set; }
        public int Quantidade { get; set; }
        public float Valor { get; set; }
        public IList<Fornecedor> Fornecedores { get; set; }

        public CatalogoMaterial()
        {
            Fornecedores = new List<Fornecedor>();
        }
    }
}