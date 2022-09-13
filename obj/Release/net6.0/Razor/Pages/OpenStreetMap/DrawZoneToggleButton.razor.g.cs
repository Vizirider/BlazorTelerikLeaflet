#pragma checksum "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de107d511bc3490b13a2a2a360da1088b18e59dd"
// <auto-generated/>
#pragma warning disable 1591
namespace GridTest.Pages.OpenStreetMap
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using GridTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using GridTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\vizira\GridTest\GridTest\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
using BlazorLeaflet.Samples.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class DrawZoneToggleButton : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(0);
            __builder.AddAttribute(1, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
                                                      ToggleClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line (7,71)-(7,81) 25 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
__builder2.AddContent(4, ButtonText);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
 if(drawStarted)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>You should draw to first point <kbd>finally</kbd></p>");
#nullable restore
#line 11 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(6);
            __builder.AddAttribute(7, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
                                                      ShowOnNewTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "Export Draw");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\DrawZoneToggleButton.razor"
       
    [Parameter] public string ButtonText { get; set; }
    [Parameter] public DrawHandler DrawHandler { get; set; }
    [Parameter] public EventCallback<bool> OnToggleCallback { get; set; }
    public bool drawStarted = false;
    public bool drawFinished = false;
    public string urlstring = "https://api.openstreetmap.org/api/0.6/map?bbox=";
    public string downloadString = "";
    public string info = "";

    protected override void OnInitialized()
    {
        DrawHandler.DrawFinished += OnDrawFinished;
        base.OnInitialized();
    }

    async Task ToggleClicked()
    {
        drawStarted = true;
        await OnToggleCallback.InvokeAsync(true);
    }

    void OnDrawFinished(object sender, EventArgs e)
    {
        StateHasChanged();
        drawFinished = true;
        downloadString = urlstring + DrawHandler._minMaxLonLat[0].ToString().Replace(',', '.') + ","
                        + DrawHandler._minMaxLonLat[1].ToString().Replace(',', '.') + ","
                        + DrawHandler._minMaxLonLat[2].ToString().Replace(',', '.') + ","
                        + DrawHandler._minMaxLonLat[3].ToString().Replace(',', '.');
        Debug.WriteLine(downloadString);

    }

    public void Dispose()
    {
        DrawHandler.DrawFinished -= OnDrawFinished;
        drawFinished = false;
    }

    private void ShowOnNewTab()
    {
        if (drawFinished)
        {
            Debug.WriteLine(downloadString);
            _jsRuntime.InvokeVoidAsync("OpenNewTab", downloadString);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591