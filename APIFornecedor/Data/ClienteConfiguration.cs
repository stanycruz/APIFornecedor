using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .ToTable("cliente");

            builder
                .Property(c => c.Id)
                .HasColumnName("id");

            builder
                .Property(c => c.NomeCliente)
                .HasColumnName("nome_cliente")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(c => c.Endereco)
                .HasColumnName("endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.Complemento)
                .HasColumnName("complemento")
                .HasColumnType("varchar(100)");

            builder
                .Property(c => c.WebSite)
                .HasColumnName("site")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.NumTelefone)
                .HasColumnName("num_telefone")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.NumFax)
                .HasColumnName("fax")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.CNPJ)
                .HasColumnName("cnpj")
                .HasColumnType("varchar(14)");

            builder
                .Property(c => c.CPF)
                .HasColumnName("cpf")
                .HasColumnType("varchar(11)");

            builder
                .Property<int>("usuario_id");

            builder
                .HasOne(c => c.IdUsuario)
                .WithMany(u => u.Clientes)
                .HasForeignKey("usuario_id");
        }
    }
}