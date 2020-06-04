#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Ribbons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4251176fcc9eb5ac003847cdb86b238fccc71d59"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesktopApp.Pages.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using WebWindows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Ribbons.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UI/ribbons")]
    public partial class Ribbons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Ribbons</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Ribbons</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n    <div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-12\">\n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">Ribbons</h3>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper\">\n                    <div class=\"ribbon bg-primary\">\n                        Ribbon\n                    </div>\n                    </div>\n                    Ribbon Default <br>\n                    <small>.ribbon-wrapper.ribbon-lg .ribbon</small>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper ribbon-lg\">\n                    <div class=\"ribbon bg-info\">\n                        Ribbon Large\n                    </div>\n                    </div>\n                    Ribbon Large <br>\n                    <small>.ribbon-wrapper.ribbon-lg .ribbon</small>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper ribbon-xl\">\n                    <div class=\"ribbon bg-secondary\">\n                        Ribbon Extra Large\n                    </div>\n                    </div>\n                    Ribbon Extra Large <br>\n                    <small>.ribbon-wrapper.ribbon-xl .ribbon</small>\n                </div>\n                </div>\n            </div>\n            <div class=\"row mt-4\">\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper ribbon-lg\">\n                    <div class=\"ribbon bg-success text-lg\">\n                        Ribbon\n                    </div>\n                    </div>\n                    Ribbon Large <br> with Large Text <br>\n                    <small>.ribbon-wrapper.ribbon-lg .ribbon.text-lg</small>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper ribbon-xl\">\n                    <div class=\"ribbon bg-warning text-lg\">\n                        Ribbon\n                    </div>\n                    </div>\n                    Ribbon Extra Large <br> with Large Text <br>\n                    <small>.ribbon-wrapper.ribbon-xl .ribbon.text-lg</small>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative p-3 bg-gray\" style=\"height: 180px\">\n                    <div class=\"ribbon-wrapper ribbon-xl\">\n                    <div class=\"ribbon bg-danger text-xl\">\n                        Ribbon\n                    </div>\n                    </div>\n                    Ribbon Extra Large <br> with Extra Large Text <br>\n                    <small>.ribbon-wrapper.ribbon-xl .ribbon.text-xl</small>\n                </div>\n                </div>\n            </div>\n            <div class=\"row mt-4\">\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative\">\n                    <img src=\"../../images/adminlte/photo1.png\" alt=\"Photo 1\" class=\"img-fluid\">\n                    <div class=\"ribbon-wrapper ribbon-lg\">\n                    <div class=\"ribbon bg-success text-lg\">\n                        Ribbon\n                    </div>\n                    </div>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative\">\n                    <img src=\"../../images/adminlte/photo2.png\" alt=\"Photo 2\" class=\"img-fluid\">\n                    <div class=\"ribbon-wrapper ribbon-xl\">\n                    <div class=\"ribbon bg-warning text-lg\">\n                        Ribbon\n                    </div>\n                    </div>\n                </div>\n                </div>\n                <div class=\"col-sm-4\">\n                <div class=\"position-relative\" style=\"min-height: 180px;\">\n                    <img src=\"../../images/adminlte/photo3.jpg\" alt=\"Photo 3\" class=\"img-fluid\">\n                    <div class=\"ribbon-wrapper ribbon-xl\">\n                    <div class=\"ribbon bg-danger text-xl\">\n                        Ribbon\n                    </div>\n                    </div>\n                </div>\n                </div>\n            </div>\n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n    </div>\n    \n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Ribbons.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        await JSRuntime.InvokeVoidAsync("loadRibbons");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await LoadJavaScript();
            await base.OnAfterRenderAsync(firstRender);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591