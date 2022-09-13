// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using BlazorLeaflet.Samples.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shapes")]
    public partial class Shapes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\Shapes.razor"
 
    enum DrawState
    {
        None,
        DrawingRectangle,
        DrawingCircle,
        DrawingPolygon
    }
    private Map _map;
    [Parameter] public DrawHandler _drawHandler { get; set; }
    private LatLng _markerLatLng = new LatLng { Lat = 47.5574007f, Lng = 16.3918687f };
    readonly IJSRuntime _jsRuntime;
    readonly Polygon _polygon = new Polygon();
    readonly List<MouseEvent> _mouseClickEvents = new List<MouseEvent>();
    DrawState _drawState;

    public event EventHandler DrawFinished;

    protected override void OnInitialized()
    {
        _polygon.StrokeColor = Color.Black;
        _polygon.StrokeWidth = 1;
        _polygon.Fill = true;
        _polygon.FillColor = Color.Red;

        _map = new Map(jsRuntime)
        {
            Center = _markerLatLng,
            Zoom = 4.8f
        };

        _map.OnInitialized += () =>
        {
            _map.AddLayer(new TileLayer
            {
                UrlTemplate = "https://a.tile.openstreetmap.org/{z}/{x}/{y}.png",
                Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors",
            });
        };

        _drawHandler = new DrawHandler(_map, jsRuntime);

    }

    private void OnDrag(BlazorLeaflet.Models.Marker marker, DragEvent evt)
    {
        _markerLatLng = evt.LatLng;
        StateHasChanged();
    }

    private async void OnDragEnd(BlazorLeaflet.Models.Marker marker, Event e)
    {
        marker.Position = _markerLatLng;
        marker.Popup.Content = string.Format("I am now at {0:0.00}° lat, {1:0.00}° lng", _markerLatLng.Lat, _markerLatLng.Lng);
        await LeafletInterops.UpdatePopupContent(jsRuntime, _map.Id, marker);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591