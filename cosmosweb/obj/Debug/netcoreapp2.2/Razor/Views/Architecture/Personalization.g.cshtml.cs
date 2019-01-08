#pragma checksum "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faceb47ae68a2a16d10a3364457a6c0df0793060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Architecture_Personalization), @"mvc.1.0.view", @"/Views/Architecture/Personalization.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Architecture/Personalization.cshtml", typeof(AspNetCore.Views_Architecture_Personalization))]
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
#line 1 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\_ViewImports.cshtml"
using cosmosweb;

#line default
#line hidden
#line 2 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\_ViewImports.cshtml"
using cosmosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faceb47ae68a2a16d10a3364457a6c0df0793060", @"/Views/Architecture/Personalization.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b570625ab4198905b668571c83eea864321a5c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Architecture_Personalization : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/architecture/personalization.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("presentation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-responsive-center img-responsive-swimlane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://docs.microsoft.com/azure/architecture/reference-architectures/serverless/_images/serverless-web-app.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/shared/swimlane-create-your-own-extension.svg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
  
    ViewData["Title"] = "Personalization Architecture Guidance";
    ViewData["Description"] = "Learn how to architect personalization and recommendation applications with Cosmos DB.";
    var swimLaneHelper = new cosmosweb.Helpers.SwimLaneHelper();

#line default
#line hidden
            BeginContext(262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(281, 61, true);
                WriteLiteral("\r\n    <h1>Recommendation engines architecture guidance</h1>\r\n");
                EndContext();
            }
            );
            BeginContext(345, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 351, "\"", 396, 1);
#line 12 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 359, swimLaneHelper.GetSwimLaneCssClass(), 359, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 490, "\"", 539, 1);
#line 15 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 498, swimLaneHelper.GetIllustrationCssClass(), 498, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(559, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "faceb47ae68a2a16d10a3364457a6c0df07930607487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 16 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(736, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 774, "\"", 818, 1);
#line 18 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 782, swimLaneHelper.GetContentCssClass(), 782, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(819, 297, true);
            WriteLiteral(@">
                <h2>Personalized recommendation applications</h2>
                <p>Generate personalized recommendations for customers in real time, using low-latency and tunable consistency settings for immediate insights.</p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1116, "\"", 1161, 1);
#line 26 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 1124, swimLaneHelper.GetSwimLaneCssClass(), 1124, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1162, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1255, "\"", 1304, 1);
#line 29 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 1263, swimLaneHelper.GetIllustrationCssClass(), 1263, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1305, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1324, 247, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "faceb47ae68a2a16d10a3364457a6c0df079306011511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 30 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1571, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1609, "\"", 1653, 1);
#line 32 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 1617, swimLaneHelper.GetContentCssClass(), 1617, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1654, 559, true);
            WriteLiteral(@">
                <h2>Build a real-time recommendation API on Azure</h2>
                <p>This reference architecture shows how to train a recommendation model using Azure Databricks and deploy it as an API by using Azure Cosmos DB and includes a reference implementation on GitHub</p>
                <p><a href=""https://docs.microsoft.com/azure/architecture/reference-architectures/ai/real-time-recommendation"" target=""_blank"" class=""btn btn-default"">Read more and deploy solution</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2213, "\"", 2258, 1);
#line 41 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 2221, swimLaneHelper.GetSwimLaneCssClass(), 2221, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2259, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2352, "\"", 2401, 1);
#line 44 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 2360, swimLaneHelper.GetIllustrationCssClass(), 2360, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2402, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2421, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "faceb47ae68a2a16d10a3364457a6c0df079306015521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 45 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2611, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2649, "\"", 2693, 1);
#line 47 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
WriteAttributeValue("", 2657, swimLaneHelper.GetContentCssClass(), 2657, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2694, 564, true);
            WriteLiteral(@">
                <h2>Additional Resources</h2>
                <p>To learn more about building personaled recommendation applications in Cosmos DB, check out these resources.</p>
                <ul>
                    <li><a href=""https://docs.microsoft.com/azure/cosmos-db/change-feed"">Change feed in Azure Cosmos DB</a></li>
                    <li><a href=""https://github.com/Azure/azure-documentdb-changefeedprocessor-dotnet"">Change Feed Processor library (v2)</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
#line 59 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Architecture\Personalization.cshtml"
   await Html.RenderPartialAsync("_TryCosmos"); 

#line default
#line hidden
            BeginContext(3309, 2, true);
            WriteLiteral("\r\n");
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
