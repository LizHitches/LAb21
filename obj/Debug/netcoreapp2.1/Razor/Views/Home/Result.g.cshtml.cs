#pragma checksum "C:\Users\Eliza\Desktop\MVC Project\FirstMVCapp\FirstMVCapp\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b74abbef2a1c7d95b9e7ee47e5f2526380f814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\Eliza\Desktop\MVC Project\FirstMVCapp\FirstMVCapp\Views\_ViewImports.cshtml"
using FirstMVCapp;

#line default
#line hidden
#line 2 "C:\Users\Eliza\Desktop\MVC Project\FirstMVCapp\FirstMVCapp\Views\_ViewImports.cshtml"
using FirstMVCapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b74abbef2a1c7d95b9e7ee47e5f2526380f814", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4246ae0541dd7a623522eb9148bedb4c30fb5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("<h2>Hello ");
            EndContext();
            BeginContext(11, 12, false);
#line 1 "C:\Users\Eliza\Desktop\MVC Project\FirstMVCapp\FirstMVCapp\Views\Home\Result.cshtml"
     Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(23, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
