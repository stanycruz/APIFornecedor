using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int NomeCliente { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string WebSite { get; set; }
        public string NumTelefone { get; set; }
        public string NumFax { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public Usuario IdUsuario { get; set; }
    }
}