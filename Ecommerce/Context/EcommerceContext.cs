﻿using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Venda>()
                .HasOne(venda => venda.Vendedor).WithMany(vendedor => vendedor.Vendas)
                .HasForeignKey(venda => venda.VendedorId);
        }
    }
}
