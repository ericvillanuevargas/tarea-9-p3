#pragma checksum "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c9fd849ff22a75d70070948d292c576bfcc626"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
using Tarea_9.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><h4>Solicitudes creadas</h4></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered");
            __builder.AddMarkupContent(9, @"<thead><tr><th scope=""col"">Cedula</th>
                        <th scope=""col"">Nombre</th>
                        <th scope=""col"">Apellido</th>
                        <th scope=""col"">Telefono</th>
                        <th scope=""col"">Correo</th>
                        <th scope=""col"">Estado de vacunacion</th></tr></thead>
                ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 23 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                     if (Datos != null && Datos.ok != false)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                         foreach (var i in Datos.data)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 28 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 30 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 31 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 32 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 33 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                                     i.Vacunacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
             if (Datos.ok == false)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<div class=\"alert alert-danger text-center\" role=\"alert\">\r\n                   No hay solicitudes registradas...\r\n                </div>");
#nullable restore
#line 44 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Index.razor"
      
    Consumo API = new Consumo();
    public dynamic Datos { get; set; }

    protected override void OnInitialized()
    {
        Datos = API.Get("https://api-solicitud-vacunacion.herokuapp.com/api/ConsultaSolicitudesGeneral");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
