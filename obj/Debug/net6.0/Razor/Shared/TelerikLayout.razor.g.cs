#pragma checksum "C:\Users\vizira\GridTest\GridTest\Shared\TelerikLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bc5c3452353f42f7b015736edcecc1bf142d63e"
// <auto-generated/>
#pragma warning disable 1591
namespace GridTest.Shared
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
    public partial class TelerikLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikRootComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line (4,6)-(4,10) 25 "C:\Users\vizira\GridTest\GridTest\Shared\TelerikLayout.razor"
__builder2.AddContent(2, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
