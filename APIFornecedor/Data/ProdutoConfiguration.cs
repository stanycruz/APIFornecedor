using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable("produto");

            builder
                .Property(p => p.Id)
                .HasColumnName("id");

            builder
                .Property(p => p.Nome)
                .HasColumnName("nome")
                .IsRequired();

            builder
                .Property<int>("tipo_produto_id");

            builder
                .HasOne(p => p.IdTipoProduto)
                .WithMany(tp => tp.Produtos)
                .HasForeignKey("tipo_produto_id");

            builder
                .Property(p => p.Especificacao)
                .HasColumnName("especificacao")
                .HasColumnType("varchar(50)");

            builder
                .Property(p => p.Ativo)
                .HasColumnName("ativo");
        }
    }
}