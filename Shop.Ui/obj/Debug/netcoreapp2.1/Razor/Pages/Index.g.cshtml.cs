#pragma checksum "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4f81ea1c4674e0449242eb8c2dc522e0ba8960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.Ui.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Shop.Ui.Pages.Pages_Index), null)]
namespace Shop.Ui.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\_ViewImports.cshtml"
using Shop.Ui;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4f81ea1c4674e0449242eb8c2dc522e0ba8960", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376196e0cc86249f2e97a2d681c1be1e024a6e46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/White t-shirt.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 75, true);
            WriteLiteral("\r\n    <div class=\"section\">\r\n        <div class=\"columns is-multiline\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
          
            for(int i = 0; i < 6; i++)
            {

                foreach (var p in Model.Products)
                {

#line default
#line hidden
            BeginContext(285, 103, true);
            WriteLiteral("                    <div class=\"column is-3-desktop is-4-tablet is-6-mobile\">\r\n                        ");
            EndContext();
            BeginContext(388, 2079, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568cf39743dd44aca477b98af34d3961", async() => {
                BeginContext(452, 221, true);
                WriteLiteral("\r\n\r\n                            <div class=\"card\" >\r\n\r\n                                <div class=\"card-image\">\r\n                                    <figure class=\"image is-4by3\">\r\n                                        ");
                EndContext();
                BeginContext(673, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2d789334ada4e6482f564ac79f50018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(713, 151, true);
                WriteLiteral("\r\n                                    </figure>\r\n                                </div>\r\n\r\n                                <div class=\"card-content\">\r\n");
                EndContext();
#line 28 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                      
                                        string cssClass = string.Empty;
                                        string message = string.Empty;

                                        if (p.StockCount == 0)
                                        {
                                            cssClass = "is-danger";
                                            message = "Out of Stock";
                                        }
                                        else if (p.StockCount <= 10)
                                        {
                                            cssClass = "is-warning";
                                            message = "Low on Stock";
                                        }
                                    

#line default
#line hidden
                BeginContext(1677, 36, true);
                WriteLiteral("                                    ");
                EndContext();
#line 43 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                     if (p.StockCount <= 10)
                                       {

#line default
#line hidden
                BeginContext(1781, 44, true);
                WriteLiteral("                                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1825, "\"", 1888, 4);
                WriteAttributeValue("", 1833, "notification", 1833, 12, true);
                WriteAttributeValue(" ", 1845, "is-paddingless", 1846, 15, true);
                WriteAttributeValue(" ", 1860, "has-text-centered", 1861, 18, true);
#line 45 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
WriteAttributeValue(" ", 1878, cssClass, 1879, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1889, 47, true);
                WriteLiteral(">\r\n                                            ");
                EndContext();
                BeginContext(1937, 7, false);
#line 46 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                       Write(message);

#line default
#line hidden
                EndContext();
                BeginContext(1944, 50, true);
                WriteLiteral("\r\n                                        </div>\r\n");
                EndContext();
#line 48 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                       }

#line default
#line hidden
                BeginContext(2036, 107, true);
                WriteLiteral("\r\n                                    <p class=\"title is-size-5\">\r\n                                        ");
                EndContext();
                BeginContext(2144, 6, false);
#line 51 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                   Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2150, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(2154, 7, false);
#line 51 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                             Write(p.Value);

#line default
#line hidden
                EndContext();
                BeginContext(2161, 144, true);
                WriteLiteral("\r\n                                    </p>\r\n\r\n                                    <p class=\"subtitle\">\r\n                                        ");
                EndContext();
                BeginContext(2306, 13, false);
#line 55 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                   Write(p.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2319, 144, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                                                  WriteLiteral(p.Name.Replace(" ","-"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2467, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 61 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(2542, 30, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(2573, 35, false);
#line 67 "C:\Users\User\Desktop\ShopOnline\Shop.Ui\Shop.Ui\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Cart"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
