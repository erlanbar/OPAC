#pragma checksum "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20338b5a0198ae1bebb18c7820cf2255eba9e644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewArrival), @"mvc.1.0.view", @"/Views/Home/NewArrival.cshtml")]
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
#line 1 "D:\Project\OPAC\OPAC\OPAC\Views\_ViewImports.cshtml"
using OPAC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\OPAC\OPAC\OPAC\Views\_ViewImports.cshtml"
using OPAC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20338b5a0198ae1bebb18c7820cf2255eba9e644", @"/Views/Home/NewArrival.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewArrival : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#212529"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""portlet light"">
    <div class=""portlet-title"">
        <div class=""caption"" style=""padding-left: 15px;"">
            <h4 style=""margin: 0;"">New Arrival</h4>
        </div>
    </div>
    <div class=""portlet-body"" style=""padding-top:0"">

        <div class=""container-fluid"">
            <!-- Three columns of text below the carousel -->
            <div class=""row"">

");
#nullable restore
#line 15 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                  
                    if (ViewBag.LoadingNewArrival != null)
                    {
                        if (ViewBag.NewArrival != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"table-scrollable\" style=\"border:none;margin: 0 !important;\">\r\n                                <table class=\"table\">\r\n                                    <tbody>\r\n                                        <tr>\r\n");
#nullable restore
#line 24 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                             foreach (var item in ViewBag.NewArrivalData) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <td style=""border:none;padding: 0;padding-left: 15px;"">
                                                    <div class=""mt-element-card mt-element-overlay"" style=""width:200px"">
                                                        <div class=""mt-card-item"" style=""border: none;margin:0"">
                                                            <div class=""mt-card-avatar mt-overlay-1"">
");
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20338b5a0198ae1bebb18c7820cf2255eba9e6445785", async() => {
                WriteLiteral("\r\n                                                                    <img");
                BeginWriteAttribute("src", " src=\"", 1995, "\"", 2062, 1);
#nullable restore
#line 33 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
WriteAttributeValue("", 2001, item.GetType().GetProperty("BookCover").GetValue(item, null), 2001, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                                                               WriteLiteral(item.GetType().GetProperty("BookID").GetValue(item, null));

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
            WriteLiteral(@"
                                                            </div>
                                                            <div class=""mt-card-content"">
                                                                <div class=""row"">
                                                                    <div class=""col-md-12"" style=""text-align: center;"">
                                                                        <div class=""mt-card-social"">
                                                                            ");
#nullable restore
#line 40 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                       Write(item.GetType().GetProperty("BookRating").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color:gold\"></i> | \r\n                                                                            ");
#nullable restore
#line 41 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                       Write(item.GetType().GetProperty("TotalReviewer").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" reviews | \r\n                                                                            <span class=\"mt-card-desc\">\r\n                                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3133, "\"", 3169, 1);
#nullable restore
#line 43 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
WriteAttributeValue("", 3140, Url.Action("Detail", "Home"), 3140, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#212529\">");
#nullable restore
#line 43 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                                                                                         Write(item.GetType().GetProperty("BookAuthor").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                            </span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class=""row"" style=""padding-top: 5px;padding-left: 15px;"">
                                                                    <p class=""mt-card-desc"">
");
            WriteLiteral("                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20338b5a0198ae1bebb18c7820cf2255eba9e64411691", async() => {
                WriteLiteral("\r\n                                                                            ");
#nullable restore
#line 52 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                       Write(item.GetType().GetProperty("BookDesc").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                                                                                                       WriteLiteral(item.GetType().GetProperty("BookID").GetValue(item, null));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                    </p>      
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
");
#nullable restore
#line 60 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <td style=""vertical-align: middle;padding-left: 30px;border: none;"">
                                                <button type=""button"" class=""btn default btn-lg"">See All</button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
");
#nullable restore
#line 68 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"alert alert-danger\" style=\"padding-left:15px;\">No available New Arrival!</span>\r\n");
#nullable restore
#line 72 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"padding-left:15px;\"><i class=\"fa fa-spin fa-spinner\"></i> Please wait while we do something...</p>\r\n");
#nullable restore
#line 77 "D:\Project\OPAC\OPAC\OPAC\Views\Home\NewArrival.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("    </div>\r\n</div>");
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
