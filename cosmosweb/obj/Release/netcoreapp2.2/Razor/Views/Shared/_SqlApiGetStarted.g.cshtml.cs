#pragma checksum "C:\Users\mjbrown\GitHub\AzureCosmosDB\cosmosweb\cosmosweb\Views\Shared\_SqlApiGetStarted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782eb3778645972cb30876e3cc553f6d7132d156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SqlApiGetStarted), @"mvc.1.0.view", @"/Views/Shared/_SqlApiGetStarted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SqlApiGetStarted.cshtml", typeof(AspNetCore.Views_Shared__SqlApiGetStarted))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"782eb3778645972cb30876e3cc553f6d7132d156", @"/Views/Shared/_SqlApiGetStarted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91534d0c164582450b0f6fa59c1880ad71e552fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SqlApiGetStarted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 7109, true);
            WriteLiteral(@"<div class=""media-grid"">
    <div class=""row"">
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=https://www.documentdb.com/sql/demo"" target=""_blank""><span class=""ms-Icon ms-Icon--Website""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://www.documentdb.com/sql/demo"" target=""_blank"">In-browser Tutorial</a></h3>
                    <p>Write Cosmos DB SQL API queries in your browser, without installing anything on your computer</p>
                    <p><a class=""btn btn-default"" href=""https://www.documentdb.com/sql/demo"" target=""_blank"" role=""button"">Start in-brower tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
           ");
            WriteLiteral(@"         <a href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-get-started"" target=""_blank""><span class=""ms-Icon ms-Icon--PowerShell""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-get-started"" target=""_blank"">Console</a></h3>
                    <p>Build a simple To Do application that runs in the console</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-get-started"" target=""_blank"" role=""button"">Start console tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-dotnet-application"" target=""_blank""><span class=""ms-Icon ms-Icon--Globe""></span></a>
              ");
            WriteLiteral(@"  </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-dotnet-application-preview"" target=""_blank"">Web</a></h3>
                    <p>Create a web app that runs on Windows, Mac or Linux using ASP.NET MVC Core and Cosmos DB .NET v3 preview</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/sql-api-dotnet-application-preview"" target=""_blank"" role=""button"">Start web tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-xamarin-dotnet"" target=""_blank""><span class=""ms-Icon ms-Icon--CellPhone""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-he");
            WriteLiteral(@"ading""><a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-xamarin-dotnet"" target=""_blank"">Mobile</a></h3>
                    <p>Create a mobile application using Xamarin with the Cosmos DB .NET SDK for SQL API</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-xamarin-dotnet"" target=""_blank"" role=""button"">Start mobile tutorial</a></p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/sandbox/gamedev/azure-gaming-samples#scavenger"" target=""_blank""><span class=""ms-Icon ms-Icon--Headset""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/sandbox/gamedev/azure-gaming-samples#scav");
            WriteLiteral(@"enger"" target=""_blank"">Gaming</a></h3>
                    <p>Create a virutal scavenger hunt game in Unity using the Cosmos DB .NET SDK for SQL API.</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/sandbox/gamedev/azure-gaming-samples#scavenger"" role=""button"" target=""_blank"">Start gaming tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-java"" target=""_blank""><span class=""ms-Icon ms-Icon--PC1""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-java"" target=""_blank"">Java</a></h3>
                    <p>Create an application with the Cosmos DB Java SDK for SQL API</p>
         ");
            WriteLiteral(@"           <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-java"" target=""_blank"" role=""button"">Start Java tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-nodejs"" target=""_blank""><span class=""ms-Icon ms-Icon--AnalyticsQuery""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-nodejs"" target=""_blank"">JavaScript</a></h3>
                    <p>Create an application with the Cosmos DB JavaScript SDK for SQL API</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-nodejs"" target=""_blank"" role=""button"">Start Ja");
            WriteLiteral(@"vaScript tutorial</a></p>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""media"">
                <div class=""media-left"" aria-hidden=""true"">
                    <a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-python"" target=""_blank""><span class=""ms-Icon ms-Icon--Robot""></span></a>
                </div>
                <div class=""media-body"">
                    <h3 class=""media-heading""><a href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-python"" target=""_blank"">Python</a></h3>
                    <p>Create an application with the Cosmos DB Python SDK for SQL API</p>
                    <p><a class=""btn btn-default"" href=""https://docs.microsoft.com/azure/cosmos-db/create-sql-api-python"" target=""_blank"" role=""button"">Start Python tutorial</a></p>
                </div>
            </div>
        </div>
    </div>
</div>");
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
