#pragma checksum "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ce2babfadbd816126d4d5602ce6b8f35893ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pharmacy_SupplyList), @"mvc.1.0.view", @"/Views/Pharmacy/SupplyList.cshtml")]
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
#line 1 "C:\Users\aswin\source\repos\Portal\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aswin\source\repos\Portal\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ce2babfadbd816126d4d5602ce6b8f35893ff1", @"/Views/Pharmacy/SupplyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Pharmacy_SupplyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pharmacy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dash", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SavePharmacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
  
    ViewData["Title"] = "Supply List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg-white pb-lg-5\">\r\n    <h3>Supply Details</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ce2babfadbd816126d4d5602ce6b8f35893ff14130", async() => {
                WriteLiteral("\r\n        <table class=\"table table-bordered border-dark pb-5\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 13 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].PharmacyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 16 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].MedicineName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 19 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].SupplyCount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 28 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PharmacyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 32 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                             foreach (var name in item.MedicineName)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                           Write(Html.DisplayFor(modelItem => name));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 35 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 39 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                             foreach (var name in item.SupplyCount)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                           Write(Html.DisplayFor(modelItem => name));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 42 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\aswin\source\repos\Portal\Portal\Views\Pharmacy\SupplyList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n            <input type=\"submit\" class=\"btn btn-outline-dark\" value=\"Save to Dashboard\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pharmacy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
