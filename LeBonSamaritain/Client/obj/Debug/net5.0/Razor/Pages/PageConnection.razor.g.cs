#pragma checksum "D:\LeBonSamaritainProduction\LeBonSamaritain\Client\Pages\PageConnection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f11567cc387c0118127bbafcb6eeef45c045f6d"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PageConnection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Page de connection</title>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    body {
        background-image: url(https://media.istockphoto.com/photos/modern-classroom-interior-design-3d-render-picture-id1056658924?k=6&m=1056658924&s=170667a&w=0&h=JtTOJVmVSz9lcFWbsbK24pnUUtQktCl0qFffq_p0HqA=);
        background-repeat: no-repeat;
        background-size: cover;
    }
</style>

");
            __builder.AddMarkupContent(2, @"<body><h1 class=""TitleConnection text-white mt-4"">Le Bon Samaritain</h1>
    <form action=""/PageHome"" method=""get"" target=""_blank""><div id=""mainBoxConnexion"" class><h2 class=""TitleConnection text-white mb-2"">Connexion</h2>
            <hr>
            <div class=""text-center""><input type=""text"" class name=""inputId"" id=""inputId"" required autocomplete=""off"" placeholder=""Identifiant"">
                <input type=""password"" class name=""inputPassword"" id=""inputPassword"" required autocomplete=""off"" placeholder=""Mot de passe"">
                <button name=""btnConnexion"" class=""btn btn-success"" id=""btnConnexion"" type=""submit"">Connexion</button></div></div></form></body>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591