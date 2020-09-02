#pragma checksum "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5940293abdb80c1cc3a0a39cc2839af822c0614"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 6 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\64221\Documents\PRJ7-Project\adventure-platform\adventure-platform\Client\Pages\Projects\EditProject.razor"
       

    [Parameter] public int ProjectID { get; set; }

    Adventure adventure;
    List<Genre> notSelectedGenreList;
    List<Genre> selectedGenreList;
    List<Chapter> chapterList;

    protected async override Task OnInitializedAsync()
    {
        var model = await adventureRepository.GetAdventureUpdateDTO(ProjectID);
        adventure = model.Adventure;
        notSelectedGenreList = model.NotSelectedGenreList;
        selectedGenreList = model.SelectedGenreList;
        chapterList = model.ChapterList;
    }

    private async Task SaveProject()
    {

            await adventureRepository.UpdateAdventure(adventure);

    }

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

    private async Task DeleteChapter(int id)
    {
        try
        {
            await chapterRepository.DeleteChapter(id);
            chapterList = await chapterRepository.GetChapters(adventure.ID);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChapterRepository chapterRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdventureRepository adventureRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
