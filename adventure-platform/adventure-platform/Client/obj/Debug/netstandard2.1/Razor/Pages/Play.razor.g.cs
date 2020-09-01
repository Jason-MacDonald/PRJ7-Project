#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebe6dd4e6632d78c0864143a664c33ea2ad0a68"
// <auto-generated/>
#pragma warning disable 1591
namespace adventureplatform.Client.Pages
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
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\_Imports.razor"
using adventureplatform.Client.Pages.Users;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/play/{adventureID:int}")]
    public partial class Play : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Play</h3>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
 if (adventureDTO != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "h4");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
         adventureDTO.ChapterList[0].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
               adventureDTO.ChapterList[0].Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
        adventureDTO.ChapterList[0].Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
     foreach (var link in @adventureDTO.ChapterList[0].Links)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
                                         link.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<p>something\'s wrong</p>\r\n");
#nullable restore
#line 22 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Play.razor"
       
    [Parameter] public int adventureID { get; set; }
    AdventureDTO adventureDTO;

    protected async override Task OnInitializedAsync()
    {
        adventureDTO = await adventureRepository.GetAdventureDTO(adventureID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdventureRepository adventureRepository { get; set; }
    }
}
#pragma warning restore 1591
