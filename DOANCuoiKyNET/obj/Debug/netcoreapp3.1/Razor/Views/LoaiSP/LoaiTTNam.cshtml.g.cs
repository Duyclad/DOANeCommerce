#pragma checksum "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52f4002c04cb42224791cb92c7211c90a509874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoaiSP_LoaiTTNam), @"mvc.1.0.view", @"/Views/LoaiSP/LoaiTTNam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52f4002c04cb42224791cb92c7211c90a509874", @"/Views/LoaiSP/LoaiTTNam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_LoaiSP_LoaiTTNam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOANCuoiKyNET.Entities.LoaiSP>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
  
    ViewData["Title"] = "LoaiTTNam";
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 157, "\"", 252, 4);
            WriteAttributeValue("", 164, "/SanPham/LoaiSP/", 164, 16, true);
#nullable restore
#line 9 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
WriteAttributeValue("", 180, SlugGenerator.SlugGenerator.GenerateSlug(item.tenLoaiSP), 180, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 237, "-", 237, 1, true);
#nullable restore
#line 9 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
WriteAttributeValue("", 238, item.idLoaiSP, 238, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">");
#nullable restore
#line 9 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.tenLoaiSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\LoaiSP\LoaiTTNam.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOANCuoiKyNET.Entities.LoaiSP>> Html { get; private set; }
    }
}
#pragma warning restore 1591
