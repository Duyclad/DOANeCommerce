#pragma checksum "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fb23041522a4f5d1a992b681d3bd04e79495fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_Chitietdonhang), @"mvc.1.0.view", @"/Views/DonHang/Chitietdonhang.cshtml")]
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
#line 1 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb23041522a4f5d1a992b681d3bd04e79495fa1", @"/Views/DonHang/Chitietdonhang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_Chitietdonhang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOANCuoiKyNET.Entities.ChiTietDonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
  
    ViewData["Title"] = "Chitietdonhang";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 style=""text-align:center"">Chi ti???t ????n h??ng</h2>
<!-- Cart Start -->
<div class=""cart-page"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""cart-page-inner"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>T??n s???n ph???m</th>
                                    <th>Gi??</th>
                                    <th>S??? l?????ng</th>
                                    <th>Th??nh ti???n</th>
                                
                                </tr>
                            </thead>
                            <tbody class=""align-middle"">
");
#nullable restore
#line 26 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n\r\n                                        <td>\r\n\r\n                                            <div class=\"img\">\r\n                                                <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fb23041522a4f5d1a992b681d3bd04e79495fa15247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1307, "~/images/sanpham/", 1307, 17, true);
#nullable restore
#line 35 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
AddHtmlAttributeValue("", 1324, item.hinhSP, 1324, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                <p>");
#nullable restore
#line 36 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                              Write(item.tenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 39 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                       Write(item.donGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ??</td>
                                        <td>
                                            <div class=""qty"">
                                                <!--<button class=""btn-minus""><i class=""fa fa-minus""></i></button>-->
                                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1882, "\"", 1903, 1);
#nullable restore
#line 43 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
WriteAttributeValue("", 1890, item.soLuong, 1890, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <!--   <button class=""btn-plus""><i class=""fa fa-plus""></i></button>-->
                                            </div>
                                        </td>
                                        <td>");
#nullable restore
#line 47 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                       Write(item.thanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??</td>\r\n\r\n                                       \r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 52 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""cart-page-inner"">
                    <div class=""row"">
                      

                        <div class=""col-md-12"">
                            
                              
                                <div class=""cart-summary"">
                                    <div class=""cart-content"">
                                        <h1>Th??ng tin ????n h??ng</h1>
                                        <p>Ng??y ?????t h??ng<span>");
#nullable restore
#line 70 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                         Write(ViewBag.ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p>Tr???ng th??i<span>");
#nullable restore
#line 71 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                      Write(ViewBag.trangthai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p>T???ng ti???n h??ng<span>");
#nullable restore
#line 72 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                          Write(ViewBag.tth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??</span></p>\r\n                                        <p>Gi???m gi??<span>");
#nullable restore
#line 73 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                    Write(ViewBag.magg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\r\n                                        <p>Ph?? giao h??ng<span>FREE</span></p>\r\n                                        <p>T???ng c???ng<span>");
#nullable restore
#line 75 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                     Write(ViewBag.tongcong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <h1>Th??ng tin ng?????i nh???n</h1>\r\n                                        <p>H??? t??n<span>");
#nullable restore
#line 77 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                  Write(ViewBag.hodh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 77 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                                Write(ViewBag.tendh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p>?????a ch???: ");
#nullable restore
#line 78 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                               Write(ViewBag.diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        <p>Email<span>");
#nullable restore
#line 79 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                                 Write(ViewBag.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p>S??T<span>");
#nullable restore
#line 80 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                               Write(ViewBag.sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p>Ghi ch??: ");
#nullable restore
#line 81 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\Chitietdonhang.cshtml"
                                               Write(ViewBag.ghichu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                
                                </div>
                            
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Cart End -->














");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOANCuoiKyNET.Entities.ChiTietDonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
