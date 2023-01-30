// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\CustomerList.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\CustomerList.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CustomerList")]
    public partial class CustomerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\CustomerList.razor"
       
    private IEnumerable<Customer> customers;
    protected override async Task OnInitializedAsync()
    {
        customers = await CustomerService.GetCustomers();
    }

    protected async void DeleteCustomer(int customerId)
    {
        bool confirm = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to remove the customer?").ConfigureAwait(false);
        if (confirm)
        {
            await CustomerService.DeleteCustomer(customerId).ConfigureAwait(false);
            navigationManager.NavigateTo("/CustomerList");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591