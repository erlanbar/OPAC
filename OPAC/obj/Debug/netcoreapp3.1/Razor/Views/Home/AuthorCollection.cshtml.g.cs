#pragma checksum "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f72e2d772de1c78bb4e100465568a67f1eb398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthorCollection), @"mvc.1.0.view", @"/Views/Home/AuthorCollection.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f72e2d772de1c78bb4e100465568a67f1eb398", @"/Views/Home/AuthorCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthorCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<div class=\"d-flex flex-wrap bd-highlight\">\r\n");
#nullable restore
#line 2 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
      
        if (ViewBag.LoadingAuthorCollection != null)
        {
            if (ViewBag.AuthorCollectionData != null)
            {
                var bookID = 0;
                var bookCover = "";
                var bookTitle = "";
                var bookRating = 0.0;
                var totalReviewer = 0;
                var totalView = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                 foreach (var item in ViewBag.AuthorCollectionData)
                {
                    bookID = item.GetType().GetProperty("BookID").GetValue(item, null);
                    bookCover = "../../Content/cover/" + item.GetType().GetProperty("BookCover").GetValue(item, null);
                    bookTitle = item.GetType().GetProperty("BookTitle").GetValue(item, null);
                    bookRating = item.GetType().GetProperty("BookRating").GetValue(item, null);
                    totalReviewer = item.GetType().GetProperty("TotalReviewer").GetValue(item, null);
                    totalView = item.GetType().GetProperty("TotalView").GetValue(item, null);


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div style=""border:none;padding: 0;padding-left: 15px;"">
                        <div class=""mt-element-card mt-element-overlay"" style=""width:200px"">
                            <div class=""mt-card-item"" style=""border: none;"">
                                <div class=""mt-card-avatar mt-overlay-1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f72e2d772de1c78bb4e100465568a67f1eb3985782", async() => {
                WriteLiteral("\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 1574, "\"", 1590, 1);
#nullable restore
#line 27 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
WriteAttributeValue("", 1580, bookCover, 1580, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
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
#line 26 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                                                                   WriteLiteral(bookID);

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
#line 34 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                           Write(bookRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color:gold\"></i> | \r\n                                                ");
#nullable restore
#line 35 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                           Write(totalReviewer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" reviews |\r\n                                                ");
#nullable restore
#line 36 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                           Write(totalView);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" views
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"" style=""padding-top: 5px;padding-left: 15px;"">
                                        <p class=""mt-card-desc"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f72e2d772de1c78bb4e100465568a67f1eb39810226", async() => {
                WriteLiteral("\r\n                                                ");
#nullable restore
#line 43 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                           Write(bookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
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
#line 42 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                                                                                           WriteLiteral(bookID);

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
            WriteLiteral("\r\n                                        </p>      \r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 51 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"alert alert-info\" style=\"padding-left:15px; width: 100%; text-align: center;\">Nothing to show here</span>\r\n");
#nullable restore
#line 56 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"padding-left:15px;\"><i class=\"fa fa-spin fa-spinner\"></i> Please wait while we do something...</p>\r\n");
#nullable restore
#line 61 "D:\Project\OPAC\OPAC\OPAC\Views\Home\AuthorCollection.cshtml"
        } 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
