#pragma checksum "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6195fde6c33635b15d54808e897235f433050d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editar), @"mvc.1.0.view", @"/Views/Home/Editar.cshtml")]
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
#line 1 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\_ViewImports.cshtml"
using AP_Web_Ferreyra;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\_ViewImports.cshtml"
using AP_Web_Ferreyra.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6195fde6c33635b15d54808e897235f433050d2c", @"/Views/Home/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52917c82f1dc7bfb902364a0757a4b014703f26f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml"
  
    ViewData["Title"] = "Editar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-12 col-lg-4\">\r\n        <div class=\"card p-3 bloque\">\r\n            <div class=\"card-body \">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6195fde6c33635b15d54808e897235f433050d2c4649", async() => {
                WriteLiteral(@"
                    <h1 class=""text-center pb-4"" id=""white"">Editar</h1>

                    <div class=""form-group"">
                        <label for=""usuario"">Usuario</label>
                        <input type=""text"" class=""form-control"" name=""usuario"" id=""usuario""
                               placeholder=""Ingrese su usuario""");
                BeginWriteAttribute("value", " value=\"", 617, "\"", 625, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>

                    <div class=""form-group"">
                        <label for=""password"">Contraseña actual</label>
                        <input type=""password"" class=""form-control"" name=""password"" id=""password""
                               placeholder=""**********""");
                BeginWriteAttribute("value", " value=\"", 932, "\"", 940, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>

                    <div class=""form-group"">
                        <label for=""password"">Nueva ontraseña</label>
                        <input type=""password"" class=""form-control"" name=""password2"" id=""password2""
                               placeholder=""**********""");
                BeginWriteAttribute("value", " value=\"", 1247, "\"", 1255, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                \r\n                        <input type=\"hidden\" id=\"userBase\" name=\"userBase\"");
                BeginWriteAttribute("value", " value=", 1379, "", 1411, 1);
#nullable restore
#line 30 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml"
WriteAttributeValue("", 1386, ViewBag.usuario.username, 1386, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" runat=\"server\" />\r\n                    <button type=\"submit\" class=\"btn btn-block btn-primary\">Editar</button>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml"
                     if (ViewBag.usuario != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p><b>");
#nullable restore
#line 35 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml"
                         Write(ViewBag.usuario.username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n");
#nullable restore
#line 36 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Editar.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6195fde6c33635b15d54808e897235f433050d2c9592", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Eliminar Usuario</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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