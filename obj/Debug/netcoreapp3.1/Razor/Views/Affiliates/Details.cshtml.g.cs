#pragma checksum "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a1cc9b1a477c08da0c3fc6365259aaaefa3f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Affiliates_Details), @"mvc.1.0.view", @"/Views/Affiliates/Details.cshtml")]
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
#line 1 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\_ViewImports.cshtml"
using AFFILIATES.GB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\_ViewImports.cshtml"
using AFFILIATES.GB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a1cc9b1a477c08da0c3fc6365259aaaefa3f4b", @"/Views/Affiliates/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc2bb1fda70676b1515fc030f951360fd2c8c2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Affiliates_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AFFILIATES.GB.Models.Affiliates>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Affiliates</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirtsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirtsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NationalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayFor(model => model.NationalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    Contracts\r\n    <hr />\r\n\r\n    <div>\r\n        <h4>Contracts</h4>\r\n        <hr />\r\n");
#nullable restore
#line 51 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
         foreach (var contract in Model.AffiliateContracts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
               Write(Html.DisplayNameFor(model => contract.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
               Write(Html.DisplayFor(model => contract.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
               Write(Html.DisplayNameFor(model => contract.ContractStatu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
               Write(Html.DisplayFor(model => contract.ContractStatu.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
            WriteLiteral("            <div>\r\n                <h4>Services</h4>\r\n                <hr />\r\n");
#nullable restore
#line 72 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                 foreach (var service in contract.AffiliateContractServices)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dl class=\"row\">\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 76 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                       Write(Html.DisplayNameFor(model => service.Service));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 79 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                       Write(Html.DisplayFor(model => service.Service.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 79 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                                                                         Write(Html.DisplayFor(model => service.Service.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 82 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                       Write(Html.DisplayNameFor(model => service.Observation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                       Write(Html.DisplayFor(model => service.Observation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n");
#nullable restore
#line 88 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 91 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <hr />\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a1cc9b1a477c08da0c3fc6365259aaaefa3f4b12222", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\OERL90\source\repos\AFFILIATES.GB\AFFILIATES.GB\Views\Affiliates\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a1cc9b1a477c08da0c3fc6365259aaaefa3f4b14374", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AFFILIATES.GB.Models.Affiliates> Html { get; private set; }
    }
}
#pragma warning restore 1591
