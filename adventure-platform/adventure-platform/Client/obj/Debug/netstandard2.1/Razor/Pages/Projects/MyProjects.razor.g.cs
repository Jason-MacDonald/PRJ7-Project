#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac271184c9ceecf56ca156711924d8d0987c84b7"
// <auto-generated/>
#pragma warning disable 1591
namespace adventureplatform.Client.Pages.Projects
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/myprojects")]
    public partial class MyProjects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddMarkupContent(4, "\r\n            ");
                __builder2.OpenComponent<adventureplatform.Client.Shared.AdventureList>(5);
                __builder2.AddAttribute(6, "Adventures", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<adventureplatform.Shared.Entities.Adventure>>(
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                       adventures

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ProjectContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ContextString", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                                                                          contextString

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
             if (numPages > 1)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "                ");
                __builder2.OpenComponent<adventureplatform.Client.Shared.Pagination>(11);
                __builder2.AddAttribute(12, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                          _UserProjectsDTO.Page

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "NumPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                                                           numPages

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "SelectPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
                                                                                                 SelectPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n");
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.AddMarkupContent(20, "<p>You must be logged in to access your projects.</p>\r\n\r\n        ");
                __builder2.OpenComponent<adventureplatform.Client.Pages.Account.LoginForm>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\MyProjects.razor"
       

    #region ##### HEAD #####
    private const string contextString = "myprojects";

    private UserProjectsDTO _UserProjectsDTO = new UserProjectsDTO() { NumPerPage = 11 };
    private List<Adventure> adventures;
    private int numPages; // Returned from paginatedResponse calculation;

    #endregion

    #region ##### LIFE CYCLE METHODS #####

    protected async override Task OnInitializedAsync()
    {
        await SelectPage(1);
    }

    #endregion

    #region ##### CALLBACK METHODS #####

    private async Task SelectPage(int page)
    {
        /// TODO: !!!!! INSECURE !!!!!
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        _UserProjectsDTO.UserEmail = user.Identity.Name;

        _UserProjectsDTO.Page = page;

        try
        {
            await FilterAdventures(_UserProjectsDTO);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async Task FilterAdventures(UserProjectsDTO userProjectsDTO)
    {
        _UserProjectsDTO = userProjectsDTO;

        var paginatedResponse = await adventureRepository.GetUserProjects(userProjectsDTO);
        adventures = paginatedResponse.Response;
        numPages = paginatedResponse.NumPages;
    }

    #endregion

    #region ##### NAVIGATION #####

    private void NavCreateProject()
    {
        navigationManager.NavigateTo($"createproject");
    }

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdventureRepository adventureRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
