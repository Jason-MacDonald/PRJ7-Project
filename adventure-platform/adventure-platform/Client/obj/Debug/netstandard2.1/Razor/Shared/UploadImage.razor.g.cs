#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f595eebdd8ec5aa18ef8b9212e742904272741c1"
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
#nullable restore
#line 3 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class UploadImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n        \r\n\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenElement(5, "label");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
                    Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
             if (imageBase64 != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin-bottom:10px");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
                                                           imageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "style", "width:400px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 19 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
             if (ImageURL != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "margin:10px");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 24 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
                                                           ImageURL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "style", "width:400px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 27 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "file");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
                                                                  ImageFileSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "accept", ".jpg,.jpeg,.png");
            __builder.AddElementReferenceCapture(42, (__value) => {
#nullable restore
#line 32 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
                                         inputElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\UploadImage.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public string ImageURL { get; set; }
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    private string imageBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach (var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))
            {
                var imageBytes = new byte[memoryStream.Length];
                memoryStream.Read(imageBytes, 0, (int)memoryStream.Length);
                imageBase64 = Convert.ToBase64String(imageBytes);
                await OnSelectedImage.InvokeAsync(imageBase64);
                ImageURL = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
