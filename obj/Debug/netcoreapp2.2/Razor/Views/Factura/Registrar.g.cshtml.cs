#pragma checksum "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3269ec1a863401b3690093aab5ce4f74ea7c4ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factura_Registrar), @"mvc.1.0.view", @"/Views/Factura/Registrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factura/Registrar.cshtml", typeof(AspNetCore.Views_Factura_Registrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3269ec1a863401b3690093aab5ce4f74ea7c4ea1", @"/Views/Factura/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ad0aeda6e21bf1be9d1f6f8b86d8f498b6f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Factura_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factura>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
  
    var clientes = (List<Cliente>)ViewBag.Cliente;
    var productos = (List<Producto>)ViewBag.Producto;

#line default
#line hidden
            BeginContext(125, 407, true);
            WriteLiteral(@"<script src=""http://code.jquery.com/jquery-1.9.1.js""></script>
<script src=""http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js""></script>
<script type=""text/javascript"">
    //Buscar Cliente
    function buscarCliente() {
        $(document).ready(function () {
            var Id_Cliente = $(""#Id_Cliente"").val().trim();
            $.ajax({
                type: ""GET"",
                url: '");
            EndContext();
            BeginContext(533, 37, false);
#line 15 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                 Write(Url.Action("buscarCliente","Factura"));

#line default
#line hidden
            EndContext();
            BeginContext(570, 968, true);
            WriteLiteral(@"',
                data: { a: Id_Cliente },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: successFunc,
                error: errorFunc
        });
            function successFunc(data) {
                document.getElementById(""Id_Cliente1"").value = data[0];
                document.getElementById(""NombreCliente"").value = data[1];
                document.getElementById(""ApellidoCliente"").value = data[2];
                document.getElementById(""Correo"").value = data[3];
                document.getElementById(""Numero_Telefonico"").value = data[4];
        }
        function errorFunc() {
        alert('error');
        }
        });
    }
    //-------
    //Buscar Producto
    function buscarProducto() {
        $(document).ready(function () {
            var Id_Producto = $(""#Id_Producto"").val().trim();
            $.ajax({
                type: ""GET"",
                url: '");
            EndContext();
            BeginContext(1539, 38, false);
#line 41 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                 Write(Url.Action("buscarProducto","Factura"));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 6828, true);
            WriteLiteral(@"',
                data: { b: Id_Producto },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: successFunc,
                error: errorFunc
        });
            function successFunc(data) {
                document.getElementById(""Codigo"").value = data[0];
                document.getElementById(""NombreProducto"").value = data[1];
                document.getElementById(""Marca"").value = data[2];
                document.getElementById(""Categoria"").value = data[3];
                document.getElementById(""Precio"").value = data[4];
        }
        function errorFunc() {
        alert('error');
        }
        });
    }
    //-------
    //Grid View
    var Codigos = new Array();
    var Nombres = new Array();
    var Cantidads = new Array();
    var preUs = new Array();
    var subTs = new Array();
    var count = new Array();
    var i = count.length;
    var total = 0;
    function productsAdd() {
        var total = 0;
        va");
            WriteLiteral(@"r codigo = document.getElementById(""Codigo"").value;
        var nombre = document.getElementById(""NombreProducto"").value;
        var cantidad = document.getElementById(""Cantidad"").value;
        var preU = document.getElementById(""Precio"").value;
        var subT = (preU * cantidad) / 1.0;
        subT = parseFloat(subT).toFixed(2);
        if(Codigos.indexOf(codigo)>=0){
            alert(""Ya esta en la tabla. Tendra que actualizarlo. Indice numero: "" + Codigos.indexOf(codigo));
        }
        else{
        Codigos.push(codigo);
        Nombres.push(nombre);
        Cantidads.push(cantidad);
        preUs.push(preU);
        subTs.push(subT);
        count.push(i);
        }
        $(""#productTable tbody"").remove();
        if ($(""#productTable tbody"").length == 0) {
            $(""#productTable"").append(""<tbody></tbody>"");
        }
        for (i = 0; i < count.length; i++) {
            // Append product to the table
            $(""#productTable tbody"").append(
                ""<tr>"" +
              ");
            WriteLiteral(@"  ""<td>"" + i + ""</td>"" +
                ""<td>"" + Codigos[i] + ""</td>"" +
                ""<td>"" + Nombres[i] + ""</td>"" +
                ""<td>"" + Cantidads[i] + ""</td>"" +
                ""<td>"" + preUs[i] + ""</td>"" +
                ""<td>"" + subTs[i] + ""</td>"" +
                ""<td>"" + ""<button type='button' "" + ""onclick='productDelete(this,"" + i + "")' "" + ""class='btn btn-default'>"" + ""Delete"" + ""</button>"" +
                ""</td>"" +
                ""</tr>""
            );
            total += subTs[i] * 1.0;
        }
        document.getElementById(""Total"").value = parseFloat(total);
        //document.getElementById(""count"").innerHTML = count[i];
    }
    //---------------
    //Eliminar de la Grilla
    function productDelete(ctl, id) {
        var total = 0;
        if (id == i) {
            var total = 0;
            $(ctl).parents(""tr"").remove();
            alert(id);
            count.splice(id);
            Codigos.splice(id);
            Nombres.splice(id);
            Cantidads.splice(id);
    ");
            WriteLiteral(@"        preUs.splice(id);
            subTs.splice(id);
            $(""#productTable tbody"").remove();
            if ($(""#productTable tbody"").length == 0) {
                $(""#productTable"").append(""<tbody></tbody>"");
            }
            for (i = 0; i < count.length; i++) {
                // Append product to the table
                $(""#productTable tbody"").append(
                    ""<tr>"" +
                    ""<td>"" + i + ""</td>"" +
                    ""<td>"" + Codigos[i] + ""</td>"" +
                    ""<td>"" + Nombres[i] + ""</td>"" +
                    ""<td>"" + Cantidads[i] + ""</td>"" +
                    ""<td>"" + preUs[i] + ""</td>"" +
                    ""<td>"" + subTs[i] + ""</td>"" +
                    ""<td>"" + ""<button type='button' "" + ""onclick='productDelete(this,"" + i + "")' "" + ""class='btn btn-default'>"" + ""Delete"" + ""</button>"" +
                    ""</td>"" +
                    ""</tr>""
                );
                total += subTs[i] * 1.0;
            }
        } else {
          ");
            WriteLiteral(@"  var total = 0;
            var repcodigos = new Array();
            var repnombres = new Array();
            var repcantidads = new Array();
            var reppreUs = new Array();
            var repsubTs = new Array();
            var repcount = new Array();
            for (i = 0; i < count.length; i++) {
                if (i != id) {
                    repcount.push(i);
                    repcodigos.push(Codigos[i]);
                    repnombres.push(Nombres[i]);
                    repcantidads.push(Cantidads[i]);
                    reppreUs.push(preUs[i]);
                    repsubTs.push(subTs[i]);
                }
            }
            count = null;
            Codigos = null;
            Descripcions = null;
            Cantidads = null;
            preUs = null;
            subTs = null;
            count = repcount;
            Codigos = repcodigos;
            Nombres = repnombres;
            Cantidads = repcantidads;
            preUs = reppreUs;
            subTs = repsubTs;
   ");
            WriteLiteral(@"         $(""#productTable tbody"").remove();
            if ($(""#productTable tbody"").length == 0) {
                $(""#productTable"").append(""<tbody></tbody>"");
            }
            for (i = 0; i < count.length; i++) {
                // Append product to the table
                $(""#productTable tbody"").append(
                    ""<tr>"" +
                    ""<td>"" + i + ""</td>"" +
                    ""<td>"" + Codigos[i] + ""</td>"" +
                    ""<td>"" + Nombres[i] + ""</td>"" +
                    ""<td>"" + Cantidads[i] + ""</td>"" +
                    ""<td>"" + preUs[i] + ""</td>"" +
                    ""<td>"" + subTs[i] + ""</td>"" +
                    ""<td>"" + ""<button type='button' "" + ""onclick='productDelete(this,"" + i + "")' "" + ""class='btn btn-default'>"" + ""Delete"" + ""</button>"" +
                    ""</td>"" +
                    ""</tr>""
                );
                total += subTs[i] * 1.0;
            }
            //alert(repnombres);
        }
        document.getElementById(""Total"").va");
            WriteLiteral(@"lue = parseFloat(total);
        //document.getElementById(""count"").innerHTML = count[i];
    }
    //-----------------
    //Registrar Grilla
    function registrar() {
        var rows = """";
        var fechaRealizada = document.getElementById(""Fecha_Realizada"").value;
        var codigoCliente = document.getElementById(""Id_Cliente1"").value;
        var Total = document.getElementById(""Total"").value;
        for (i = 0; i < count.length; i++){
            rows += Codigos[i] + ""-"" + Nombres[i] + ""-"" + Cantidads[i] + ""-"" + preUs[i] + ""-"" + subTs[i] + ""-"";
        }
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '");
            EndContext();
            BeginContext(8406, 41, false);
#line 214 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                 Write(Url.Action("registrarFactura", "Factura"));

#line default
#line hidden
            EndContext();
            BeginContext(8447, 901, true);
            WriteLiteral(@"',
                data: { row: rows, fchRealizada:fechaRealizada, codClnt: codigoCliente, total: Total},
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: successFunc,
                error: errorFunc
            });
            function successFunc(data) {
                alert(data);
            }
            function errorFunc() {
                alert(""No Registrado"");
            }
        });
    }
</script>
<h1>Registrar Factura</h1>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""form-group"">
            <label>Fecha Realizada:</label>
            <input type=""date"" class=""form-control"" id=""Fecha_Realizada"" >
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""form-group"">
            <label>Cliente:</label>
            <select id=""Id_Cliente"">
");
            EndContext();
#line 244 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                 foreach(var cliente in clientes){

#line default
#line hidden
            BeginContext(9399, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(9415, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3269ec1a863401b3690093aab5ce4f74ea7c4ea115062", async() => {
                BeginContext(9452, 14, false);
#line 245 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                                               Write(cliente.Nombre);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 245 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                   WriteLiteral(cliente.Id_Cliente);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9475, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 246 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                }

#line default
#line hidden
            BeginContext(9494, 1023, true);
            WriteLiteral(@"            </select>
            <button class=""btn btn-default"" onclick=""buscarCliente()"">Buscar</button>
        </div>
        <h2>Cliente</h2>
        <input type=""hidden"" id=""Id_Cliente1"">
        <div class=""form-group"">
            <label>Nombre:</label>
            <input type=""text"" class=""form-control"" id=""NombreCliente"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Nombre:</label>
            <input type=""text"" class=""form-control"" id=""ApellidoCliente"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Correo:</label>
            <input type=""text"" class=""form-control"" id=""Correo"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Numero Telefonico:</label>
            <input type=""text"" class=""form-control"" id=""Numero_Telefonico"" disabled=""true"">
        </div>
    </div>
    <div class=""col-lg-6"">
    <div class=""form-group"">
        <label>Producto:</label>
        <select id=""Id_Producto"">
");
            EndContext();
#line 273 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
             foreach(var producto in productos){

#line default
#line hidden
            BeginContext(10566, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(10582, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3269ec1a863401b3690093aab5ce4f74ea7c4ea118528", async() => {
                BeginContext(10621, 15, false);
#line 274 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                                                 Write(producto.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(10636, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(10640, 21, false);
#line 274 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                                                                    Write(producto.Marca.Nombre);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 274 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
                   WriteLiteral(producto.Id_Producto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10670, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 275 "/home/yayo/Documents/Programacion-1/Views/Factura/Registrar.cshtml"
            }

#line default
#line hidden
            BeginContext(10685, 2174, true);
            WriteLiteral(@"        </select>
        <button class=""btn btn-default"" onclick=""buscarProducto()"">Buscar</button>
    </div>
        <h2>Producto</h2>
        <input type=""hidden"" id=""Codigo"">
        <div class=""form-group"">
            <label>Nombre:</label>
            <input type=""text"" class=""form-control"" id=""NombreProducto"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Marca:</label>
            <input type=""text"" class=""form-control"" id=""Marca"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Categoria:</label>
            <input type=""text"" class=""form-control"" id=""Categoria"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Precio:</label>
            <input type=""text"" class=""form-control"" id=""Precio"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Cantidad:</label>
            <input type=""number"" id=""Cantidad"" class=""form-control"" value=""1"" min=""1"" max=""100"" size=""2"" >");
            WriteLiteral(@"
        </div>
        <button class=""btn btn-default"" type=""button"" onclick=""productsAdd()"">Agregar Material</button>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <!--GridView-->
        <div class=""panel panel-default"" align=""center"">
            <div class=""panel-heading""></div>
            <div class=""panel-body"">
                <table id=""productTable"" width=""300"" align=""center"" class=""table"">
                    <thead>
                        <tr>
                        <th></th>
                        <th>Codigo</th>
                        <th>Nombre</th>
                        <th>Cantidad</th>
                        <th>Precio Unitario</th>
                        <th>Sub Total</th>
                        <th></th>
                    </tr>
                    </thead>
                </table>
             </div>
        </div>
        <div class=""left"">
        <input type=""text"" id=""Total"" disabled=""true"">
    </div>
    <!--End GridView-->
    </div>
</div>
<but");
            WriteLiteral("ton class=\"btn btn-default\" onclick=\"registrar()\">Registrar Factura</button>\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n");
            EndContext();
            BeginContext(12859, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3269ec1a863401b3690093aab5ce4f74ea7c4ea123385", async() => {
                BeginContext(12928, 8, true);
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