#pragma checksum "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c912349b09492e0b37866cb62a28cf2b07e1d3db"
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
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\"><div class=\'row my-4\'><legend>Hungary with bubble (population) and marker </legend></div></div>");
#nullable restore
#line 14 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
 if (MapMode.Any())
{

#line default
#line hidden
#nullable disable
            __Blazor.GridTest.Pages.OpenStreetMap.OpenStreetMap.TypeInference.CreateTelerikDropDownList_0(__builder, 1, 2, 
#nullable restore
#line 16 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                MapMode

#line default
#line hidden
#nullable disable
            , 3, "ModeName", 4, "ModeId", 5, "Select Mode", 6, "100%", 7, 
#nullable restore
#line 17 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                   Value

#line default
#line hidden
#nullable disable
            , 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Value = __value, Value)), 9, () => Value, 10, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.DropDownListPopupSettings>(11);
                __builder2.AddAttribute(12, "Height", "auto");
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikMap>(14);
            __builder.AddAttribute(15, "Center", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double[]>(
#nullable restore
#line 26 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                         Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "MinZoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#nullable restore
#line 27 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                     3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "MaxZoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#nullable restore
#line 28 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                     11

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Zoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#nullable restore
#line 29 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                  7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "WrapAround", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 30 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.MapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.MapClickEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                      OnMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "OnShapeClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.MapShapeClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.MapShapeClickEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                           OnShapeClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "OnMarkerClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.MapMarkerClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.MapMarkerClickEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                            OnMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.MapLayers>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.MapLayer>(26);
                    __builder3.AddAttribute(27, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.MapLayersType?>(
#nullable restore
#line 35 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                             MapLayersType.Tile

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Attribution", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                Attribution

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Subdomains", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 37 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                               Subdomains

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "UrlTemplate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                UrlTemplate

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 40 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
             if (Value == 1)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Telerik.Blazor.Components.MapLayer>(31);
                    __builder3.AddAttribute(32, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.MapLayersType?>(
#nullable restore
#line 42 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                 MapLayersType.Bubble

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                         BubbleData1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "LocationField", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                  nameof(BubbleModel.LatLng)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ValueField", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                               nameof(BubbleModel.Population_2010)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.MapLayerBubbleSettings>(37);
                        __builder4.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Telerik.Blazor.Components.MapLayerBubbleSettingsStyle>(39);
                            __builder5.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Telerik.Blazor.Components.MapLayerBubbleSettingsStyleFill>(41);
                                __builder6.AddAttribute(42, "Color", "#0000ff");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(43, "\r\n                            ");
                                __builder6.OpenComponent<Telerik.Blazor.Components.MapLayerBubbleSettingsStyleStroke>(44);
                                __builder6.AddAttribute(45, "Color", "#000000");
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 53 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Telerik.Blazor.Components.MapLayer>(46);
                    __builder3.AddAttribute(47, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.MapLayersType?>(
#nullable restore
#line 56 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                 MapLayersType.Marker

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 57 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                         MarkerData1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "LocationField", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                  nameof(MarkerModel.LatLng)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "TitleField", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                               nameof(MarkerModel.Address)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 61 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 64 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
}
else
{
    if (IsLoading)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "<div class=\"text-center\"><img src=\"/images/loading.gif\"></div>");
#nullable restore
#line 72 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<p>No records found</p>");
#nullable restore
#line 76 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "DemoConsole");
            __builder.AddAttribute(54, "EventLog", 
#nullable restore
#line 80 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                        EventLog

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "OnClearLogClick", 
#nullable restore
#line 80 "C:\Users\vizira\GridTest\GridTest\Pages\OpenStreetMap\OpenStreetMap.razor"
                                                    OnClearLogClick

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
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
namespace __Blazor.GridTest.Pages.OpenStreetMap.OpenStreetMap
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikDropDownList_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikDropDownList<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextField", __arg1);
        __builder.AddAttribute(__seq2, "ValueField", __arg2);
        __builder.AddAttribute(__seq3, "DefaultText", __arg3);
        __builder.AddAttribute(__seq4, "Width", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.AddAttribute(__seq8, "DropDownListSettings", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
