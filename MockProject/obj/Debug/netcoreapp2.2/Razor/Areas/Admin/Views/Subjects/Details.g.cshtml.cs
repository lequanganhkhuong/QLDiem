#pragma checksum "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "985341763e95528578c546842876b5011a77050e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subjects_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Subjects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Subjects/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Subjects_Details))]
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
#line 1 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/_ViewImports.cshtml"
using MockProject;

#line default
#line hidden
#line 2 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/_ViewImports.cshtml"
using MockProject.Models;

#line default
#line hidden
#line 1 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
using System.Diagnostics;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"985341763e95528578c546842876b5011a77050e", @"/Areas/Admin/Views/Subjects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subjects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Subject>
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
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
  
    ViewData["Title"] = "User's details";
    var listTeacher = ViewBag.TC as IEnumerable<Schedule>;
    var listStudent = ViewBag.ST as IEnumerable<Transcript>;

#line default
#line hidden
            BeginContext(209, 253, true);
            WriteLiteral("\n<h1>Details</h1>\n<h4>Subject</h4>\n<hr/>\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"card\">\n            <div class=\"card-content\">\n\n                <dl class=\"row\">\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(463, 40, false);
#line 20 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(503, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(598, 36, false);
#line 23 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(634, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(728, 43, false);
#line 26 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(771, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(866, 39, false);
#line 29 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(905, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(999, 44, false);
#line 32 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1138, 40, false);
#line 35 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                   Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 122, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n            </div>\n            <div style=\"margin: 5px\">\n                ");
            EndContext();
            BeginContext(1300, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "985341763e95528578c546842876b5011a77050e8127", async() => {
                BeginContext(1370, 4, true);
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
#line 40 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
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
            BeginContext(1378, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1397, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "985341763e95528578c546842876b5011a77050e10523", async() => {
                BeginContext(1442, 12, true);
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
            BeginContext(1458, 636, true);
            WriteLiteral(@"
            </div>

        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-content"">
                <table  class=""table"">
                    <thead>
                    <tr>
                        <th style=""width: 50%"">
                            Teacher Name
                        </th>

                        <th style=""width: 25%"">
                            Address
                        </th>
                        <th style=""width: 25%"">Code</th>

                    </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 69 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                      
                        Debug.Assert(listTeacher != null, nameof(listTeacher) + " != null");
                    

#line default
#line hidden
            BeginContext(2232, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 72 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                     foreach (var item in listTeacher)
                    {

#line default
#line hidden
            BeginContext(2309, 62, true);
            WriteLiteral("                        <tr>\n                            <td> ");
            EndContext();
            BeginContext(2372, 39, false);
#line 75 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 40, true);
            WriteLiteral("</td>\n\n                            <td> ");
            EndContext();
            BeginContext(2452, 42, false);
#line 77 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2494, 39, true);
            WriteLiteral("</td>\n                            <td> ");
            EndContext();
            BeginContext(2534, 39, false);
#line 78 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Code));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 37, true);
            WriteLiteral("</td>\n\n                        </tr>\n");
            EndContext();
#line 81 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2632, 704, true);
            WriteLiteral(@"                    </tbody>
                </table>
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
                        <th style=""width: 50%"">
                            Student Name
                        </th>

                        <th style=""width: 25%"">
                            Address
                        </th>
                        <th style=""width: 25%"">Code</th>

                    </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 110 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                      
                        Debug.Assert(listStudent != null, nameof(listStudent) + " != null");
                    

#line default
#line hidden
            BeginContext(3474, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 113 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                     foreach (var item in listStudent)
                    {

#line default
#line hidden
            BeginContext(3551, 62, true);
            WriteLiteral("                        <tr>\n                            <td> ");
            EndContext();
            BeginContext(3614, 39, false);
#line 116 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3653, 40, true);
            WriteLiteral("</td>\n\n                            <td> ");
            EndContext();
            BeginContext(3694, 42, false);
#line 118 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3736, 39, true);
            WriteLiteral("</td>\n                            <td> ");
            EndContext();
            BeginContext(3776, 39, false);
#line 119 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                            Write(Html.DisplayFor(hihi => item.User.Code));

#line default
#line hidden
            EndContext();
            BeginContext(3815, 37, true);
            WriteLiteral("</td>\n\n                        </tr>\n");
            EndContext();
#line 122 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Subjects/Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(3874, 108, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4000, 192, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n        $(document).ready(function() {\n\n            $(\'#listStudent\').DataTable({\n                pageLength: 10\n            });\n        });\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Subject> Html { get; private set; }
    }
}
#pragma warning restore 1591
