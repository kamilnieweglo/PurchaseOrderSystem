using System.Collections.Generic;
using PurchaseOrderSystem.Shared;

namespace PurchaseOrderSystem.Server.Services
{
    public interface IRepositoryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Order id</returns>
        int AddPurchaseOrder(Order order);

        List<Order> GetAllOrders();
    }
}