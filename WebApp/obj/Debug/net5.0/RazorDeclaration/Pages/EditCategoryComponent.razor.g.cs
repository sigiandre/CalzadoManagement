// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages
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
#nullable restore
#line 2 "D:\Programacion\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcategory/{categoryId}")]
    public partial class EditCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Programacion\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
       

    [Parameter]
    public string CategoryId { get; set; }

    private Category category;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (int.TryParse(this.CategoryId, out int iCategoryId))
        {
            var cat = GetCategoryByIdUseCase.Execute(iCategoryId);
            this.category = new Category { CategoryId = cat.CategoryId, Name = cat.Name, Description = cat.Description };
        }
    }

    private void OnValidSubmit()
    {
        EditCategoryUseCase.Execute(this.category);
        NavigationManager.NavigateTo("/categories");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/categories");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IEditCategoryUseCase EditCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
