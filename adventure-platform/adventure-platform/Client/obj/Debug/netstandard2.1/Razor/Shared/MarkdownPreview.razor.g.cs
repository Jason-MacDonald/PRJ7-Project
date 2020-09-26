#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0cf336db16cb0cd4cda6e32002fbe856c97760e"
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
#nullable restore
#line 19 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class MarkdownPreview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor"
 if (HTMLContent != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor"
      (MarkupString)HTMLContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor"
                                ;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\MarkdownPreview.razor"
       
    [Parameter] public string MarkdownContent { get; set; }
    private string HTMLContent;

    protected override void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(MarkdownContent))
        {
            HTMLContent = Markdown.ToHtml(MarkdownContent);
        }
        else
        {
            HTMLContent = null;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
