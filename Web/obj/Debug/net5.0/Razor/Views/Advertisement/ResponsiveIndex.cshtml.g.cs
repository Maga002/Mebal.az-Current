#pragma checksum "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15eab570b56d6da9f22fc4aa6492e5bcbedd0947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisement_ResponsiveIndex), @"mvc.1.0.view", @"/Views/Advertisement/ResponsiveIndex.cshtml")]
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
#line 1 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15eab570b56d6da9f22fc4aa6492e5bcbedd0947", @"/Views/Advertisement/ResponsiveIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5fab7f34fa74bd3f422dc62d52db857f06bb53", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisement_ResponsiveIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchVM>
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
            WriteLiteral(@"
<section class=""filter-page"">
    <div class=""container"">

        <div class=""row "">
            <div class="" all-res-filter col-12 p-0 m-0"">

                <div class=""home-category-filter pt-3"">
                    <h3>Kateqoriyalar</h3>
                    <div class=""line""></div>

                    <ul>
                        <li>
                            <a href=""/advertisement"">Bütün elanlar</span></a>
                        </li>
");
#nullable restore
#line 17 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
                         foreach (var categ in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 608, "\"", 661, 1);
#nullable restore
#line 19 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
WriteAttributeValue("", 616, Model.CategoryID==categ.ID?"cat-active":"", 616, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 699, "\"", 817, 1);
#nullable restore
#line 20 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
WriteAttributeValue("", 706, Url.Action("index","advertisement", new {categoryID=categ.ID,sortBy=Model.SortBy,searchTerm=Model.SearchTerm}), 706, 111, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
                                                                                                                                                     Write(categ.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>(");
#nullable restore
#line 20 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
                                                                                                                                                                       Write(categ.Advertisements.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></a>\r\n                            </li>\r\n");
#nullable restore
#line 22 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                    <hr>

                </div>
                <div class=""home-price-filter"">
                    <h3>Qiymət</h3>
                    <div class=""line""></div>
                    <div class=""panel"">
                        <div class=""price-slider mt-2 "">
                            <span class=""d-flex justify-content-between align-items-center"">
                                <input class=""mr-1"" type=""number"" value=""0"" min=""0"" max=""15000"" /><div class=""tre""></div>
                                <input class=""ml-1"" type=""number"" value=""15000"" min=""0"" max=""15000"" />
                            </span>
                            <div class="" aabd d-flex p-0 mt-3 justify-content-between"">

                                <input class=""mr-1"" value=""0"" min=""0"" max=""15000"" step=""10"" type=""range"" />
                                <input class="" ml-1"" value=""15000"" min=""0"" max=""15000"" step=""10"" type=""range"" />
                            </div>

    ");
            WriteLiteral(@"                        <svg width=""100%"" height=""24""></svg>
                        </div>
                    </div>
                    <hr>
                </div>
                <div class=""home-color-filter"">
                    <h3>Rəng</h3>
                    <div class=""line mb-2""></div>
                    <ul>
                        <li>
                            <button class=""color1""></button>
                            <a href=""#"">
                                Qara
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 2523, "\"", 2530, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2531, "\"", 2536, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>

                            </a>

                            </a>
                        </li>
                        <li>
                            <button class=""color2""></button>
                            <a href=""#"">
                                Krem
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 2903, "\"", 2910, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2911, "\"", 2916, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>

                            </a>

                            </a>
                        </li>
                        <li>
                            <button class=""color3""></button>
                            <a href=""#"">
                                Qızılı
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 3285, "\"", 3292, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3293, "\"", 3298, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>

                            </a>
                        </li>
                        <li>
                            <button class=""color4""></button>
                            <a href=""#"">
                                Gümüşü
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 3631, "\"", 3638, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3639, "\"", 3644, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>

                            </a>
                        </li>
                        <li>
                            <button class=""color5""></button>
                            <a href=""#"">
                                Qəhvəyi
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 3978, "\"", 3985, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3986, "\"", 3991, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>

                            </a>
                            </a>
                        </li>
                    </ul>
                    <hr>

                </div>
                <div class=""home-marka-filter"">
                    <h3>Marka və sexlər</h3>
                    <div class=""line mb-2""></div>
                    <ul>
                        <li>
                            <a href=""#"">
                                Embawood
                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 4549, "\"", 4556, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4557, "\"", 4562, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Madeyra\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 4798, "\"", 4805, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4806, "\"", 4811, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Bellona\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 5047, "\"", 5054, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5055, "\"", 5060, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Saloglu\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 5296, "\"", 5303, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5304, "\"", 5309, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Kilim\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 5543, "\"", 5550, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5551, "\"", 5556, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Istikbal\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 5793, "\"", 5800, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5801, "\"", 5806, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                Damla\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 6040, "\"", 6047, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6048, "\"", 6053, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
        </div>
    </div>
</section>
<button  class=""detail-button"">Axtar</button>
<section class=""Marka-slider"">
        <div class=""mmm"">
");
#nullable restore
#line 161 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
             foreach (var brand in Model.Brands)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mark\">\r\n                    <div class=\"col-3\">\r\n                        <a href=\"#\"></a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15eab570b56d6da9f22fc4aa6492e5bcbedd094715677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6559, "~/Img/", 6559, 6, true);
#nullable restore
#line 166 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
AddHtmlAttributeValue("", 6565, brand.BrandURL, 6565, 15, false);

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
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 170 "C:\Users\acer\Desktop\Code\Mebelan.az - backup\Web\Views\Advertisement\ResponsiveIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
