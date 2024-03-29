#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2b8f5c3d1e8671249120c9be2d80f709edcf19c"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemsPage.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemsPage.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemsPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemspage")]
    public partial class ItemsPage : OwningComponentBase<ItemTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemsPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<ItemTable> itemsList;

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;

        try
        {
            itemsList = await @Service.GetItemByCategoryAsync(ItemTableService.Category);

        }
        catch (Exception e)
        {
            logger.LogError(e, e.Message);
        }

    }

    ItemTable objItemTable = new ItemTable();
    CategoryTable objCategoryTable = new CategoryTable();


    bool ShowPopup = false;

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

            objNewItemTable.CategoryId = ItemTableService.Number;

            objNewItemTable.UserName = user.Identity.Name;

            objNewItemTable.Description = ItemTableService.Description;

            objNewItemTable.ImageUrl = objItemTable.ImageUrl;

            var result =
            @Service.CreateItemAsync(objNewItemTable);
        }
        else
        {
            var result =
            @Service.UpdateItemAsync(objItemTable);
        }

        itemsList =
        await @Service.GetItemByCategoryAsync(ItemTableService.Category);
    }

    async Task DeleteBillSplit(ItemTable itemTable, string category)
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteItemAsync(itemTable);
        itemsList =
        await @Service.GetItemByCategoryAsync(category);
    }

    //void OpenEmailSender()
    //{
    //    NavigationManager.NavigateTo("emailsender");
    //}

    //void OpenEmailSender(ItemTable itemTable, string name)
    //{
    //    BillSplitService.Re = name;
    //    objBillSplit = billSplit;
    //    NavigationManager.NavigateTo("emailsender");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ItemTableService ItemTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ItemsPage> logger { get; set; }
    }
}
#pragma warning restore 1591
