#pragma checksum "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a719f6b3376b03ce2ee2cdb1196c18b15a48481"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyWebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome!</h1>\n\n");
            __builder.AddMarkupContent(1, "<p> On this webpage, you can: </p>\n\n");
            __builder.AddMarkupContent(2, "<p>1. View family data</p>\n\n");
            __builder.AddMarkupContent(3, "<p>and</p>\n\n");
            __builder.AddMarkupContent(4, "<p>2. Manage families (registered users only).</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
