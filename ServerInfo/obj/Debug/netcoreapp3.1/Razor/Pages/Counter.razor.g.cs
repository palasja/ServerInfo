#pragma checksum "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6521bd8dcaa45904ecf0fbf2e445cf620f3bd13c"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerInfo.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col alert alert-secondary text-center\">\r\n        <h1>Counter</h1>\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6 text-left");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary p-3");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Pages\Counter.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col text-right");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "font-size: 50px");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Pages\Counter.razor"
             currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col text-center");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "number");
            __builder.AddAttribute(32, "class", "form-control-lg");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Pages\Counter.razor"
                                                            currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Home\source\repos\ServerInfo\ServerInfo\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
