// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Programacion\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
    public partial class SellProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Programacion\SupermarketManagement\WebApp\Controls\SellProductComponent.razor"
       

    private Product productToSell;
    private string errorMessage;

    [Parameter]
    public string CashierName { get; set; }

    [Parameter]
    public Product SelectedProduct { get; set; }

    [Parameter]
    public EventCallback<Product> OnProductSold { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (SelectedProduct != null)
        {
            productToSell = new Product
            {
                ProductId = SelectedProduct.ProductId,
                Name = SelectedProduct.Name,
                CategoryId = SelectedProduct.CategoryId,
                Price = SelectedProduct.Price,
                Quantity = 0

            };
        }
        else
        {
            productToSell = null;
        }
    }

    private void SellProduct()
    {
        if (string.IsNullOrWhiteSpace(CashierName))
        {
            errorMessage = "Falta el nombre del cajero(a).";
            return;
        }

        var product = GetProductByIdUseCase.Execute(productToSell.ProductId);
        if (productToSell.Quantity <= 0)
        {
            errorMessage = "La cantidad debe ser mayor que cero.";
        }
        else if (product.Quantity >= productToSell.Quantity)
        {
            OnProductSold.InvokeAsync(productToSell);
            errorMessage = string.Empty;
            SellProductUseCase.Execute(CashierName, productToSell.ProductId, productToSell.Quantity.Value);
        }
        else
        {
            errorMessage = $"{product.Name} solo tiene {product.Quantity} en stock. No es suficiente.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.ISellProductUseCase SellProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IGetProductByIdUseCase GetProductByIdUseCase { get; set; }
    }
}
#pragma warning restore 1591
