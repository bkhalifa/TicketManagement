#pragma checksum "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7361b369fc48ae2ccdc8316e68ca9e40c3a0338"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoryoverview")]
    public partial class CategoryOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Event Category Overview</h3>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "custom-checkbox");
            __builder.AddAttribute(4, "type", "checkbox");
            __builder.AddAttribute(5, "id", "includeHistory");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
                                                                                 OnIncludeHistoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(7, "   Include past events?");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 9 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
 if (Categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "table");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<thead>\r\n            <tr>\r\n                <th>Category name</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 22 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
             foreach (var cat in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 25 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
__builder.AddContent(21, cat.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "nested-table ml-auto mr-auto");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.AddMarkupContent(32, @"<thead>
                                <tr>
                                    <th>Event name</th>
                                    <th class=""category-event-header"">Event date</th>
                                    <th class=""category-event-header"">Artist</th>
                                    <th class=""category-event-header"">Price</th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 40 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
                                 foreach (var ev in cat.Events)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                                    ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "event-name");
#nullable restore
#line 43 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
__builder.AddContent(40, ev.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "class", "event-date");
#nullable restore
#line 44 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
__builder.AddContent(45, ev.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "class", "event-artist");
#nullable restore
#line 45 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
__builder.AddContent(50, ev.Artist);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "class", "event-price");
#nullable restore
#line 46 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
__builder.AddContent(54, ev.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 48 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 53 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 56 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\CategoryOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
