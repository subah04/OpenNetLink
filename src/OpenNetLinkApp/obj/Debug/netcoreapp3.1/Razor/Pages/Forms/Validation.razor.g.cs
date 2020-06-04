#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Forms/Validation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ecf5ab9c356a472bc309021332742213466ef9"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using OpenNetLinkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using OpenNetLinkApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using WebWindows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Forms/Validation.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Forms/validation")]
    public partial class Validation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Validation</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Validation</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n    <div class=\"container-fluid\">\n    <div class=\"row\">\n        \n        <div class=\"col-md-12\">\n        \n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">Quick Example <small>jQuery Validation</small></h3>\n            </div>\n            \n            \n            <form role=\"form\" id=\"quickForm\">\n            <div class=\"card-body\">\n                <div class=\"form-group\">\n                <label for=\"exampleInputEmail1\">Email address</label>\n                <input type=\"email\" name=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" placeholder=\"Enter email\">\n                </div>\n                <div class=\"form-group\">\n                <label for=\"exampleInputPassword1\">Password</label>\n                <input type=\"password\" name=\"password\" class=\"form-control\" id=\"exampleInputPassword1\" placeholder=\"Password\">\n                </div>\n                <div class=\"form-group mb-0\">\n                <div class=\"custom-control custom-checkbox\">\n                    <input type=\"checkbox\" name=\"terms\" class=\"custom-control-input\" id=\"exampleCheck1\">\n                    <label class=\"custom-control-label\" for=\"exampleCheck1\">I agree to the <a href=\"#\">terms of service</a>.</label>\n                </div>\n                </div>\n            </div>\n            \n            <div class=\"card-footer\">\n                <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n            </div>\n            </form>\n        </div>\n        \n        </div>\n        \n        \n        <div class=\"col-md-6\">\n\n        </div>\n        \n    </div>\n    \n    </div>\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Forms/Validation.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        await JSRuntime.InvokeVoidAsync("loadFormsValidation");
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