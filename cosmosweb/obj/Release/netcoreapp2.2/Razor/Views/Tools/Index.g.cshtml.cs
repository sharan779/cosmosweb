#pragma checksum "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0622699f2b1ec85168c4ea0e83885607f491bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Index), @"mvc.1.0.view", @"/Views/Tools/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tools/Index.cshtml", typeof(AspNetCore.Views_Tools_Index))]
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
using cosmoswebsite;

#line default
#line hidden
#line 2 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\_ViewImports.cshtml"
using cosmoswebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0622699f2b1ec85168c4ea0e83885607f491bb", @"/Views/Tools/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91534d0c164582450b0f6fa59c1880ad71e552fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/shared/cosmosdb_darktheme.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("presentation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-responsive-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/shared/swimlane-wpf.svg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/tools/vscode.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/tools/storageexplorer.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/shared/lift-shift.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
    ViewData["Title"] = "Azure Cosmos DB Tools";
    ViewData["Description"] = "Explore and downloead tools for Azure Cosmos DB.";

    var swimLaneHelper = new cosmoswebsite.Helpers.SwimLaneHelper();

#line default
#line hidden
            BeginContext(288, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(307, 38, true);
                WriteLiteral("\r\n    <h1>Azure Cosmos DB Tools</h1>\r\n");
                EndContext();
            }
            );
            BeginContext(348, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 354, "\"", 399, 1);
#line 13 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 362, swimLaneHelper.GetSwimLaneCssClass(), 362, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 493, "\"", 542, 1);
#line 16 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 501, swimLaneHelper.GetIllustrationCssClass(), 501, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(543, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(562, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb7654", async() => {
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
#line 17 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(712, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 750, "\"", 794, 1);
#line 19 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 758, swimLaneHelper.GetContentCssClass(), 758, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(795, 642, true);
            WriteLiteral(@">
                <h2>Cosmos DB Emulator</h2>
                <p>
                    The Azure Cosmos DB Emulator provides a local environment that emulates the Azure Cosmos DB service for development purposes.
                    Using the Azure Cosmos DB Emulator, you can develop and test your application locally, without creating an Azure subscription or incurring any costs.
                </p>
                <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/en-us/azure/cosmos-db/local-emulator"" role=""button"">Learn about Cosmos DB Emulator</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1437, "\"", 1482, 1);
