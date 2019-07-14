namespace APIFornecedor.Models
{
    public class TipoFornecedor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Fornecedor IdFornecedor { get; set; }
    }
}