#pragma checksum "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dffc3f132c704572e074ba7443fcd424405c4cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuItem_Index), @"mvc.1.0.view", @"/Views/MenuItem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MenuItem/Index.cshtml", typeof(AspNetCore.Views_MenuItem_Index))]
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
#line 4 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises.Utils;

#line default
#line hidden
#line 5 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dffc3f132c704572e074ba7443fcd424405c4cb3", @"/Views/MenuItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6d8450458aa9fdfd75e728caa75efa164f542b", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 24, true);
            WriteLiteral("<h4>Items In Category - ");
            EndContext();
            BeginContext(92, 18, false);
#line 5 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml"
                   Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 51, true);
            WriteLiteral("</h4>\r\n<ul class=\"list-group col-sm-8 col-xs-12\">\r\n");
            EndContext();
#line 7 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml"
      
        foreach (MenuItem item in Model.MenuItems)
        {

#line default
#line hidden
            BeginContext(232, 58, true);
            WriteLiteral("            <li class=\"list-group-item\">\r\n                ");
            EndContext();
            BeginContext(291, 16, false);
#line 11 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(307, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 13 "C:\Users\Phuc-pc\source\repos\ASPNetExercises\ASPNETExercises\Views\MenuItem\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(346, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
