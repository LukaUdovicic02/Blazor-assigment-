#pragma checksum "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c2829afa838fc23b5e07d7431e04e7911c10bc"
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
#line 1 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
using FamilyWebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>");
#nullable restore
#line 10 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
 if (showAutheticationError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
            __builder.AddAttribute(3, "role", "alert");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 13 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
            authenticationErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                                        ExecuteLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    \r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group row");
                __builder2.AddMarkupContent(16, "<label for=\"username\" class=\"col-md-2 col-form-label\">Username:</label>\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-10");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "id", "username");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                                                                               user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Username = __value, user.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.FamilyWebApplication.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 25 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                                      () => user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    \r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "<label for=\"password\" class=\"col-md-2 col-form-label\">Password:</label>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-10");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "id", "password");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                                                                               user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.FamilyWebApplication.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 33 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
                                      () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    \r\n    ");
                __builder2.AddMarkupContent(44, "<div class=\"row\"><div class=\"col-md-12 text-right\"><button type=\"submit\" class=\"btn btn-success\">Login</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\3RD SEMESTER\DNP1Assigment2\FamilyWebApplication\Pages\Login.razor"
       
    User user = new User();
    bool showAutheticationError = false;
    string authenticationErrorText = "";

    void ExecuteLogin()
    {
        showAutheticationError = false;
    
        User result = DataList.Login(user);

        if (result is not null)
        {
            NavManager.NavigateTo("/counter");
        }
        else
        {
            authenticationErrorText = "There was an error trying to log in.";
            showAutheticationError = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdultDataList DataList { get; set; }
    }
}
namespace __Blazor.FamilyWebApplication.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
