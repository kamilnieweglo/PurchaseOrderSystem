using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using AntiFraudSystem.Database;
using Newtonsoft.Json;
using PurchaseOrderSystem.Shared;

namespace AntiFraudSystem.Services
{
    public class AntifraudService : IAntifraudService
    {
        private readonly IRepositoryService _repositoryService;

        public AntifraudService(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }
        public void LoadData(string json)
        {
            Order[] orders = JsonConvert.DeserializeObject<Order[]>(json);
            _repositoryService.LoadOrders(orders);
        }

        public void RunMonitor()
        {
            while (true)
            {
                var orders = _repositoryService.GetNewOrders();
                foreach (var order in orders)
                {
                    if (ValidateOrder(order))
                    {
                        Console.WriteLine($"Order correct: {order.Id}");
                        _repositoryService.UpdateOrderStatus(order.Id, OrderStatus.Registered);
                    }
                    else
                    {
                        Console.WriteLine($"Detect anti fraud order: {order.Id}");
                        _repositoryService.UpdateOrderStatus(order.Id, OrderStatus.NotRegistered);
                    }
                }

                Thread.Sleep(5000);
            }
        }

        private bool ValidateOrder(Order order)
        {
            if (!CountryAndAmountIsValid(order))
            {
                return false;
            }

            if (!HistoryIsValid(order))
            {
                return false;
            }

            return true;
        }

        private bool HistoryIsValid(Order order)
        {
            // TODO KN : Please implement it.
            return true;
        }

        private bool CountryAndAmountIsValid(Order order)
        {
            if (order.Address.Country == "Nigeria" && order.Amount > 1000)
            {
                return false;
            }

            return true;
        }
    }
}
