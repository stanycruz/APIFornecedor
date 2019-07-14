using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class TipoServicoConfiguration : IEntityTypeConfiguration<TipoServico>
    {
        public void Configure(EntityTypeBuilder<TipoServico> builder)
        {
            builder
                .ToTable("tipo_servico");

            builder
                .Property(ts => ts.Id)
                .HasColumnName("id");

            builder
                .Property(ts => ts.Descricao)
                .HasColumnName("descricao")
                .IsRequired();

            builder
                .Property<int>("subcategoria_servico_id");

            builder
                .HasOne(ts => ts.IdSubCategoriaServico)
                .WithMany(scs => scs.TiposServicos)
                .HasForeignKey("subcategoria_servico_id");
        }
    }
}