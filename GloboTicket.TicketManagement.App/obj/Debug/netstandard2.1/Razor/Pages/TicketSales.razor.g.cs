#pragma checksum "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2b301edb32912aeca355047e44e1156fa72963"
// <auto-generated/>
#pragma warning disable 1591
namespace GloboTicket.TicketManagement.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ticketsales")]
    public partial class TicketSales : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mb-5\">Ticket Sales</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<span>Select month</span>\r\n        ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                             SelectedMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedMonth = __value, SelectedMonth));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
             foreach (var month in MonthList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 12 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " ");
#nullable restore
#line 12 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
__builder.AddContent(20, month);

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 13 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-2");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<span>Select year</span>\r\n        ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                             SelectedYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedYear = __value, SelectedYear));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 20 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
             foreach (var year in YearList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 22 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " ");
#nullable restore
#line 22 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
__builder.AddContent(42, year);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 23 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                  GetSales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "mt-4");
            __builder.AddContent(51, "Get Sales");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 33 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
 if (ordersList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.AddMarkupContent(54, "<p><em>No data</em></p>\r\n");
#nullable restore
#line 36 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "ticket-sales-table");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.AddMarkupContent(59, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Total</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(60, "tbody");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 47 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
             foreach (var order in ordersList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 50 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
__builder.AddContent(66, order.OrderPlaced);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
#nullable restore
#line 51 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
__builder.AddContent(69, order.OrderTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 53 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.AddContent(75, "    ");
            __builder.OpenComponent<GloboTicket.TicketManagement.App.Components.Pager>(76);
            __builder.AddAttribute(77, "PageIndex", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                       paginatedList.PageIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "TotalPages", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                                            paginatedList.TotalPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 57 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                                                                              PageIndexChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(80, "HasNextPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                        paginatedList.HasNextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "HasPreviousPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
                                                                   paginatedList.HasPreviousPage

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 60 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\TicketSales.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
