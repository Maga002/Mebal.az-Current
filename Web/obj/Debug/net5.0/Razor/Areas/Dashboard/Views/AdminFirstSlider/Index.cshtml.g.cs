#pragma checksum "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579d9dc6181e796d6ddc0d933d2e6110b07f8436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_AdminFirstSlider_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/AdminFirstSlider/Index.cshtml")]
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
#line 1 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579d9dc6181e796d6ddc0d933d2e6110b07f8436", @"/Areas/Dashboard/Views/AdminFirstSlider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5fab7f34fa74bd3f422dc62d52db857f06bb53", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_AdminFirstSlider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstSlider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-sorter-wrapper col-lg-12 table-responsive"">
    <table id=""sortable-table-2"" class=""table table-striped"">
        <thead>
            <tr>
                <th>#</th>
                <th class=""sortStyle"">PhotoUrl<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle"">Top-Header<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle"">Middle-Header<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle"">Description<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle"">ButtonText<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle"">SlideAdv<i class=""mdi mdi-chevron-down""></i></th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579d9dc6181e796d6ddc0d933d2e6110b07f84365807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1000, "~/uploads/", 1000, 10, true);
#nullable restore
#line 25 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
AddHtmlAttributeValue("", 1010, item.PhotoURL, 1010, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.TopHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.SlideDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.SlideButton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
               Write(item.SlideAdv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1279, "\"", 1327, 2);
            WriteAttributeValue("", 1286, "/Dashboard/AdminFirstSlider/Edit/", 1286, 33, true);
#nullable restore
#line 31 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
WriteAttributeValue("", 1319, item.ID, 1319, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Areas\Dashboard\Views\AdminFirstSlider\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstSlider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
