#pragma checksum "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b731ee7a0f50d83f8caea67c4cbfac3288718deb"
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
#line 2 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using BlazorServerAppDB.Data.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sportpage")]
    public partial class SportPage : OwningComponentBase<ItemTableService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "D:\all of this\code this code\blazor_asp\BlazorServerApp\Pages\SportPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    bool ShowPopup = false;
    bool ShowFolderPopup = false;
    int progress;
    string info;
    string CurrentDirectory = "";
    string CurrentRoot = "";
    string NewFolderName = "";
    FileObject SelectedFile = new FileObject();
    List<string> Directories = new List<string>();
    List<FileObject> Files = new List<FileObject>();
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
    //private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<ItemTable> itemsList;


    int categoryId = 1;
    string category = "Спорт";

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

            objNewItemTable.Category = category;

            objNewItemTable.UserName = user.Identity.Name;

            objNewItemTable.ItemName = objItemTable.ItemName;

            objNewItemTable.Description = objItemTable.Description;

            objNewItemTable.ImageUrl = objItemTable.ImageUrl;

            objNewItemTable.CategoryId = categoryId;

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

    async Task DeleteItemTable(ItemTable itemTable, string category)
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteItemAsync(itemTable);
        itemsList =
        await @Service.GetItemByCategoryAsync(category);
    }

    protected override void OnInitialized()
    {
        CurrentRoot =
            Path.Combine(HostEnvironment.WebRootPath, "uploads");
        CurrentDirectory = CurrentRoot;
        Directories.Add(CurrentDirectory);
        LoadFiles();
    }

    void SelectImage(FileObject file)
    {
        if (SelectedFile.FileName == file.FileName)
        {
            SelectedFile = new FileObject();
        }
        else
        {
            SelectedFile = file;
        }
    }

    void LogChange(TreeEventArgs args)
    {
        CurrentDirectory = args.Value as string;
        LoadFiles();
    }

    string GetTextForNode(object data)
    {
        return Path.GetFileName((string)data);
    }

    RenderFragment<RadzenTreeItem>
        FileOrFolderTemplate = (context) => builder =>
        {
            string path = context.Value as string;
            bool isDirectory = Directory.Exists(path);
            builder.OpenComponent<RadzenIcon>(0);
            builder.AddAttribute(1,
                    "Icon", isDirectory ? "folder" :
                    "insert_drive_file");
            if (!isDirectory)
            {
                builder.AddAttribute(2,
                        "Style",
                        "margin-left: 24px");
            }
            builder.CloseComponent();
            builder.AddContent(3, context.Text);
        };
    void LoadDirectory(TreeExpandEventArgs args)
    {
        CurrentDirectory = args.Value as string;
        // Only get the folders not the files
        args.Children.Data =
            Directory.EnumerateFileSystemEntries(CurrentDirectory)
            .Where(x => !x.Contains("."));
        args.Children.Text = GetTextForNode;
        args.Children.HasChildren =
            (path) => Directory.Exists((string)path);
        args.Children.Template = FileOrFolderTemplate;
    }
    void LoadFiles()
    {
        Files = new List<FileObject>();
        var FileNames =
            Directory.EnumerateFileSystemEntries(CurrentDirectory)
            .Where(x => x.Contains("."));
        foreach (var item in FileNames)
        {
            Files.Add(new FileObject()
            {
                FileName =
                Path.GetFileName(item),
                FilePath =
                item.Replace(HostEnvironment.WebRootPath, "")
            });
        }
        // Reset selected file
        SelectedFile = new FileObject();
        // Update UI
        StateHasChanged();
    }

    async void OnProgress(UploadProgressArgs args)
    {
        ShowPopup = true;
        this.info = $"{args.Loaded} of {args.Total} bytes.";
        this.progress = args.Progress;
        StateHasChanged();
        if (args.Loaded == args.Total)
        {
            // Delay to give files time to be saved
            // before reloading file view
            await LoadFilesAsync();
        }
    }
    public async Task LoadFilesAsync()
    {
        int Time = 1;
        while (Time > 0)
        {
            Time--;
            StateHasChanged();
            await Task.Delay(1000);
        }
        ShowPopup = false;
        LoadFiles();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ItemTableService ItemTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ItemsPage> logger { get; set; }
    }
}
#pragma warning restore 1591