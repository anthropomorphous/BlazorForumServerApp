#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a062143f0200e5d195118dd121594b0c896d921b"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/component")]
    public partial class Component : OwningComponentBase<MessageTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, "Тема #");
            __builder.AddContent(2, 
#nullable restore
#line 8 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
           ThemeTableService.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "padding: 15px");
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "h4");
                __builder2.AddMarkupContent(11, "Добро пожаловать, ");
                __builder2.AddContent(12, 
#nullable restore
#line 17 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n");
#nullable restore
#line 19 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
             if (messages == null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(15, "                \r\n                ");
                __builder2.AddMarkupContent(16, "<p><em>Загрузка...</em></p>\r\n");
#nullable restore
#line 23 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(17, "                \r\n                ");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "nav flex-column");
                __builder2.AddMarkupContent(20, "\r\n");
#nullable restore
#line 28 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                     foreach (var message in messages)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "                        ");
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "id", 
#nullable restore
#line 30 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                 message.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(24, "class", "nav-item px-3");
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "alert alert-success");
                __builder2.AddMarkupContent(28, "\r\n                                <span class=\"oi oi-caret-bottom\" aria-hidden=\"true\"></span> ");
                __builder2.OpenElement(29, "strong");
                __builder2.AddContent(30, 
#nullable restore
#line 32 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                                                                     ThemeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(31, " ");
                __builder2.AddContent(32, 
#nullable restore
#line 32 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                                                                                         message.Date.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n\r\n                                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddContent(35, "#");
                __builder2.AddContent(36, 
#nullable restore
#line 34 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                       message.ThemeId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(37, " ");
                __builder2.AddContent(38, 
#nullable restore
#line 34 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                        ThemeTableService.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddContent(41, 
#nullable restore
#line 36 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                      message.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "style", "padding:10px;");
                __builder2.AddContent(45, 
#nullable restore
#line 37 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                            message.Text

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n                                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddMarkupContent(48, "\r\n                                    \r\n                                    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                      (() => EditMessage(message))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "\r\n                                        Редактировать\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n");
#nullable restore
#line 49 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
                __builder2.AddContent(59, "                ");
                __builder2.OpenElement(60, "p");
                __builder2.AddMarkupContent(61, "\r\n                    \r\n                    ");
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "class", "btn btn-primary");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                      AddNewMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "\r\n                        Ответить\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 60 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                 if (ShowPopup)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "                    \r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "modal");
                __builder2.AddAttribute(71, "tabindex", "-1");
                __builder2.AddAttribute(72, "style", "display:block");
                __builder2.AddAttribute(73, "role", "dialog");
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "modal-dialog");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "modal-content");
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "modal-header");
                __builder2.AddMarkupContent(83, "\r\n                                    ");
                __builder2.AddMarkupContent(84, "<h3 class=\"modal-title\">Изменить</h3>\r\n                                    \r\n                                    ");
                __builder2.OpenElement(85, "button");
                __builder2.AddAttribute(86, "type", "button");
                __builder2.AddAttribute(87, "class", "close");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                      ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(89, "\r\n                                        ");
                __builder2.AddMarkupContent(90, "<span aria-hidden=\"true\">X</span>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                \r\n                                ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "modal-body");
                __builder2.AddMarkupContent(95, "\r\n                                    ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "type", "text");
                __builder2.AddAttribute(99, "placeholder", "Сообщение");
                __builder2.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                  objMessageTable.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMessageTable.Text = __value, objMessageTable.Text));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                    <br>\r\n                                    \r\n                                    ");
                __builder2.OpenElement(103, "button");
                __builder2.AddAttribute(104, "class", "btn btn-primary");
                __builder2.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                      SaveMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(106, "\r\n                                        Save\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n                                    \r\n");
#nullable restore
#line 87 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                     if (objMessageTable.Id > 0)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(108, "                                        \r\n                                        ");
                __builder2.OpenElement(109, "button");
                __builder2.AddAttribute(110, "class", "btn btn-primary");
                __builder2.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                                          DeleteMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(112, "\r\n                                            Delete\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n");
#nullable restore
#line 94 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(114, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n");
#nullable restore
#line 99 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
                 

            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(119, "        ");
            }
            ));
            __builder.AddAttribute(120, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.AddMarkupContent(122, "<p>Темы могут видеть только зарегистрированные пользователи.</p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
       

    protected override void OnInitialized()
    {
        ThemeTableService.OnClick += StateHasChanged;
    }

    string strt = "...";

    void ShowMessage()
    {
        strt = "Ееееее биохакинг пацаны!!1!";
    }



    // Demonstrates how a parent component can supply parameters
    [Parameter] public string Message { get; set; }

    // AuthenticationState is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    List<MessageTable> messages;
    List<ThemeTable> themes;
    string ThemeName;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get all the themes
        // We access ThemeTableService using @Service
        // And pick (probably ok) not only the 4
        messages = await @Service.GetMessagesAsync(ThemeTableService.Number);

    }

    MessageTable objMessageTable = new MessageTable();
    ThemeTable objThemeTable = new ThemeTable();
    bool ShowPopup = false;
    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }
    void AddNewMessage()
    {
        // Make new theme
        objMessageTable = new MessageTable();
        // Set Id to 0 so we know it is a new record
        objMessageTable.Id = 0;
        // Open the Popup
        ShowPopup = true;
    }

    void SelectTheme()
    {
        objThemeTable = new ThemeTable();
        objThemeTable.Id = ThemeTableService.Number;

    }

    async Task SaveMessage()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the current user
        var user = (await authenticationStateTask).User;
        // A new theme will have the Id set to 0
        if (objMessageTable.Id == 0)
        {
            // Create new message
            MessageTable objNewMessageTable = new MessageTable();
            objNewMessageTable.Date = System.DateTime.Now;
            objNewMessageTable.ThemeId = ThemeTableService.Number;
            objNewMessageTable.Text = objMessageTable.Text;
            objNewMessageTable.UserName = user.Identity.Name;


            // Save the result
            var result =
            @Service.CreateMessageAsync(objNewMessageTable);
        }
        else
        {
            // This is an update
            var result =
            @Service.UpdateMessageAsync(objMessageTable);
        }
        // Get the messages for the current theme

        messages =
        await @Service.GetMessagesAsync(ThemeTableService.Number);

    }

    void EditMessage(MessageTable messageTable)
    {
        // Set the selected message
        // as the current message
        objMessageTable = messageTable;
        // Open the Popup
        ShowPopup = true;
    }

    async Task DeleteMessage()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Delete the theme
        var result = @Service.DeleteMessageAsync(objMessageTable);
        // Get the themes for the current user
        messages =
        await @Service.GetMessageAsync(user.Identity.Name);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ThemeTableService ThemeTableService { get; set; }
    }
}
#pragma warning restore 1591
