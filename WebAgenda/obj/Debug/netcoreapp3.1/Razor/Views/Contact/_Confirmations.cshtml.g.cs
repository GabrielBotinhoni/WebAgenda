#pragma checksum "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f2dfaea01061edce9847506f08ffbad3daab76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact__Confirmations), @"mvc.1.0.view", @"/Views/Contact/_Confirmations.cshtml")]
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
#line 1 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\_ViewImports.cshtml"
using WebAgenda.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f2dfaea01061edce9847506f08ffbad3daab76", @"/Views/Contact/_Confirmations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8551b5dae28ff9339a4141943a5cb3e10f5e1c48", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact__Confirmations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\">X</button>\r\n        ");
#nullable restore
#line 5 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
   Write(Html.Raw(TempData["Success"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 7 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
 if (TempData["Danger"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\">X</button>\r\n        ");
#nullable restore
#line 13 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
   Write(Html.Raw(TempData["Danger"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\Gabriel-PC\source\repos\WebAgenda\WebAgenda\Views\Contact\_Confirmations.cshtml"
}

#line default
#line hidden
#nullable disable
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