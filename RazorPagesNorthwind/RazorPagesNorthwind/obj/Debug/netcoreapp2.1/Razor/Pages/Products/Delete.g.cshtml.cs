#pragma checksum "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecfa479ebb8a6618ad5710c9043862838d173674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesNorthwind.Pages.Products.Pages_Products_Delete), @"mvc.1.0.razor-page", @"/Pages/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Products/Delete.cshtml", typeof(RazorPagesNorthwind.Pages.Products.Pages_Products_Delete), null)]
namespace RazorPagesNorthwind.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\_ViewImports.cshtml"
using RazorPagesNorthwind;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfa479ebb8a6618ad5710c9043862838d173674", @"/Pages/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252a0a685652465168116e7ffabce6d02b467f5d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(106, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(275, 55, false);
#line 16 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 51, false);
#line 19 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(469, 54, false);
#line 22 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(567, 50, false);
#line 25 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(661, 54, false);
#line 28 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(759, 50, false);
#line 31 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(853, 59, false);
#line 34 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(912, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(956, 55, false);
#line 37 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1055, 53, false);
#line 40 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1152, 49, false);
#line 43 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1245, 56, false);
#line 46 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1345, 52, false);
#line 49 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1441, 56, false);
#line 52 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1541, 52, false);
#line 55 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1637, 56, false);
#line 58 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1737, 52, false);
#line 61 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1833, 56, false);
#line 64 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1933, 52, false);
#line 67 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Product.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2023, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccd30434275941c59e01a06b0ca35c07", async() => {
                BeginContext(2043, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2053, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a02f448e8e94abb91f2b0bcd32c12d4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "C:\myRazorPages\Proj_1\razor_rev2\RazorPagesNorthwind\RazorPagesNorthwind\RazorPagesNorthwind\Pages\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Product.ProductID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2104, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2188, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b05aa515694847d1b14e6502c49b7130", async() => {
                    BeginContext(2210, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2226, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2239, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesNorthwind.Pages.Products.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesNorthwind.Pages.Products.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesNorthwind.Pages.Products.DeleteModel>)PageContext?.ViewData;
        public RazorPagesNorthwind.Pages.Products.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
