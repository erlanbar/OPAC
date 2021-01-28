#pragma checksum "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be841fb95b4ca9390a90108652541d83e1cc8aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserReview), @"mvc.1.0.view", @"/Views/Home/UserReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be841fb95b4ca9390a90108652541d83e1cc8aa4", @"/Views/Home/UserReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
  

    var avgRating = 0;
    var rating5Count = 0;
    var rating4Count = 0;
    var rating3Count = 0;
    var rating2Count = 0;
    var rating1Count = 0;

    var widthTimes = 10;
    var progressWidth5 = rating5Count * widthTimes + "px;";
    var progressWidth4 = rating4Count * widthTimes + "px;";
    var progressWidth3 = rating3Count * widthTimes + "px;";
    var progressWidth2 = rating2Count * widthTimes + "px;";
    var progressWidth1 = rating1Count * widthTimes + "px;";

    var totalReviews = rating5Count + rating4Count + rating3Count + rating2Count + rating1Count;

    if (ViewBag.UserReviewData != null) {

        avgRating = ViewBag.UserReviewData.GetType().GetProperty("BookRating").GetValue(ViewBag.UserReviewData, null);
        rating5Count = ViewBag.UserReviewData.GetType().GetProperty("Rating5Count").GetValue(ViewBag.UserReviewData, null);
        rating4Count = ViewBag.UserReviewData.GetType().GetProperty("Rating4Count").GetValue(ViewBag.UserReviewData, null);
        rating3Count = ViewBag.UserReviewData.GetType().GetProperty("Rating3Count").GetValue(ViewBag.UserReviewData, null);
        rating2Count = ViewBag.UserReviewData.GetType().GetProperty("Rating2Count").GetValue(ViewBag.UserReviewData, null);
        rating1Count = ViewBag.UserReviewData.GetType().GetProperty("Rating1Count").GetValue(ViewBag.UserReviewData, null);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .progress {\r\n        background-color: white;\r\n    }\r\n</style>\r\n\r\n");
            WriteLiteral(@"<div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;"">
    <div class=""portlet-title"">
        <div class=""caption"">
            User Feedback
        </div>
    </div>
    <div class=""portlet-body"">
        <div class=""row"">
            <div class=""col-md-3"" style=""text-align: center;border-right: 1px solid #ccc;"">
                <div class=""col-md-12"">
                    <span style=""font-size:xx-large"">
                        ");
#nullable restore
#line 49 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                   Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <i class=\"fa fa-star\" style=\"color: gold;\"></i>\r\n                    </span>\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 54 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
               Write(totalReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" reviews
                </div>
            </div>
            <div class=""col-md-9"">
                <div class=""row form-inline"">
                    <div class=""col-md-2"">
                        5
                        <i class=""fa fa-star"" style=""color: gold;""></i>
                    </div>
                    <div class=""col-md-10"">
                        <div class=""progress"">
                            <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\"", 2685, "\"", 2715, 2);
            WriteAttributeValue("", 2693, "width:", 2693, 6, true);
#nullable restore
#line 65 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
WriteAttributeValue(" ", 2699, progressWidth5, 2700, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        </div>
                    </div>
                    <div class=""col-md-2"">
                        4
                        <i class=""fa fa-star"" style=""color: gold;""></i>
                    </div>
                    <div class=""col-md-10"">
                        <div class=""progress"">
                            <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\"", 3122, "\"", 3152, 2);
            WriteAttributeValue("", 3130, "width:", 3130, 6, true);
#nullable restore
#line 74 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
WriteAttributeValue(" ", 3136, progressWidth4, 3137, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        </div>
                    </div>
                    <div class=""col-md-2"">
                        3
                        <i class=""fa fa-star"" style=""color: gold;""></i>
                    </div>
                    <div class=""col-md-10"">
                        <div class=""progress"">
                            <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\"", 3559, "\"", 3589, 2);
            WriteAttributeValue("", 3567, "width:", 3567, 6, true);
#nullable restore
#line 83 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
WriteAttributeValue(" ", 3573, progressWidth3, 3574, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        </div>
                    </div>
                    <div class=""col-md-2"">
                        2
                        <i class=""fa fa-star"" style=""color: gold;""></i>
                    </div>
                    <div class=""col-md-10"">
                        <div class=""progress"">
                            <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\"", 3996, "\"", 4026, 2);
            WriteAttributeValue("", 4004, "width:", 4004, 6, true);
#nullable restore
#line 92 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
WriteAttributeValue(" ", 4010, progressWidth2, 4011, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        </div>
                    </div>
                    <div class=""col-md-2"">
                        1
                        <i class=""fa fa-star"" style=""color: gold;""></i>
                    </div>
                    <div class=""col-md-10"">
                        <div class=""progress"">
                            <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\"", 4433, "\"", 4463, 2);
            WriteAttributeValue("", 4441, "width:", 4441, 6, true);
#nullable restore
#line 101 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
WriteAttributeValue(" ", 4447, progressWidth1, 4448, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <br/>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"col-md-12\">\r\n");
#nullable restore
#line 111 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                     foreach (var item in ViewBag.UserReviewDetail)
                    {
                        var userRating = item.GetType().GetProperty("UserRating").GetValue(item, null);
                        var userReview = item.GetType().GetProperty("UserReview").GetValue(item, null);
                        var userName = item.GetType().GetProperty("UserName").GetValue(item, null);
                        var reviewDate = item.GetType().GetProperty("ReviewDate").GetValue(item, null);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <div class=\"user-rating\">\r\n");
#nullable restore
#line 120 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                                     for (int i = 0; i < userRating; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star\" style=\"color:gold;font-size: large;\"></i>\r\n");
#nullable restore
#line 123 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"user-review\">\r\n                                    <blockquote class=\"blockquote mb-0\">\r\n                                        <p>");
#nullable restore
#line 127 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                                      Write(userReview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <footer class=\"blockquote-footer\">\r\n                                            <span style=\"font-size:12px\">");
#nullable restore
#line 129 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                                                                    Write(userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                                            &nbsp;&nbsp; \r\n                                            <span style=\"font-size:10px;color:darkgray\">");
#nullable restore
#line 131 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                                                                                   Write(reviewDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </footer>\r\n                                    </blockquote>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 137 "D:\Project\OPAC\OPAC\OPAC\Views\Home\UserReview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col-xs-12"" style=""padding:0;padding-top:15px;text-align:center; display: none;"">
            <button type=""button"" class=""btn btn-link"" style=""color:red"">SEE MORE REVIEWS</button>
        </div>
    </div>
</div>
");
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