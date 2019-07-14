using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class TipoProdutoConfiguration : IEntityTypeConfiguration<TipoProduto>
    {
        public void Configure(EntityTypeBuilder<TipoProduto> builder)
        {
            builder
                .ToTable("tipo_produto");

            builder
                .Property(tp => tp.Id)
                .HasColumnName("id");

            builder
                .Property(tp => tp.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(tp => tp.TpUnidadeMedida)
                .HasColumnName("tp_unidade_medida");

            builder
                .Property<int>("subcategoria_produto_id");

            builder
                .HasOne(tp => tp.IdSubCategoriaProduto)
                .WithMany(scp => scp.TiposProdutos)
                .HasForeignKey("subcategoria_produto_id");
        }
    }
}