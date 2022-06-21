using Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MercadoDbContext : DbContext
    {
        public MercadoDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Produto> Produtos { get; set; }
        DbSet<Fornecedor> Fornecedors { get; set; }
        DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MercadoDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