#line 31 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1445, swimLaneHelper.GetSwimLaneCssClass(), 1445, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1483, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1576, "\"", 1625, 1);
#line 34 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1584, swimLaneHelper.GetIllustrationCssClass(), 1584, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1626, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1645, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb11961", async() => {
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
#line 35 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(1789, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1827, "\"", 1871, 1);
#line 37 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1835, swimLaneHelper.GetContentCssClass(), 1835, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1872, 577, true);
            WriteLiteral(@">
                <h2>Data Explorer</h2>
                <p>
                    Data Explorer, now in preview, provides a rich and unified developer experience for inserting, querying, and managing Azure
                    Cosmos DB data within the Azure portal and the Emulator.
                </p>
                <p><a class=""btn btn-default"" href=""https://azure.microsoft.com/updates/documentdb-data-explorer-preview-now-available-in-the-azure-portal/"" role=""button"">Learn about Data Explorer</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2449, "\"", 2494, 1);
#line 49 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 2457, swimLaneHelper.GetSwimLaneCssClass(), 2457, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2495, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2588, "\"", 2637, 1);
#line 52 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 2596, swimLaneHelper.GetIllustrationCssClass(), 2596, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2638, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2657, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb16210", async() => {
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
#line 53 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(2794, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2832, "\"", 2876, 1);
#line 55 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 2840, swimLaneHelper.GetContentCssClass(), 2840, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2877, 442, true);
            WriteLiteral(@">
                <h2>Azure Cosmos DB extension for VS Code</h2>
                <p>
                    Get rich intellisense and other capabilities for Cosmos DB.
                </p>
                <p><a class=""btn btn-default"" href=""https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-cosmosdb"" role=""button"">Download the VS Code Extension</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3319, "\"", 3364, 1);
#line 66 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 3327, swimLaneHelper.GetSwimLaneCssClass(), 3327, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3365, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3458, "\"", 3507, 1);
#line 69 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 3466, swimLaneHelper.GetIllustrationCssClass(), 3466, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3508, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(3527, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb20324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 70 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(3673, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3711, "\"", 3755, 1);
#line 72 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 3719, swimLaneHelper.GetContentCssClass(), 3719, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3756, 578, true);
            WriteLiteral(@">
                <h2>Azure Storage Explorer</h2>
                <p>
                    Using Azure Cosmos DB in Azure Storage Explorer enables users to manage Azure Cosmos DB entities, manipulate data,
                    update stored procedures and triggers along with other Azure entities like Storage blobs and queues.
                </p>
                <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/storage-explorer"" role=""button"">Get Azure Storage Explorer</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4334, "\"", 4379, 1);
#line 84 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 4342, swimLaneHelper.GetSwimLaneCssClass(), 4342, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4380, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4473, "\"", 4522, 1);
#line 87 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 4481, swimLaneHelper.GetIllustrationCssClass(), 4481, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4523, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(4542, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb24574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 88 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(4684, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4722, "\"", 4766, 1);
#line 90 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 4730, swimLaneHelper.GetContentCssClass(), 4730, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4767, 417, true);
            WriteLiteral(@">
                <h2>Azure Database Migration Guide</h2>
                <p>Step-by-step guidance for and tools for migrating Mongo DB and Cassandra databases and Azure Table storage to Cosmos DB.</p>
                <p><a class=""btn btn-default"" href=""https://datamigration.microsoft.com/"" role=""button"">Learn about Database Migration Guide</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5184, "\"", 5229, 1);
#line 99 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 5192, swimLaneHelper.GetSwimLaneCssClass(), 5192, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5230, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5323, "\"", 5372, 1);
#line 102 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 5331, swimLaneHelper.GetIllustrationCssClass(), 5331, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5373, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(5392, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb28664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 103 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(5534, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5572, "\"", 5616, 1);
#line 105 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 5580, swimLaneHelper.GetContentCssClass(), 5580, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5617, 544, true);
            WriteLiteral(@">
                <h2>Data Migration Tool</h2>
                <p>The Azure Cosmos DB Data Migration tool, can import data from various sources into Azure Cosmos DB containers. You can import from JSON files, CSV files, SQL, MongoDB, Azure Table storage, Amazon DynamoDB, and other Cosmos DB SQL API containers.</p>
                <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/import-data"" role=""button"">Learn about Data Migration Tool</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6161, "\"", 6206, 1);
#line 114 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 6169, swimLaneHelper.GetSwimLaneCssClass(), 6169, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6207, 93, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row vertical-align-sm\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6300, "\"", 6349, 1);
#line 117 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 6308, swimLaneHelper.GetIllustrationCssClass(), 6308, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6350, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(6369, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0622699f2b1ec85168c4ea0e83885607f491bb32884", async() => {
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
#line 118 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
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
            BeginContext(6519, 38, true);
            WriteLiteral("\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6557, "\"", 6601, 1);
#line 120 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 6565, swimLaneHelper.GetContentCssClass(), 6565, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6602, 649, true);
            WriteLiteral(@">
                <h2>Bulk Executor Library</h2>
                <p>
                    The bulk executor library allows you to perform bulk operations in Cosmos DB and significantly reduces the client-side compute resources needed to saturate the throughput allocated to a container.
                    Bulk Executor supports SQL API and also Gremlin (graph) import as well.
                </p>
                <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/en-us/azure/cosmos-db/bulk-executor-overview"" role=""button"">Learn about Bulk Executor Library</a></p>
            </div>
        </div>
    </div>
</div>

<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7251, "\"", 7296, 1);
#line 132 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
WriteAttributeValue("", 7259, swimLaneHelper.GetSwimLaneCssClass(), 7259, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7297, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 133 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
       await Html.RenderPartialAsync("_LearnMore"); 

#line default
#line hidden
            BeginContext(7355, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
#line 136 "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Tools\Index.cshtml"
   await Html.RenderPartialAsync("_TryCosmosSwim"); 

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public cosmoswebsite.Helpers.ExternalLinkManager ExternalLinkManager { get; private set; }
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
