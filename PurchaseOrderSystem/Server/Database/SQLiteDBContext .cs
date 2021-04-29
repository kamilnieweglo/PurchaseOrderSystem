using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PurchaseOrderSystem.Shared;

namespace PurchaseOrderSystem.Server.Database
{
    public class SQLiteDBContext : DbContext
    { 
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=sqlitedemo.db");
    }
}
