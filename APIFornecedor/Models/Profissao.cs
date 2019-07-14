using System.Collections.Generic;

namespace APIFornecedor.Models
{
    public class Profissao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Usuario> Usuarios { get; set; }

        public Profissao()
        {
            Usuarios = new List<Usuario>();
        }
    }
}