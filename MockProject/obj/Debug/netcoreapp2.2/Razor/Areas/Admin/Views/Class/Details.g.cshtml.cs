#pragma checksum "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0662c8f10f12f0f02494dd927c4c75c7a916e3da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Class_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Class/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Class/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Class_Details))]
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
#line 1 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/_ViewImports.cshtml"
using MockProject;

#line default
#line hidden
#line 2 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/_ViewImports.cshtml"
using MockProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0662c8f10f12f0f02494dd927c4c75c7a916e3da", @"/Areas/Admin/Views/Class/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Class_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Class>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
  
    ViewData["Title"] = "Details Classes";
    var listStudent = ViewBag.CC as IEnumerable<User>;

#line default
#line hidden
            BeginContext(123, 264, true);
            WriteLiteral(@"
<h1>Details</h1>
<h4>Classes</h4>
<hr/>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-content"">

                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
            EndContext();
            BeginContext(388, 45, false);
#line 18 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.NameClass));

#line default
#line hidden
            EndContext();
            BeginContext(433, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(531, 41, false);
#line 21 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayFor(model => model.NameClass));

#line default
#line hidden
            EndContext();
            BeginContext(572, 96, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(669, 40, false);
#line 24 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(709, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(807, 36, false);
#line 27 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(843, 96, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(940, 43, false);
#line 30 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Faculty));

#line default
#line hidden
            EndContext();
            BeginContext(983, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(1081, 44, false);
#line 33 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Faculty.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 132, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                </dl>\r\n            </div>\r\n\r\n            <div style=\"margin: 5px\">\r\n                 ");
            EndContext();
            BeginContext(1257, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0662c8f10f12f0f02494dd927c4c75c7a916e3da7971", async() => {
                BeginContext(1327, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1335, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(1354, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0662c8f10f12f0f02494dd927c4c75c7a916e3da10370", async() => {
                BeginContext(1399, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1415, 716, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-content"">
                <table id=""listStudent"" class=""table"">
                    <thead>
                    <tr>
                        <th>
                            Name Student
                        </th>
                        <th>
                            Address
                        </th>
                        <th>
                            Gender
                        </th>
                        <th> Faculty</th>
                    </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 68 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                     foreach (var item in listStudent)
                    {

#line default
#line hidden
            BeginContext(2210, 63, true);
            WriteLiteral("                        <tr>\r\n                            <td> ");
            EndContext();
            BeginContext(2274, 34, false);
#line 71 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2308, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(2349, 37, false);
#line 72 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(2427, 41, false);
#line 73 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                            Write(Html.Raw(item.Gender ? "Male" : "Famale"));

#line default
#line hidden
            EndContext();
            BeginContext(2468, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(2509, 42, false);
#line 74 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.Faculty.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2551, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 76 "/home/kimhung/RiderProjects/QLDiem/MockProject/Areas/Admin/Views/Class/Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2612, 116, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2747, 201, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function() {\r\n\r\n            $(\'#listStudent\').DataTable({\r\n                pageLength: 10\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Class> Html { get; private set; }
    }
}
#pragma warning restore 1591