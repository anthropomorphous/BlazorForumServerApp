#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64b1de37bb05eb67a02e2fd73620dd28dfbc4eb"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemPage.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemPage.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/itempage")]
    public partial class ItemPage : OwningComponentBase<MessageTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\ItemPage.razor"
       

    protected override void OnInitialized()
    {
        ItemTableService.OnClick += StateHasChanged;
    }

    [Parameter] public string Message { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }


    List<MessageTable> messages;
    int itemId = 0;
    string description = "";
    string category = "";


    protected override async Task OnInitializedAsync()
    {

        var user = (await authenticationStateTask).User;
        try
        {
            messages = await @Service.GetMessagesByItemAsync(ItemTableService.Number);
            MessageTable thisMessage = messages.First();
            itemId = thisMessage.ItemId;
       
        }
        catch (Exception e)
        {
            logger.LogError(e, e.Message);
        }
    }

    MessageTable objMessageTable = new MessageTable();
    ThemeTable objThemeTable = new ThemeTable();
    bool ShowPopup = false;
    void ClosePopup()
    {
        ShowPopup = false;
    }
    void AddNewMessage()
    {
        objMessageTable = new MessageTable();
        objMessageTable.Id = 0;
        ShowPopup = true;
    }

    async Task SaveMessage()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        if (objMessageTable.Id == 0)
        {
            // Create new message
            MessageTable objNewMessageTable = new MessageTable();
            objNewMessageTable.Date = System.DateTime.Now;
            objNewMessageTable.ItemId = ItemTableService.Number;
            objNewMessageTable.Text = objMessageTable.Text;
            objNewMessageTable.UserName = user.Identity.Name;
            objNewMessageTable.ItemId = ItemTableService.Number;


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
        await @Service.GetMessagesByItemAsync(ItemTableService.Number);

    }

    void EditMessage(MessageTable messageTable)
    {
        objMessageTable = messageTable;
        ShowPopup = true;
    }

    async Task DeleteMessage()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteMessageAsync(objMessageTable);
        messages =
        await @Service.GetMessageAsync(user.Identity.Name);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.MessageTableService MessageTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ItemTableService ItemTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ItemPage> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
