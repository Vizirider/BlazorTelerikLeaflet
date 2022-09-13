#pragma checksum "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e88fe990ebc8422a15665b2fa419b09ffc0037e"
// <auto-generated/>
#pragma warning disable 1591
namespace GridTest.Pages.Category
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
#line 2 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
using GridTest.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/edit/{id:int}")]
    public partial class CategoryUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row my-2");
            __builder.OpenElement(2, "legend");
#nullable restore
#line (10,14)-(10,19) 24 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
__builder.AddContent(3, Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " Category");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-8");
#nullable restore
#line 13 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
         if (IsLoading)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<div class=\"text-center\"><img src=\"/images/loading.gif\"></div>");
#nullable restore
#line 18 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "EditForm");
            __builder.AddAttribute(10, "Model", "Category");
            __builder.AddAttribute(11, "OnValidSubmit", "UpsertCategory");
            __builder.OpenElement(12, "DataAnnotationsValidator");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label>Name</label>\r\n                    ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(17);
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
                                                 Category.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Name = __value, Category.Name))));
            __builder.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "ValidationMessage");
            __builder.AddAttribute(24, "For", "()=>Category.Name");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group py-3");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
#nullable restore
#line (30,54)-(30,59) 25 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
__builder.AddContent(30, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "href", "grid");
            __builder.AddAttribute(34, "class", "btn btn-secondary");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(36, "Back to Grid");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\vizira\GridTest\GridTest\Pages\Category\CategoryUpsert.razor"
       
    [Parameter]
    public int Id { get; set; }

    private CategoryDTO Category { get; set; } = new CategoryDTO();
    private string Title { get; set; } = "Create";
    public bool IsLoading { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            if (Id == 0)
            {
                IsLoading = false;
            }
            else
            {
                Title = "Update";
                await LoadCategory();
            }           
        }
    }

    private async Task LoadCategory()
    {
        IsLoading=true;
        StateHasChanged();
        Category = await _categoryRepository.GetById(Id);
        IsLoading = false;
        StateHasChanged();
    }

    private async Task UpsertCategory()
    {
        if (Category.Id == 0)
        {
            await _categoryRepository.Create(Category);
        }
        else
        {
            await _categoryRepository.Update(Category);
        }
       _navigationManager.NavigateTo("grid");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryRepository _categoryRepository { get; set; }
    }
}
#pragma warning restore 1591
