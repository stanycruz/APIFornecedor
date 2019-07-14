using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class SubCategoriaServicoConfiguration : IEntityTypeConfiguration<SubCategoriaServico>
    {
        public void Configure(EntityTypeBuilder<SubCategoriaServico> builder)
        {
            builder
                .ToTable("subcategoria_servico");

            builder
                .Property(scs => scs.CategoriaId)
                .HasColumnName("categoria_id");

            builder
                .HasKey(scs => scs.CategoriaId);

            builder
                .Property(scs => scs.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}