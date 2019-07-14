namespace APIFornecedor.Models
{
    public class CatalogoServico
    {
        public int FornecedorId { get; set; }
        public float Valor { get; set; }
        public Servico Servico { get; set; }
    }
}
