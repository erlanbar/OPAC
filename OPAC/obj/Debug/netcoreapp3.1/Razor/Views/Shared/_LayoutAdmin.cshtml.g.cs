#pragma checksum "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d5d721f8b8ca49bb1647555d088186cbaa2217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d5d721f8b8ca49bb1647555d088186cbaa2217", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-container-bg-solid page-header-top-fixed fadein"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Lato\', sans-serif !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d5d721f8b8ca49bb1647555d088186cbaa22173971", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <!-- BEGIN GLOBAL MANDATORY STYLES -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 245, "\"", 329, 1);
#nullable restore
#line 9 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 252, Url.Content("~/assets/global/plugins/font-awesome/css/font-awesome.min.css"), 252, 77, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 375, "\"", 465, 1);
#nullable restore
#line 10 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 382, Url.Content("~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css"), 382, 83, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 511, "\"", 589, 1);
#nullable restore
#line 11 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 518, Url.Content("~/assets/global/plugins/bootstrap/css/bootstrap.min.css"), 518, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 635, "\"", 727, 1);
#nullable restore
#line 12 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 642, Url.Content("~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css"), 642, 85, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <!-- END GLOBAL MANDATORY STYLES -->\r\n    <!-- BEGIN PAGE LEVEL PLUGINS -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 854, "\"", 955, 1);
#nullable restore
#line 15 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 861, Url.Content("~/assets/global/plugins/bootstrap-datepicker/css/bootstrap-datepicker3.min.css"), 861, 94, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1001, "\"", 1075, 1);
#nullable restore
#line 16 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1008, Url.Content("~/assets/global/plugins/select2/css/select2.min.css"), 1008, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1121, "\"", 1205, 1);
#nullable restore
#line 17 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1128, Url.Content("~/assets/global/plugins/select2/css/select2-bootstrap.min.css"), 1128, 77, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <!-- END PAGE LEVEL PLUGINS -->\r\n    <!-- BEGIN THEME GLOBAL STYLES -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1328, "\"", 1397, 1);
#nullable restore
#line 20 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1335, Url.Content("~/assets/global/css/components-rounded.min.css"), 1335, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" id=\"style_components\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1465, "\"", 1523, 1);
#nullable restore
#line 21 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1472, Url.Content("~/assets/global/css/plugins.min.css"), 1472, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <!-- END THEME GLOBAL STYLES -->\r\n    <!-- BEGIN PAGE LEVEL STYLES -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1645, "\"", 1700, 1);
#nullable restore
#line 24 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1652, Url.Content("~/assets/apps/css/todo-2.min.css"), 1652, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <!-- END PAGE LEVEL STYLES -->\r\n    <!-- BEGIN THEME LAYOUT STYLES -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1822, "\"", 1888, 1);
#nullable restore
#line 27 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1829, Url.Content("~/assets/layouts/layout3/css/layout.min.css"), 1829, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1934, "\"", 2008, 1);
#nullable restore
#line 28 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1941, Url.Content("~/assets/layouts/layout3/css/themes/default.min.css"), 1941, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" id=\"style_color\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 2071, "\"", 2137, 1);
#nullable restore
#line 29 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2078, Url.Content("~/assets/layouts/layout3/css/custom.min.css"), 2078, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <!-- END THEME LAYOUT STYLES -->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d5d721f8b8ca49bb1647555d088186cbaa221711736", async() => {
                WriteLiteral(@"

    <div class=""main"">
        <div class=""page-wrapper container-fluid"" aria-hidden=""true"" style=""padding: 0px;"">
            <div class=""page-wrapper-row full-height"">
                <div class=""page-wrapper-middle"" style=""background:white !important"">
                    <div class=""page-container"" style=""background:ghostwhite"">
                        <div class=""page-content-wrapper"">
                            <div class=""page-content"" style=""padding-top:0px"">
                                <div class=""container-fluid"" style=""padding-left: 15px;padding-right: 15px;"">
                                    <div class=""page-content-inner"">
                                        ");
#nullable restore
#line 44 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
                                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- BEGIN CORE PLUGINS -->
    <script");
                BeginWriteAttribute("src", " src=\"", 3359, "\"", 3418, 1);
#nullable restore
#line 56 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3365, Url.Content("~/assets/global/plugins/jquery.min.js"), 3365, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3465, "\"", 3540, 1);
#nullable restore
#line 57 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3471, Url.Content("~/assets/global/plugins/bootstrap/js/bootstrap.min.js"), 3471, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3587, "\"", 3649, 1);
#nullable restore
#line 58 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3593, Url.Content("~/assets/global/plugins/js.cookie.min.js"), 3593, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3696, "\"", 3784, 1);
#nullable restore
#line 59 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3702, Url.Content("~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js"), 3702, 82, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3831, "\"", 3898, 1);
#nullable restore
#line 60 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3837, Url.Content("~/assets/global/plugins/jquery.blockui.min.js"), 3837, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3945, "\"", 4034, 1);
#nullable restore
#line 61 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 3951, Url.Content("~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js"), 3951, 83, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <!-- END CORE PLUGINS -->\r\n    <!-- BEGIN PAGE LEVEL PLUGINS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4151, "\"", 4248, 1);
#nullable restore
#line 64 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4157, Url.Content("~/assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"), 4157, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4295, "\"", 4371, 1);
#nullable restore
#line 65 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4301, Url.Content("~/assets/global/plugins/select2/js/select2.full.min.js"), 4301, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <!-- END PAGE LEVEL PLUGINS -->\r\n    <!-- BEGIN THEME GLOBAL SCRIPTS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4496, "\"", 4552, 1);
#nullable restore
#line 68 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4502, Url.Content("~/assets/global/scripts/app.min.js"), 4502, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <!-- END THEME GLOBAL SCRIPTS -->\r\n    <!-- BEGIN PAGE LEVEL SCRIPTS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4677, "\"", 4734, 1);
#nullable restore
#line 71 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4683, Url.Content("~/assets/apps/scripts/todo-2.min.js"), 4683, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <!-- END PAGE LEVEL SCRIPTS -->\r\n    <!-- BEGIN THEME LAYOUT SCRIPTS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4859, "\"", 4927, 1);
#nullable restore
#line 74 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4865, Url.Content("~/assets/layouts/layout3/scripts/layout.min.js"), 4865, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4974, "\"", 5040, 1);
#nullable restore
#line 75 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 4980, Url.Content("~/assets/layouts/layout3/scripts/demo.min.js"), 4980, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5087, "\"", 5161, 1);
#nullable restore
#line 76 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 5093, Url.Content("~/assets/layouts/global/scripts/quick-sidebar.min.js"), 5093, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5208, "\"", 5278, 1);
#nullable restore
#line 77 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 5214, Url.Content("~/assets/layouts/global/scripts/quick-nav.min.js"), 5214, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <!-- END THEME LAYOUT SCRIPTS -->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
