using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PurchaseOrderSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseOrderSystem.Server.Services;

namespace PurchaseOrderSystem.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IPurchaseOrderService _purchaseOrderService;

        public OrdersController(IPurchaseOrderService purchaseOrderService)
        {
            this._purchaseOrderService = purchaseOrderService;
        }

        [HttpGet]
        public IEnumerable<Order> Get() => _purchaseOrderService.GetAllOrders();

        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            try
            {
                var id = _purchaseOrderService.AddPurchaseOrder(order);
                return Ok(id);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }
    }
}
