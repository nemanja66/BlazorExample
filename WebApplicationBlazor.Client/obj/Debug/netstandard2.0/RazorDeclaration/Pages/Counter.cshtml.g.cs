#pragma checksum "C:\Users\CD_PC-110\source\repos\WebApplicationBlazor\WebApplicationBlazor.Client\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c8fb6de8e648147bed81b7704c9e6125f5a927e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplicationBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using WebApplicationBlazor.Client;
    using WebApplicationBlazor.Client.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "C:\Users\CD_PC-110\source\repos\WebApplicationBlazor\WebApplicationBlazor.Client\Pages\Counter.cshtml"
            
    int currentCount = 0;

    [Parameter] int IncrementAmount { get; set; } = 1;

    void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
