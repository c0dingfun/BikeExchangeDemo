#pragma checksum "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321c07487cb49825d66445cbfe4fc01af75348c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Make_Index), @"mvc.1.0.view", @"/Views/Make/Index.cshtml")]
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
#line 1 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\_ViewImports.cshtml"
using BikeExchange;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\_ViewImports.cshtml"
using BikeExchange.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321c07487cb49825d66445cbfe4fc01af75348c2", @"/Views/Make/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ded1372792f191f1ccf5e999730eec0fbe1a278", @"/Views/_ViewImports.cshtml")]
    public class Views_Make_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BikeExchange.Models.Make>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EditDeletePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br/> <br/>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Makes of Vehicle</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321c07487cb49825d66445cbfe4fc01af75348c24640", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-motorcycle\"></i> &nbsp; Add New Make\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br/>\r\n    <div class=\"col-12\">\r\n        <table class=\"table table-striped border\">\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th> </th>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "321c07487cb49825d66445cbfe4fc01af75348c27069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 36 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <!-- HH: replaced by the partial view -- _EditDeletePartial --, but want to preserve the history\r\n");
            WriteLiteral("\r\n                    <td class=\"text-right\">\r\n                        <div class=\"btn-group\" role=\"group\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
                            <form method=""get"" action=""Edit"">
                                <button class=""btn btn-primary"" 
                                        type=""submit""
                                        asp-action=""Edit""
                                        asp-route-id=""");
#nullable restore
#line 66 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >\r\n\r\n                                    <i class=\"far fa-edit\"></i>\r\n\r\n                                </button>\r\n                            </form>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                        <form method=\"post\" action=\"Delete\">\r\n");
            WriteLiteral("\r\n                            <button class=\"btn btn-danger rounded-0\" \r\n                                    type=\"submit\"\r\n                                    asp-action=\"Delete\"\r\n                                    asp-route-id=\"");
#nullable restore
#line 92 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                                <i class=\"far fa-trash-alt\"></i>\r\n\r\n                            </button>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n                        </form>\r\n                        </div>\r\n                    </td>\r\n                    -->\r\n                </tr>\r\n");
#nullable restore
#line 121 "C:\GitRepos\BikeExchangeDemo\BikeExchange\Views\Make\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BikeExchange.Models.Make>> Html { get; private set; }
    }
}
#pragma warning restore 1591
