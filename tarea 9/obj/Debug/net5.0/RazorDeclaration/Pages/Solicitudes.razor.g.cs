// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
using Tarea_9.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Solicitudes")]
    public partial class Solicitudes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
       
    Consumo API = new Consumo();
    private ExampleModel exampleModel = new();
    public dynamic B_Cedula { get; set; }
    public dynamic B_Provincias { get; set; }
    public dynamic B_Municipio { get; set; }
    public dynamic B_Distrito { get; set; }
    public dynamic B_LongLag { get; set; }
    public dynamic B_ProvinciaUnica { get; set; }
    public dynamic AGuardar { get; set; }
    string jsonString;
    string mensaje;
    string Mensaje, m;
    private string message {get; set;} = "";
    private void SendMail()
    {
        try
        {
            using(MailMessage mail = new MailMessage()){
                mail.From = new MailAddress("20198669@itla.edu.do");
                mail.To.Add(exampleModel.Correo);
                mail.Subject = "Datos personales";
                mail.Body = "<html>"+"<head>"+"<title>Informe de datos</title>"+"<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css' integrity='sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l' crossorigin='anonymous'>"+"<link rel='stylesheet' href='css/bootstrap/bootstrap.min.css' /><link href='css/site.css' rel='stylesheet' />"+"</head>"+"<body>"+"<h4><b>Datos del formulario</b></h4>"+"<table class='table'>"+"<thead class='thead-dark'><tr><th scope='col'>Datos personales</th><th scope='col'></th></tr></thead>"+"<tbody>"+"<tr><th>Cedula:</th><td>"+exampleModel.Cedula+"</td></tr>"+"<tr><th>Nombre:</th><td>"+exampleModel.Nombre+"</td></tr>"+"<tr><th>Apellido:</th><td>"+exampleModel.Apellido+"</td></tr>"+"<tr><th>Telefono:</th><td>"+exampleModel.Telefono+"</td></tr>"+"<tr><th>Correo Electronico:</th><td>"+exampleModel.Correo+"</td></tr>"+"<tr><th>Fecha de Nacimiento:</th><td>"+exampleModel.Fecha_Nacimiento+"</td></tr>"+"<tr><th>Tipo de Sangre:</th><td>"+exampleModel.Tipo_Sangre+"</td></tr>"+"<tr><th>Provincia:</th><td>"+exampleModel.Provincia+"</td></tr>"+"<tr><th>Direccion:</th><td>"+exampleModel.Direccion+"</td></tr>"+"<tr><th>Latitud:</th><td>"+exampleModel.Latitud+"</td></tr>"+"<tr><th>Longitud:</th><td>"+exampleModel.Longitud+"</td></tr>"+"<tr><th>Le ha dado covid-19:</th><td>"+exampleModel.Vacunacion+"</td></tr>"+"<tr><th>Justificacion:</th><td>"+exampleModel.Justificacion+"</td></tr>"+"</tbody>"+"</table>"+"<script src='https://code.jquery.com/jquery-3.5.1.slim.min.js' integrity='sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj' crossorigin='anonymous'></script>"+"<script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js' integrity='sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns' crossorigin='anonymous'></script>"+"<script src='https://code.jquery.com/jquery-3.5.1.slim.min.js' integrity='sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj' crossorigin='anonymous'></script>"+"<script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js' integrity='sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN' crossorigin='anonymous'></script>"+"<script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js' integrity='sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF' crossorigin='anonymous'></script>"+"</body>"+"</html>";
                mail.IsBodyHtml = true;

                using(SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                smtp.Credentials = new System.Net.NetworkCredential("20198669@itla.edu.do", "20198669");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                message = "Correo Enviado...";
                }

            }
           

        }
        catch(Exception)
        {
            throw;
        }
    }

    private void HandleValidSubmit()
    {
        jsonString = JsonConvert.SerializeObject(exampleModel);
        AGuardar = API.Post("https://api-solicitud-vacunacion.herokuapp.com/api/RegistrarSolicitudVacunacion", jsonString);
        if (AGuardar != null)
        {
            Mensajes();
           if(AGuardar.ok == true){
                
                SendMail();
           }
        }

    }

    public void BuscarCedula(ChangeEventArgs e)
    {
        B_Cedula = API.Get("https://api.adamix.net/apec/cedula/" + e.Value.ToString() + "");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 247 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
         if (B_Cedula != null || B_Cedula == false)
        {
            if (B_Cedula.ok == true)
            {
                exampleModel.Nombre = B_Cedula.Nombres;
                exampleModel.Apellido = B_Cedula.Apellido1 + " " + B_Cedula.Apellido2;
            }
            else
            {
                Mensaje = "La cedula no es valida";
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 258 "C:\Users\Administrador\OneDrive\Documentos\PROGRAMACION 3\Tarea-9 nueva\Tarea-9\Pages\Solicitudes.razor"
         
    }
    protected override void OnInitialized()
    {
        B_Provincias = API.Get("http://provinciasrd.raydelto.org/provincias");
    }

    public void BuscarMunicipio(ChangeEventArgs e)
    {
        B_Municipio = API.Get("http://provinciasrd.raydelto.org/provincias/" + e.Value.ToString() + "/municipios");
        B_ProvinciaUnica = API.Get("http://provinciasrd.raydelto.org/provincias/" + e.Value.ToString() + "");
        if (B_ProvinciaUnica != null)
        {
            exampleModel.Provincia = B_ProvinciaUnica.data[0].nombre;
        }
        if (exampleModel.Municipio != null)
        {

        }


    }
    public void BuscarDistrito(ChangeEventArgs e)
    {
        B_Distrito = API.Get("http://provinciasrd.raydelto.org/municipios/" + e.Value.ToString() + "/distritos_municipales");

    }
    public void BuscarLang(ChangeEventArgs e)
    {
        B_LongLag = API.Get("https://maps.googleapis.com/maps/api/geocode/json?key=AIzaSyAfCsBivkdYabQdQnmCNnbWMiRnGIAYj3c&address" +
            "=" + exampleModel.Provincia + "," + exampleModel.Municipio + "," + exampleModel.Distrito_Municipal + "," + exampleModel.Nombre_Calle + ",#" + e.Value.ToString() + "");

        if (B_LongLag != null)
        {
            try
            {
                var s = B_LongLag.results[0].geometry.location.lng;
                exampleModel.Longitud = s;
                var g = B_LongLag.results[0].geometry.location.lat;
                exampleModel.Latitud = g;
                exampleModel.Direccion = "" + exampleModel.Provincia + "," + exampleModel.Municipio + "," + exampleModel.Distrito_Municipal + "," + exampleModel.Nombre_Calle + ",#" + e.Value.ToString() + "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }


    }
    private async Task Mensajes()
    {
        if (AGuardar.ok == true)
        {
            await js.InvokeVoidAsync("Confirmar", "success", "??Exito!", "Los datos se guardaron con exito!");
        }
        else
        {
            await js.InvokeVoidAsync("Confirmar", "error", "Vaya!", "Ocurrio un error ya que haz hecho una solicitud anteriormente");
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
    }
}
#pragma warning restore 1591
