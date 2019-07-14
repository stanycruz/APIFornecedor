using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder
                .ToTable("servico");

            builder
                .Property(s => s.CatalogoServicoId)
                .HasColumnName("catalogo_servico_id");

            builder
                .HasKey(s => s.CatalogoServicoId);

            builder
                .Property(s => s.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property<int>("tipo_servico_id");

            builder
                .HasOne(s => s.IdTipoServico)
                .WithMany(ts => ts.Servicos)
                .HasForeignKey("tipo_servico_id");
        }
    }
}