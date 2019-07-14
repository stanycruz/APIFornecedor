using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class CatalogoServicoConfiguration : IEntityTypeConfiguration<CatalogoServico>
    {
        public void Configure(EntityTypeBuilder<CatalogoServico> builder)
        {
            builder
                .ToTable("catalogo_servico");

            builder
                .Property(cs => cs.FornecedorId)
                .HasColumnName("fornecedor_id");

            builder
                .HasKey(cs => cs.FornecedorId);

            builder
                .Property(cs => cs.Valor)
                .HasColumnName("valor")
                .HasColumnType("money");
        }
    }
}