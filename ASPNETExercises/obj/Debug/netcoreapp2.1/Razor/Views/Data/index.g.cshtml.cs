#pragma checksum "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\Data\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c472ebf3283ef5dd584a6415ab126e922d0f48c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_index), @"mvc.1.0.view", @"/Views/Data/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/index.cshtml", typeof(AspNetCore.Views_Data_index))]
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
#line 1 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises;

#line default
#line hidden
#line 2 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises.Models;

#line default
#line hidden
#line 3 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNETExercises.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c472ebf3283ef5dd584a6415ab126e922d0f48c", @"/Views/Data/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376707906c8f66e85b1d886bfa461dfe94ec2992", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\Data\index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 23, true);
            WriteLiteral("<div class=\"m-4\">\r\n    ");
            EndContext();
            BeginContext(112, 17, false);
#line 6 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\Data\index.cshtml"
Write(ViewBag.LoadedMsg);

#line default
#line hidden
            EndContext();
            BeginContext(129, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
