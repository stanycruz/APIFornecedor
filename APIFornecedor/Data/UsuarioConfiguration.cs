using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("usuario");

            builder
                .Property(u => u.Id)
                .HasColumnName("id");

            builder
                .Property(u => u.TpUsuario)
                .HasColumnName("tp_usuario");

            builder
                .Property(u => u.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property<int>("profissao_id");

            builder
                .HasOne(u => u.IdProfissao)
                .WithMany(p => p.Usuarios)
                .HasForeignKey("profissao_id");

            builder
                .Property(u => u.NumTelefone)
                .HasColumnName("num_telefone")
                .HasColumnType("varchar(20)");

            builder
                .Property(u => u.NumCelular)
                .HasColumnName("num_celular")
                .HasColumnType("varchar(20)");

            builder
                .Property(u => u.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(u => u.EmailAdicional)
                .HasColumnName("email_adicional")
                .HasColumnType("varchar(50)");

            builder
                .Property(u => u.Login)
                .HasColumnName("login")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(u => u.Senha)
                .HasColumnName("senha")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(u => u.Empresa)
                .HasColumnName("empresa");

            builder
                .Property(u => u.TpContrato)
                .HasColumnName("tp_contrato");
        }
    }
}