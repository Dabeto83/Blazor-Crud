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
#line 4 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\NewCustomer.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\NewCustomer.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewCustomer")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewCustomer/{id:int}")]
    public partial class NewCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\Dario\Proyectos\Courses\Blazor\Crud\BlazorCRUD\BlazorCRUD\Pages\NewCustomer.razor"
       
    [Parameter]
    public int id { get; set; }
    Customer customer = new Customer();

    protected async Task Save()
    {
        await CustomerService.SaveCustomer(customer).ConfigureAwait(false);
        navigationManager.NavigateTo("/CustomerList");
    }

    protected void Cancel()
    {
        navigationManager.NavigateTo("/CustomerList");
    }

    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
        {
            customer = await CustomerService.GetCustomerById(id).ConfigureAwait(false);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
