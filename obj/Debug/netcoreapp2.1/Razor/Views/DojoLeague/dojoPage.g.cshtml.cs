#pragma checksum "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8704ba696420ce07511dc7bd4b7ff670bb37154b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoLeague_dojoPage), @"mvc.1.0.view", @"/Views/DojoLeague/dojoPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoLeague/dojoPage.cshtml", typeof(AspNetCore.Views_DojoLeague_dojoPage))]
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
#line 1 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/_ViewImports.cshtml"
using DojoLeague.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8704ba696420ce07511dc7bd4b7ff670bb37154b", @"/Views/DojoLeague/dojoPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0589cc4ec95946e4f3ceac49fd043578237229ab", @"/Views/_ViewImports.cshtml")]
    public class Views_DojoLeague_dojoPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 8, true);
            WriteLiteral("\n<title>");
            EndContext();
            BeginContext(25, 15, false);
#line 3 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
  Write(Model.dojo.name);

#line default
#line hidden
            EndContext();
            BeginContext(40, 18, true);
            WriteLiteral(" Dojo</title>\n<h3>");
            EndContext();
            BeginContext(59, 15, false);
#line 4 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
Write(Model.dojo.name);

#line default
#line hidden
            EndContext();
            BeginContext(74, 86, true);
            WriteLiteral("</h3>\n<hr>\n<h6 class=\"text-info\"> Location: <span class=\"font-weight-light text-dark\">");
            EndContext();
            BeginContext(161, 19, false);
#line 6 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                                                                      Write(Model.dojo.location);

#line default
#line hidden
            EndContext();
            BeginContext(180, 68, true);
            WriteLiteral("</span></h6>\n<h6> Dojo Information:<span class=\"font-weight-light\"> ");
            EndContext();
            BeginContext(249, 22, false);
#line 7 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                                                  Write(Model.dojo.description);

#line default
#line hidden
            EndContext();
            BeginContext(271, 354, true);
            WriteLiteral(@"</span></h6>
<hr>
<div class=""row mt-5"">
    <div class=""col-5"">
        <table class=""table table-striped "">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Ninja Name</th>
                    <th scope=""col"">Action</th>
                    
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                 foreach(var ninja in Model.dojo.ninjas)
                {

#line default
#line hidden
            BeginContext(700, 54, true);
            WriteLiteral("                    <tr>\n                        <td> ");
            EndContext();
            BeginContext(754, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d134f84f364e4bbdc7518b80241301", async() => {
                BeginContext(788, 10, false);
#line 23 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                                                         Write(ninja.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 763, "~/dojo/", 763, 7, true);
#line 23 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 770, ninja.ninja_id, 770, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(802, 35, true);
            WriteLiteral("</td>\n                        <td> ");
            EndContext();
            BeginContext(837, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df7bcd4e81c74caa8ebe6ccf72c4309f", async() => {
                BeginContext(929, 6, true);
                WriteLiteral("Banish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 846, "~/banish/", 846, 9, true);
#line 24 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 855, ninja.ninja_id, 855, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 870, "/", 870, 1, true);
#line 24 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 871, Model.dojo.dojo_id, 871, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(939, 33, true);
            WriteLiteral("</td>\n\n                    </tr>\n");
            EndContext();
#line 27 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                }

#line default
#line hidden
            BeginContext(990, 362, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-5"">
        <table class=""table table-striped "">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Ninja Name</th>
                    <th scope=""col"">Action</th>
                    
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 41 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                 foreach(var ninja in Model.RogueNinjas)
                {

#line default
#line hidden
            BeginContext(1427, 54, true);
            WriteLiteral("                    <tr>\n                        <td> ");
            EndContext();
            BeginContext(1481, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "998b4c0c1a854372a8681b22f8f3cbcd", async() => {
                BeginContext(1515, 10, false);
#line 44 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                                                         Write(ninja.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1490, "~/dojo/", 1490, 7, true);
#line 44 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 1497, ninja.ninja_id, 1497, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1529, 35, true);
            WriteLiteral("</td>\n                        <td> ");
            EndContext();
            BeginContext(1564, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27b3cd1852044c69fc0d6e2fe0dda0a", async() => {
                BeginContext(1659, 7, true);
                WriteLiteral("Recruit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1573, "~/recruit/", 1573, 10, true);
#line 45 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 1583, ninja.ninja_id, 1583, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1598, "/", 1598, 1, true);
#line 45 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
AddHtmlAttributeValue("", 1599, Model.dojo.dojo_id, 1599, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1670, 33, true);
            WriteLiteral("</td>\n\n                    </tr>\n");
            EndContext();
#line 48 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoLeague/Views/DojoLeague/dojoPage.cshtml"
                }

#line default
#line hidden
            BeginContext(1721, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
