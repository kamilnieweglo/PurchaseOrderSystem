using System.Collections.Generic;
using PurchaseOrderSystem.Shared;

namespace AntiFraudSystem.Database
{
    public interface IRepositoryService
    {
        List<Order> GetNewOrders();

        void UpdateOrderStatus(int orderId, OrderStatus orderStatus);

        void LoadOrders(Order[] orders);
    }
}