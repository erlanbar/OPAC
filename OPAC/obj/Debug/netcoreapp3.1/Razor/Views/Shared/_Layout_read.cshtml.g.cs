#pragma checksum "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0221b9c511b530b42ea1776905d831bc301ef89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_read), @"mvc.1.0.view", @"/Views/Shared/_Layout_read.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0221b9c511b530b42ea1776905d831bc301ef89a", @"/Views/Shared/_Layout_read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pdf.js/pdf.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0221b9c511b530b42ea1776905d831bc301ef89a5131", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0221b9c511b530b42ea1776905d831bc301ef89a5749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0221b9c511b530b42ea1776905d831bc301ef89a6927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
      Html.RenderPartial("_link");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0221b9c511b530b42ea1776905d831bc301ef89a8418", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0221b9c511b530b42ea1776905d831bc301ef89a9521", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <style>\r\n\r\n        ");
                WriteLiteral(@"@media screen and (max-width: 600px) {
            .res-navbar {
                overflow: hidden;
                background-color: #333;
                position: fixed;
                bottom: 0;
                width: 100%;
                margin-bottom: 0 !important;
            }
        }

        ");
                WriteLiteral(@"@media print {
            html, body {
            display: none;  /* hide whole page */
            }
        }

        .res-navbar {
            overflow: hidden;
            background-color: #333;
            /*position: fixed;
            bottom: 0;*/
            width: 100%;
            margin-bottom: 0 !important;
        }

            .res-navbar a {
                float: left;
                display: block;
                color: grey;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 10px;
            }

                .res-navbar a:hover {
                    background: #f1f1f1;
                    color: black;
                }

                .res-navbar a.active {
                    color: white;
                }

        .main {
            margin-bottom: 40px;
        }

        .mt-card-desc {
            font-size: 12px !important;
        }

        .c");
                WriteLiteral(@"arousel-caption {
            text-align: left;
            line-height: 1;
            right: 5%;
            left: 5%;
            background-color: #0000005c;
            border-radius: 10px;
            bottom: 35px;
            padding-top: 15px;
            padding-bottom: 15px;
        }

        .carousel-indicators {
            bottom: 0px;
        }

        .mt-card-social {
            margin-left: -5px;
        }

        .portlet.light {
            padding-left: 0;
            padding-right: 0;
            margin-bottom: 0px;
        }

        .portlet-title {
            margin-bottom: 0px !important;
            min-height: 0px;
            border: none;
        }

        .portlet.light > .portlet-title {
            border: none;
        }

        .myDiv {
            position: relative;
            z-index: 1;
        }

            .myDiv .bg {
                position: absolute;
                z-index: -1;
                top: 0;
         ");
                WriteLiteral(@"       bottom: 0;
                left: 0;
                right: 0;
                opacity: .1;
                width: 100%;
                height: 100%;
            }

        .fill {
            display: flex;
            justify-content: center;
            align-items: center;
            overflow: hidden
        }

            .fill img {
                flex-shrink: 0;
                min-width: 100%;
                min-height: 100%
            }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0221b9c511b530b42ea1776905d831bc301ef89a14359", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"res-navbar\" style=\"z-index:3;height: 55px;\">\r\n");
#nullable restore
#line 142 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
          
            var tempFeatured = "";
            var tempMyBook = "";
            var tempWishlist = "";
            var tempContactUs = "";
            var tempAccount = "";
            if (ViewBag.UI == "Featured") { tempFeatured = "active"; }
            if (ViewBag.UI == "MyBook") { tempMyBook = "active"; }
            if (ViewBag.UI == "MyList") { tempWishlist = "active"; }
            if (ViewBag.UI == "ContactUs") { tempContactUs = "active"; }
            if (ViewBag.UI == "Account") { tempAccount = "active"; }


#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul class=\"nav justify-content-center\">\r\n                <li class=\"nav-item\" style=\"text-align: center;\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4201, "\"", 4235, 1);
#nullable restore
#line 156 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4208, Url.Action("Index","Home"), 4208, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4236, "\"", 4257, 1);
#nullable restore
#line 156 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4244, tempFeatured, 4244, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""icon-star"" style=""font-size: x-large;""></i>
                        <br />
                        Featured
                    </a>
                </li>
                <li class=""nav-item"" style=""text-align: center;"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 4544, "\"", 4579, 1);
#nullable restore
#line 163 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4551, Url.Action("MyBook","Home"), 4551, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4580, "\"", 4599, 1);
#nullable restore
#line 163 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4588, tempMyBook, 4588, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""width: 88px;"">
                        <i class=""icon-book-open"" style=""font-size: x-large;""></i>
                        <br />
                        My Book
                    </a>
                </li>
                <li class=""nav-item"" style=""text-align: center;"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 4911, "\"", 4946, 1);
#nullable restore
#line 170 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4918, Url.Action("MyList","Home"), 4918, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4947, "\"", 4968, 1);
#nullable restore
#line 170 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 4955, tempWishlist, 4955, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""icon-grid"" style="" font-size: x-large""></i>
                        <br />
                        My List
                    </a>
                </li>
                <li class=""nav-item"" style=""text-align: center;"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 5254, "\"", 5291, 1);
#nullable restore
#line 177 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 5261, Url.Action("User","HelpDesk"), 5261, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 5292, "\"", 5314, 1);
#nullable restore
#line 177 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 5300, tempContactUs, 5300, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""icon-envelope-open"" style=""font-size: x-large;""></i>
                        <br />
                        Contact
                    </a>
                </li>
                <li class=""nav-item"" style=""text-align: center;"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 5609, "\"", 5645, 1);
#nullable restore
#line 184 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 5616, Url.Action("Account","Home"), 5616, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 5646, "\"", 5666, 1);
#nullable restore
#line 184 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
WriteAttributeValue("", 5654, tempAccount, 5654, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"icon-user\" style=\"font-size: x-large;\"></i>\r\n                        <br />Account\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n");
                WriteLiteral(@"    </div>

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
#line 202 "D:\Project\OPAC\OPAC\OPAC\Views\Shared\_Layout_read.cshtml"
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

");
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).keydown(function (e) {

            if (e.keyCode == 44) {

                $("".page-content-inner"").hide();
            }
        });

        var initWindowWidth = $(window).width();
        initWindowWidth -= 17;

        $(window).on('resize', function () {

            if ($(window).width() < initWindowWidth) {
                
                $("".main"").width($(window).width() + 89);   
            }
            else {

                $("".main"").width(initWindowWidth);  
            }
        });	
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
