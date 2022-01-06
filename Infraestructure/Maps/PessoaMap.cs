using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoa");

            builder.HasKey(pessoa => pessoa.IdPessoa);

            builder.Property(pesspa => pesspa.IdPessoa)
                .HasColumnName("idPessoa")
                .HasColumnType("INTEGER");

            builder.Property(pessoa => pessoa.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(pessoa => pessoa.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired();
        }
    }
}
