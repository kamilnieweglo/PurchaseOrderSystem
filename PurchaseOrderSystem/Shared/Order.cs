using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PurchaseOrderSystem.Shared
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string Email { get; set; }
        public Decimal Amount { get; set; }
        public string Currency { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        public List<Product> Products { get; set; }
    }
}
