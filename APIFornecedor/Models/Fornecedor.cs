using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public string Endereco { get; set; }
        public string EnderecoAdicional { get; set; }
        public string WebSite { get; set; }
        public string NumTelefone { get; set; }
        public string NumFax { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public IList<TipoFornecedor> TiposFornecedores { get; set; }
        public Usuario IdUsuario { get; set; }
        public CatalogoMaterial IdCatalogoMaterial { get; set; }
        public CatalogoServico CatalogoServico { get; set; }

        public Fornecedor()
        {
            TiposFornecedores = new List<TipoFornecedor>();
        }
    }
}
