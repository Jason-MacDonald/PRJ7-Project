#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdeded6768c79b8cb57e0a5ed516db7afb1c0d2"
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
#line 8 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editlink/{AdventureID:int}/{LinkID:int}")]
    public partial class EditLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "left-column");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 14 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
         if (_Link != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.AddMarkupContent(7, "<h3>Edit Link</h3>\r\n            ");
            __builder.OpenComponent<adventureplatform.Client.Pages.Projects.Forms.LinkForm>(8);
            __builder.AddAttribute(9, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<adventureplatform.Shared.Entities.Link>(
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                            _Link

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                                                  SaveLink

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "Back", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                                                                  NavEditChapter

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 18 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "right-column");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 26 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
             if (_Chapters != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                 foreach (var chapter in _Chapters)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                     if (_Link.Target == chapter.ID)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-primary btn-block");
            __builder.AddContent(24, "Current Target ");
            __builder.OpenElement(25, "b");
            __builder.AddContent(26, 
#nullable restore
#line 34 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                                                                                chapter.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 35 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-warning btn-block");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                                                                       (() => SetTarget(chapter.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Set ");
            __builder.OpenElement(33, "b");
            __builder.AddContent(34, 
#nullable restore
#line 39 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                                                                                                              chapter.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(35, " as Target");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 40 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditLink.razor"
       

    #region ##### HEAD #####

    [Parameter] public int AdventureID { get; set; }
    [Parameter] public int LinkID { get; set; }

    private List<Chapter> _Chapters;
    public Link _Link;

    #endregion

    #region ##### LIFECYCLE METHODS #####

    protected async override Task OnInitializedAsync()
    {
        await GetLink();
        await GetChapters();
    }

    #endregion

    #region ##### GENERAL METHODS #####

    private void SetTarget(int chapterID)
    {
        _Link.Target = chapterID;
        SaveLink();
    }

    #endregion

    #region ##### CRUD METHODS #####

    private async Task GetLink()
    {
        try
        {
            _Link = await linkRepository.GetLink(LinkID);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ELK001: Unable to Retrieve Link.");
        }
    }

    private async Task GetChapters()
    {
        try
        {
            _Chapters = await chapterRepository.GetChapters(AdventureID);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ELK000: Unable to Retrieve Chapters.");
        }
    }

    private async void SaveLink()
    {
        try
        {
            await linkRepository.UpdateLink(_Link);
            await GetLink();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ELK002: Unable to Save Link.");
        }
    }

    #endregion

    #region ##### NAVIGATION #####

    private void NavEditChapter()
    {
        navigationManager.NavigateTo($"editchapter/{_Link.ChapterID}");
    }

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChapterRepository chapterRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILinkRepository linkRepository { get; set; }
    }
}
#pragma warning restore 1591
