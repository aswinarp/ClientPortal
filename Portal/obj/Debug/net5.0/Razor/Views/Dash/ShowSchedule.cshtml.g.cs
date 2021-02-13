#pragma checksum "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005edadecd73e94c248e3268d35471bd45317c14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dash_ShowSchedule), @"mvc.1.0.view", @"/Views/Dash/ShowSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"005edadecd73e94c248e3268d35471bd45317c14", @"/Views/Dash/ShowSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Dash_ShowSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Schedule>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
  
    ViewData["Title"] = "Schedule";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No Data Saved</h3>\r\n");
#nullable restore
#line 9 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
}
else
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container pt-5"">
<div class=""row"">
    <div class=""col-sm-12 bg-dark pr-2 pl-2 pb-1 shadow-sm"" style=""border-radius:15px"">
        <h3 class=""text-white text-center p-3"">Saved Representative Schedule</h3>
        <table class=""table table-bordered bg-white pb-0"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 20 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].DocName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Ailment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DocName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ailment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 57 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                             foreach (var name in item.Medicine)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                           Write(Html.DisplayFor(modelItem => name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 60 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 72 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 78 "C:\Users\aswin\source\repos\Portal\Portal\Views\Dash\ShowSchedule.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Schedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
