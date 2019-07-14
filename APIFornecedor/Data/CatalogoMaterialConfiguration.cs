using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class CatalogoMaterialConfiguration : IEntityTypeConfiguration<CatalogoMaterial>
    {
        public void Configure(EntityTypeBuilder<CatalogoMaterial> builder)
        {
            builder
                .ToTable("catalogo_material");

            builder
                .Property(cm => cm.Id)
                .HasColumnName("id");

            builder
                .Property(cm => cm.Empresa)
                .HasColumnName("empresa_id");

            builder
                .Property<int>("produto_id");

            builder
                .HasOne(cm => cm.IdProduto)
                .WithMany(p => p.CatalogosMateriais)
                .HasForeignKey("produto_id");

            builder
                .Property(cm => cm.Quantidade)
                .HasColumnName("quantidade");

            builder
                .Property(cm => cm.Valor)
                .HasColumnName("valor")
                .HasColumnType("money");
        }
    }
}