#pragma checksum "D:\Development\Source\github\Blazor-ChildForms\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f77e0db47363e5ab7316abe0c5326cbda18435"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_ChildForms.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Blazor_ChildForms;

#line default
#line hidden
#line 8 "D:\Development\Source\github\Blazor-ChildForms\_Imports.razor"
using Blazor_ChildForms.Shared;

#line default
#line hidden
#line 2 "D:\Development\Source\github\Blazor-ChildForms\Pages\FetchData.razor"
using Blazor_ChildForms.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "D:\Development\Source\github\Blazor-ChildForms\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
