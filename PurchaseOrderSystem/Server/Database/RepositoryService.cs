using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PurchaseOrderSystem.Server.Database;
using PurchaseOrderSystem.Shared;

namespace PurchaseOrderSystem.Server.Services
{
    public class RepositoryService : IRepositoryService
    {
        public int AddPurchaseOrder(Order order)
        {
            using (var db = new SQLiteDBContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }

            return order.Id;
        }

        public List<Order> GetAllOrders()
        {
            var result = new List<Order>();
            using (var db = new SQLiteDBContext())
            {
                result = db.Orders.Include("Address").Include("Products").ToList();
            }

            return result;
        }
    }
}
