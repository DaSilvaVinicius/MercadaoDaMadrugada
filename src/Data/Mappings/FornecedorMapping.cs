using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    internal class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Documento)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.HasMany(p => p.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.IdFornecedor)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Endereco)
                .WithOne(p => p.Fornecedor);           
        }
    }
}
