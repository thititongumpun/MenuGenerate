#pragma checksum "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab7d55f7323bb0a538d6961f73e90109a84cf1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/_ViewImports.cshtml"
using FoodGenerate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/_ViewImports.cshtml"
using FoodGenerate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab7d55f7323bb0a538d6961f73e90109a84cf1c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc590b0fb336481358cd8685e77c6a212688f71c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodGenerate.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "DOGDOGDOGDOGDOGDOGDOGDOG";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome To RandomFoodForEveryday</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xl-4 col-md-6 col-sm-12 mt-4\">\r\n            ");
#nullable restore
#line 12 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-xl-4 col-md-6 col-sm-12 mt-4\">\r\n        ");
#nullable restore
#line 18 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
   Write(Html.DisplayFor(item => item.FoodName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
   Write(Html.DisplayFor(item => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n\r\n    <div class=\"span3 top1\">\r\n        <div class=\"row\">\r\n            <div class=\"span3 food1\">\r\n                <img class=\"card=img-top\"");
            BeginWriteAttribute("src", " src=\"", 742, "\"", 764, 1);
#nullable restore
#line 27 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
WriteAttributeValue("", 748, Model.ImageData, 748, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Food\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 842, "\"", 896, 3);
            WriteAttributeValue("", 852, "location.href=\'", 852, 15, true);
#nullable restore
#line 33 "/Users/Thiti/Desktop/HandOn/FoodGenerate/Views/Home/Index.cshtml"
WriteAttributeValue("", 867, Url.Action("Index", "Home"), 867, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 895, "\'", 895, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Click</button>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodGenerate.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
