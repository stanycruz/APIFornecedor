using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
                .ToTable("categoria");

            builder
                .Property(c => c.Id)
                .HasColumnName("id");

            builder
                .Property(c => c.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}