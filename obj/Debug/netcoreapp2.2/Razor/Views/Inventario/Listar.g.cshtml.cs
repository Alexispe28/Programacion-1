#pragma checksum "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52024511ba6b070906ed607e10482f2a55c556f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Listar), @"mvc.1.0.view", @"/Views/Inventario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Listar.cshtml", typeof(AspNetCore.Views_Inventario_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52024511ba6b070906ed607e10482f2a55c556f", @"/Views/Inventario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ad0aeda6e21bf1be9d1f6f8b86d8f498b6f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guia_de_Remision>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary a-btn-slide-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger a-btn-slide-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/categoria/registrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 225, true);
            WriteLiteral("\r\n<h1>Lista de Guia De Remision</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Código</th>\r\n        <th>Proveedor</th>\r\n        <th>Fecha de Llegada</th>\r\n        <th>Total</th>\r\n        <th>Opciones</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
     foreach(var p in Model) {

#line default
#line hidden
            BeginContext(288, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(319, 21, false);
#line 16 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
           Write(p.Id_Guia_de_Remision);

#line default
#line hidden
            EndContext();
            BeginContext(340, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(364, 18, false);
#line 17 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
           Write(p.Proveedor.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(382, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(406, 18, false);
#line 18 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
           Write(p.Fecha_de_Llegada);

#line default
#line hidden
            EndContext();
            BeginContext(424, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(448, 7, false);
#line 19 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
           Write(p.Total);

#line default
#line hidden
            EndContext();
            BeginContext(455, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(496, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52024511ba6b070906ed607e10482f2a55c556f6249", async() => {
                BeginContext(610, 39, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-edit\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 505, "~/inventario/detalles/", 505, 22, true);
#line 21 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
AddHtmlAttributeValue("", 527, p.Id_Guia_de_Remision, 527, 22, false);

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
            BeginContext(653, 21, true);
            WriteLiteral(" | \r\n                ");
            EndContext();
            BeginContext(674, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52024511ba6b070906ed607e10482f2a55c556f8101", async() => {
                BeginContext(787, 41, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-remove\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 683, "~/inventario/eliminar/", 683, 22, true);
#line 23 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
AddHtmlAttributeValue("", 705, p.Id_Guia_de_Remision, 705, 22, false);

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
            BeginContext(832, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 27 "C:\Users\Yayo\Documents\Programacion-1\Views\Inventario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(875, 18, true);
            WriteLiteral("    \r\n\r\n</table>\r\n");
            EndContext();
            BeginContext(893, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52024511ba6b070906ed607e10482f2a55c556f10217", async() => {
                BeginContext(968, 15, true);
                WriteLiteral("Nueva Categoria");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guia_de_Remision>> Html { get; private set; }
    }
}
#pragma warning restore 1591