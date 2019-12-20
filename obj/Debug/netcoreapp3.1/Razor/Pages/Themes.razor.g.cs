#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f60b3a6c324b4636c87aae83f5aeaa949b6ea2eb"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/themes")]
    public partial class Themes : OwningComponentBase<ThemeTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Темы</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    /* Add a dark gray background color to the modal header and center text */
    .modal-header {
        background-image: linear-gradient(darkslategray, darkseagreen);
        color: #fff !important;
        text-align: center;
        font-size: 30px;
    }

    .modal-header, .modal-body {
        padding: 40px 50px;
    }
</style>



");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenElement(5, "h4");
                __builder2.AddMarkupContent(6, "Добро пожаловать, ");
                __builder2.AddContent(7, 
#nullable restore
#line 30 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(8, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 31 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
         if (themes == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(10, "            \r\n            ");
                __builder2.AddMarkupContent(11, "<p><em>Загрузка...</em></p>\r\n");
#nullable restore
#line 35 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(12, "            \r\n            ");
                __builder2.OpenElement(13, "table");
                __builder2.AddAttribute(14, "class", "table");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, @"<thead>
                    <tr>
                        <th>Дата</th>
                        <th>Тема</th>
                        <th>Пользователь</th>
                        <td></td>
                        <th></th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(17, "tbody");
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 50 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                     foreach (var theme in themes)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                        ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 53 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                 theme.Date.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 54 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                 theme.ThemeName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 55 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                 theme.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.OpenElement(32, "td");
                __builder2.AddMarkupContent(33, "\r\n                                ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn btn-primary");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                                  (() => OpenTheme(theme, theme.Id, theme.ThemeName))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n                                    Открыть\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddMarkupContent(41, "\r\n                                ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                                  (() => EditTheme(theme))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "\r\n                                    Редактировать\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
#nullable restore
#line 69 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(49, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "p");
                __builder2.AddMarkupContent(53, "\r\n                \r\n                ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "class", "btn btn-primary");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                  AddNewTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "\r\n                    Add New Theme\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n");
#nullable restore
#line 79 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(60, "                \r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "modal");
                __builder2.AddAttribute(63, "tabindex", "-1");
                __builder2.AddAttribute(64, "style", "display:block");
                __builder2.AddAttribute(65, "role", "dialog");
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "modal-dialog");
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "modal-content");
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "modal-header");
                __builder2.AddMarkupContent(75, "\r\n                                ");
                __builder2.AddMarkupContent(76, "<h3 class=\"modal-title\">Изменить</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "type", "button");
                __builder2.AddAttribute(79, "class", "close");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(81, "\r\n                                    ");
                __builder2.AddMarkupContent(82, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                            \r\n                            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "modal-body");
                __builder2.AddMarkupContent(87, "\r\n                                ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "placeholder", "Тема");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                              objThemeTable.ThemeName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objThemeTable.ThemeName = __value, objThemeTable.ThemeName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                <br>\r\n                                \r\n                                ");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "class", "btn btn-primary");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                                  SaveTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(98, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n                                \r\n");
#nullable restore
#line 106 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                 if (objThemeTable.Id > 0)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(100, "                                    \r\n                                    ");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "class", "btn btn-primary");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                                      DeleteTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(104, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 113 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(106, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n");
#nullable restore
#line 118 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
             

        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(111, "    ");
            }
            ));
            __builder.AddAttribute(112, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.AddMarkupContent(114, "<p>Темы могут видеть только зарегистрированные пользователи.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Themes.razor"
       
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
        logger.LogInformation("Processing request from {Address}", themes);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Themes> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ThemeTableService ThemeTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
