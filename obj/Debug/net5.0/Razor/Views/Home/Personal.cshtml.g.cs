#pragma checksum "C:\Users\Pc\firstApplication\Views\Home\Personal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e08009610922b1a75212946d52df758879a1509c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Personal), @"mvc.1.0.view", @"/Views/Home/Personal.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Pc\firstApplication\Views\_ViewImports.cshtml"
using firstApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pc\firstApplication\Views\_ViewImports.cshtml"
using firstApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08009610922b1a75212946d52df758879a1509c", @"/Views/Home/Personal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df49d661beca9a22efd546ea84e0e996c7730177", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Personal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Pc\firstApplication\Views\Home\Personal.cshtml"
  
    ViewData["Title"] = "Personal";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bg-success p-2 text-white"">Programacion Computacional 1</div>

<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>

<h1>Jonathan Elias</h1>

<img src=""https://miro.medium.com/max/1024/1*ha-4qKf09p9ETpCDFKFQyw.jpeg""/>
<div class=""accordion"" id=""accordionExample"">
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingOne"">
      <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
       Que es ASP.NET? <div class=""spinner-grow text-primary"" role=""status"">
  <span class=""visually-hidden"">Loading...</span>");
            WriteLiteral(@"
</div>
      </button>
    </h2>
    <div id=""collapseOne"" class=""accordion-collapse collapse show"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>ASP.NET es una plataforma de desarrollo web la cual separa la lógica de negocio y utiliza servicios incluidos en .NET Framework.</strong> El código es compilado la primera vez que una  página  es  solicitada,  la  programación  de  las  páginas  se realiza  mediante lenguajes como: VB, C#.
      </div>
    </div>
  </div>
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingTwo"">
      <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
        Ciclo de  vida de una página ASP.NET. <div class=""spinner-grow text-success"" role=""status"">
  <span class=""visually-hidden"">Loading...</span>
</div>
      </button>
    </h2>
    <div id=""collapseTwo"" class");
            WriteLiteral(@"=""accordion-collapse collapse"" aria-labelledby=""headingTwo"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>Cuando se  lanza una aplicación ASP.Net, hay una serie de  pasos que se  llevan a cabo. Esta serie de pasos conforman el ciclo de vida de la aplicación.</strong> <strong>• Inicio de la aplicación:</strong> el ciclo de vida de una aplicación ASP.NET comienza 
cuando un usuario realiza una solicitud. Esta solicitud es para el servidor web de 
la aplicación ASP.Net. Esto sucede cuando el primer usuario normalmente va a 
la página de inicio de la aplicación por p rimera vez. Durante este tiempo, hay 
un método llamado Application_start que es ejecutado por el servidor web. Por 
lo general, en este método, todas las variables globales se establecen en sus 
valores predeterminados. 
 
<strong>• Creación  de objetos:</strong>  la  siguiente  etapa  es la  creación  de HttpContext, 
HttpRequest y HttpResponse por parte del servidor web. HttpContext es solo el 
");
            WriteLiteral(@"contenedor de los objetos HttpRequest y HttpResponse. El objeto HttpRequest 
contiene  información  sobre la  solicitud  actual,  incluidas  las cookies  y la 
información del navegador. El objeto HttpResponse contiene la respuesta que 
se envía al cliente. 
 
<strong>• Creación de HttpApplication:</strong> este objeto es creado por el servidor web. Este es 
el  objeto que se  utiliza para procesar  cada solicitud posterior  enviada a la 
aplicación. Por ejemplo, supongamos que tenemos 2 aplicaciones web. Una 
es una aplicación de carrito de compras y la otra es u n sitio web de noticias. 
Para cada aplicación, tendríamos 2 objetos HttpApplication creados. 
Cualquier otra solicitud a cada sitio web será procesada por cada 
HttpApplication respectivamente. 
 
<strong>• Dispose:</strong>  este  evento se  llama antes de  que  se  destruya la  insta ncia de  la 
aplicación.  Durante este tiempo, se  puede utilizar este  método para liberar 
manualmente los recursos no administrados. 
 
<strong>•");
            WriteLiteral(@" Fin  de  la  solicitud:</strong>  esta  es  la  parte  final  de  la  solicitud. En  esta  parte,  la 
aplicación finalmente se descarga de la memoria. .
      </div>
    </div>
  </div>
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingThree"">
      <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
       ¿Qué es el ciclo de vida de la página ASP.Net? <div class=""spinner-grow text-danger"" role=""status"">
  <span class=""visually-hidden"">Loading...</span>
</div>
      </button>
    </h2>
    <div id=""collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>Cuando se llama a una página ASP.Net, pasa por un ciclo de vida particular. Esto se hace antes de que se envíe la respuesta al usuario. Hay una serie  de pasos que se siguen para el procesamie");
            WriteLiteral(@"nto de una página ASP.Net. </strong> • Solicitud de página: aquí es cuando la página se solicita por primera vez desde 
el servidor. Cuando se solicita la página, el servidor comprueba si se solicita por 
primera vez. Si es así, debe compilar la página, analizar la respuesta y enviarla 
al usuario. Si no es la primera vez que se solicita la página, se comprueba la 
caché para ver si existe la salida de la página. Si es así, esa respuesta se envía 
al usuario. 
• Inicio de página: durante este tiempo, se crean 2 objetos, conocidos como el 
objeto Solicitud y Respuesta. El objeto Solicitud se utiliza para contener toda la 
información que se envió cuando se solicitó la página. El objeto Respuesta se 
utiliza para contener la información que se envía al usuario. 
• Inicialización  de página: durante este tiempo, se inicializan todos los controles 
de  una página web. Entonces, si  tiene alguna etiqueta, cuadro de texto o 
cualquier otro control en el formulario web, todos están inicializados. 
• Car");
            WriteLiteral(@"ga de página: aquí es cuando la página se carga realmente con todos los 
valores predeterminados. Entonces, si se supone que un cuadro de texto tiene 
un valor predeterminado, ese valor se carga durante el tiempo de carga de la 
página. 
• Validación: a veces puede  haber algún  conjunto  de validación  en el 
formulario. Por ejemplo, puede haber una validación que diga que un cuadro 
de lista debe tener un determinado conjunto de valores. Si la condición es falsa, 
entonces debería haber un error al cargar la página. 
• Manejo de eventos de devolución de datos: este evento se activa si se vuelve 
a cargar la misma página. Esto sucede en respuesta a un evento anterior. A 
veces puede haber una situación en la que un usuario hace clic en un botón 
de envío en la página. En este caso, se vuelve a mostrar la misma página. En 
tal caso, se llama al controlador de eventos Postback. 
• Representación de la página: esto sucede justo antes de que se envíe al usuario 
toda la información de respuesta. To");
            WriteLiteral(@"da la información del formulario se guarda 
y el resultado se envía al usuario como una página web completa. 
• Descargar: una  vez  que  se  envía la  salida  de  la  página al  usuario, no  es 
necesario mantener los  objetos del  formulario web  ASP.net en  la  memoria. 
Entonces,  el  proceso de  descarga  implica  eliminar  todos  los objetos no 
deseados de la memoria.
      </div>
    </div>
  </div>
</div>
<h1>Diseño y desarrollo de aplicaciones web</h1>
<div class=""p-3 mb-2 bg-info text-dark"">ASP.NET</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
