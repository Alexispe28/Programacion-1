#pragma checksum "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03a5fe6ab740f0bdcab6fce0916d4b3afd68cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Registrar), @"mvc.1.0.view", @"/Views/Inventario/Registrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Registrar.cshtml", typeof(AspNetCore.Views_Inventario_Registrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03a5fe6ab740f0bdcab6fce0916d4b3afd68cea", @"/Views/Inventario/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ad0aeda6e21bf1be9d1f6f8b86d8f498b6f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventario>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
  
    var proveedores = (List<Proveedor>)ViewBag.Proveedor;
    var productos = (List<Producto>)ViewBag.Producto;

#line default
#line hidden
            BeginContext(135, 415, true);
            WriteLiteral(@"<script src=""http://code.jquery.com/jquery-1.9.1.js""></script>
<script src=""http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js""></script>
<script type=""text/javascript"">
    //Buscar Proveedor
    function buscarProveedor() {
        $(document).ready(function () {
            var Id_Proveedor = $(""#Id_Proveedor"").val().trim();
            $.ajax({
                type: ""GET"",
                url: '");
            EndContext();
            BeginContext(551, 42, false);
#line 15 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                 Write(Url.Action("buscarProveedor","Inventario"));

#line default
#line hidden
            EndContext();
            BeginContext(593, 890, true);
            WriteLiteral(@"',
                data: { a: Id_Proveedor },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: successFunc,
                error: errorFunc
        });
            function successFunc(data) {
                document.getElementById(""Id_Proveedor1"").value = data[0];
                document.getElementById(""NombreProveedor"").value = data[1];
                document.getElementById(""Direccion"").value = data[2];
                document.getElementById(""Correo"").value = data[3];
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
            BeginContext(1484, 41, false);
#line 40 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                 Write(Url.Action("buscarProducto","Inventario"));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 6831, true);
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
        var fechaLlegada = document.getElementById(""Fecha_de_Llegada"").value;
        var codigoProveedor = document.getElementById(""Id_Proveedor1"").value;
        var Total = document.getElementById(""Total"").value;
        for (i = 0; i < count.length; i++){
            rows += Codigos[i] + ""-"" + Nombres[i] + ""-"" + Cantidads[i] + ""-"" + preUs[i] + ""-"" + subTs[i] + ""-"";
        }
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '");
            EndContext();
            BeginContext(8357, 49, false);
#line 213 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                 Write(Url.Action("registrarGuiaRemision", "Inventario"));

#line default
#line hidden
            EndContext();
            BeginContext(8406, 919, true);
            WriteLiteral(@"',
                data: { row: rows, fchLlegada:fechaLlegada, codProv: codigoProveedor, total: Total},
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
<h1>Registro de Stock de Inventario</h1>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""form-group"">
            <label>Fecha de Llegada:</label>
            <input type=""date"" class=""form-control"" id=""Fecha_de_Llegada"" >
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""form-group"">
            <label>Proveedor:</label>
            <select id=""Id_Proveedor"">
");
            EndContext();
#line 243 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                 foreach(var proveedor in proveedores){

#line default
#line hidden
            BeginContext(9381, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(9397, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03a5fe6ab740f0bdcab6fce0916d4b3afd68cea14196", async() => {
                BeginContext(9438, 16, false);
#line 244 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                                                   Write(proveedor.Nombre);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 244 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                   WriteLiteral(proveedor.Id_Proveedor);

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
            BeginContext(9463, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 245 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                }

#line default
#line hidden
            BeginContext(9482, 842, true);
            WriteLiteral(@"            </select>
            <button class=""btn btn-default"" onclick=""buscarProveedor()"">Buscar</button>
        </div>
        <h2>Proveedor</h2>
        <input type=""hidden"" id=""Id_Proveedor1"">
        <div class=""form-group"">
            <label>Nombre:</label>
            <input type=""text"" class=""form-control"" id=""NombreProveedor"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Correo:</label>
            <input type=""text"" class=""form-control"" id=""Correo"" disabled=""true"">
        </div>
        <div class=""form-group"">
            <label>Direccion:</label>
            <input type=""text"" class=""form-control"" id=""Direccion"" disabled=""true"">
        </div>
    </div>
    <div class=""col-lg-6"">
    <div class=""form-group"">
        <label>Producto:</label>
        <select id=""Id_Producto"">
");
            EndContext();
#line 268 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
             foreach(var producto in productos){

#line default
#line hidden
            BeginContext(10373, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(10389, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03a5fe6ab740f0bdcab6fce0916d4b3afd68cea17492", async() => {
                BeginContext(10428, 15, false);
#line 269 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
                                                 Write(producto.Nombre);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 269 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
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
            BeginContext(10452, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 270 "/home/yayo/Documents/Programacion-1/Views/Inventario/Registrar.cshtml"
            }

#line default
#line hidden
            BeginContext(10467, 2130, true);
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
            WriteLiteral("ton class=\"btn btn-default\" onclick=\"registrar()\">Registrar al Inventario</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventario> Html { get; private set; }
    }
}
#pragma warning restore 1591
