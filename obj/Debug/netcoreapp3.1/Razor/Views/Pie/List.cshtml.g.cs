#pragma checksum "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d7cbf0258a3a719cf2ebff690e62e345a11255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\_ViewImports.cshtml"
using BethenyPieShop2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d7cbf0258a3a719cf2ebff690e62e345a11255", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a411483857d39ea122b5f68583baad3fc94d11c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 3 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 4 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
     foreach (var pie in Model.Pies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 192, "\"", 220, 1);
#nullable restore
#line 7 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
WriteAttributeValue("", 198, pie.ImageThumbnailUrl, 198, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 221, "\"", 227, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
#nullable restore
#line 9 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
                              Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
#nullable restore
#line 11 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
              Write(pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
#nullable restore
#line 13 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
          Write(pie.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\joaon\source\repos\BethenyPieShop2\Views\Pie\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
