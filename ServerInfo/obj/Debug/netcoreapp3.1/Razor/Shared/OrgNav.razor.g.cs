#pragma checksum "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd30ea38ba303b9f90c2b993d4d908fe76af9251"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerInfo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using ServerInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using ServerInfo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\_Imports.razor"
using ServerInfo.Model;

#line default
#line hidden
#nullable disable
    public partial class OrgNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", true);
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "nav flex-column");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 3 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
            Organizations.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 4 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
         foreach (var org in Organizations)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "nav-item px-3");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link");
            __builder.AddAttribute(16, "href", "");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n                    <span class=\"oi oi-home\" aria-hidden=\"true\"></span> ");
                __builder2.AddContent(20, 
#nullable restore
#line 8 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
                                                                         org.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 11 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item px-3");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "counter");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Shared\OrgNav.razor"
       
    [Parameter] public List<Organization> Organizations { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
