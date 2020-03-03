using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class DbContextSales:DbContext
    {
        public DbContextSales(DbContextOptions<DbContextSales> options) : base(options)
        {
                
        }
        public DbSet<Accounts.Customers> Customers { get; set; }
        public DbSet<Accounts.Suppliers> Suppliers { get; set; }
        public DbSet<Accounts.Employees> Employees { get; set; }
        public DbSet<Accounts.Banks> Banks { get; set; }
        public DbSet<Accounts.Boxs> Boxs { get; set; }
        public DbSet<Accounts.AccountsGroupe> accountsGroupes { get; set; }
        public DbSet<Accounts.AccountsRanks> AccountsRanks { get; set; }
        public DbSet<Accounts.AccountsTypes> AccountsTypes { get; set; }
        public DbSet<Accounts.CostCenters.CostCenter> CostCenter { get; set; }
        public DbSet<Accounts.MainAccounts> MainAccounts { get; set; }
        public DbSet<Accounts.Moneys> Moneys  { get; set; }
        public DbSet<BillsSetting.Summation> Summations { get; set; }
        public DbSet<BillsSetting.SalesAreas> SalesAreas { get; set; }
        public DbSet<BillsSetting.BillsVariables.CustomersType> customersTypes { get; set; }
    }
}
