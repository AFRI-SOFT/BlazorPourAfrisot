#pragma checksum "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83949ba45ed2d41fa1ae695b308d5870e0e4e808"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using CRUDBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\_Imports.razor"
using CRUDBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
using CRUDBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addCustomer")]
    public partial class AddCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Customer</h2>\n<hr>\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                                               objCI.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Name = __value, objCI.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\n                <label asp-for=\"Gender\" class=\"control-label\"></label>\n                ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                objCI.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Gender = __value, objCI.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(27, "\n                    ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", true);
            __builder.AddContent(30, "-- Select Gender --");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Male");
            __builder.AddContent(34, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "Female");
            __builder.AddContent(38, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.AddMarkupContent(45, "<label for=\"Country\" class=\"control-label\">Country</label>\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "for", "Country");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                                                  objCI.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Country = __value, objCI.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddMarkupContent(55, "\n                ");
            __builder.AddMarkupContent(56, "<label for=\"City\" class=\"control-label\">City</label>\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "for", "City");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                                               objCI.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.City = __value, objCI.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.AddMarkupContent(68, "\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-md-4");
            __builder.AddMarkupContent(71, "\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.AddMarkupContent(74, "\n                ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-primary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                                                        CreateCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "class", "btn btn-primary");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\AddCustomer.razor"
       
    CustomerInfo objCI = new CustomerInfo();
    protected void CreateCustomer()
    {
        ObjCustomService.Create(objCI);
        NavigationManager.NavigateTo("Customer");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Customer");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591
