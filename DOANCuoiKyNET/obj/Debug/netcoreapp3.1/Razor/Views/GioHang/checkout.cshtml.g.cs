#pragma checksum "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9498df2302ec18a0e55c70da5bfb8450082f542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_checkout), @"mvc.1.0.view", @"/Views/GioHang/checkout.cshtml")]
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
#line 1 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9498df2302ec18a0e55c70da5bfb8450082f542", @"/Views/GioHang/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "xacnhancheckout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
  
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Checkout Start -->\r\n<div class=\"checkout\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9498df2302ec18a0e55c70da5bfb8450082f5424120", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""checkout-inner"">
                        <div class=""billing-address"">
                            <h2>Thông tin khách hàng</h2>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Họ</label>
                                    <input class=""form-control"" name=""ho"" type=""text"" placeholder=""First Name""");
                BeginWriteAttribute("value", " value=\"", 691, "\"", 710, 1);
#nullable restore
#line 16 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 699, ViewBag.ho, 699, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""col-md-6"">
                                    <label>Tên""</label>
                                    <input class=""form-control"" name=""ten"" type=""text"" placeholder=""Last Name""");
                BeginWriteAttribute("value", " value=\"", 977, "\"", 997, 1);
#nullable restore
#line 20 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 985, ViewBag.ten, 985, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""col-md-6"">
                                    <label>E-mail</label>
                                    <input class=""form-control"" name=""email"" type=""text"" placeholder=""E-mail""");
                BeginWriteAttribute("value", " value=\"", 1265, "\"", 1287, 1);
#nullable restore
#line 24 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 1273, ViewBag.email, 1273, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""col-md-6"">
                                    <label>Số điện thoại</label>
                                    <input class=""form-control"" name=""sdt"" maxlength=""10"" type=""text"" placeholder=""Mobile No""");
                BeginWriteAttribute("value", " value=\"", 1578, "\"", 1598, 1);
#nullable restore
#line 28 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 1586, ViewBag.sdt, 1586, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""col-md-12"">
                                    <label>Địa chỉ</label>
                                    <input class=""form-control"" name=""diachi"" type=""text"" placeholder=""Address""");
                BeginWriteAttribute("value", " value=\"", 1870, "\"", 1893, 1);
#nullable restore
#line 32 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 1878, ViewBag.diachi, 1878, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""col-md-6"">
                                    <label>Ghi chú</label>
                                    <input class=""form-control"" name=""ghichu"" type=""text"" placeholder=""Ghi chú"">
                                </div>
                                

                            </div>
                        </div>


                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""checkout-inner"">
                        <div class=""checkout-summary"">
                            <h1>Thông tin thanh toán</h1>
                        
                            <p>Giá trị hàng hóa<span>");
#nullable restore
#line 51 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
                                                Write(ViewBag.tth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                            <input hidden name=\"tth\"");
                BeginWriteAttribute("value", " value=\"", 2728, "\"", 2748, 1);
#nullable restore
#line 52 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 2736, ViewBag.tth, 2736, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input hidden name=\"mggvl\"");
                BeginWriteAttribute("value", " value=\"", 2806, "\"", 2828, 1);
#nullable restore
#line 53 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 2814, ViewBag.mggvl, 2814, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input hidden name=\"mggvlcode\"");
                BeginWriteAttribute("value", " value=\"", 2890, "\"", 2916, 1);
#nullable restore
#line 54 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 2898, ViewBag.mggvlcode, 2898, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input hidden name=\"tongcong\"");
                BeginWriteAttribute("value", " value=\"", 2977, "\"", 3002, 1);
#nullable restore
#line 55 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
WriteAttributeValue("", 2985, ViewBag.tongcong, 2985, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p class=\"sub-total\">Giảm giá<span>");
#nullable restore
#line 56 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
                                                          Write(ViewBag.mggvl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\r\n                            <p class=\"ship-cost\">Phí giao hàng<span>FREE</span></p>\r\n                            <h2>Tổng cộng<span>");
#nullable restore
#line 59 "E:\STUDY NET.MVC\DOANCuoiKyNET\DOANCuoiKyNET\Views\GioHang\checkout.cshtml"
                                          Write(ViewBag.tongcong);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></h2>
                        </div>

                        <div class=""checkout-payment"">

                            <div class=""checkout-btn"">
                                <button>Đặt hàng</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
               
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!-- Checkout End -->");
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