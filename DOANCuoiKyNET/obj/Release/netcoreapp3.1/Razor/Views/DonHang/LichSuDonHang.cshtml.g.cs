#pragma checksum "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3700f6b90a3252f84d67339505a9a4f66a03a3b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_LichSuDonHang), @"mvc.1.0.view", @"/Views/DonHang/LichSuDonHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3700f6b90a3252f84d67339505a9a4f66a03a3b6", @"/Views/DonHang/LichSuDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_LichSuDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOANCuoiKyNET.Entities.DonHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
  
    ViewData["Title"] = "LichSuDonHang";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- My Account Start -->
<div class=""my-account"">
    <div class=""container-fluid"">
        <div class=""row"">
          
            <div class=""col-md-12"">
               
                   
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>ID</th>
                                    
                                        <th>Ngày đặt hàng</th>
                                        <th>Tổng tiền</th>
                                        <th>Trạng thái</th>
                                        <th>Chức năng</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 31 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                     foreach(var item in Model)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 36 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                           Write(item.idDH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 37 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                           Write(item.ngayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 38 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                           Write(item.tongSoTien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                                            <td>");
#nullable restore
#line 39 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                           Write(item.trangThai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1546, 3);
            WriteAttributeValue("", 1511, "/donhang/chitietdonhang/", 1511, 24, true);
#nullable restore
#line 40 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
WriteAttributeValue("", 1535, item.idDH, 1535, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1545, "/", 1545, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">View</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 42 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\LichSuDonHang.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    
                 
              
            </div>
        </div>
    </div>
</div>
<!-- My Account End -->







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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOANCuoiKyNET.Entities.DonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591