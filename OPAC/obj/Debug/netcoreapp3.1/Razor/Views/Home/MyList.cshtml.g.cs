#pragma checksum "C:\Users\170051\Documents\DocOpac\OPAC\Views\Home\MyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f951311839f2a120d121c49674e673e3c1873392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyList), @"mvc.1.0.view", @"/Views/Home/MyList.cshtml")]
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
#line 1 "C:\Users\170051\Documents\DocOpac\OPAC\Views\_ViewImports.cshtml"
using OPAC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\170051\Documents\DocOpac\OPAC\Views\_ViewImports.cshtml"
using OPAC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f951311839f2a120d121c49674e673e3c1873392", @"/Views/Home/MyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2206ef01c076d6da3c5315ef12011c8aa5a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\170051\Documents\DocOpac\OPAC\Views\Home\MyList.cshtml"
  
    ViewData["Title"] = "MyList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" style=""padding: 10px 10px 0px 10px;"">
    <div class=""portlet solid white"" style=""padding: 10px;margin-bottom: 0;"">
        <div class=""portlet-body"">
            <div class=""col-xs-12"" style=""padding:0"">
                <div class=""col-xs-3 fill"" style=""padding:0"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 453, 1);
#nullable restore
#line 12 "C:\Users\170051\Documents\DocOpac\OPAC\Views\Home\MyList.cshtml"
WriteAttributeValue("", 412, Url.Content("~/assets/images/book1.jpg"), 412, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-height: 75px;"" />
                </div>
                <div class=""col-xs-9"" style=""padding:0; padding-left:5px"">
                    <span>Photorealistic Digital Painting From Beginner To Advanced</span>
                    <br />
                    <span style=""color: lightgray;"">Austin Batchelor</span>
                    <br />
                    <div>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star-half"" style=""color:gold""></i>
                        <span style=""font-size: 12px;""> 4.5 (50.000)</span>
                        <br />
                        <span style=""color:green""><i class=""icon-check""></i> &nbsp; Offline</span>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""row"" style=""padding: 10px 10px 0px 10px;"">
    <div class=""portlet solid white"" style=""padding: 10px;margin-bottom: 0;"">
        <div class=""portlet-body"">
            <div class=""col-xs-12"" style=""padding:0"">
                <div class=""col-xs-3 fill"" style=""padding:0"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 1829, "\"", 1876, 1);
#nullable restore
#line 40 "C:\Users\170051\Documents\DocOpac\OPAC\Views\Home\MyList.cshtml"
WriteAttributeValue("", 1835, Url.Content("~/assets/images/book2.jpg"), 1835, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-height: 75px;"" />
                </div>
                <div class=""col-xs-9"" style=""padding:0; padding-left:5px"">
                    <span>Docker Mastery: with Kubernetes +Swarm from a Docker Captain</span>
                    <br />
                    <span style=""color: lightgray;"">Bret Fisher, Docker Captain Program</span>
                    <br />
                    <div>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star"" style=""color:gold""></i>
                        <i class=""fa fa-star-half"" style=""color:gold""></i>
                        <span style=""font-size: 12px;""> 4.5 (10.000)</span>
                        <br />
                        <span><i class=""icon-check""></i> &nbsp; Offline &nbsp;</span>
                        <a href=""javascript:;"" class=""btn btn-c");
            WriteLiteral(@"ircle btn-xs default"">
                            <i class=""icon-cloud-download""></i>
                            &nbsp; Download
                        </a>
                    </div>
                </div>
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
