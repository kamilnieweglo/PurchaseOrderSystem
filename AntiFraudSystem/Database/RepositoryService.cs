using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PurchaseOrderSystem.Shared;

namespace AntiFraudSystem.Database
{
    public class RepositoryService : IRepositoryService
    {
        public List<Order> GetNewOrders()
        {
            var result = new List<Order>();
            using (var db = new SQLiteDBContext())
            {
                result = db.Orders.Include("Address").Include("Products")
                    .Where(x => x.OrderStatus == OrderStatus.New || x.OrderStatus == OrderStatus.Unknown)
                    .ToList();
            }

            return result;
        }

        public void UpdateOrderStatus(int orderId, OrderStatus orderStatus)
        {
            using (var db = new SQLiteDBContext())
            {
                var order = db.Orders.Single(x => x.Id == orderId);
                order.OrderStatus = orderStatus;
                db.SaveChanges();
            }
        }

        public void LoadOrders(Order[] orders)
        {
            using (var db = new SQLiteDBContext())
            {
                foreach (var order in orders)
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
        }
    }
}
