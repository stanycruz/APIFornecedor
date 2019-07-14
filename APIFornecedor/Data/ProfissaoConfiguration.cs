using APIFornecedor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIFornecedor.Data
{
    public class ProfissaoConfiguration : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder
                .ToTable("profissao");

            builder
                .Property(p => p.Id)
                .HasColumnName("id");

            builder
                .Property(p => p.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(20)")
                .IsRequired();
        }
    }
}