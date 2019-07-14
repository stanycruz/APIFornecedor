using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class TipoFornecedorConfiguration : IEntityTypeConfiguration<TipoFornecedor>
    {
        public void Configure(EntityTypeBuilder<TipoFornecedor> builder)
        {
            builder
                .ToTable("tipo_fornecedor");

            builder
                .Property(tf => tf.Id)
                .HasColumnName("id");

            builder
                .Property(tf => tf.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder
                .Property<int>("fornecedor_id");

            builder
                .HasOne(tf => tf.IdFornecedor)
                .WithMany(f => f.TiposFornecedores)
                .HasForeignKey("fornecedor_id");
        }
    }
}