#pragma checksum "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Customer - Copier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e653d4fc47aaf0104d82541f347f843e7337428"
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
#line 2 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Customer - Copier.razor"
using CRUDBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer")]
    public partial class Customer___Copier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\MES PROJETS\BLAZOR\CRUDBlazor-master (1)\CRUDBlazor-master\CRUDBlazor\Pages\Customer - Copier.razor"
       
    List<CustomerInfo> objCtmr;
    protected override async Task OnInitializedAsync()
    {
        CustomerService objCS = new CustomerService();
        objCtmr = await Task.Run(()=> objCS.GetCustomer());
        //CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();
        //objCtmr = objCustomerDAL.GetAllCustomers().ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591
