#pragma checksum "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c449294f3ff63630e31ba584b89254380527748a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Details), @"mvc.1.0.view", @"/Views/Contact/Details.cshtml")]
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
#line 1 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c449294f3ff63630e31ba584b89254380527748a", @"/Views/Contact/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8551b5dae28ff9339a4141943a5cb3e10f5e1c48", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/phoneMask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/emailValidation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""body-center"">
    <div class=""container-box"">
        <div class=""title-form"">
            Detalhes do contato.
        </div>
            <div class=""form-details"">
                <div class=""input-box"">
                    <span class=""details"">
                        ");
#nullable restore
#line 15 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(itemModel => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 16 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(itemModel => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span> \r\n                </div>\r\n\r\n                <div class=\"input-box\">\r\n                    <span class=\"details\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(itemModel => Model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 23 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(itemModel => Model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"input-box\">\r\n                    <span class=\"details\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(itemModel => Model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 29 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(itemModel => Model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"input-box\">\r\n                    <span class=\"details\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(itemModel => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 35 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(itemModel => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"input-box\">\r\n                    <span class=\"details\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(itemModel => Model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 41 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(itemModel => Model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            <div class=\"button\">\r\n                <input type=\"button\" class=\"back-button\" value=\"Voltar para lista\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1807, "\"", 1885, 2);
#nullable restore
#line 45 "C:\Users\Gabriel-PC\Documents\ProjetosVS\WebAgenda\WebAgenda\Views\Contact\Details.cshtml"
WriteAttributeValue("", 1817, "window.location.href='" + @Url.Action("Index", "Contact") + "'", 1817, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1884, ";", 1884, 1, true);
            EndWriteAttribute();
            WriteLiteral("  />\r\n            </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c449294f3ff63630e31ba584b89254380527748a9055", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c449294f3ff63630e31ba584b89254380527748a10154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
