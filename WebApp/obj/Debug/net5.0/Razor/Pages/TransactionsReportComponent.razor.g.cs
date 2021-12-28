#pragma checksum "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62aa44bfc05ae62c96eedd21c7789ca1112fdc1b"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transaction")]
    public partial class TransactionsReportComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-2");
            __builder.AddMarkupContent(4, "<label for=\"cashier\">Nombre del Cajero(a)</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "cashier");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                          cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-3");
            __builder.AddMarkupContent(14, "<label for=\"startdate\">Fecha de Inicio</label>\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "date");
            __builder.AddAttribute(17, "id", "startdate");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                            startDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startDate = __value, startDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-3");
            __builder.AddMarkupContent(24, "<label for=\"enddate\">Fecha de Fin</label>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "date");
            __builder.AddAttribute(27, "id", "enddate");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                          endDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endDate = __value, endDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-2");
            __builder.AddMarkupContent(34, "<label>&nbsp;</label>\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-primary form-control");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                             LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-2");
            __builder.AddMarkupContent(43, "<label>&nbsp;</label>\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary form-control");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                             PrintReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Imprimir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n<br>");
#nullable restore
#line 31 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "id", "printarea");
            __builder.OpenElement(52, "table");
            __builder.AddAttribute(53, "class", "table");
            __builder.AddMarkupContent(54, @"<thead><tr><th>Fecha y Hora</th>
                    <th>Nombre del Cajero(a)</th>
                    <th>Nombre del Producto</th>
                    <th>Cantidad Antes</th>
                    <th>Cantidad Vendida</th>
                    <th>Cantidad Después</th>
                    <th>Precio</th>
                    <th>Vendido AMT</th></tr></thead>
            ");
            __builder.OpenElement(55, "tbody");
#nullable restore
#line 48 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                 foreach (var tran in transactions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "tr");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 51 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.TimeStamp.ToString("yyyy-MM-dd hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 52 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.CashierName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 53 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 54 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.BeforeQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 55 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.SoldQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 56 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                              tran.BeforeQuantity - tran.SoldQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "style", "text-align:right");
            __builder.AddContent(77, 
#nullable restore
#line 57 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                       string.Format("{0:c}", tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "style", "text-align:right");
            __builder.AddContent(81, 
#nullable restore
#line 58 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                       string.Format("{0:c}", tran.SoldQuantity * tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "tfoot");
            __builder.OpenElement(84, "tr");
            __builder.AddMarkupContent(85, "<td colspan=\"6\">&nbsp;</td>\r\n                    ");
            __builder.AddMarkupContent(86, "<td style=\"text-align:right\"><b>Gran Total:</b></td>\r\n                    ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "style", "text-align:right");
            __builder.OpenElement(89, "b");
            __builder.AddContent(90, 
#nullable restore
#line 70 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                              string.Format("{0:c}", transactions.Sum(x => x.Price * x.SoldQuantity))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\Programacion\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
       

    private string cashierName;
    private DateTime startDate;
    private DateTime endDate;
    private IEnumerable<Transaction> transactions;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        startDate = DateTime.Today;
        endDate = DateTime.Today;
    }

    private void LoadTransactions()
    {
        transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate);

    }

    private void PrintReport()
    {
        JSRuntime.InvokeVoidAsync("print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.UseCaseInterfaces.IGetTransactionsUseCase GetTransactionsUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591