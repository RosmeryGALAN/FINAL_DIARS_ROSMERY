#pragma checksum "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a49293eaecce17ef863fc1dfd6a151899026e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CrearGasto), @"mvc.1.0.view", @"/Views/Home/CrearGasto.cshtml")]
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
#line 1 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\_ViewImports.cshtml"
using SanchezFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\_ViewImports.cshtml"
using SanchezFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a49293eaecce17ef863fc1dfd6a151899026e42", @"/Views/Home/CrearGasto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02318c83e7e6ed7e223ba74d73eb90f5fedb9f10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CrearGasto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/CrearGasto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml"
   var transaccion = (Transaccion)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Crear Gasto</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a49293eaecce17ef863fc1dfd6a151899026e424218", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Tipo\" value=\"Gasto\" />\r\n            ");
#nullable restore
#line 8 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml"
       Write(Html.ValidationMessage("Cuenta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"IdCuenta\"");
                BeginWriteAttribute("value", " value=\"", 326, "\"", 351, 1);
#nullable restore
#line 9 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml"
WriteAttributeValue("", 334, ViewBag.CuentaId, 334, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label>Descripcion</label>\r\n                <textarea class=\"form-control\" name=\"Descripcion\"></textarea>\r\n                ");
#nullable restore
#line 13 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml"
           Write(Html.ValidationMessage("Descripcion"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Monto</label>\r\n                <input type=\"number\" class=\"form-control\" name=\"Monto\" />\r\n                ");
#nullable restore
#line 18 "C:\Users\USER\3D Objects\DIARS FINAL\SanchezFinal\SanchezFinal\Views\Home\CrearGasto.cshtml"
           Write(Html.ValidationMessage("Descripcion"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <button class=\"btn btn-primary\">Guardar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
