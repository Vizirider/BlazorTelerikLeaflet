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
#line 4 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/map")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/map/events")]
    public partial class OpenStreetMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
       
    private IEnumerable<DropdownDTO> MapMode { get; set; } = new List<DropdownDTO>();
    private IEnumerable<MarkerDTO> MarkerDatas { get; set; } = new List<MarkerDTO>();
    public List<MarkerModel> MarkerData1 { get; set; } = new List<MarkerModel>();
    public List<BubbleModel> BubbleData1 { get; set; } = new List<BubbleModel>();
    public bool IsLoading { get; set; }
    public string EventLog { get; set; } = string.Empty;

    public string[] Subdomains { get; set; } = new string[] { "a", "b", "c" };
    public string UrlTemplate { get; set; } = "https://#= subdomain #.tile.openstreetmap.org/#= zoom #/#= x #/#= y #.png";
    public string Attribution { get; set; } = "&copy; <a href='https://osm.org/copyright'>OpenStreetMap contributors</a>";
    public double[] Center { get; set; } = new double[] { 47, 20 };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await LoadMarkers();
        }
    }

    private async Task LoadMarkers()
    {
        IsLoading = true;
        StateHasChanged();
        MapMode = await _dropdownRepository.GetAll();
        MarkerDatas = await _markerRepository.GetAll();

        foreach(var datas in MarkerDatas)
        {
            MarkerModel MarkerData = new()
                {
                    Address = datas.Address,
                    LatLng = new double[] { datas.Latitude, datas.Longitude }
                };
            BubbleModel BubbleData = new()
                {
                    City = datas.Address,
                    LatLng = new double[] { datas.Latitude, datas.Longitude },
                    Population_2010 = datas.Population
                };
            MarkerData1.Add(MarkerData);
            BubbleData1.Add(BubbleData);
        }

        IsLoading = false;
        StateHasChanged();
    }

    public int Value { get; set; }

    public void OnMapClick(MapClickEventArgs args)
    {
        var location = args.Location;
        var mouseEventArgs = args.EventArgs as MouseEventArgs;

        var log = string.Empty;
        log += "<div>";
        log += $"<div><strong>Map Click event</strong> at location <strong>[{location.Latitude}, {location.Longitude}]</strong>.</div>";
        log += $"<div>Mouse Position: {mouseEventArgs.ClientX}, {mouseEventArgs.ClientY}</div>";
        log += "</div>";

        LogToConsole(log);
    }

    public void OnMarkerClick(MapMarkerClickEventArgs args)
    {
        var dataItem = args.DataItem as MarkerModel;
        var mouseEventArgs = args.EventArgs as MouseEventArgs;

        var log = string.Empty;
        log += "<div>";
        log += $"<div><strong>Marker Click event</strong> on <strong>{dataItem.Address}</strong> ";
        log += $"at location <strong>[{string.Join(",", dataItem.LatLng)}]</strong>.</div>";
        log += $"<div>Mouse Position: {mouseEventArgs.ClientX}, {mouseEventArgs.ClientY}.</div>";
        log += "</div>";

        LogToConsole(log);
    }

    public void OnShapeClick(MapShapeClickEventArgs args)
    {
        var dataItem = args.DataItem as BubbleModel;
        var mouseEventArgs = args.EventArgs as MouseEventArgs;

        var log = string.Empty;
        log += "<div>";
        log += $"<div><strong>Shape Click event</strong> on <strong>{dataItem.City}</strong> ";
        log += $"at location <strong>[{string.Join(",", dataItem.LatLng)}]</strong>.</div>";
        log += $"<div>Mouse Position: {mouseEventArgs.ClientX}, {mouseEventArgs.ClientY}.</div>";
        log += "</div>";

        LogToConsole(log);
    }

    public void LogToConsole(string text)
    {
        EventLog = EventLog.Insert(0, text);
    }

    public void OnClearLogClick()
    {
        EventLog = string.Empty;
    }

    public class MarkerModel
    {
        public double[] LatLng { get; set; }
        public string Address { get; set; }
    }

    public class BubbleModel
    {
        public double[] LatLng { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Population_2010 { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMarkerRepository _markerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDropdownRepository _dropdownRepository { get; set; }
    }
}
#pragma warning restore 1591