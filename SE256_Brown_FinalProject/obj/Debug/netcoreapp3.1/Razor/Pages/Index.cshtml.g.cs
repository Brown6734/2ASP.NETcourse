#pragma checksum "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b451a4c6e0e262d4c3987ae0108b3021acf7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SE256_Brown_FinalProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SE256_Brown_FinalProject.Pages
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
#line 1 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\_ViewImports.cshtml"
using SE256_Brown_FinalProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b451a4c6e0e262d4c3987ae0108b3021acf7a7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fcbad9c81f4efe935f8ca44f9994b02272d905", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 8 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                             Write(Model.EmpFName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>

    <br /> <br /> <br /> <br/> 

    <table class=""table table-bordered table-sm table-striped"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Employee First Name</th>
                <th>Employee Last Name</th>
                <th>Employee Email</th>
                <th>Employee Phone</th>
                <th>Employee ID Number</th>
                
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"7\" class=\"text-center\">No Model</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                 foreach (var p in Model.emp1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                       Write(p.Employee_Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Brown\Source\Repos\2ASP.NETcourse\SE256_Brown_FinalProject\Pages\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
