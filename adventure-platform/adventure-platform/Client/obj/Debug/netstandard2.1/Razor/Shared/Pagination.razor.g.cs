#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5abd44e0b5fa5188b1de553bee744d02e9a9e66"
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
using adventureplatform.Client.Repository;

#line default
#line hidden
#nullable disable
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
             foreach (var link in links)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "                ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
                              (() => SelectedPageInternal(link))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "cursor: pointer;");
            __builder.AddAttribute(9, "class", "page-item" + " " + (
#nullable restore
#line 9 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
                                       link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 9 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
                                                                           link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "page-link");
            __builder.AddAttribute(13, "href", "#");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
                                                      link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\Pagination.razor"
       
    [Parameter] public int CurrentPage { get; set; } = 1;
    [Parameter] public int NumPages { get; set; }
    [Parameter] public int Radius { get; set; } = 3; // Number of page buttons to show.
    [Parameter] public EventCallback<int> SelectPage { get; set; }

    List<LinkModel> links;

    protected override void OnParametersSet()
    {
        LoadPages();
        base.OnParametersSet();
    }

    private void LoadPages()
    {
        var isPreviousPageLinkEnabled = CurrentPage != 1;
        var previousPage = CurrentPage - 1;

        links = new List<LinkModel>();

        // Adds [previous] link.
        links.Add(new LinkModel(previousPage, isPreviousPageLinkEnabled, "Previous"));

        // Adds links within radius.
        for (int i = 1; i <= NumPages; i++)
        {
            if(i >= CurrentPage - Radius && i <= CurrentPage + Radius)
            {
                links.Add(new LinkModel(i)
                {
                    Active = CurrentPage == i
                });
            }
        }

        // Adds [next] link
        var isNextPageLinkEnabled = CurrentPage != NumPages;
        var nextPage = CurrentPage + 1;

        links.Add(new LinkModel(nextPage, isNextPageLinkEnabled, "Next"));

    }

    private async Task SelectedPageInternal(LinkModel link)
    {
        if(link.Page == CurrentPage || !link.Enabled)
        {
            return;
        }

        CurrentPage = link.Page;
        await SelectPage.InvokeAsync(link.Page);
    }

    class LinkModel
    {
        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;

        public LinkModel(int page) : this(page, true) { }

        public LinkModel(int page, bool enabled) : this(page, enabled, page.ToString()) { }

        public LinkModel(int page, bool enabled, string text)
        {
            Text = text;
            Page = page;
            Enabled = enabled;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
