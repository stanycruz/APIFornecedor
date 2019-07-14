using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder
                .ToTable("fornecedor");

            builder
                .Property(f => f.Id)
                .HasColumnName("id");

            builder
                .Property(f => f.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(f => f.Endereco)
                .HasColumnName("endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(f => f.EnderecoAdicional)
                .HasColumnName("endereco_adicional")
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.WebSite)
                .HasColumnName("web_site")
                .HasColumnType("varchar(50)");

            builder
                .Property(f => f.NumTelefone)
                .HasColumnName("num_telefone")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(f => f.NumFax)
                .HasColumnName("num_fax")
                .HasColumnType("varchar(50)");

            builder
                .Property(f => f.CNPJ)
                .HasColumnName("cnpj")
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder
                .Property(f => f.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)");

            builder
                .Property<int>("usuario_id");

            builder
                .HasOne(f => f.IdUsuario)
                .WithMany(u => u.Fornecedores)
                .HasForeignKey("usuario_id");

            builder
                .Property<int>("catalogo_material_id");

            builder
                .HasOne(f => f.IdCatalogoMaterial)
                .WithMany(cm => cm.Fornecedores)
                .HasForeignKey("catalogo_material_id");
        }
    }
}