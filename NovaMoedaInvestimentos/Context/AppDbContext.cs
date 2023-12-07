﻿using Microsoft.EntityFrameworkCore;
using NovaMoedaInvestimentos.Models;
using System.Security.Principal;

namespace NovaMoedaInvestimentos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<DetailOrder> DetailOrders { get; set; }
    }
}
