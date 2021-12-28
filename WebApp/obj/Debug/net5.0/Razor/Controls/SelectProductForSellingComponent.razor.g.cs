#pragma checksum "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329c66a9e8642567d0e102f989460ed3865a6a52"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class SelectProductForSellingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label for=\"category\">Categoria</label>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "id", "category");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                 SelectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategoryId = __value, SelectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected");
            __builder.CloseElement();
#nullable restore
#line 8 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                            cat.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                             cat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
 if (productsInCategory != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>Nombre Producto</th>\r\n                <th>Cantidad Restante</th></tr></thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 25 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
             foreach (var prod in productsInCategory)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                () => OnSelectProduct(prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", 
#nullable restore
#line 27 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                                                       prod.ProductId == selectedProductId?"background-color:beige; cursor:pointer;":"cursor:pointer"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                         prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                         prod.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Programacion\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
       

    private IEnumerable<Product> productsInCategory;
    private int selectedProductId;

    [Parameter]
    public EventCallback<Product> OnProductSelected {get; set;}

    private int selectedCategoryId;

    private int SelectedCategoryId
    {
        get
        {
            return selectedCategoryId;
        }
        set
        {
            selectedCategoryId = value;
            productsInCategory = ViewProductsByCategoryId.Execute(value);
            OnSelectProduct(null);
            StateHasChanged();
        }
    }

    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = ViewCategoriesUseCase.Execute();
    }

    private void OnSelectProduct(Product product)
    {
        OnProductSelected.InvokeAsync(product);
        if(product != null) selectedProductId = product.ProductId;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IViewProductsByCategoryId ViewProductsByCategoryId { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IViewCategoriesUseCase ViewCategoriesUseCase { get; set; }
    }
}
#pragma warning restore 1591