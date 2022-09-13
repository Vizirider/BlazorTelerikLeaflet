using BlazorLeaflet.Models;
using BlazorLeaflet.Models.Events;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Rectangle = BlazorLeaflet.Models.Rectangle;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Security.Policy;
using System.Data.SqlTypes;
using BlazorLeaflet;

namespace GridTest;

public class DrawHandler : IDisposable
{
    enum DrawState
    {
        None,
        DrawingPolygon
    }

    readonly Map _map;
    readonly IJSRuntime _jsRuntime;
    readonly Polygon _polygon = new();
    readonly List<MouseEvent> _mouseClickEvents = new();
    DrawState _drawState;
    public static double[] _minMaxLonLat = new double[] { 0,0,0,0};
    public static bool complete { get; set; }

    public string urlstring = "https://api.openstreetmap.org/api/0.6/map?bbox=";
    public event EventHandler DrawFinished;

    public DrawHandler(Map map, IJSRuntime jsRuntime)
    {
        _map = map;
        _jsRuntime = jsRuntime;

        _polygon.StrokeColor = Color.Black;
        _polygon.StrokeWidth = 1;
        _polygon.Fill = true;
        _polygon.FillColor = Color.Red;

    }

    public void OnDrawPolygonToggle(bool isToggled)
    {
        //_map.RemoveLayer(_polygon);
        _polygon.Shape = null;
        _drawState = DrawState.DrawingPolygon;
        OnDrawToggle(isToggled);
    }

    void OnDrawToggle(bool isToggled)
    {
        _mouseClickEvents.Clear();
        if (isToggled)
        {
            _map.OnClick += OnMapClick;
            _map.OnMouseMove += OnMouseMove;
        }
        else
        {
            UnsubscribeFromMapEvents();
        }
    }

    public void OnMapClick(object sender, MouseEvent e)
    {
        complete = false;
        if (_drawState != DrawState.DrawingPolygon)
        {
            AddClickAndUpdateShape(e);
            if (_mouseClickEvents.Count == 2)
            {
                // untoggle button
                DrawComplete();
            }
        }
        else
        {
            // finish a line
            if (_polygon.Shape?[0].Count() > 2 &&
                Math.Abs(_mouseClickEvents[0].ContainerPoint.X - e.ContainerPoint.X) < 10 &&
                Math.Abs(_mouseClickEvents[0].ContainerPoint.Y - e.ContainerPoint.Y) < 10)
            {
                // update the polygon without the last point (mouse move point)
                // and we're finished
                UpdatePolygon(null);
                DrawComplete();
                complete = true;
            }
            else
            {
                AddClickAndUpdateShape(e);
            }
        }
    }

    void OnMouseMove(object sender, MouseEvent e)
    {
        if (_mouseClickEvents.Any())
        {
            UpdateShape(e.LatLng);
        }
    }

    void AddClickAndUpdateShape(MouseEvent e)
    {
        _mouseClickEvents.Add(e);
        UpdateShape(e.LatLng);
    }

    void UpdateShape(LatLng latLng)
    {
        switch (_drawState)
        {
            case DrawState.DrawingPolygon:
                UpdatePolygon(latLng);
                break;
        }
    }

    void UpdatePolygon(LatLng latLng)
    {
        var size = _mouseClickEvents.Count;
        var shape = new PointF[1][];
        shape[0] = new PointF[latLng == null ? size : size + 1];
        for (int i = 0; i < size; i++)
        {
            if(i == 0)
            {
                _minMaxLonLat[0] = _mouseClickEvents[i].LatLng.Lat;
                _minMaxLonLat[1] = _mouseClickEvents[i].LatLng.Lng;
            }
            shape[0][i] = _mouseClickEvents[i].LatLng.ToPointF();
            if(_mouseClickEvents[i].LatLng.Lat < _minMaxLonLat[0])
            {
                _minMaxLonLat[0] = _mouseClickEvents[i].LatLng.Lat;
            }
            if (_mouseClickEvents[i].LatLng.Lat > _minMaxLonLat[2])
            {
                _minMaxLonLat[2] = _mouseClickEvents[i].LatLng.Lat;
            }
            if (_mouseClickEvents[i].LatLng.Lng < _minMaxLonLat[1])
            {
                _minMaxLonLat[1] = _mouseClickEvents[i].LatLng.Lng;
            }
            if (_mouseClickEvents[i].LatLng.Lng > _minMaxLonLat[3])
            {
                _minMaxLonLat[3] = _mouseClickEvents[i].LatLng.Lng;
            }

        }
        if (latLng != null)
        {
            shape[0][size] = latLng.ToPointF();
        }
        _polygon.Shape = shape;
        AddOrUpdateShape(_polygon);
    }

    void AddOrUpdateShape(Layer shape)
    {
        if (_map.GetLayers().Contains(shape))
        {
            LeafletInterops.UpdateShape(_jsRuntime, _map.Id, shape);
        }
        else
        {
            _map.AddLayer(shape);
        }
    }

    void DrawComplete()
    {
        UnsubscribeFromMapEvents();
        _drawState = DrawState.None;
        DrawFinished?.Invoke(this, null);
    }

    void UnsubscribeFromMapEvents()
    {
        _map.OnClick -= OnMapClick;
        _map.OnMouseMove -= OnMouseMove;
    }

    public void Dispose() => UnsubscribeFromMapEvents();
}
