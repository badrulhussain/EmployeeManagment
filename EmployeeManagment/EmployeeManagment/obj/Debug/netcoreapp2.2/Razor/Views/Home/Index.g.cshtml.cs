#pragma checksum "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3bfbbffcd2d7c9c381f1d5c276654ffe23ee879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3bfbbffcd2d7c9c381f1d5c276654ffe23ee879", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManagment.Model.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(54, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee List";


#line default
#line hidden
            BeginContext(152, 321, true);
            WriteLiteral(@"
<table>
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Depratment
            </th>
            <th>
                Email
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
            BeginContext(526, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(565, 11, false);
#line 31 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(576, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(604, 13, false);
#line 32 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(617, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(645, 19, false);
#line 33 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(664, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(692, 14, false);
#line 34 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(706, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\PC\Documents\GitHub\DotNetCOR\EmployeeManagment\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(743, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(793, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(799, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3bfbbffcd2d7c9c381f1d5c276654ffe23ee8796280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(843, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManagment.Model.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
