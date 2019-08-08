#pragma checksum "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40185bf5e40b4a26aab0c7a843beee30e44af19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Semesters_AddSchedule), @"mvc.1.0.view", @"/Areas/Admin/Views/Semesters/AddSchedule.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Semesters/AddSchedule.cshtml", typeof(AspNetCore.Areas_Admin_Views_Semesters_AddSchedule))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40185bf5e40b4a26aab0c7a843beee30e44af19", @"/Areas/Admin/Views/Semesters/AddSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Semesters_AddSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<Semester,List<Schedule>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSchedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ScheduleDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
  
    ViewData["Title"] = "Add schedule";

#line default
#line hidden
            BeginContext(89, 34, true);
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>Semester ");
            EndContext();
            BeginContext(124, 16, false);
#line 9 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
        Write(Model.Item1.Name);

#line default
#line hidden
            EndContext();
            BeginContext(140, 8, true);
            WriteLiteral(" - Year ");
            EndContext();
            BeginContext(149, 16, false);
#line 9 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
                                 Write(Model.Item1.Year);

#line default
#line hidden
            EndContext();
            BeginContext(165, 11, true);
            WriteLiteral(" - Faculty ");
            EndContext();
            BeginContext(177, 24, false);
#line 9 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
                                                             Write(Model.Item1.Faculty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(201, 70, true);
            WriteLiteral("</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(271, 800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40185bf5e40b4a26aab0c7a843beee30e44af195967", async() => {
                BeginContext(302, 556, true);
                WriteLiteral(@"
            
            <div class=""form-group"">
                <label  class=""control-label"">Teacher</label>
                <input name=""teacherId"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Subject</label>
                <input name=""subjectId"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Semester</label>
                <input name=""semesterId"" class=""form-control"" hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 858, "\"", 881, 1);
#line 25 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
WriteAttributeValue("", 866, Model.Item1.Id, 866, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(882, 182, true);
                WriteLiteral("/>\r\n            </div>\r\n          \r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1071, 291, true);
            WriteLiteral(@"
    </div>
</div>
<table class=""table"">
     <thead>
     <tr>
         <th>
             Teacher Name
         </th>
         <th>
             Subject Name
         </th>
         
         <th>
             Actions
         </th>
     </tr>
     </thead>
     <tbody>
");
            EndContext();
#line 50 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
      foreach (var item in Model.Item2) {

#line default
#line hidden
            BeginContext(1405, 51, true);
            WriteLiteral("         <tr>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(1457, 44, false);
#line 53 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
            Write(Html.DisplayFor(modelItem => item.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(1560, 47, false);
#line 56 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
            Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 60, true);
            WriteLiteral("\r\n             </td>\r\n\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(1667, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40185bf5e40b4a26aab0c7a843beee30e44af1910261", async() => {
                BeginContext(1722, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1733, 58, true);
            WriteLiteral(" |\r\n                \r\n             </td>\r\n         </tr>\r\n");
            EndContext();
#line 64 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
     }

#line default
#line hidden
            BeginContext(1799, 36, true);
            WriteLiteral("     </tbody>\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1835, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40185bf5e40b4a26aab0c7a843beee30e44af1912917", async() => {
                BeginContext(1857, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1873, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1903, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Semesters/AddSchedule.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<Semester,List<Schedule>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
