#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0589b2cfd69bf478362f8a9c849a55519047ec64"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : OwningComponentBase<ThemeTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Theme Table</h1>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "h4");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 20 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 21 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
         if (themes == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, "            \r\n            ");
                __builder2.AddMarkupContent(10, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 25 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(11, "            \r\n            ");
                __builder2.OpenElement(12, "table");
                __builder2.AddAttribute(13, "class", "table");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<thead>\r\n                    <tr>\r\n                        <th>Date</th>\r\n                        <th>Theme</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                ");
                __builder2.OpenElement(16, "tbody");
                __builder2.AddMarkupContent(17, "\r\n");
#nullable restore
#line 38 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                     foreach (var theme in themes)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(18, "                        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 41 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                 theme.Date.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 42 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                 theme.ThemeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddMarkupContent(28, "\r\n                                \r\n                                ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn btn-primary");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                                  (() => EditTheme(theme))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n");
#nullable restore
#line 51 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(36, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "p");
                __builder2.AddMarkupContent(40, "\r\n                \r\n                ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "class", "btn btn-primary");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                  AddNewTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(44, "\r\n                    Add New Theme\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 61 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(47, "                \r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "modal");
                __builder2.AddAttribute(50, "tabindex", "-1");
                __builder2.AddAttribute(51, "style", "display:block");
                __builder2.AddAttribute(52, "role", "dialog");
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal-dialog");
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "modal-content");
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal-header");
                __builder2.AddMarkupContent(62, "\r\n                                ");
                __builder2.AddMarkupContent(63, "<h3 class=\"modal-title\">Изменить</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "type", "button");
                __builder2.AddAttribute(66, "class", "close");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(68, "\r\n                                    ");
                __builder2.AddMarkupContent(69, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            \r\n                            ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "modal-body");
                __builder2.AddMarkupContent(74, "\r\n                                ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "type", "text");
                __builder2.AddAttribute(78, "placeholder", "Тема");
                __builder2.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                              objThemeTable.ThemeName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objThemeTable.ThemeName = __value, objThemeTable.ThemeName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                <br>\r\n                                \r\n                                ");
                __builder2.OpenElement(82, "button");
                __builder2.AddAttribute(83, "class", "btn btn-primary");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                                  SaveTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(85, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n                                \r\n");
#nullable restore
#line 88 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                 if (objThemeTable.Id > 0)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(87, "                                    \r\n                                    ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "class", "btn btn-primary");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                                      DeleteTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(91, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 95 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n");
#nullable restore
#line 100 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
             

        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(98, "    ");
            }
            ));
            __builder.AddAttribute(99, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.AddMarkupContent(101, "<p>You\'re not signed in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\FetchData.razor"
       
    // AuthenticationState is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<ThemeTable> themes;
    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get the forecasts for the current user
        // We access ThemeTableService using @Service
        themes = await @Service.GetThemeAsync(user.Identity.Name);
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
        // Get the themess for the current user
        themes =
        await @Service.GetThemeAsync(user.Identity.Name);
       
    }

     void EditTheme(ThemeTable themeTable)
    {
        // Set the selected theme
        // as the current theme
        objThemeTable = themeTable;
        // Open the Popup
        ShowPopup = true;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
