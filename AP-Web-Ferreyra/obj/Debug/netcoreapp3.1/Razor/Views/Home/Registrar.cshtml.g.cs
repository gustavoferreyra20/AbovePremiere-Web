#pragma checksum "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae3848ad4f8e9722a672e6b30ed099e8ea9491d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registrar), @"mvc.1.0.view", @"/Views/Home/Registrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae3848ad4f8e9722a672e6b30ed099e8ea9491d", @"/Views/Home/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52917c82f1dc7bfb902364a0757a4b014703f26f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml"
  
    ViewData["Title"] = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-12 col-lg-4\">\r\n        <div class=\"card p-3 bloque\">\r\n            <div class=\"card-body \">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cae3848ad4f8e9722a672e6b30ed099e8ea9491d4673", async() => {
                WriteLiteral(@"
                    <h1 class=""text-center pb-4"" id=""white"">Registrar</h1>

                    <div class=""form-group"">
                        <label for=""usuario"">Usuario</label>
                        <input type=""text"" class=""form-control"" name=""usuario"" id=""usuario""
                               placeholder=""Ingrese su usuario""");
                BeginWriteAttribute("value", " value=\"", 626, "\"", 634, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                    </div>

                    <div class=""form-group"">
                        <label for=""password"">Contraseña</label>
                        <input type=""password"" class=""form-control"" name=""password"" id=""password""
                               placeholder=""**********""");
                BeginWriteAttribute("value", " value=\"", 943, "\"", 951, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                    </div>\r\n\r\n                    <input type=\"hidden\" id=\"id_pass\" name=\"id_pass\"");
                BeginWriteAttribute("value", " value=", 1062, "", 1084, 1);
#nullable restore
#line 24 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml"
WriteAttributeValue("", 1069, ViewBag.idPass, 1069, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" runat=\"server\" />\r\n                    <button type=\"submit\" class=\"btn btn-block btn-primary\">Registrar</button>\r\n\r\n                ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml"
                 if (ViewBag.msg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p><b>");
#nullable restore
#line 30 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml"
                     Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n");
#nullable restore
#line 31 "C:\Users\ferre\Desktop\Davinci\Plataformas de desarrollo\AP-Web-Ferreyra\AP-Web-Ferreyra\Views\Home\Registrar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
