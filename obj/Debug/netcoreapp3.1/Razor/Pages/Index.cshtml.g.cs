#pragma checksum "/Users/satouyuuki/Practice/c#/practices/LetsDotNet/LetsDotNet/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1225ee033a023a81e7f25c8a168a56a012271251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LetsDotNet.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LetsDotNet.Pages
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
#line 1 "/Users/satouyuuki/Practice/c#/practices/LetsDotNet/LetsDotNet/Pages/_ViewImports.cshtml"
using LetsDotNet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225ee033a023a81e7f25c8a168a56a012271251", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b009d33520935cbd8cb89a66db2b10c7a8b6ec19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/satouyuuki/Practice/c#/practices/LetsDotNet/LetsDotNet/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n    <p>The application is running on ");
#nullable restore
#line 10 "/Users/satouyuuki/Practice/c#/practices/LetsDotNet/LetsDotNet/Pages/Index.cshtml"
                                Write(Environment.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <img src=""https://sato-dot-net-s3-test.s3.ap-northeast-1.amazonaws.com/aws-logo.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIAXBIULASRZITJ55NF%2F20210625%2Fap-northeast-1%2Fs3%2Faws4_request&X-Amz-Date=20210625T143948Z&X-Amz-Expires=3600&X-Amz-SignedHeaders=host&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEFYaDmFwLW5vcnRoZWFzdC0xIkcwRQIhAJ3sUTjhDlKqAG8MP8VI%2FyqiWj8VszAIelWCH%2BmEcFy7AiAIrNVpgq7GaCbVOAs32tNL1icU6qfNJVbWu2bkYWxwxSqoAggvEAIaDDQ4Mzc2MzM1NjgzNSIMrrj1Z%2B4BoI8DyA74KoUCD1IUgaZzrzhICtwVcCAraELFqih751TMz%2FaJzpdklRbJBSivBq31wUB2fVlgGWpwLAKErIBLKpgzMdPQuwI5vU27JClbtkQ9SmKSsWpzhzTPs7U4o4Jx9Y%2BoGCLfSzSFwaC3x2%2F8wERQihJ6pKJTctju%2FKsl73H95BjwIzY2S%2FVMxM02JBB%2BHyJeH%2FMo%2FTMlGa6sau2Q7s8fLUDoO4D1YrSIqdI3OUnkmBIGyDvZHrN0X%2BPE3RU7cbhDfgyrb1Kp3mFC2U0mpYU60NXf9Ypj%2FGCWQONhvgtI2Q0gAayUQb9SX8hBtDKnc1dLEXWwT91UzOlSRm0%2BwCHjUZ2qk1hfg92CVpDHMLDK14YGOp0Bkhs9TWEACtd1SvtlOzD43kqI3ai3QVgaSvGFC3n7POsApOAbHwpfVGNM5IhjrCW%2Bu2YISimo%2FMWF6DJe6%2B8dwRZQYGVYmam2EJ8Dxdy64FA%2FcSlt9uG0NDoyfj7HQE6wGaJvUux");
            WriteLiteral("Y2GXqiHodhSDDqFKxJVa2FwhHia64s2BZSeE3U6OXIbRO9v9SGrvBK44pY%2Fwm7O1ikAXH2EfCkA%3D%3D&X-Amz-Signature=e4253a882eaf790f24b5fe1977c741c4a3b50c31acd04e5c8d7f6a0f35379d1c\" alt=\"aws?????????\" title=\"aws?????????\" style=\"width:50px;height:50px;\" />\n");
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
