#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c13dfaf660ec7820d59301e27c3b352096b587c4"
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
#line 10 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproject/{ProjectID:int}")]
    public partial class EditProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Project</h3>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
 if (_Adventure != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "left-column");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenComponent<adventureplatform.Client.Pages.Projects.Forms.ProjectForm>(8);
            __builder.AddAttribute(9, "Project", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<adventureplatform.Shared.Entities.Adventure>(
#nullable restore
#line 21 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                  _Adventure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                             SaveProject

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<adventureplatform.Shared.Entities.Genre>>(
#nullable restore
#line 21 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                                                             _NotSelectedGenreList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "SelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<adventureplatform.Shared.Entities.Genre>>(
#nullable restore
#line 21 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                                                                                                    _SelectedGenreList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "right-column");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 29 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                 foreach (var chapter in _ChapterList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex");
            __builder.AddMarkupContent(24, "\r\n\r\n                        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-warning flex-grow-1 mb-2");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                                                     () => NavEditChapter(chapter.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                            Edit ");
            __builder.AddContent(29, 
#nullable restore
#line 35 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                  chapter.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n                        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger ml-2 mb-2");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                                             () => DeleteChapter(chapter.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 44 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "btn btn-info btn-block");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
                                                            NavCreateChapter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Create New Chapter");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 53 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
       

    #region ##### HEAD #####

    [Parameter] public int ProjectID { get; set; }

    Adventure _Adventure;
    List<Genre> _NotSelectedGenreList;
    List<Genre> _SelectedGenreList;
    List<Chapter> _ChapterList;

    #endregion

    #region ##### LIFECYCLE METHODS #####

    protected async override Task OnInitializedAsync()
    {
        await GetAdventureModel();
    }

    #endregion

    #region ##### CRUD METHODS #####

    private async Task GetAdventureModel()
    {
        try
        {
            var model = await adventureRepository.GetAdventureUpdateDTO(ProjectID);

            _Adventure = model.Adventure;
            _NotSelectedGenreList = model.NotSelectedGenreList;
            _SelectedGenreList = model.SelectedGenreList;
            _ChapterList = model.ChapterList;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("EPT001: Unable to Retrieve Adventure.");
        }
    }

    private async Task SaveProject()
    {
        try
        {
            await adventureRepository.UpdateAdventure(_Adventure);
            await GetAdventureModel();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ACC001: Unable to Save Project.");
        }
    }

    private async Task DeleteChapter(int id)
    {
        try
        {
            await chapterRepository.DeleteChapter(id);
            await GetAdventureModel();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetBaseException().ToString());
            Console.WriteLine("ACC001: Unable to Delete Chapter.");
        }
    }

    #endregion

    #region ##### NAVIGATION #####

    private void NavCreateChapter()
    {
        navigationManager.NavigateTo($"createchapter/{ProjectID}");
    }

    private void NavEditChapter(int id)
    {
        navigationManager.NavigateTo($"editchapter/{id}");
    }

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChapterRepository chapterRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdventureRepository adventureRepository { get; set; }
    }
}
#pragma warning restore 1591
