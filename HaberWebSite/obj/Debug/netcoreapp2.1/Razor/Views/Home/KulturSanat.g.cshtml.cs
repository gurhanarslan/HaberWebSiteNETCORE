#pragma checksum "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd1b20fd7ee7eecce12a842ff795864f06da9f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_KulturSanat), @"mvc.1.0.view", @"/Views/Home/KulturSanat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/KulturSanat.cshtml", typeof(AspNetCore.Views_Home_KulturSanat))]
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
#line 1 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\_ViewImports.cshtml"
using HaberWebSite;

#line default
#line hidden
#line 2 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\_ViewImports.cshtml"
using HaberWebSite.Models;

#line default
#line hidden
#line 3 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\_ViewImports.cshtml"
using HaberWebSite.Models.EfCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd1b20fd7ee7eecce12a842ff795864f06da9f2", @"/Views/Home/KulturSanat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b9de70d9544f15ada162a6622735d3fce2ab03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_KulturSanat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
  
    ViewData["Title"] = "Kültür Sanat";

#line default
#line hidden
            BeginContext(74, 385, true);
            WriteLiteral(@"
<div class=""container "" id=""ability"">

    <div class=""row"">






        <div class=""GuncelHaberler container-fluid text-center mt-4 "">
            <span class=""header h3 bg-warning text-white rounded px-4 pt-2"">Kültür-Sanat</span>
            <div class=""border-bottom"" style=""border-bottom: 4px solid #ffc107 !important;""></div>
            <div class=""row mt-4"">

");
            EndContext();
#line 20 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(524, 158, true);
            WriteLiteral("                    <div class=\"col-12 col-md-6 col-lg-4 mt-3\">\r\n                        <div class=\"card\" style=\"width: 100%;\">\r\n                            ");
            EndContext();
            BeginContext(682, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77ddce4676084ecaab5a493cca599dda", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 692, "~/img/", 692, 6, true);
#line 24 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
AddHtmlAttributeValue("", 698, item.Image, 698, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(742, 134, true);
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(877, 17, false);
#line 26 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
                                                                          Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(894, 105, true);
            WriteLiteral("</small></p>\r\n                                <p class=\"card-text\">\r\n                                    ");
            EndContext();
            BeginContext(1000, 20, false);
#line 28 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
                               Write(item.NewsDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 130, true);
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"card-text clock\"><small class=\"text-muted mx-2\">");
            EndContext();
            BeginContext(1151, 13, false);
#line 30 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
                                                                                     Write(item.NewsTime);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 110, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 34 "C:\Users\gurhan\source\repos\HaberWebSite\HaberWebSite\Views\Home\KulturSanat.cshtml"
                }

#line default
#line hidden
            BeginContext(1293, 78, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n        <hr />\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
