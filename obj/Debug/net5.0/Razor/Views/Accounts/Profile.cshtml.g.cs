#pragma checksum "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229066127d06a2145d07bcae81b28eb4ea874373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Profile), @"mvc.1.0.view", @"/Views/Accounts/Profile.cshtml")]
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
#line 1 "D:\FshopASP\FshopASP\Views\_ViewImports.cshtml"
using FshopASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FshopASP\FshopASP\Views\_ViewImports.cshtml"
using FshopASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229066127d06a2145d07bcae81b28eb4ea874373", @"/Views/Accounts/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21968bd082d17f86fb7021492fd6064162172aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FshopASP.Models.Account>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
  
    ViewBag.title = "Hồ sơ";
    Layout = "_LayoutTemplate";


#line default
#line hidden
#nullable disable
            DefineSection("Top", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "229066127d06a2145d07bcae81b28eb4ea8743734764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Bottom", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "229066127d06a2145d07bcae81b28eb4ea8743736064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    body {
    background: #dc3545
    }

    .form-control:focus {
    box-shadow: none;
    border-color: #BA68C8
    }

    .profile-button {
    background: #BA68C8;
    box-shadow: none;
    border: none
    }

    .profile-button:hover {
    background: #682773
    }

    .profile-button:focus {
    background: #682773;
    box-shadow: none
    }

    .profile-button:active {
    background: #682773;
    box-shadow: none
    }

    .back:hover {
    color: #682773;
    cursor: pointer
    }

    .labels {
    font-size: 11px
    }

    .add-experience:hover {
    background: #BA68C8;
    color: #fff;
    cursor: pointer;
    border: solid 1px #BA68C8
    }
");
            }
            );
            WriteLiteral(@"<!-- breadcrumb-section -->
<div class=""breadcrumb-section breadcrumb-bg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 offset-lg-2 text-center"">
                <div class=""breadcrumb-text"">
                    <p> ");
#nullable restore
#line 67 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
                   Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h1>Hồ sơ cá nhân</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\" style=\"height:100%\">\r\n");
#nullable restore
#line 75 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
     if (ViewBag.Username != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <nav class=""navbar navbar-expand-sm navbar-dark bg-dark"">
            <div class=""container-fluid"">

                <div class=""collapse navbar-collapse"" id=""mynavbar"">
                    <ul class=""navbar-nav me-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""javascript:void(0)"">Thông tin cá nhân</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""javascript:void(0)"">Đơn hàng của tôi</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""javascript:void(0)"">Chi tiết đơn hàng</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
");
#nullable restore
#line 95 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
         if (ViewBag.info == -1)
        {
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container rounded bg-white mt-5 mb-5"">
                    <div class=""row"">
                        <div class=""col-md-3 border-right"">
                            <div class=""d-flex flex-column align-items-center text-center p-3 py-5"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "229066127d06a2145d07bcae81b28eb4ea87437310474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2751, "~/assets/img/avaters/", 2751, 21, true);
#nullable restore
#line 103 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
AddHtmlAttributeValue("", 2772, item.Image, 2772, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <span class=\"font-weight-bold\">");
#nullable restore
#line 104 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
                                                          Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"text-black-50\">");
#nullable restore
#line 105 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
                                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <span>Việt Nam</span>
                            </div>
                        </div>
                        <div class=""col-md-5 border-right"">
                            <div class=""p-3 py-5"">

                                <div class=""row mt-2"">
                                    <div class=""col-md-6"">
                                        <label class=""labels"">Họ tên</label>
                                        <input type=""text"" class=""form-control"" placeholder=""first name""");
            BeginWriteAttribute("value", " value=\"", 3500, "\"", 3522, 1);
#nullable restore
#line 115 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
WriteAttributeValue("", 3508, item.FullName, 3508, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""col-md-6"">
                                        <label class=""labels"">Tên hiển thị</label>
                                        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3793, "\"", 3815, 1);
#nullable restore
#line 119 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
WriteAttributeValue("", 3801, item.Username, 3801, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Doe"">
                                    </div>
                                </div>
                                <div class=""row mt-3"">
                                    <div class=""col-md-12"">
                                        <label class=""labels"">Địa chỉ</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Địa chỉ""");
            BeginWriteAttribute("value", " value=\"", 4218, "\"", 4239, 1);
#nullable restore
#line 125 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
WriteAttributeValue("", 4226, item.Address, 4226, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""col-md-12"">
                                        <label class=""labels"">Số điện thoại</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Só phone""");
            BeginWriteAttribute("value", " value=\"", 4535, "\"", 4554, 1);
#nullable restore
#line 129 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
WriteAttributeValue("", 4543, item.Phone, 4543, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>                                 
                                </div>
                             
                                <div class=""mt-5 text-center""><button class=""btn btn-primary profile-button"" type=""button"">Save Profile</button></div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""p-3 py-5"">
                                <div class=""d-flex justify-content-between align-items-center experience""><span>Edit Experience</span><span class=""border px-3 p-1 add-experience""><i class=""fa fa-plus""></i>&nbsp;Experience</span></div>
                                <div class=""d-flex flex-row mt-3 exp-container"">
                                    <img src=""https://i.imgur.com/azSfBM3.png"" width=""45"" height=""45"">
                                    <div class=""work-experience ml-1""><span class=""font-weight-bold d-block"">Senior UI/UX Designer<");
            WriteLiteral(@"/span><span class=""d-block text-black-50 labels"">Twitter Inc.</span><span class=""d-block text-black-50 labels"">March,2017 - May 2020</span></div>
                                </div>
                                <hr>
                                <div class=""d-flex flex-row mt-3 exp-container"">
                                    <img src=""https://img.icons8.com/color/100/000000/facebook.png"" width=""45"" height=""45"">
                                    <div class=""work-experience ml-1""><span class=""font-weight-bold d-block"">Senior UI/UX Designer</span><span class=""d-block text-black-50 labels"">Facebook Inc.</span><span class=""d-block text-black-50 labels"">March,2017 - May 2020</span></div>
                                </div>
                                <hr>
                                <div class=""d-flex flex-row mt-3 exp-container"">
                                    <img src=""https://img.icons8.com/color/50/000000/google-logo.png"" width=""45"" height=""45"">
                          ");
            WriteLiteral(@"          <div class=""work-experience ml-1""><span class=""font-weight-bold d-block"">UI/UX Designer</span><span class=""d-block text-black-50 labels"">Google Inc.</span><span class=""d-block text-black-50 labels"">March,2017 - May 2020</span></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 157 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"height:40%\">\r\n        </div>\r\n        <h1>Bạn chưa đăng nhập</h1>\r\n");
#nullable restore
#line 166 "D:\FshopASP\FshopASP\Views\Accounts\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FshopASP.Models.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
