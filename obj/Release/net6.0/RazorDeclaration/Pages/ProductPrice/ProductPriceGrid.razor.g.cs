// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GridTest.Pages.ProductPrice
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
#line 3 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
using GridTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
using GridTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
using GridTest.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grid")]
    public partial class ProductPriceGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\vizira\GridTest\GridTest\Pages\ProductPrice\ProductPriceGrid.razor"
       
    private IEnumerable<ProductDTO> Products { get; set; } = new List<ProductDTO>();
    private IEnumerable<ProductPriceDTO> ProductPrices { get; set; } = new List<ProductPriceDTO>();
    public List<ProductPriceDTO> ProductPriceDetailsData { get; set; } = new List<ProductPriceDTO>();
    public bool IsLoading { get; set; }
    public bool isRowClicked { get; set; }
    public string EventLog { get; set; } = "";
    public TelerikAnimationContainer AnimationContainer { get; set; }
    public IEnumerable<object> ExpandedItems { get; set; } 

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            LoadProducts();
        }
    }

    private async Task LoadProducts()
    {
        IsLoading = true;
        StateHasChanged();
        Products = await _productRepository.GetAll();
        ProductPrices = await _productPricerepository.GetAll();
        ExpandedItems = Products;        
        IsLoading = false;
        StateHasChanged();
    }

    async Task OnRowProductClickHandler(GridRowClickEventArgs args)
    {
        args.ShouldRender = true;
        ProductDTO item = args.Item as ProductDTO;
        var id = item.CategoryId;
        _navigationManager.NavigateTo("/category/edit/" + id);
    }

    void OnRowPriceClickHandler(GridRowClickEventArgs args)
    {
        isRowClicked = true;
        var item = args.Item as ProductPriceDTO;

        ProductPriceDetailsData = ProductPrices.Where(x => x.Id == item.Id).ToList();

        string log = $"<div><strong>Row Double Click event fired - Item: {item.Price}</strong>.</div>";
        EventLog = EventLog.Insert(0, log);
    }

    public async void Show(MouseEventArgs args)
    {
        await AnimationContainer.ShowAsync();

        await Task.Delay(6000);

        await AnimationContainer.HideAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductPriceRepository _productPricerepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductRepository _productRepository { get; set; }
    }
}
#pragma warning restore 1591
