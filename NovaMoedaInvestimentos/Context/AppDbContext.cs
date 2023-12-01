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
    }
}
