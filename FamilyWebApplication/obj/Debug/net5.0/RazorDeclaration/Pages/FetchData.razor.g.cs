// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\FetchData.razor"
using FamilyWebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\FetchData.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\FetchData.razor"
 
    readonly IList<Family> Families = AdultDataList.ReadFamiliesData<Family>();
    IList<Family> toShowFamilies = AdultDataList.ReadFamiliesData<Family>();


    private string? filterByFN = "";

    private void FilterBySN(ChangeEventArgs changeEventArgs)
    {
        filterByFN = changeEventArgs.Value.ToString();
        if (filterByFN != null)
        {
            toShowFamilies = Families.Where(a => a.StreetName == filterByFN).ToList();
        }
        else
        {
            toShowFamilies = Families;
        }
    }

    private void GoToAdultPage2()
    {
        Navgr.NavigateTo("/Counter");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Adult Adult { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdultDataList _dataList { get; set; }
    }
}
#pragma warning restore 1591
