#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b80ce3806aee8b0c02bb970baa1df6b2254381f"
// <auto-generated/>
#pragma warning disable 1591
namespace adventureplatform.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Pages.Projects.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Pages.Users;

#line default
#line hidden
#nullable disable
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
 if (display)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "confirmModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.AddAttribute(7, "style", "display: block");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-header");
            __builder.AddMarkupContent(18, "\r\n                \r\n                ");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "modal-title");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
                                  OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "close");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.AddMarkupContent(28, "<span aria-hidden=\"true\">&times</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-body");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddContent(34, 
#nullable restore
#line 33 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-footer");
            __builder.AddMarkupContent(39, "\r\n\r\n                ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
                                  OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-secondary");
            __builder.AddMarkupContent(44, "\r\n                    Cancel\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
                                  OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddMarkupContent(50, "\r\n                    Confirm\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 55 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Confirmation.razor"
       

    #region ##### HEAD #####

    [Parameter] public string Title { get; set; } = "Confirm";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }

    private bool display = false;

    #endregion

    #region ##### GENERAL METHODS #####

    public void Show() => display = true;
    public void Hide() => display = false;

    #endregion


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591