﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SergeyChervyakov_CRUDapp.Models;
using Microsoft.EntityFrameworkCore;

namespace SergeyChervyakov_CRUDapp.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
        }

    }
}
