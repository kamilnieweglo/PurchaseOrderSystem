using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseOrderSystem.Shared;

namespace PurchaseOrderSystem.Server.Services
{
    public interface IPurchaseOrderService
    {
        int AddPurchaseOrder(Order order);

        List<Order> GetAllOrders();
    }
}
