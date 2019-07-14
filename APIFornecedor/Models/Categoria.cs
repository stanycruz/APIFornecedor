namespace APIFornecedor.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public SubCategoriaProduto SubCategoriaProduto { get; set; }
        public SubCategoriaServico SubCategoriaServico { get; set; }
    }
}
