using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Mappings
{
    internal class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Cep)
               .HasColumnType("char(8)")
               .IsRequired();

            builder.Property(p => p.Estado)
                .HasColumnType("varchar(70)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(70)")
                .IsRequired();

            builder.Property(p => p.Bairro)
                .HasColumnType("varchar(70)")
                .IsRequired();

            builder.Property(p => p.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Numero)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(p => p.Complemento)
                .HasColumnType("varchar(200)");               
        }
    }
}
