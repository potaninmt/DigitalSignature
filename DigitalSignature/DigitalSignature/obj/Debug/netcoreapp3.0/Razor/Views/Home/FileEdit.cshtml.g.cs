#pragma checksum "C:\Users\Marat\Desktop\Job\AI\DigitalSignature\DigitalSignature\DigitalSignature\Views\Home\FileEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c838fcfb1d2e4b0458647bd54c02dce2523ca95c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FileEdit), @"mvc.1.0.view", @"/Views/Home/FileEdit.cshtml")]
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
#line 1 "C:\Users\Marat\Desktop\Job\AI\DigitalSignature\DigitalSignature\DigitalSignature\Views\_ViewImports.cshtml"
using TestASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marat\Desktop\Job\AI\DigitalSignature\DigitalSignature\DigitalSignature\Views\_ViewImports.cshtml"
using TestASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c838fcfb1d2e4b0458647bd54c02dce2523ca95c", @"/Views/Home/FileEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a133ffb72e3ed881538d619d3ec3e49d4c7e6fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FileEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/iframes/frame-load.html?address=https://czo.gov.ua&formType=3&debug=false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sign-widget"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("frameborder", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("allowtransparency", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Marat\Desktop\Job\AI\DigitalSignature\DigitalSignature\DigitalSignature\Views\Home\FileEdit.cshtml"
  
    ViewData["Title"] = "FileView";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    center {
        margin: auto;
        margin-top: 15%;
    }

    #sign-widget-parent {
        height: 400px !important;
    }
    /* Фіксований підвал */
    html {
        position: relative;
        min-height: 100%;
    }

    body {
        /* Відступ на висоту підвалу */
        margin-bottom: 230px;
        background-color: #eee;
    }

    #footer {
        width: 100%;
        height: 230px;
        position: absolute;
        bottom: 0;
        background-color: black;
        color: white;
        /*border-top: 15px solid #007f33;*/
    }

        #footer a {
            color: white;
        }

            #footer a:hover {
                color: white;
            }

    /* Головний блок */
    #main {
        overflow: auto;
    }

        #main h1 {
            border-bottom: dotted 1px #5083AC;
            text-transform: uppercase;
            font-size: 1.2rem;
        }

    /* Градієнт */
    .czogradient {
        backgr");
            WriteLiteral(@"ound-image: linear-gradient(45deg, #04C65D, #5B5AFF);
    }

    /* Dropdown-меню */
    .dropdown-menu {
        font-size: 12px;
    }

    /* Інше */
    h4 {
        font-size: 1.1em;
    }

    a {
        color: #000;
    }

    .header_block {
        cursor: pointer;
    }

    li.pimp {
        background: url(/images/pimp.png) no-repeat 0px 5px;
        list-style-type: none;
        margin-left: 10px;
        padding-left: 20px;
        padding-bottom: 0px;
        margin-top: 10px;
    }


    div.inner_block span.block_header {
        display: block;
        font-size: 1.3em;
        margin-bottom: 20px;
    }

    ol, ul {
        margin-bottom: 0px;
    }

    .inner_block h1 {
        font-size: 1.3em;
    }

    .news_entry h2 {
        font-size: 1em;
        margin-bottom: 3px;
    }

    .news_entry p {
        margin-top: 10px;
        margin-bottom: 3px;
    }

        .news_entry p.date {
            font-style: italic;
         ");
            WriteLiteral(@"   margin-bottom: 0px;
            margin-top: 0px;
        }

        .news_entry p img {
            float: right;
            margin-top: 5px;
        }

    hr {
        border-top: dashed 1px #333;
    }


    .document h1 {
    }

    .document h2 {
        font-size: 1.0em;
    }

    .document h3 {
        margin-top: 20px;
        font-size: 1.2em;
    }

    .document .center {
        text-align: center;
    }

    .document p {
        margin-top: 10px;
        text-align: justify;
        padding-bottom: 10px;
        margin-bottom: 0px;
    }

        .document p img.left {
            float: left;
            margin-right: 10px;
        }

        .document p img.right {
            float: right;
            margin-left: 10px;
        }

    .document a {
    }

    .document p.caption {
        clear: both;
        margin-bottom: 20px;
        width: 100%;
        font-weight: bold;
    }

        .document p.caption span.title {
      ");
            WriteLiteral(@"      margin-left: 5%;
            float: left;
        }

        .document p.caption span.name {
            float: right;
            margin-right: 5%;
        }

    .document .rightField {
        padding-left: 50%;
    }


    .document .blank figcaption {
        text-align: center;
        border-top: 1px solid;
    }

        .document .blank figcaption.dotline {
            text-align: center;
            border-top: 1px dotted;
        }

    .section h1 {
        text-transform: uppercase;
    }

    .hidden {
        display: none;
    }

    .right {
        text-align: right !important;
    }

    th {
        font-weight: bold;
        border-bottom: solid 1px #777;
        padding-right: 0.5em;
        padding-left: 0.5em;
    }

        th.center {
            text-align: center;
        }

    table.row-borders td {
        border-bottom: dotted 1px #555;
        padding-right: 10px;
    }

    table.row-solidborders th {
        border: ");
            WriteLiteral(@"solid 1px;
    }

    table.row-solidborders td {
        border: solid 1px;
    }

    .document .gerb {
        padding-top: 80px;
        margin-top: 20px;
        background: url(/images/gerb.gif) center 0px no-repeat;
        overflow: visible;
    }

    .section_list h3 {
        font-size: 1.3em;
        border-bottom: dotted 1px #333;
    }

    table.small-fonts td {
        font-size: 0.8em;
    }

    img.archive_thumbs {
        border: solid 1px #bbb;
    }

    ul.archive_elements {
        margin: 0px;
    }

        ul.archive_elements li {
            display: block;
            border: solid 1px #bbb;
            padding: 5px;
            float: left;
            text-align: center;
            margin: 0px;
            margin-right: 5px;
            margin-bottom: 5px;
            min-height: 165px;
        }

            ul.archive_elements li.file {
                display: list-item;
            }

            ul.archive_elements li img {
 ");
            WriteLiteral(@"               margin-top: 4px;
            }

    .tooltip .description {
        display: none;
        border: solid 1px #777;
        float: left;
        position: absolute;
        left: 18px;
        margin-top: -100px;
        background-color: #D6DBFA;
        padding: 5px;
        width: 573px;
        max-height: 200px;
        overflow: auto;
        text-decoration: none !important;
    }

    .tooltip {
        display: inline;
        border-bottom: dotted 1px #333;
        background-color: #eee;
        cursor: pointer;
    }

    div.inner_block img.emblems {
        max-width: 550px;
        display: block;
        margin-left: auto;
        margin-right: auto;
        margin-bottom: 20px;
        padding: 5px;
        border: solid 1px #ccc;
    }

    .section_list h3 {
        margin-top: 20px;
    }

    div.paging {
        overflow-x: auto;
        overflow-y: no;
        width: 100%;
        height: 45px;
    }

        div.paging > div {");
            WriteLiteral(@"
            white-space: nowrap;
        }

        div.paging span {
            list-style: none;
            padding: 5px;
            padding-bottom: 2px;
            padding-top: 2px;
            margin: 0px;
            margin-right: 5px;
            margin-bottom: 5px;
            border: solid 1px #777;
            font-size: 0.8em;
            background-color: #ddd;
        }

            div.paging span:hover {
                background-color: #ccc;
            }

            div.paging span.current {
                background-color: #fff;
            }

    #logo {
        cursor: pointer;
        padding-left: 5px;
    }

        #logo h1 {
            color: #305ab0;
            height: 30px;
            padding-bottom: 5px;
        }

        #logo p {
            color: #777;
            margin-left: 1px;
        }

        #logo h1 {
            margin-bottom: 0px;
        }

        #logo h2 {
            font-size: 1em;
            margin-bo");
            WriteLiteral(@"ttom: 3px;
            margin-left: 1px;
            text-transform: uppercase;
            color: #5083AC;
        }

    .float-right {
        float: right;
    }

    div.left_block {
        padding-right: 10px;
        border-right: solid 1px #ccc;
    }

    ul.mainmenu {
        line-height: 28px;
    }

        ul.mainmenu li {
            margin-left: 0px;
            text-transform: uppercase;
            list-style: none;
            font-size: 110%;
            padding-left: 5px;
            border-top: dotted 1px #ccc;
        }

            ul.mainmenu li a {
                color: #000;
                text-decoration: none;
                font-weight: bold;
            }

            ul.mainmenu li:hover {
                background-color: #9BBBD5;
            }

    .header_block {
        border-bottom: solid 1px #ccc;
        margin-bottom: 10px;
    }

    .section_list ul {
        margin-left: 5px;
    }

    .document h1,
    .document h");
            WriteLiteral(@"4,
    .inner_block h1 {
        border-bottom: dotted 1px #5083AC;
        text-transform: uppercase;
        margin-top: 7px;
        font-size: 1.1em;
    }

    .banner_block {
        padding-top: 50px;
        text-align: center;
    }

        .banner_block a {
            display: block;
            padding-bottom: 5px;
        }

    ul.certs {
        margin-top: 20px;
    }

        ul.certs li {
            display: block;
            float: left;
            margin-left: 0px;
            padding-top: 5px;
            padding-left: 35px;
            padding-right: 15px;
            background: url(/images/CertPackageIcon.gif) no-repeat;
            height: 30px;
            margin-bottom: 10px;
        }

    /*ul.certs li.outdated {
            background: url(/images/OutdatedCertPackageIcon.gif) no-repeat;
        }*/

    table.row-borders {
        width: 100%;
    }

    .main_block {
    }

    .root_block {
        background-color: #fff;
     ");
            WriteLiteral(@"   min-height: 100%;
        border-left: solid 1px #ccc;
        border-right: solid 1px #ccc;
        padding: 10px;
    }

    li.cer {
        background: url(/images/CertPackageIcon.gif) no-repeat 0px 0px;
        list-style-type: none;
        margin-left: 0px;
        padding-left: 35px;
        padding-top: 5px;
        padding-bottom: 0px;
        margin-top: 10px;
        min-height: 30px;
    }

    li.crl {
        background: url(/images/crl.gif) no-repeat 0px 0px;
        list-style-type: none;
        margin-left: 0px;
        padding-left: 35px;
        padding-top: 7px;
        padding-bottom: 0px;
        margin-top: 10px;
        min-height: 30px;
    }

    div.news div.item {
        border-bottom: dotted 1px #ccc;
        padding-left: 4px;
        padding-right: 4px;
        padding-top: 10px;
    }

    div.news p.date {
        margin-top: 0px;
        margin-bottom: 0px;
        padding-bottom: 0px;
        font-weight: bold;
    }

    div.n");
            WriteLiteral(@"ews p.announce {
        padding-top: 0px;
        margin-top: 0px;
    }

    div.news p.news_footer {
        padding-top: 0px;
        margin-top: 0px;
        padding-right: 4px;
        text-align: right;
        font-style: italic;
    }

    div.news h4 {
        margin-bottom: 0px;
        padding-bottom: 0px;
    }

    div.news div.item h4 {
        border: 0px;
    }

    p.delimiter {
        margin: 0px;
    }

    .blue_bg {
        background-color: #FFFAEB;
    }

    table.doc tr td {
        padding-left: 10px;
        padding-bottom: 10px;
    }

    /* ЕКРАНИ */
    ");
            WriteLiteral("@media (max-width: 991px) {\r\n        /* Згорнуте меню */\r\n        #navbar-collapsible {\r\n            background-color: white;\r\n        }\r\n\r\n            #navbar-collapsible a {\r\n                color: black;\r\n            }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (max-width: 767px) {\r\n        /* Підвал на середньому */\r\n        body {\r\n            margin-bottom: 320px;\r\n        }\r\n\r\n        #footer {\r\n            height: 320px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (max-width: 576px) {\r\n        /* Підвал на мобільному */\r\n        body {\r\n            margin-bottom: 400px;\r\n        }\r\n\r\n        #footer {\r\n            height: 400px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (min-width: 992px) {
        /* Відступи між пунктами меню */
        .nav-item {
            margin: 0 4px;
        }
    }

    /* Назва організації у шапці */
    #orgname-sm {
        display: none;
    }

    #orgname-md {
        display: inline-block;
    }

    ");
            WriteLiteral(@"@media (max-width: 581px) {
        #orgname-sm {
            display: inline-block;
        }

        #orgname-md {
            display: none;
        }
    }

    /* Зображення у новинах */
    .newslistlogo {
        float: left;
        margin: 0px 10px 10px 0px;
        width: 360px;
        max-height: 360px;
    }

    .newslogo {
        float: left;
        margin: 0px 10px 10px 0px;
        width: 360px;
        max-height: 360px;
    }

    ");
            WriteLiteral(@"@media (max-width: 767px) {
        .newslistlogo {
            float: none;
            width: 100%;
        }
    }
</style>

<div class=""container-write"">
    <center>

        <div id=""sign-widget-parent"" style=""max-width: 600px;height: 600px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c838fcfb1d2e4b0458647bd54c02dce2523ca95c18726", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </center>\r\n</div>\r\n\r\n");
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
