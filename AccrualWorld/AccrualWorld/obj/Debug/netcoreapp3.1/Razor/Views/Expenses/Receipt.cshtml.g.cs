#pragma checksum "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa063cdf411480d398e56c3cb6a4f34ebf7c5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expenses_Receipt), @"mvc.1.0.view", @"/Views/Expenses/Receipt.cshtml")]
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
#line 1 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\_ViewImports.cshtml"
using AccrualWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\_ViewImports.cshtml"
using AccrualWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa063cdf411480d398e56c3cb6a4f34ebf7c5e5", @"/Views/Expenses/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9310b666124367327d369f79bfc7a43a079b32f", @"/Views/_ViewImports.cshtml")]
    public class Views_Expenses_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccrualWorld.Models.Expense>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Incomes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
  
    ViewData["Title"] = "Receipt";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Receipts</h1>\r\n\r\n<table>\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa063cdf411480d398e56c3cb6a4f34ebf7c5e55351", async() => {
                WriteLiteral("View Paystubs and Invoices");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            <a href=\"javascript:window.print()\" class=\"btn btn-dark\">Click to Print This Page</a>\r\n        </th>\r\n    </tr>\r\n        </thead>\r\n</table>\r\n \r\n\r\n");
#nullable restore
#line 25 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
  using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <span>Start Date :</span> <input type=""date"" name=""start"" />



        <span>End Date :</span> <input type=""date"" name=""end"" />



        <input type=""submit"" class=""btn btn-outline-dark"" value=""Get Receipts Between Dates"" />



    </div>
");
#nullable restore
#line 41 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
//Date range picker with table

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped shadow-lg\" style=\"background-color: #F6F1EA\">\r\n<thead>\r\n<tr>\r\n\r\n<th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n<th>\r\n                ");
#nullable restore
#line 50 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n<th>\r\n                Receipt\r\n            </th>\r\n\r\n            \r\n\r\n        </tr>\r\n    </thead>\r\n<tbody>\r\n");
#nullable restore
#line 61 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n\r\n<td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n<td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpenseType.Label));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n<td>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfa063cdf411480d398e56c3cb6a4f34ebf7c5e59683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
WriteLiteral("~/receipt/" + item.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 72 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n\r\n          \r\n        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 82 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Expenses\Receipt.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccrualWorld.Models.Expense>> Html { get; private set; }
    }
}
#pragma warning restore 1591
