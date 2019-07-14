using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class SubCategoriaProdutoConfiguration : IEntityTypeConfiguration<SubCategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<SubCategoriaProduto> builder)
        {
            builder
                .ToTable("subcategoria_produto");

            builder
                .Property(scp => scp.CategoriaId)
                .HasColumnName("categoria_id");

            builder
                .HasKey(scp => scp.CategoriaId);

            builder
                .Property(scp => scp.Nome)
                .HasColumnName("nome")
                .IsRequired();
        }
    }
}