#pragma checksum "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\Pages\Order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583748bd3293842bd0c1e8257b7fd22d7b124bd5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>New random order</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>// I should add here some form... </p>  \r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\Pages\Order.razor"
                                          AddOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Add random product:) ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n ID:\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 11 "C:\Projects\PurchaseSystem_blazor\PurchaseOrderSystem\PurchaseOrderSystem\Client\Pages\Order.razor"
               OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
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
