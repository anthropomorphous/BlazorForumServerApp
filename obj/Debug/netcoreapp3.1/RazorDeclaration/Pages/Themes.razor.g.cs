#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032b507340138dfe2406f9df05655fe33dd15ba9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\all of this\code this code\blazor_asp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/themes")]
    public partial class Themes : OwningComponentBase<ThemeTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
       
    public int i = 0;

    // Demonstrates how a parent component can supply parameters
    [Parameter] public string Theme { get; set; }


    // AuthenticationState is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<ThemeTable> themes;
    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get all the themes
        // We access ThemeTableService using @Service
        // And pick (probably ok) not only the 4 theme
        themes = await @Service.GetThemesAsync();
    }


    ThemeTable objThemeTable = new ThemeTable();
    bool ShowPopup = false;
    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }
    void AddNewTheme()
    {
        // Make new theme
        objThemeTable = new ThemeTable();
        // Set Id to 0 so we know it is a new record
        objThemeTable.Id = 0;
        // Open the Popup
        ShowPopup = true;
    }
    async Task SaveTheme()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the current user
        var user = (await authenticationStateTask).User;
        // A new theme will have the Id set to 0
        if (objThemeTable.Id == 0)
        {
            // Create new theme
            ThemeTable objNewThemeTable = new ThemeTable();
            objNewThemeTable.Date = System.DateTime.Now;
            objNewThemeTable.ThemeName = objThemeTable.ThemeName;
            objNewThemeTable.UserName = user.Identity.Name;
            // Save the result
            var result =
            @Service.CreateThemeAsync(objNewThemeTable);
        }
        else
        {
            // This is an update
            var result =
            @Service.UpdateThemeAsync(objThemeTable);
        }
        // Get the themes for the current user
        themes =
        await @Service.GetThemesAsync();

    }

    void EditTheme(ThemeTable themeTable)
    {
        // Set the selected theme
        // as the current theme
        objThemeTable = themeTable;
        // Open the Popup
        ShowPopup = true;
    }

    int themenum = 0;

    void OpenTheme(ThemeTable themeTable, int i, string name)
    {
        ThemeTableService.Name = name;
        ThemeTableService.Number = i;
        objThemeTable = themeTable;
        NavigationManager.NavigateTo("component");

    }

    async Task DeleteTheme()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Delete the theme
        var result = @Service.DeleteThemeAsync(objThemeTable);
        // Get the themes for the current user
        themes =
        await @Service.GetThemeAsync(user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ThemeTableService ThemeTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
