#pragma checksum "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Stock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33549e7449094ac52e605fef09194b1063d1b39c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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