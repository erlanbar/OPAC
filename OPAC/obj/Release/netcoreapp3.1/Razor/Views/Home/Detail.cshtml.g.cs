#pragma checksum "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749862de46ef610dfd469564be8619d189c5c6a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\_ViewImports.cshtml"
using OPAC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\_ViewImports.cshtml"
using OPAC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749862de46ef610dfd469564be8619d189c5c6a6", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"margin-bottom: 25px;\">\r\n    <div class=\"jumbotron myDiv\" style=\"background: black;height: 290px;border-radius: 0;line-height: 2;\">\r\n        <div class=\"row\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 320, 1);
#nullable restore
#line 8 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml"
WriteAttributeValue("", 293, Url.Action("Index","Home"), 293, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""fa fa-arrow-left"" style=""color:white;font-size: x-large;padding-left: 15px;float: left;""></a>
            <a class=""fa fa-share-alt"" style=""color:white;font-size: x-large;right: 15px;position: absolute;""></a>
        </div>

        <div class=""bg""");
            BeginWriteAttribute("style", " style=\"", 581, "\"", 662, 6);
            WriteAttributeValue("", 589, "background:", 589, 11, true);
            WriteAttributeValue(" ", 600, "Url(", 601, 5, true);
#nullable restore
#line 12 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml"
WriteAttributeValue("", 605, Url.Content("~/assets/images/book1.jpg"), 605, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 646, ")", 646, 1, true);
            WriteAttributeValue(" ", 647, "center", 648, 7, true);
            WriteAttributeValue(" ", 654, "center;", 655, 8, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
        <h3 style=""color: white"">Photorealistic Digital Painting From Beginner To Advanced</h3>
        <p style=""color:white;font-size:14px"">Bring your imagination to life!</p>

        <a href=""javascript:;"" class=""btn btn-circle btn-xs white"" style=""background-color: #fff0;"">
            <i class=""fa fa-star"" style=""color:white;""></i><span style=""color:white;""> 4.5</span>
        </a>
        <a href=""javascript:;"" class=""btn btn-circle btn-xs white"" style=""background-color: #fff0;"">
            <i class=""fa fa-user"" style=""color:white;""></i><span style=""color:white;""> 45.000 Viewed</span>
        </a>
        <a href=""javascript:;"" class=""btn btn-circle btn-xs white"" style=""background-color: #fff0;"">
            <span style=""color:white;"">Created by Austin Batchelor</span>
        </a>
        <a href=""javascript:;"" class=""btn btn-circle btn-xs white"" style=""background-color: #fff0;"">
            <span style=""color:white;"">Updated 05/2020</span>
        </a>
        <a href=""javasc");
            WriteLiteral(@"ript:;"" class=""btn btn-circle btn-xs white"" style=""background-color: #fff0;"">
            <i class=""fa fa-map"" style=""color:white;""></i><span style=""color:white;""> Perpustakaan Nasional</span>
        </a>

        <div class=""row"" style=""margin-top: 20px;text-align: center;display: block;"">
            <img");
            BeginWriteAttribute("src", " src=\"", 2001, "\"", 2048, 1);
#nullable restore
#line 33 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2007, Url.Content("~/assets/images/book1.jpg"), 2007, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
        </div>
    </div>
</div>

<div class=""row"" style=""margin-top: 60px; padding: 10px;"">
    <div class=""col-xs-12"" style=""padding: 5px 2px 5px 0px;text-align:center;margin-bottom: 10px;"">
        <span>Available (1)</span> &nbsp;&nbsp; <button type=""button"" class=""btn btn-circle btn-info"" style=""font-size: smaller;height: 40px;"">SHOW LOCATION</button>
    </div>
    <input type=""button"" class=""btn red btn-block"" value=""READ NOW"">
    <div class=""col-xs-6"" style=""padding: 5px 2px 5px 0px;"">
        <button type=""button"" class=""btn btn-default"" style=""width: 100%;font-size: smaller;height: 40px;"">BORROW THIS BOOK</button>
    </div>
    <div class=""col-xs-6"" style=""padding: 5px 0px 5px 2px;"">
        <button type=""button"" class=""btn btn-default"" style=""height: 40px;width: 100%;font-size: smaller;"">ADD TO MY LIST</button>
    </div>
</div>

<div class=""row"" style=""padding: 0px 10px 10px 10px;"">
    <div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;margin-bottom: 0;"">");
            WriteLiteral(@"
        <div class=""portlet-title"">
            <div class=""caption"">
                What Will I Learn
            </div>
        </div>
        <div class=""portlet-body"">
            <div class=""col-xs-1"" style=""padding:0""><i class=""fa fa-check"" style=""color:green""></i></div>
            <div class=""col-xs-11"" style=""padding:0"">Will be able to paint photorealistic digital images</div>
        </div>
    </div>
</div>

<div class=""row"" style=""padding: 0px 10px 10px 10px;"">
    <div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;margin-bottom: 0;"">
        <div class=""portlet-title"">
            <div class=""caption"">
                Requirements
            </div>
        </div>
        <div class=""portlet-body"">
            <div class=""col-xs-1"" style=""padding:0""><i class=""fa fa-check"" style=""color:green""></i></div>
            <div class=""col-xs-11"" style=""padding:0"">Have a basic familiarity with a painting software such as Procreate or Photoshop</div>
            <div");
            WriteLiteral(@" class=""col-xs-1"" style=""padding:0""><i class=""fa fa-check"" style=""color:green""></i></div>
            <div class=""col-xs-11"" style=""padding:0"">Have some basic drawing skills</div>
        </div>
    </div>
</div>

<div class=""row"" style=""padding: 0px 10px 10px 10px;"">
    <div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;margin-bottom: 0;"">
        <div class=""portlet-title"">
            <div class=""caption"">
                Description
            </div>
        </div>
        <div class=""portlet-body"">
            <p>Join the course and begin digitally painting today!</p>

            <p>Do you want to learn how to digitally paint images for games and film like an industry pro? Or maybe you’re wanting to branch out and try a new painting style? In any case you’ve come to the right place.</p>

            <p>The 'Photorealistic Digital Painting' course will show you how to create photoreal and extremely detailed paintings that will stand up as professional work. The techni");
            WriteLiteral(@"ques taught in this course can be translated into any program from Photoshop to Procreate. This course will enhance or give you skills in the world of digital painting - or your money back!</p>

            <p>This course is your track to building a solid portfolio of realistic digital paintings and concept art! Whether for your own portfolio or for client work.</p>

            <p>This course will take you from having little knowledge in how to paint realistically to creating professional paintings in as little as one week.</p>
        </div>
    </div>
</div>

<div class=""row"" style=""padding: 0px 10px 10px 10px;"">
    <div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;margin-bottom: 0;"">
        <div class=""portlet-title"">
            <div class=""caption"">
                Created by Austin Batchelor
            </div>
        </div>
        <div class=""portlet-body"">
            <div class=""col-xs-3"" style=""padding:0""><img");
            BeginWriteAttribute("src", " src=\"", 6093, "\"", 6141, 1);
#nullable restore
#line 110 "C:\Users\170051\Documents\DocOpac\OPAC\OPAC\Views\Home\Detail.cshtml"
WriteAttributeValue("", 6099, Url.Content("~/assets/images/avatar.png"), 6099, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width:80px""></img></div>
            <div class=""col-xs-9"" style=""padding:0"">
                <div class=""col-xs-12""><i class=""fa fa-user""></i>&nbsp;&nbsp; 145.000 Viewed</div>
                <div class=""col-xs-12""><i class=""fa fa-book""></i>&nbsp;&nbsp;  15 Books</div>
                <div class=""col-xs-12""><i class=""fa fa-star""></i>&nbsp;&nbsp;  4.5 Average Rating</div>
            </div>
        </div>
    </div>
</div>

<div class=""row"" style=""padding: 0px 10px 10px 10px;"">
    <div class=""portlet solid white"" style=""padding: 0px 15px 15px 15px;margin-bottom: 0;"">
        <div class=""portlet-title"">
            <div class=""caption"">
                User Feedback
            </div>
        </div>
        <div class=""portlet-body"">
            <div class=""col-xs-12"" style=""padding:0"">
                <span style=""font-size:xx-large"">4.5</span> <span> average rating</span>
            </div>
            <div class=""col-xs-12"" style=""padding:0;padding-top: 10px;"">
           ");
            WriteLiteral(@"     <div class=""col-xs-6"" style=""padding:0"">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""54"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 54%"">
                            <span class=""sr-only""> 54% </span>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-6"" style=""padding:0;padding-left: 5px;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <span style=""font-size: 14px;""> 54%</span>
                </div>
            </div>
       ");
            WriteLiteral(@"     <div class=""col-xs-12"" style=""padding:0;"">
                <div class=""col-xs-6"" style=""padding:0"">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""32"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 32%"">
                            <span class=""sr-only""> 32% </span>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-6"" style=""padding:0;padding-left: 5px;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <span style=""font-size: 14px;""> 54%");
            WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <div class=""col-xs-6"" style=""padding:0"">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 10%"">
                            <span class=""sr-only""> 10% </span>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-6"" style=""padding:0;padding-left: 5px;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""><");
            WriteLiteral(@"/i>
                    <span style=""font-size: 14px;""> 54%</span>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <div class=""col-xs-6"" style=""padding:0"">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""2"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 2%"">
                            <span class=""sr-only""> 2% </span>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-6"" style=""padding:0;padding-left: 5px;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <i ");
            WriteLiteral(@"class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <span style=""font-size: 14px;""> 54%</span>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <div class=""col-xs-6"" style=""padding:0"">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""2"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 2%"">
                            <span class=""sr-only""> 2% </span>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-6"" style=""padding:0;padding-left: 5px;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""co");
            WriteLiteral(@"lor:grey;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                    <span style=""font-size: 14px;""> 54%</span>
                </div>
            </div>

            <div class=""col-xs-15"" style=""padding:0;padding-top:10px"">
                <div class=""col-xs-6"" style=""padding:0;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <p>Great course! The instructor goes over a lot of techniques in a comprehensible way, and really knows his craft. I've bee");
            WriteLiteral(@"n painting for a while and this really shone some light into it!</p>
            </div>
            <div class=""col-xs-12"" style=""padding:0;margin-top: -5px;"">
                <span style=""font-size:12px"">Anna Giovannini</span> &nbsp;&nbsp; <span style=""font-size:10px;color:darkgray"">1 week ago</span>
            </div>

            <div class=""col-xs-12"" style=""padding:0;padding-top:15px"">
                <div class=""col-xs-6"" style=""padding:0;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <p>After this course yo");
            WriteLiteral(@" got a lot of technics that helps me create better stuff. awesome</p>
            </div>
            <div class=""col-xs-12"" style=""padding:0;margin-top: -5px;"">
                <span style=""font-size:12px"">Aldo Rocha</span> &nbsp;&nbsp; <span style=""font-size:10px;color:darkgray"">1 month ago</span>
            </div>

            <div class=""col-xs-12"" style=""padding:0;padding-top:15px"">
                <div class=""col-xs-6"" style=""padding:0;"">
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:gold;font-size: large;""></i>
                    <i class=""fa fa-star"" style=""color:grey;font-size: large;""></i>
                </div>
            </div>
            <div class=""col-xs-12"" style=""padding:0;"">
                <p>Awesome! However, some ");
            WriteLiteral(@"parts are a bit(just a bit) hard to follow because I can't find his mouse lol. I wish we could see where his cursor is at specially on subtle parts like adding small shadows and highlights. But overall, I really enjoyed this one!</p>
            </div>
            <div class=""col-xs-12"" style=""padding:0;margin-top: -5px;"">
                <span style=""font-size:12px"">Ape CE</span> &nbsp;&nbsp; <span style=""font-size:10px;color:darkgray"">3 months ago</span>
            </div>

            <div class=""col-xs-12"" style=""padding:0;padding-top:15px;text-align:center"">
                <button type=""button"" class=""btn btn-link"" style=""color:red"">SEE MORE REVIEWS</button>
            </div>
        </div>
    </div>
</div>");
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
