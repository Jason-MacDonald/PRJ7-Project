#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16230dd666fc49f8ad8ef7bcf64099ad166c39a3"
// <auto-generated/>
#pragma warning disable 1591
namespace adventureplatform.Client.Pages.Users
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Users</h3>\r\n\r\n");
            __Blazor.adventureplatform.Client.Pages.Users.Users.TypeInference.CreateGenericList_0(__builder, 1, 2, 
#nullable restore
#line 6 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                   users

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-striped");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>User</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                    ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "\r\n                        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddMarkupContent(15, "\r\n                            ");
                __builder2.AddContent(16, 
#nullable restore
#line 20 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                             user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "/users/edit/" + (
#nullable restore
#line 23 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                                                  user.UserID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "class", "btn btn-success");
                __builder2.AddContent(24, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 26 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenComponent<adventureplatform.Client.Shared.Pagination>(32);
            __builder.AddAttribute(33, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "SelectPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 32 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                                                          SelectPage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(35, "NumPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
                                                                                numPages

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\Users.razor"
       
    List<UserDTO> users;
    PaginationDTO paginationDTO = new PaginationDTO();
    int numPages;


    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        var paginatedResponse = await userRepository.GetUsers(paginationDTO);
        users = paginatedResponse.Response;
        numPages = paginatedResponse.NumPages;
    }

    private async Task  SelectPage(int page)
    {
        paginationDTO.Page = page;
        await LoadUsers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
    }
}
namespace __Blazor.adventureplatform.Client.Pages.Users.Users
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::adventureplatform.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
