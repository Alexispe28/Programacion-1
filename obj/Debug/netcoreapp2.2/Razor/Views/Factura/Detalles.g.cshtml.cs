#pragma checksum "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f919822387ef6af26ecc19ca30e88c434a344f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factura_Detalles), @"mvc.1.0.view", @"/Views/Factura/Detalles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factura/Detalles.cshtml", typeof(AspNetCore.Views_Factura_Detalles))]
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
#line 1 "/home/yayo/Documents/Programacion-1/Views/_ViewImports.cshtml"
using Programacion_1;

#line default
#line hidden
#line 2 "/home/yayo/Documents/Programacion-1/Views/_ViewImports.cshtml"
using Programacion_1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f919822387ef6af26ecc19ca30e88c434a344f1", @"/Views/Factura/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ad0aeda6e21bf1be9d1f6f8b86d8f498b6f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Factura_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/factura/listar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary a-btn-slide-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
  
    var Factura_Item = (List<Factura_Item>)ViewBag.Factura_Items;

#line default
#line hidden
            BeginContext(86, 44, true);
            WriteLiteral("<h1>Detalles de la Boleta</h1>\n\n<p>Cliente: ");
            EndContext();
            BeginContext(131, 20, false);
#line 7 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
       Write(Model.Cliente.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(151, 36, true);
            WriteLiteral("</p>\n<p>Numero de Guia de Remision: ");
            EndContext();
            BeginContext(188, 16, false);
#line 8 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
                          Write(Model.Id_Factura);

#line default
#line hidden
            EndContext();
            BeginContext(204, 26, true);
            WriteLiteral("</p>\n<p>Fecha de Llegada: ");
            EndContext();
            BeginContext(231, 21, false);
#line 9 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
                Write(Model.Fecha_Realizada);

#line default
#line hidden
            EndContext();
            BeginContext(252, 151, true);
            WriteLiteral("</p>\n\n <table class=\"table\">\n    <tr>\n        <th>Producto</th>\n        <th>Precio</th>\n        <th>Cantidad</th>\n        <th>Subtotal</th>\n    </tr>\n\n");
            EndContext();
#line 19 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
     foreach(var p in Factura_Item) {

#line default
#line hidden
            BeginContext(441, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(471, 17, false);
#line 21 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
           Write(p.Producto.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(488, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(511, 17, false);
#line 22 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
           Write(p.Producto.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(528, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(551, 10, false);
#line 23 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
           Write(p.Cantidad);

#line default
#line hidden
            EndContext();
            BeginContext(561, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(584, 10, false);
#line 24 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
           Write(p.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(594, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 26 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
    }

#line default
#line hidden
            BeginContext(620, 19, true);
            WriteLiteral("</table>\n<p>Total: ");
            EndContext();
            BeginContext(640, 11, false);
#line 28 "/home/yayo/Documents/Programacion-1/Views/Factura/Detalles.cshtml"
     Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(651, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
            BeginContext(656, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f919822387ef6af26ecc19ca30e88c434a344f17346", async() => {
                BeginContext(725, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factura> Html { get; private set; }
    }
}
#pragma warning restore 1591
