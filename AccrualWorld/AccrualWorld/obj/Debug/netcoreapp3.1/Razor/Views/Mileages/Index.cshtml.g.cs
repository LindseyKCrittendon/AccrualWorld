#pragma checksum "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d62df6447395f60546a98cf81a18dbdbbbc2e18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mileages_Index), @"mvc.1.0.view", @"/Views/Mileages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d62df6447395f60546a98cf81a18dbdbbbc2e18", @"/Views/Mileages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9310b666124367327d369f79bfc7a43a079b32f", @"/Views/_ViewImports.cshtml")]
    public class Views_Mileages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccrualWorld.Models.Mileage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Mileage</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d62df6447395f60546a98cf81a18dbdbbbc2e185054", async() => {
                WriteLiteral("Add Mileage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <span>Start Date :</span> <input type=\"date\" name=\"start\" />\r\n\r\n\r\n\r\n        <span>End Date :</span> <input type=\"date\" name=\"end\" />\r\n\r\n\r\n\r\n        <input type=\"submit\" value=\"Get Mileage Between Dates\" />\r\n\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
    //Date range picker with table


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AmountPerMile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Deduction\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AmountPerMile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $0.58\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d62df6447395f60546a98cf81a18dbdbbbc2e1811527", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                                               WriteLiteral(item.MileageId);

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
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d62df6447395f60546a98cf81a18dbdbbbc2e1813744", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                                                  WriteLiteral(item.MileageId);

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
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d62df6447395f60546a98cf81a18dbdbbbc2e1815967", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                                                 WriteLiteral(item.MileageId);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 90 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h4>Monthly Totals</h4>
    <table class=""table table-striped table-bordered"">
        <thead>

            <tr>
                <th>
                    Total Miles
                </th>
                <th>
                    Total Unpaid Miles
                </th>
                <th>
                    Total Paid Miles
                </th>

                <th>
                    Total Amount Paid
                </th>
                <th>
                    Total Amount Unpaid
                </th>
                <th>
                    Total Deduction
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
#nullable restore
#line 121 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString()).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 124 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 127 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 130 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round((Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.42), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 133 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round((Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total) * 0.58), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 136 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round(((Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total) * 0.58) + ((Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.58)) - (Model.Where(i => i.DateTime.Month.ToString() == DateTime.Now.Month.ToString() && i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.42)), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>

            </tr>
        </tbody>

    </table>

    <h4>Yearly Totals</h4>
    <table class=""table table-striped table-bordered"">
        <thead>

            <tr>
                <th>
                    Total Miles
                </th>
                <th>
                    Total Unpaid Miles
                </th>
                <th>
                    Total Paid Miles
                </th>

                <th>
                    Total Amount Paid
                </th>
                <th>
                    Total Amount Unpaid
                </th>
                <th>
                    Total Deduction
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
#nullable restore
#line 173 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString()).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 176 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 179 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
               Write(Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 182 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round((Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.42), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 185 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round((Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total) * 0.58), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 188 "C:\Users\Newforce.NEWFORCE-015\workspace\AccrualWorld\AccrualWorld\AccrualWorld\Views\Mileages\Index.cshtml"
                Write(Math.Round(((Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == false).Sum(i => i.Total) * 0.58) + ((Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.58)) - (Model.Where(i => i.DateTime.Year.ToString() == DateTime.Now.Year.ToString() && i.Paid == true).Sum(i => i.Total) * 0.42)), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n            </tr>\r\n        </tbody>\r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccrualWorld.Models.Mileage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
