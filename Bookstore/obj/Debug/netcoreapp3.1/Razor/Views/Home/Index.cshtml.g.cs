#pragma checksum "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d74f14c3ad7f7eff3b7636db43cd991a4dadf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\_ViewImports.cshtml"
using Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d74f14c3ad7f7eff3b7636db43cd991a4dadf5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3b0fbadf0458c4e3afe1c82c8c1e30d3d3c0dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 350px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Bookstore";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Search Section -->\n<div class=\"container-fluid search-bg\">\n    <div class=\"text-center\">\n        <h1 class=\"display-4\">Welcome DJ_Engiz</h1>\n    </div>\n\n    <div class=\"col-md-6 mx-auto p-5\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d74f14c3ad7f7eff3b7636db43cd991a4dadf55471", async() => {
                WriteLiteral("\n            <div class=\"input-group\">\n                <input type=\"text\" class=\"form-control bg-light\" placeholder=\"Search\" name=\"Search\" id=\"searchbook\"");
                BeginWriteAttribute("value", " value=\"", 480, "\"", 488, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                <button class=\"btn btn-success\" id=\"searchBtn\">\n                    Search\n                    <i class=\"fa fa-search\"></i>\n                </button>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<!-- Banner Section -->
<div class=""container-fluid bookstore-background"">
    <div class=""row"">
        <div class=""col-12"">
            <h1 class=""display-4 banner-text-style1"">Welcome to our online bookstore</h1>
            <h4 class=""display-4 banner-text-style2"">Find Your Next Adventure</h4>
            <div class=""col-md-6 quotes-section"">
                <blockquote class=""quote-text-quote"" id=""quote""></blockquote>
                <p class=""quote-text-author"" id=""quote_author""></p>
");
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n\n<!-- All Books Section-->\n<div class=\"container-fluid\">\n    <h2>All Books</h2>\n    <h6><em>List of all books</em></h6>\n    <div class=\"row pb-5 cards-div-background  pl-2 pr-2\">\n");
#nullable restore
#line 45 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
         foreach (var book in Model.AllBooksList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-md-3 mt-5\">\n            <!-- <div class=\"card h-100\" style=\"background-image: url(/photos/");
#nullable restore
#line 48 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
                                                                         Write(book.PhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("); background-repeat: no-repeat; background-size: 100% 100%;\">-->\n            <div class=\"card h-100\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45d74f14c3ad7f7eff3b7636db43cd991a4dadf59226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1831, "~/photos/", 1831, 9, true);
#nullable restore
#line 50 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1840, book.PhotoURL, 1840, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\"> ");
#nullable restore
#line 52 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\n                    <h6");
            BeginWriteAttribute("class", " class=\"", 2058, "\"", 2066, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by</em> &nbsp; ");
#nullable restore
#line 53 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => book.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n                    <hr />\n                    <p class=\"card-text\">Category: ");
#nullable restore
#line 55 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => book.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\">Book Type: ");
#nullable restore
#line 56 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => book.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <button class=""btn btn-secondary btn-block btn-wishlist"">
                    <i class=""fas fa-plus-circle""></i>&nbsp;&nbsp; Add to Wishlist
                    </button>
                    <button class=""btn btn-success btn-block""> 
                    <i class=""fas fa-cart-plus""></i>&nbsp;&nbsp; Add to Card
                    </button>
                </div>
            </div>
        </div>
");
#nullable restore
#line 66 "C:\Users\lido\Desktop\.Net(Core)\BookStore_DJ\Bookstore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d74f14c3ad7f7eff3b7636db43cd991a4dadf513218", async() => {
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
                WriteLiteral("\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591