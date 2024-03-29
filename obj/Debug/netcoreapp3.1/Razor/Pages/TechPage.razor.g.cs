#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f679e829f193202a927bec3966471e154b24f1"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/techpage")]
    public partial class TechPage : OwningComponentBase<ThemeTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Техника</h1>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n");
#nullable restore
#line 17 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
         if (themes == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.AddMarkupContent(5, "<p><em>Загрузка...</em></p>\r\n");
#nullable restore
#line 20 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.AddMarkupContent(10, "<thead>\r\n                    <tr>\r\n                        <th>Date</th>\r\n                        <th>Theme</th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                ");
                __builder2.OpenElement(11, "tbody");
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 33 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                     foreach (var theme in themes)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                        ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\r\n                            ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 36 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                 theme.Date.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 37 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                 theme.ThemeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddMarkupContent(23, "\r\n                                ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "class", "btn btn-primary");
                __builder2.AddAttribute(26, "style", "background-color: #4CAF50;");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                                  (() => EditTheme(theme))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddAttribute(35, "style", "background-color: #4CAF50;");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                                  (() => OpenTheme(theme, theme.Id, theme.CategoryName))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n                                    Открыть\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 51 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "p");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "style", "background-color: #4CAF50;");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                  AddNewTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(50, "\r\n                    Добавить тему\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 60 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal");
                __builder2.AddAttribute(56, "tabindex", "-1");
                __builder2.AddAttribute(57, "style", "display:block");
                __builder2.AddAttribute(58, "role", "dialog");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal-dialog");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "modal-content");
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "modal-header");
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __builder2.AddMarkupContent(69, "<h3 class=\"modal-title\">Изменить</h3>\r\n                                ");
                __builder2.OpenElement(70, "button");
                __builder2.AddAttribute(71, "type", "button");
                __builder2.AddAttribute(72, "class", "close");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(74, "\r\n                                    ");
                __builder2.AddMarkupContent(75, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "modal-body");
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "type", "text");
                __builder2.AddAttribute(84, "placeholder", "Тема");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                              objThemeTable.ThemeName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objThemeTable.ThemeName = __value, objThemeTable.ThemeName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                <br>\r\n                                ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "class", "btn btn-primary");
                __builder2.AddAttribute(90, "style", "background-color: #4CAF50;");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                                  SaveTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(92, "\r\n                                    Сохранить\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n");
#nullable restore
#line 82 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                 if (objThemeTable.Id > 0)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(94, "                                    ");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "class", "btn btn-primary");
                __builder2.AddAttribute(97, "style", "background-color: #4CAF50;");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                                      DeleteTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(99, "\r\n                                        Удалить\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n");
#nullable restore
#line 88 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(101, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 93 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
             

        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(106, "    ");
            }
            ));
            __builder.AddAttribute(107, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.AddMarkupContent(109, "<p>Вы не вошли в аккаунт.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\TechPage.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<ThemeTable> themes;

    string category = "Техника";

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;
        themes = await @Service.GetThemeByCategoryAsync(category);
    }

    ThemeTable objThemeTable = new ThemeTable();
    bool ShowPopup = false;
    void ClosePopup()
    {
        ShowPopup = false;
    }
    void AddNewTheme()
    {
        objThemeTable = new ThemeTable();
        objThemeTable.Id = 0;
        ShowPopup = true;
    }
    async Task SaveTheme()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        if (objThemeTable.Id == 0)
        {
            ThemeTable objNewThemeTable = new ThemeTable();
            objNewThemeTable.Date = System.DateTime.Now;
            objNewThemeTable.ThemeName = objThemeTable.ThemeName;
            objNewThemeTable.UserName = user.Identity.Name;
            objNewThemeTable.CategoryName = category;

            var result =
            @Service.CreateThemeAsync(objNewThemeTable);
        }
        else
        {
            var result =
            @Service.UpdateThemeAsync(objThemeTable);
        }

        themes =
        await @Service.GetThemeByCategoryAsync(category);

    }

    void EditTheme(ThemeTable themeTable)
    {
        objThemeTable = themeTable;
        ShowPopup = true;
    }

    void OpenTheme(ThemeTable themeTable, int i, string name)
    {
        ThemeTableService.Name = name;
        ThemeTableService.Number = i;
        objThemeTable = themeTable;
        NavigationManager.NavigateTo("messagepage");
        logger.LogInformation("Processing request from TechPage");

    }

    async Task DeleteTheme()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteThemeAsync(objThemeTable);
        themes =
        await @Service.GetThemeByCategoryAsync(category);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<TechPage> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ThemeTableService ThemeTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
