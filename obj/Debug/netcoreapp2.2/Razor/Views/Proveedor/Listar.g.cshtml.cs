#pragma checksum "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8935ccacea875b8e05ea98dc1d602f390804c794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proveedor_Listar), @"mvc.1.0.view", @"/Views/Proveedor/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proveedor/Listar.cshtml", typeof(AspNetCore.Views_Proveedor_Listar))]
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
#line 1 "C:\Users\Yayo\Documents\Programacion-1\Views\_ViewImports.cshtml"
using Programacion_1;

#line default
#line hidden
#line 2 "C:\Users\Yayo\Documents\Programacion-1\Views\_ViewImports.cshtml"
using Programacion_1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8935ccacea875b8e05ea98dc1d602f390804c794", @"/Views/Proveedor/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ad0aeda6e21bf1be9d1f6f8b86d8f498b6f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Proveedor_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Proveedor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary a-btn-slide-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger a-btn-slide-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/proveedor/registrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 273, true);
            WriteLiteral(@"
<h1>Listado de Proveedor</h1>

<table class=""table"">
    <tr>
        <th>Código</th>
        <th>Nombre</th>
        <th>Correo</th>
        <th>NumeroTelefonico</th>
        <th>Detalles</th>
        <th>Direccion</th>
        <th>Opciones</th>
    </tr>

");
            EndContext();
#line 16 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
     foreach(var p in Model) {

#line default
#line hidden
            BeginContext(329, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(360, 14, false);
#line 18 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Id_Proveedor);

#line default
#line hidden
            EndContext();
            BeginContext(374, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(398, 8, false);
#line 19 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(406, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(430, 8, false);
#line 20 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(438, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(462, 19, false);
#line 21 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Numero_Telefonico);

#line default
#line hidden
            EndContext();
            BeginContext(481, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(505, 10, false);
#line 22 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Detalles);

#line default
#line hidden
            EndContext();
            BeginContext(515, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(539, 11, false);
#line 23 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
           Write(p.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(550, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(591, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8935ccacea875b8e05ea98dc1d602f390804c7946916", async() => {
                BeginContext(699, 39, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-edit\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 600, "~/proveedor/actualizar/", 600, 23, true);
#line 25 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
AddHtmlAttributeValue("", 623, p.Id_Proveedor, 623, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(742, 21, true);
            WriteLiteral(" | \r\n                ");
            EndContext();
            BeginContext(763, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8935ccacea875b8e05ea98dc1d602f390804c7948761", async() => {
                BeginContext(868, 41, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-remove\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 772, "~/proveedor/eliminar/", 772, 21, true);
#line 27 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
AddHtmlAttributeValue("", 793, p.Id_Proveedor, 793, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(913, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Yayo\Documents\Programacion-1\Views\Proveedor\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(956, 18, true);
            WriteLiteral("    \r\n\r\n</table>\r\n");
            EndContext();
            BeginContext(974, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8935ccacea875b8e05ea98dc1d602f390804c79410867", async() => {
                BeginContext(1049, 15, true);
                WriteLiteral("Nuevo Proveedor");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Proveedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
