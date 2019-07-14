using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFornecedor.Data
{
    public class SolutionContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<TipoFornecedor> TipoFornecedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CatalogoMaterial> CatalogoMateriais { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TiposProdutos { get; set; }
        public DbSet<SubCategoriaProduto> SubCategoriaProdutos { get; set; }
        public DbSet<CatalogoServico> CatalogosServicos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoServico> TiposServicos { get; set; }
        public DbSet<SubCategoriaServico> SubCategoriaServicos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=IP_SQL_SERVER;Initial Catalog=DATABASE_NAME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new TipoFornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProfissaoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogoMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoriaProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogoServicoConfiguration());
            modelBuilder.ApplyConfiguration(new ServicoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoServicoConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoriaServicoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
        }
    }
}
