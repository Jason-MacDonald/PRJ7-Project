#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfed00e2df1a930148b24d8dc5fb1be665954eb6"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-sm-12 col-xl-8\">\r\n                <img class=\"mb-4\" style=\"display:block; margin:auto; width:80%;\" src=\"https://localhost:44363\\chapter\\4e3cd841-d1d8-44d1-8f6c-29cfc0b4a78a.jpg\" alt=\"Alternate Text\">\r\n\r\n                <h4 style=\"text-align:center\" class=\"mb-5\">\r\n                    Now you\'ve gone and done it! You\'ve only gone and stumbled into an endless world of adventure, of magic, \r\n                    of fierce battles, and most importantly of all, super awesome loot!\'\r\n                </h4>\r\n            </div>\r\n\r\n            <div class=\"cols-sm-6 col-xl-4\">\r\n                <div class=\"card my-4\">\r\n                    <div class=\"card-header\" style=\"background-color: #28a745\"></div>\r\n                    <div class=\"card-title center mt-4\">\r\n                        <h4> Play</h4>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        Play through adventures alone or with friends. It\'s as simple as searching the library\r\n                        and pressing play. Create an account to save your progress so you don\'t have to\r\n                        complete an adventure all in one hit.\r\n                    </div>\r\n                    <div class=\"p-3\">\r\n                        <a class=\"btn btn-block btn-success\" href=\"adventures\">Check out the Adventures</a>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"card mb-4\">\r\n                    <div class=\"card-header\" style=\"background-color: #ffc107\"></div>\r\n                    <div class=\"card-title center mt-4\">\r\n                        <h4>Create</h4>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        Create your own adventures using our simple adventure design system. Use simple annotations to \r\n                        style your narrative and contextual help is provided along the way so there\'s no big instruction manual\r\n                        to read first. \r\n                    </div>\r\n                    <div class=\"p-3\">\r\n                        <a class=\"btn btn-block btn-warning\" href=\"myprojects\" style=\"color: white\">Create a New Project</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Index.razor"
       

    #region ##### HEAD #####

    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }

    string _Test = "";

    #endregion

    #region ##### 

    #endregion

    //List<UserFavourite> userFavourites = new List<UserFavourite>();

    //protected async override Task OnInitializedAsync()
    //{
    //    var authState = await authenticationStateTask;
    //    var user = authState.User;
    //    if (user.Identity.IsAuthenticated)
    //    {
    //        _Test = user.Identity.Name;
    //        Console.WriteLine(user.Claims);
    //    }
    //    else
    //    {
    //        _Test = "The user is not authenticated.";
    //    }

    //    userFavourites = await userFavouriteRepository.GetUserFavourites();
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserFavouriteRepository userFavouriteRepository { get; set; }
    }
}
#pragma warning restore 1591
