#pragma checksum "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba0137825b4fb76efb11159b130bc787e7ffab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductSale), @"mvc.1.0.view", @"/Views/Products/ProductSale.cshtml")]
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
#line 1 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\_ViewImports.cshtml"
using OnlineSalePrj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\_ViewImports.cshtml"
using OnlineSalePrj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba0137825b4fb76efb11159b130bc787e7ffab0", @"/Views/Products/ProductSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d52f09a21c87a8f0d9f7eb33bbc720d34b7391a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineSalePrj.ViewModel.ProductPruchaseItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductSale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
  
    ViewData["Title"] = "ProductSale";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" style=\"padding-top:25px;\">\r\n        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba0137825b4fb76efb11159b130bc787e7ffab05035", async() => {
                WriteLiteral(@"
            <table id=""tblshow"" border=""1"" class=""table table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <td>Image</td>
                        <td>Product Name</td>
                        <td>Qty</td>
                        <td>Price</td>
                        <td>Action</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ba0137825b4fb76efb11159b130bc787e7ffab06108", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
                               WriteLiteral("~/Image/"+item.ImageName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 27 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1130, "\"", 1148, 1);
#nullable restore
#line 28 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1138, item.Name, 1138, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1149, "\"", 1168, 2);
                WriteAttributeValue("", 1154, "Name", 1154, 4, true);
#nullable restore
#line 28 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1158, item.ID, 1158, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1226, "\"", 1242, 1);
#nullable restore
#line 29 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1234, item.ID, 1234, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1316, 1);
#nullable restore
#line 30 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1308, item.ID, 1308, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"prod\"/>\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" value=\"0\"");
                BeginWriteAttribute("id", " id=\"", 1460, "\"", 1478, 2);
                WriteAttributeValue("", 1465, "Qty", 1465, 3, true);
#nullable restore
#line 33 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1468, item.ID, 1468, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1536, "\"", 1553, 1);
#nullable restore
#line 34 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1544, item.Qty, 1544, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1554, "\"", 1572, 2);
                WriteAttributeValue("", 1559, "Qty", 1559, 3, true);
#nullable restore
#line 34 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1562, item.ID, 1562, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1630, "\"", 1646, 1);
#nullable restore
#line 35 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1638, item.ID, 1638, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1818, "\"", 1837, 1);
#nullable restore
#line 39 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1826, item.Price, 1826, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1838, "\"", 1858, 2);
                WriteAttributeValue("", 1843, "Price", 1843, 5, true);
#nullable restore
#line 39 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1848, item.ID, 1848, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1916, "\"", 1932, 1);
#nullable restore
#line 40 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 1924, item.ID, 1924, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input class=\"btn btn-success\" type=\"button\" value=\"Add\"");
                BeginWriteAttribute("onclick", "  onclick=\"", 2095, "\"", 2123, 3);
                WriteAttributeValue("", 2106, "Additem(", 2106, 8, true);
#nullable restore
#line 43 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
WriteAttributeValue("", 2114, item.ID, 2114, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2122, ")", 2122, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 47 "D:\entity framework\OnlineSalePrj\OnlineSalePrj\Views\Products\ProductSale.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </tbody>
            </table>
            <table width=""500px"" border=""1"" class=""table table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Qty</th>
                        <th>Total Price</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody id=""addtable"">
                </tbody>
            </table><br />
            <input class=""btn btn-primary"" type=""submit"" value=""Create"" ");
                WriteLiteral(" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
            <script>
                var i = 0;
                function Additem(k) {
                    var name = $(""#Name"" + k).val();
                    var price = $(""#Price"" + k).val();
                    
                    var qty = $(""#Qty"" + k).val();
                    var totalPrice = price * qty;
                    var tr = '<tr><td>' + name + '</label><input type=""hidden"" name=""ItemList[' + i + '].ProductId"" value=""' + k + '"" /></td><td>' + price + '</label><input type=""hidden"" name=""ItemList[' + i + '].Price"" value=""' + price + '"" /></td><td>' + qty + '</label><input type=""hidden"" name=""ItemList[' + i + '].Qty"" value=""' + qty + '"" /></td><td>' + totalPrice + '</label><input type=""hidden"" name=""ItemList[' + i + '].TotalPricePerItem"" value=""' + totalPrice + '"" /></td></label><input type=""hidden"" name=""ItemList[' + i + '].OrderId"" value=""' + k + '"" /></td><td><a class=""btn btn-danger"" onclick=""Delete(this);"">Delete</a></td></tr>';
                    $(""#addtable"").append(tr);
  ");
                WriteLiteral(@"                  i++;
                }
                function Delete(id) {                    
                    $(id).parent().parent().remove();
                }
            </script>
            <script>
                function CustomerCreate() {
                    
                    //<a class=""nav-link text-dark"" asp-area="""" asp-controller=""Customers"" asp-action=""Create""></a>
                }
            </script>
");
                WriteLiteral("        ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineSalePrj.ViewModel.ProductPruchaseItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591