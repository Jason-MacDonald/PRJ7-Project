#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6445ad32499aafdf3d2bf4b10817eda9bb334b64"
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
    public partial class AdventureCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "individual-adventure-container shadow mb-4 bg-white");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "individual-adventure-header");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "h5");
            __builder.AddAttribute(9, "class", "pt-4 px-3");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                   Adventure.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "pb-3 px-3");
            __builder.OpenElement(14, "i");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                     Adventure.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
#nullable restore
#line 20 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
         if (Adventure.Image != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                         NavAdventureDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "data-toggle", "tooltip");
            __builder.AddAttribute(22, "title", "Find out more");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 25 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                           Adventure.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "adventure-image");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 28 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
        }

        

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "px-3");
            __builder.AddContent(32, 
#nullable restore
#line 31 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                         Adventure.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "px-3 pb-3");
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                 NavPlay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "data-toggle", "tooltip");
            __builder.AddAttribute(44, "title", "Play" + " " + (
#nullable restore
#line 40 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                  Adventure.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "\r\n                <span class=\"oi oi-media-play\" aria-hidden=\"true\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
            __builder.AddAttribute(48, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(49, "\r\n\r\n");
#nullable restore
#line 49 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                     if (ContextString == "adventures")
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(50, "                        ");
                __builder2.OpenElement(51, "a");
                __builder2.AddAttribute(52, "class", "btn btn-info");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                         AddToLibrary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "data-toggle", "tooltip");
                __builder2.AddAttribute(55, "title", "Add" + " " + (
#nullable restore
#line 52 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                             Adventure.Title

#line default
#line hidden
#nullable disable
                ) + " to" + " your" + " library");
                __builder2.AddMarkupContent(56, "\r\n                            <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 56 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n\r\n");
#nullable restore
#line 62 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
             if (ContextString == "mylibrary")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "btn btn-warning");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                       () => DeleteFromLibrary.InvokeAsync(Adventure.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "data-toggle", "tooltip");
            __builder.AddAttribute(65, "title", "Delete" + " " + (
#nullable restore
#line 65 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                        Adventure.Title

#line default
#line hidden
#nullable disable
            ) + " from" + " your" + " library");
            __builder.AddMarkupContent(66, "\r\n                    <span class=\"oi oi-minus\" aria-hidden=\"true\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 69 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
            }

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
             if (ContextString == "myprojects")
            {

            }

            

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(69);
            __builder.AddAttribute(70, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n\r\n");
#nullable restore
#line 81 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                     if (ContextString == "myprojects")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                         if (_UserEmail == Adventure.Author)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "                            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "float-right");
                __builder2.AddMarkupContent(75, "\r\n\r\n                                ");
                __builder2.OpenElement(76, "a");
                __builder2.AddAttribute(77, "class", "btn btn-warning");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                                     NavEditProject

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "data-toggle", "tooltip");
                __builder2.AddAttribute(80, "title", "Edit" + " " + (
#nullable restore
#line 89 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                                      Adventure.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(81, "\r\n                                    <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n                                ");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "type", "button");
                __builder2.AddAttribute(85, "class", "btn btn-danger");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                                                        () => DeleteAdventure.InvokeAsync(Adventure)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "data-toggle", "tooltip");
                __builder2.AddAttribute(88, "title", "Edit" + " " + (
#nullable restore
#line 96 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                                                                           Adventure.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(89, "\r\n                                    <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n");
#nullable restore
#line 102 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(92, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Shared\AdventureCard.razor"
       

    #region ##### HEAD #####

    [Parameter] public string ContextString { get; set; }
    [Parameter] public Adventure Adventure { get; set; }
    [Parameter] public EventCallback<Adventure> DeleteAdventure { get; set; }
    [Parameter] public EventCallback<int> DeleteFromLibrary { get; set; }

    private string _UserEmail = "";

    #endregion

    #region ##### LIFECYCLE METHODS #####

    protected override async Task OnInitializedAsync()
    {
        //TODO: ugly.
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        _UserEmail = authState.User.Identity.Name;
    }

    #endregion

    #region ##### CRUD METHODS #####

    private async Task AddToLibrary()
    {
        UserFavourite userFavourite = new UserFavourite()
        {
            UserID = _UserEmail,
            AdventureID = Adventure.ID
        };

        try
        {
            await userFavouriteRepository.CreateUserFavourite(userFavourite);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ADC001: Unable Add Adventure to Library.");
        }
    }

    #endregion

    #region ##### NAVIGATION #####

    private void NavPlay()
    {
        navigationManager.NavigateTo($"play/{Adventure.ID}");
    }

    private void NavAdventureDetails()
    {
        navigationManager.NavigateTo($"details/{Adventure.ID}");
    }

    private void NavEditProject()
    {
        navigationManager.NavigateTo($"editproject/{Adventure.ID}");
    }

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdventureRepository adventureRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserFavouriteRepository userFavouriteRepository { get; set; }
    }
}
#pragma warning restore 1591
