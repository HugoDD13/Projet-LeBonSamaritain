#pragma checksum "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e2ee2ee1976f9d4cca12e8b8024e72a3af169e"
// <auto-generated/>
#pragma warning disable 1591
namespace LeBonSamaritain.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using LeBonSamaritain.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\_Imports.razor"
using LeBonSamaritain.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
using LeBonSamaritain.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PageAdSale")]
    public partial class PageAdSale : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    body {
        background-image: url(https://media.istockphoto.com/photos/modern-classroom-interior-design-3d-render-picture-id1056658924?k=6&m=1056658924&s=170667a&w=0&h=JtTOJVmVSz9lcFWbsbK24pnUUtQktCl0qFffq_p0HqA=);
        background-repeat: no-repeat;
        background-size: cover;
        background-attachment: fixed;
    }
</style>

");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "<div class=\"TextHome\"><h2>Le Bon Samaritain le site de don, de vente, et de pr??t entre ??tablissements d\'enseignement priv??s</h2></div>\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""SecondaryNavbar""><nav class=""navbar navbar-expand-sm navbar-dark bg-dark""><div class=""container-fluid""><div class=""navbar-nav mr-auto""><a class=""nav-link"" href=""/PageHome"">Derni??res annonces</a>
                    <a class=""nav-link"" href=""/PageAdSale"">Ventes</a>
                    <a class=""nav-link"" href=""/PageAdGift"">Dons</a>
                    <a class=""nav-link"" href=""/PageAdLoad"">Pr??ts</a>
                    <a class=""nav-link disabled"">Personnels</a></div>

                <form class=""d-flex""><input class=""form-control me-2"" type=""search"" placeholder=""Ex : Table"" aria-label=""Recherche"">
                    <button class=""btn btn-outline-success"" type=""submit"">Recherche</button></form></div></nav></div>


    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "LastAdBlock");
            __builder.AddMarkupContent(6, "<h2>Ventes</h2>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex justify-content-around text-center mt-4");
#nullable restore
#line 46 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
             foreach (Ad ad in adAllAdSale)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "p-2 bd-highlight");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/PageAdChaise");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 51 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
                                   ad.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "width", "250");
            __builder.AddAttribute(16, "height", "250");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h4");
            __builder.AddContent(19, 
#nullable restore
#line 53 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
                         ad.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageAdSale.razor"
       

    private List<Ad> adAllAdSale = new List<Ad>();

    protected override async Task OnInitializedAsync()
    {
        adAllAdSale = await Http.GetFromJsonAsync<List<Ad>>("https://localhost:44351/api/Ad/AllAdSale");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
