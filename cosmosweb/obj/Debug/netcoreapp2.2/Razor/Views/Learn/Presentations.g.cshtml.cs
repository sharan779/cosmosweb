#pragma checksum "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843c2f820b9b959a06a2c1e256cfd0aa38f6c07a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Learn_Presentations), @"mvc.1.0.view", @"/Views/Learn/Presentations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Learn/Presentations.cshtml", typeof(AspNetCore.Views_Learn_Presentations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843c2f820b9b959a06a2c1e256cfd0aa38f6c07a", @"/Views/Learn/Presentations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b570625ab4198905b668571c83eea864321a5c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Learn_Presentations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/learn/microsoft-ignite-logo.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("presentation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-responsive-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/illustrations/screen.svg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/illustrations/screen-blue-image.svg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
  
    ViewData["Title"] = "Azure Cosmos DB Presentations";
    ViewData["Description"] = "Azure Cosmos DB presentations to customers.";

    var swimLaneHelper = new cosmosweb.Helpers.SwimLaneHelper();

#line default
#line hidden
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(230, 46, true);
                WriteLiteral("\r\n    <h1>Azure Cosmos DB Presentations</h1>\r\n");
                EndContext();
            }
            );
            BeginContext(279, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 285, "\"", 330, 1);
#line 12 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 293, swimLaneHelper.GetSwimLaneCssClass(), 293, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(331, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 424, "\"", 473, 1);
#line 15 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 432, swimLaneHelper.GetIllustrationCssClass(), 432, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(474, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(493, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "843c2f820b9b959a06a2c1e256cfd0aa38f6c07a7119", async() => {
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
#line 16 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
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
            BeginContext(645, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 683, "\"", 727, 1);
#line 18 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 691, swimLaneHelper.GetContentCssClass(), 691, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(728, 2252, true);
            WriteLiteral(@">
                <h2>Ignite 2018</h2>
                <p>Watch our latest presentations at Ignite 2018 and download the decks.</p>
                <ul>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65366"" target=""_blank"">Technical overview of Azure Cosmos DB</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65927"" target=""_blank"">Modeling data and best practices for the Azure Cosmos DB SQL API</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65367"" target=""_blank"">Lambda architecture simplified with Azure Cosmos DB and Azure Databricks</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65368"" target=""_blank"">Event driven architecture with Azure Functions and Azure Cosmos DB</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65369"" target=""_blank"">How to migrate existing MongoDB an");
            WriteLiteral(@"d Cassandra apps to Azure Cosmos DB</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65370"" target=""_blank"">Advanced Azure Cosmos DB: Design patterns, tips, and tricks</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65923"" target=""_blank"">Multi-master at global scale with Azure Cosmos DB</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65371"" target=""_blank"">Azure Cosmos DB for enterprise: Security, compliance, and GDPR</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65924"" target=""_blank"">Building massively scalable IoT data pipelines with Azure Cosmos DB</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.com/sessions/65925"" target=""_blank"">Traversing Scalable Graphs with Azure Cosmos DB's Gremlin API</a></li>
                    <li><a href=""https://myignite.techcommunity.microsoft.c");
            WriteLiteral("om/sessions/65922\" target=\"_blank\">Common data problems solved with graphs using Azure Cosmos DB Gremlin API</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2980, "\"", 3025, 1);
#line 39 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 2988, swimLaneHelper.GetSwimLaneCssClass(), 2988, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3026, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3119, "\"", 3168, 1);
#line 42 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 3127, swimLaneHelper.GetIllustrationCssClass(), 3127, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3169, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(3188, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "843c2f820b9b959a06a2c1e256cfd0aa38f6c07a13184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 43 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
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
            BeginContext(3333, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3371, "\"", 3415, 1);
#line 45 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 3379, swimLaneHelper.GetContentCssClass(), 3379, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3416, 1246, true);
            WriteLiteral(@">
                <h2>Customer Presentations</h2>
                <p>Download and view our latest customer Powerpoint presentations.</p>
                <ul>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/blob/master/decks/CosmosDB-briefing.pptx?raw=true"" target=""_blank"">Azure Cosmos DB Overview Briefing</a></li>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/blob/master/decks/Azure%20Cosmos%20DB%20+%20Analytics.pptx?raw=true"" target=""_blank"">Azure Cosmos DB + Analytics</a></li>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/blob/master/decks/Azure%20Cosmos%20DB%20L400%20tech%20Deck_06282018.PPTX?raw=true"" target=""_blank"">Azure Cosmos DB - Level 400 Deep Dive</a></li>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/blob/master/decks/Azure%20Cosmos%20DB_Nov2018.pptx?raw=true"" target=""_blank"">Azure Cosmos DB - Deep Dive</a></li>
                    <li><a href=""https://github.com/AzureCosmo");
            WriteLiteral("sDB/fileshare/blob/master/decks/Azure%20CosmosDB%20Security.pptx?raw=true\" target=\"_blank\">Azure Cosmos DB - Security Overview</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4662, "\"", 4707, 1);
#line 60 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 4670, swimLaneHelper.GetSwimLaneCssClass(), 4670, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4708, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4801, "\"", 4850, 1);
#line 63 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 4809, swimLaneHelper.GetIllustrationCssClass(), 4809, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4851, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(4870, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "843c2f820b9b959a06a2c1e256cfd0aa38f6c07a18194", async() => {
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
#line 64 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
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
            BeginContext(5026, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5064, "\"", 5108, 1);
#line 66 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
WriteAttributeValue("", 5072, swimLaneHelper.GetContentCssClass(), 5072, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5109, 766, true);
            WriteLiteral(@">
                <h2>Flyers</h2>
                <p>Download and view or print these helpful flyers</p>
                <ul>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/raw/master/flyers/azure_cosmos_db_cheat%20sheet.pdf"" target=""_blank"">Azure Cosmos DB Cheat Sheet</a></li>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/raw/master/flyers/azure_cosmos_db_change%20feed.pdf"" target=""_blank"">Azure Cosmos DB Change Feed Support</a></li>
                    <li><a href=""https://github.com/AzureCosmosDB/fileshare/raw/master/flyers/azure_cosmos_db_flyer.pdf"" target=""_blank"">Azure Cosmos DB Features Overview</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
#line 79 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Learn\Presentations.cshtml"
   await Html.RenderPartialAsync("_TryCosmos"); 

#line default
#line hidden
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
