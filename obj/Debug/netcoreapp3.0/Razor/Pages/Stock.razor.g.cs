#pragma checksum "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33549e7449094ac52e605fef09194b1063d1b39c"
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
#line 2 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
using CRUDBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Stock")]
    public partial class Stock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddCustomer");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add New\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.AddMarkupContent(6, "<h1>Customer Data</h1>\n");
#nullable restore
#line 10 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
 if (objCtmr == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 13 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, "<thead>\n            <tr>\n                <th>STOCK ID</th>\n                <th>ARTICLE</th>\n                <th>STOCK</th>\n                \n                <th>Action</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 27 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
             foreach (var temp in objCtmr)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 30 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
                         temp.CodeMarchandise

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 31 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
                         temp.DesignationMarchandise

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 32 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
                         temp.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                  \n                   \n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "EditCustomer/" + (
#nullable restore
#line 36 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
                                                                temp.CodeMarchandise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\n                            <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Edit\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "DeleteCustomer/" + (
#nullable restore
#line 39 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
                                                                  temp.CodeMarchandise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span> Delete\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 44 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#nullable restore
#line 47 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor"
       
    List<LesStocks> objCtmr;
    protected override async Task OnInitializedAsync()
    {
        LesStocksService objCS = new LesStocksService();
        objCtmr = await Task.Run(()=> objCS.GetLesStock());
        //CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();
        //objCtmr = objCustomerDAL.GetAllCustomers().ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LesStocksService ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591
