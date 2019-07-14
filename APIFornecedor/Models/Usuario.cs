using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int TpUsuario { get; set; }
        public string Nome { get; set; }
        public Profissao IdProfissao { get; set; }
        public string NumTelefone { get; set; }
        public string NumCelular { get; set; }
        public string Email { get; set; }
        public string EmailAdicional { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Empresa { get; set; }
        public IList<Fornecedor> Fornecedores { get; set; }
        public IList<Cliente> Clientes { get; set; }
        public bool TpContrato { get; set; }

        public Usuario()
        {
            Fornecedores = new List<Fornecedor>();
            Clientes = new List<Cliente>();
        }
    }
}
