#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ecd6892d9a5617ad1d90250c65f9e90a3f0dac"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using MimeKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sendemail")]
    public partial class SendEmail : OwningComponentBase<EmailService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    input.my-input {\r\n        width: 325px;\r\n    }\r\n\r\n    input.large-input {\r\n        width: 350px;\r\n        line-grid: create;\r\n        height: 100px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Отправьте письмо участнику:</h1>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n\r\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddMarkupContent(8, "\r\n                Ваша почта:\r\n                ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "class", "my-input form-control");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "name", "customerEmail");
                __builder2.AddAttribute(13, "placeholder", "Ваш Email");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
                              eMailFrom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eMailFrom = __value, eMailFrom));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddMarkupContent(19, "\r\n                Ваш пароль:\r\n                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "class", "my-input form-control");
                __builder2.AddAttribute(22, "type", "password");
                __builder2.AddAttribute(23, "name", "password");
                __builder2.AddAttribute(24, "placeholder", "Ваш пароль");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
                              password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "span");
                __builder2.AddMarkupContent(32, "\r\n                    Получатель:\r\n                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "class", "my-input form-control");
                __builder2.AddAttribute(35, "typeof", "text");
                __builder2.AddAttribute(36, "placeholder", "Email участника");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
                                  eMailTo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eMailTo = __value, eMailTo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddMarkupContent(43, "\r\n                Ваше сообщение: <br>\r\n                ");
                __builder2.OpenElement(44, "textarea");
                __builder2.AddAttribute(45, "name", "customerRequest");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "cols", "45");
                __builder2.AddAttribute(48, "rows", "4");
                __builder2.AddAttribute(49, "placeholder", "Введите сообщение...");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
                                 message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "class", "btn btn-primary");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
                              SendMail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(58, "\r\n                Отправить\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n");
#nullable restore
#line 81 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(60, "                ");
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
                __builder2.AddMarkupContent(76, "<h3 class=\"modal-title\">Сообщение отправлено</h3>\r\n                                ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "type", "button");
                __builder2.AddAttribute(79, "class", "close");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
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
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n");
#nullable restore
#line 96 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(88, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
            }
            ));
            __builder.AddAttribute(90, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.AddMarkupContent(92, "<p>Войдите в свой аккаунт либо зарегистрируйтесь.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SendEmail.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    string eMailFrom = "";
    string subject = "";
    string message = "";
    string password = "";
    string eMailTo = "";

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;
        eMailFrom = user.Identity.Name;
    }

    bool ShowPopup = false;

    void ClosePopup()
    {
        ShowPopup = false;
    }

    async Task SendMail()
    {

        var result =
           @Service.SendEmailAsync(eMailFrom, password, eMailTo, subject, message);

        logger.LogInformation("Сообщение отправлено");

        ShowPopup = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.EmailService EmailService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<SendEmail> logger { get; set; }
    }
}
#pragma warning restore 1591
