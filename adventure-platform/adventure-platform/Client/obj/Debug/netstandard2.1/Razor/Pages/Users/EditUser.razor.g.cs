#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06465eeaff1274cde4f26957d26a442f0485643f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/users/edit/{UserID}")]
    public partial class EditUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditUser</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-inline");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
                                                     selectedRole

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedRole = __value, selectedRole));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", "0");
            __builder.AddContent(11, "--Select Role--");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 9 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
         foreach (var role in roles)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 11 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
                            role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 11 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
                                        role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-info mb-2 mr-sm-2");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
                                                        Assign

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Assign");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger mb-2 mr-sm-2");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
                                                          Remove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Users\EditUser.razor"
       
    [Parameter] public string UserID { get; set; }
    private List<RoleDTO> roles = new List<RoleDTO>();
    private string selectedRole = "0";

    protected override async Task OnInitializedAsync()
    {
        roles = await userRepository.GetRoles();
    }

    private async Task Assign()
    {
        if(selectedRole == "0")
        {
            Console.WriteLine("No role selected.");
            return;
        }

        await userRepository.AssignRole(new EditRoleDTO() { RoleName = selectedRole, UserID = UserID });
    }

    private async Task Remove()
    {
        if (selectedRole == "0")
        {
            Console.WriteLine("No role selected.");
            return;
        }

        await userRepository.RemoveRole(new EditRoleDTO() { RoleName = selectedRole, UserID = UserID });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
    }
}
#pragma warning restore 1591
