#pragma checksum "C:\Users\ADURAMIMO\source\repos\CalculatorWeb\Views\calc\show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f0945759a5b4b6c11cfbc917a5220a8899556d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_calc_show), @"mvc.1.0.view", @"/Views/calc/show.cshtml")]
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
#line 1 "C:\Users\ADURAMIMO\source\repos\CalculatorWeb\Views\_ViewImports.cshtml"
using CalculatorWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADURAMIMO\source\repos\CalculatorWeb\Views\_ViewImports.cshtml"
using CalculatorWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f0945759a5b4b6c11cfbc917a5220a8899556d", @"/Views/calc/show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c0af211802ea319c8f0a82097c5ffcc6b759f7", @"/Views/_ViewImports.cshtml")]
    public class Views_calc_show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ADURAMIMO\source\repos\CalculatorWeb\Views\calc\show.cshtml"
  
        if(ViewBag.Result != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span> <p> Your result is : ViewBag.Result</p></span>\r\n");
#nullable restore
#line 4 "C:\Users\ADURAMIMO\source\repos\CalculatorWeb\Views\calc\show.cshtml"
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
