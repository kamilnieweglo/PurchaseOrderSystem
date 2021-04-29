// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PurchaseOrderSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using PurchaseOrderSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\_Imports.razor"
using PurchaseOrderSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\Pages\Order.razor"
using PurchaseOrderSystem.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addorder")]
    public partial class Order : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\Pages\Order.razor"
       

    public string OrderId
    {
        get => _id;
        set
        {
            _id = value;
            this.StateHasChanged();
        }
    }

    private string _id;


    private async Task AddOrder()
    {
        PurchaseOrderSystem.Shared.Order order = PrepareRandomOrder();

        var response = await Http.PostAsJsonAsync("Orders", order);
        OrderId = await response.Content.ReadAsStringAsync();
    }

    private PurchaseOrderSystem.Shared.Order PrepareRandomOrder()
    {
        var order = new PurchaseOrderSystem.Shared.Order();
        order.OrderStatus = OrderStatus.New;
        var random = new Random();
        var countries = new List<string> { "Poland", "Nigeria", "Germany", "Denmark" };
        var currencies = new List<string> { "EUR", "PLN", "USD" };
        var prices = new List<decimal> { 1200, 500, 2000, -10 };
        order.Address = new Address()
        {
            City = "Random city",
            Street = "Random Street",
            ZipCode = "Random zip",
            Country = countries[random.Next(countries.Count)]
        };
        order.Currency = currencies[random.Next(currencies.Count)];
        order.Amount = prices[random.Next(prices.Count)];
        order.Email = "Random email";
        order.Products = new List<Product>()
        {
            new Product()
            {
                Name = "Product name",
                Quantity = 2
            }
        };
        order.CreateDate = DateTime.Now;

        return order;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
