using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PurchaseOrderSystem.Shared;

namespace AntiFraudSystem.Database
{
    public class SQLiteDBContext : DbContext
    {
        
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           // => options.UseSqlite($"Data Source=C:\\Projects\\PurchaseSystem_blazor\\PurchaseOrderSystem\\PurchaseOrderSystem\\Server\\sqlitedemo.db");
            => options.UseSqlite($"Data Source={Environment.GetEnvironmentVariable("SqlitePath")}");
    }
}
