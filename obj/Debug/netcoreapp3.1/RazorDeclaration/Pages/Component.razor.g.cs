#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1990590aecf392d3cffcd45ad234be9b0d0a4a2d"
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
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/component")]
    public partial class Component : OwningComponentBase<MessageTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\Component.razor"
       

    protected override void OnInitialized()
    {
        ThemeTableService.OnClick += StateHasChanged;
    }

    [Parameter] public string Message { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }


    List<MessageTable> messages;
    //List<ThemeTable> themes;
    // string ThemeName;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        try
        {
            // We access ThemeTableService using @Service
            messages = await @Service.GetMessagesAsync(ThemeTableService.Number);
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
        ShowPopup = false;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Component> logger { get; set; }
    }
}
#pragma warning restore 1591
