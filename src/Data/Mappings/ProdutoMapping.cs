using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Mappings
{
    internal class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasDefaultValue(1)
                .IsRequired();

            builder.Property(p => p.Valor)
                .IsRequired();

            builder.Property(p => p.Imagem)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
