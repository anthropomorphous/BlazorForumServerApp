#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3abad48f5813187327d2eda2f0ffa8996c1f97e"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/drugspage")]
    public partial class DrugsPage : OwningComponentBase<ItemTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Фармацевтика</h1>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "main");
                __builder2.AddMarkupContent(6, "\r\n");
#nullable restore
#line 24 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
             if (itemsList != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                 foreach (var item in itemsList)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(7, "                    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card");
                __builder2.AddAttribute(10, "style", "width: 18rem;");
                __builder2.AddMarkupContent(11, "\r\n                        <img class=\"card-img-top\" src=\"~/Images/accountimg.png\" alt=\"Card image cap\">\r\n                        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "card-body");
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "h5");
                __builder2.AddAttribute(16, "class", "card-title");
                __builder2.AddContent(17, 
#nullable restore
#line 31 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                                    item.ItemName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "p");
                __builder2.AddAttribute(20, "class", "card-text");
                __builder2.AddContent(21, 
#nullable restore
#line 32 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                                  item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "ul");
                __builder2.AddAttribute(25, "class", "list-group list-group-flush");
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "li");
                __builder2.AddAttribute(28, "class", "list-group-item");
                __builder2.AddContent(29, 
#nullable restore
#line 35 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                                         item.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.AddMarkupContent(32, "<div class=\"card-body\">\r\n                            <a href=\"itempage\" class=\"card-link\">Открыть</a>\r\n                            <a href=\"#\" class=\"card-link\">Удалить</a>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    <br>\r\n");
#nullable restore
#line 43 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n");
#nullable restore
#line 47 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(36, "            ");
                __builder2.OpenElement(37, "p");
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary");
                __builder2.AddAttribute(41, "style", " background-color: #4CAF50;");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                  AddNewItemTable

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(43, "\r\n                    Добавить продукт\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n");
#nullable restore
#line 55 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(46, "                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "modal");
                __builder2.AddAttribute(49, "tabindex", "-1");
                __builder2.AddAttribute(50, "style", "display:block");
                __builder2.AddAttribute(51, "role", "dialog");
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "modal-dialog");
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "modal-content");
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "modal-header");
                __builder2.AddMarkupContent(61, "\r\n                                ");
                __builder2.AddMarkupContent(62, "<h3 class=\"modal-title\">Изменить</h3>\r\n                                ");
                __builder2.OpenElement(63, "button");
                __builder2.AddAttribute(64, "type", "button");
                __builder2.AddAttribute(65, "class", "close");
                __builder2.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(67, "\r\n                                    ");
                __builder2.AddMarkupContent(68, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "modal-body");
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.OpenElement(74, "input");
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "type", "text");
                __builder2.AddAttribute(77, "placeholder", "Продукт");
                __builder2.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                              objItemTable.ItemName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objItemTable.ItemName = __value, objItemTable.ItemName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                                <br>\r\n                                ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "type", "text");
                __builder2.AddAttribute(84, "placeholder", "Описание");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                              objItemTable.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objItemTable.Description = __value, objItemTable.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                <br>\r\n                                ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "placeholder", "Image URL");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                              objItemTable.ImageUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objItemTable.ImageUrl = __value, objItemTable.ImageUrl));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                <br>\r\n\r\n                                ");
                __builder2.AddMarkupContent(95, "<div align=\"center\">\r\n\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(96, "button");
                __builder2.AddAttribute(97, "class", "btn btn-primary");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
                                                  SaveItemTable

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(99, "\r\n                                    Сохранить\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n");
#nullable restore
#line 92 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
             
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "    ");
            }
            ));
            __builder.AddAttribute(106, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(107, "\r\n        ");
                __builder2.AddMarkupContent(108, "<p>Войдите в свой аккаунт либо зарегистрируйтесь.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\DrugsPage.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    bool ShowPopup = false;

    List<ItemTable> itemsList;


    int categoryId = 0;
    string category = "Фармацевтика";

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;

        try
        {
            itemsList = await @Service.GetItemByCategoryAsync(category);

        }
        catch (Exception e)
        {
            logger.LogError(e, e.Message);
        }

    }

    ItemTable objItemTable = new ItemTable();
    CategoryTable objCategoryTable = new CategoryTable();


    void ClosePopup()
    {
        ShowPopup = false;
    }

    void AddNewItemTable()
    {
        objItemTable = new ItemTable();
        objItemTable.Id = 0;
        ShowPopup = true;
    }

    async Task SaveItemTable()
    {

        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        if (objItemTable.Id == 0)
        {
            ItemTable objNewItemTable = new ItemTable();

            objNewItemTable.Date = System.DateTime.Now;

            objNewItemTable.ItemName = objItemTable.ItemName;

            objNewItemTable.CategoryId = categoryId;

            objNewItemTable.UserName = user.Identity.Name;

            objNewItemTable.Description = objItemTable.Description;

            objNewItemTable.ImageUrl = objItemTable.ImageUrl;

            objNewItemTable.Category = category;

            var result =
            @Service.CreateItemAsync(objNewItemTable);
        }
        else
        {
            var result =
            @Service.UpdateItemAsync(objItemTable);
        }

        itemsList =
        await @Service.GetItemByCategoryAsync(category);
    }

    async Task DeleteItemTable(ItemTable itemTable, string category)
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteItemAsync(itemTable);
        itemsList =
        await @Service.GetItemByCategoryAsync(category);
    }

    void OpenItem(ItemTable itemTable, int i, string description, string category, string name)
    {
        ItemTableService.Description = description;
        ItemTableService.Number = i;
        ItemTableService.Category = category;
        ItemTableService.Name = name;
        objItemTable = itemTable;
        NavigationManager.NavigateTo("itempage");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ItemTableService ItemTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ItemsPage> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
