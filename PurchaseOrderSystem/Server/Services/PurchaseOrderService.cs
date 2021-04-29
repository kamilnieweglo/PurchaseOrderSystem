using System;
using System.Collections.Generic;
using System.Linq;
using PurchaseOrderSystem.Shared;

namespace PurchaseOrderSystem.Server.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IRepositoryService _repositoryService;

        public PurchaseOrderService(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }
        public int AddPurchaseOrder(Order order)
        {
            if (order != null && IsValid(order))
            {
              return  _repositoryService.AddPurchaseOrder(order);
            }
            
            throw new ArgumentException("Order is invalid.");
        }

        private bool IsValid(Order order)
        {
            if (order.Amount < 0)
            {
                return false;
            }

            return true;
        }

        public List<Order> GetAllOrders() => _repositoryService.GetAllOrders();
        
    }
}