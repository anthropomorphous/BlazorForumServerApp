#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c27236275995a0a12babff445934df7b414c99"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Администрирование</h1>\r\n<br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n");
#nullable restore
#line 11 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.OpenElement(5, "p");
                __builder2.AddMarkupContent(6, "Вы являетесь администратором. (");
                __builder2.AddContent(7, 
#nullable restore
#line 13 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                               ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(8, ") ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n");
                __builder2.AddContent(10, "            ");
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, @"<thead>
                    <tr>
                        <th>Id</th>
                        <th>User Name</th>
                        <th>Email</th>
                        <th></th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(15, "tbody");
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 25 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                     foreach (var user in ColUsers)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                        ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 28 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(22, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 29 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 30 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "td");
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "btn btn-primary");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                  (() => EditUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(35, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
#nullable restore
#line 38 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(39, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 41 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, "                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "modal");
                __builder2.AddAttribute(45, "tabindex", "-1");
                __builder2.AddAttribute(46, "style", "display:block");
                __builder2.AddAttribute(47, "role", "dialog");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "modal-dialog");
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "modal-content");
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "modal-header");
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.AddMarkupContent(58, "<h3 class=\"modal-title\">Edit User</h3>\r\n                                ");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "type", "button");
                __builder2.AddAttribute(61, "class", "close");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(63, "\r\n                                    ");
                __builder2.AddMarkupContent(64, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "modal-body");
                __builder2.AddMarkupContent(69, "\r\n");
#nullable restore
#line 54 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "                                    ");
                __builder2.OpenElement(71, "p");
                __builder2.AddContent(72, 
#nullable restore
#line 56 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                        objUser.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n");
#nullable restore
#line 57 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(74, "                                    ");
                __builder2.OpenElement(75, "p");
                __builder2.AddContent(76, 
#nullable restore
#line 60 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                        objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n");
#nullable restore
#line 61 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(78, "                                    ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "placeholder", "UserName");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                  objUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n");
#nullable restore
#line 67 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(86, "                                ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "type", "text");
                __builder2.AddAttribute(90, "placeholder", "Email");
                __builder2.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                              objUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "type", "password");
                __builder2.AddAttribute(97, "placeholder", "Password");
                __builder2.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                                ");
                __builder2.OpenElement(101, "select");
                __builder2.AddAttribute(102, "class", "form-control");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                CurrentUserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 76 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                     foreach (var option in Options)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(106, "                                        ");
                __builder2.OpenElement(107, "option");
                __builder2.AddAttribute(108, "value", 
#nullable restore
#line 78 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                        option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(109, "\r\n                                            ");
                __builder2.AddContent(110, 
#nullable restore
#line 79 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                             option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n");
#nullable restore
#line 81 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(113, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                <br><br>\r\n                                ");
                __builder2.OpenElement(115, "button");
                __builder2.AddAttribute(116, "class", "btn btn-primary");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                  SaveUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(118, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n");
#nullable restore
#line 88 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(120, "                                    ");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "class", "btn btn-danger");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                      DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(124, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n");
#nullable restore
#line 94 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(126, "                                <br>\r\n                                ");
                __builder2.OpenElement(127, "span");
                __builder2.AddAttribute(128, "style", "color:red");
                __builder2.AddContent(129, 
#nullable restore
#line 96 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n");
#nullable restore
#line 101 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(135, "            ");
                __builder2.OpenElement(136, "button");
                __builder2.AddAttribute(137, "class", "btn btn-success");
                __builder2.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                      AddNewUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(139, "Add User");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n");
#nullable restore
#line 103 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(141, "            ");
                __builder2.OpenElement(142, "p");
                __builder2.AddMarkupContent(143, "Вы не являетесь администратором данного сайта. (");
                __builder2.AddContent(144, 
#nullable restore
#line 106 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
                                                                ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(145, ")");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n");
#nullable restore
#line 107 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(147, "    ");
            }
            ));
            __builder.AddAttribute(148, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(149, "\r\n        ");
                __builder2.AddMarkupContent(150, "<p>You\'re not loggged in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Administration.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    IdentityUser objUser = new IdentityUser();

    string CurrentUserRole { get; set; } = "Users";

    List<IdentityUser> ColUsers = new List<IdentityUser>();

    List<string> Options = new List<string>() { "Users", "Administrators" };

    string strError = "";

    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }

        var user = await _UserManager.FindByNameAsync("Admin@BlazorServerApp.com");
        if (user != null)
        {

            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }

        CurrentUser = (await authenticationStateTask).User;

        GetUsers();
    }

    void AddNewUser()
    {
        objUser = new IdentityUser();
        objUser.PasswordHash = "*****";
        objUser.Id = "";
        ShowPopup = true;
    }
    async Task SaveUser()
    {
        try
        {
            if (objUser.Id != "")
            {
                var user = await _UserManager.FindByIdAsync(objUser.Id);
                user.Email = objUser.Email;

                await _UserManager.UpdateAsync(user);
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =
                        await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser =
                        await _UserManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passworduser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Pasword error";
                        }
                        return;
                    }
                }
                var UserResult =
                    await _UserManager
                    .IsInRoleAsync(user, ADMINISTRATION_ROLE);
                if (
                    (CurrentUserRole == ADMINISTRATION_ROLE)
                    &
                    (!UserResult))
                {
                    await _UserManager
                        .AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    if ((CurrentUserRole != ADMINISTRATION_ROLE)
                        &
                        (UserResult))
                    {
                        await _UserManager
                            .RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    }
                }
            }
            else
            {
                var NewUser =
                    new IdentityUser
                    {
                        UserName = objUser.UserName,
                        Email = objUser.Email
                    };
                var CreateResult =
                    await _UserManager
                    .CreateAsync(NewUser, objUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult
                        .Errors
                        .FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    return;
                }
                else
                {

                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        await _UserManager
                            .AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
                }
            }

            ShowPopup = false;

            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditUser(IdentityUser _IdentityUser)
    {
        objUser = _IdentityUser;

        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            var UserResult =
                await _UserManager
                .IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                CurrentUserRole = "Users";
            }
        }
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        ShowPopup = false;
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            await _UserManager.DeleteAsync(user);
        }
        GetUsers();
    }

    void ClosePopup()
    {
        ShowPopup = false;
    }

    public void GetUsers()
    {
        strError = "";
        ColUsers = new List<IdentityUser>();

        var user = _UserManager.Users.Select(x => new IdentityUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
           // PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }

        ColUsers.RemoveAll(x => x.UserName == "Admin@BlazorServerApp.com");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
