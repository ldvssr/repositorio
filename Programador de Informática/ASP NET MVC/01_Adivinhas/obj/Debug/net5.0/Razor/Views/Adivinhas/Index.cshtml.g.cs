#pragma checksum "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429efdefd2119992cb99f58a6febde3e58296e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adivinhas_Index), @"mvc.1.0.view", @"/Views/Adivinhas/Index.cshtml")]
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
#line 1 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\_ViewImports.cshtml"
using _01_Adivinhas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\_ViewImports.cshtml"
using _01_Adivinhas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429efdefd2119992cb99f58a6febde3e58296e06", @"/Views/Adivinhas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197282776f5021469c31a412a33045b076d8875d", @"/Views/_ViewImports.cshtml")]
    public class Views_Adivinhas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_01_Adivinhas.Models.Adivinhas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
  
    ViewData["Title"] = "Adivinhas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Aqui encontra todas as adivinhas </h3>\r\n<h6>Caso saiba alguma outra, por favor adicione na nossa lista</h6>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429efdefd2119992cb99f58a6febde3e58296e063853", async() => {
                WriteLiteral("Inserir nova");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.pergunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.resposta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.pergunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.resposta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new {id=item.id}, htmlAttributes: new {@class = "btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 43 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
               Write(Html.ActionLink("Detalhes", "Details", new { id=item.id}, htmlAttributes: new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id=\"", 1475, "\"", 1488, 1);
#nullable restore
#line 45 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
WriteAttributeValue("", 1480, item.id, 1480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"Eliminar(this)\">Eliminar</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\repositorio\Programador de Informática\ASP NET MVC\01_Adivinhas\Views\Adivinhas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_01_Adivinhas.Models.Adivinhas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
