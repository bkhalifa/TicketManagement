#pragma checksum "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ed7c1f2d62a474eb4e7c3120d3bb35d45d4163"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">Welcome to the GloboTicket Ticket Management System!</h1>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h4>Using this application, you have access to all functionalities of GloboTicket.</h4>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenElement(5, "button");
                __builder2.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\Index.razor"
                          Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(7, "Logout");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\Index.razor"
                          NavigateToLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(13, "Click here to log in");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(15, "button");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\dev\architecting-asp-dot-net-core-applications-best-practices\09\demos\end\GloboTicket.TicketManagement.App\Pages\Index.razor"
                          NavigateToRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(17, "Click here to register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
