#pragma checksum "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6824f630904bba60c251f47d0475fb35e60f758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_EditMark), @"mvc.1.0.view", @"/Views/Teacher/EditMark.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/EditMark.cshtml", typeof(AspNetCore.Views_Teacher_EditMark))]
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
#line 1 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/_ViewImports.cshtml"
using MockProject;

#line default
#line hidden
#line 2 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/_ViewImports.cshtml"
using MockProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6824f630904bba60c251f47d0475fb35e60f758", @"/Views/Teacher/EditMark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_EditMark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MockProject.Models.Transcript>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(96, 156, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"card\">\n            <div class=\"card-content\">\n                 <h2>Edit mark of Subject: ");
            EndContext();
            BeginContext(253, 27, false);
#line 12 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml"
                                      Write(Model.Schedule.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(280, 12, true);
            WriteLiteral(" - Teacher: ");
            EndContext();
            BeginContext(293, 24, false);
#line 12 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml"
                                                                              Write(Model.Schedule.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(317, 13, true);
            WriteLiteral(" - Semester: ");
            EndContext();
            BeginContext(331, 28, false);
#line 12 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml"
                                                                                                                    Write(Model.Schedule.Semester.Name);

#line default
#line hidden
            EndContext();
            BeginContext(359, 23, true);
            WriteLiteral("</h2>\n                 ");
            EndContext();
            BeginContext(382, 473, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6824f630904bba60c251f47d0475fb35e60f7585274", async() => {
                BeginContext(410, 196, true);
                WriteLiteral("\n                        <div class=\"form-group\">\n                            <label class=\"control-label\">Mark</label>\n                            <input name=\"Mark\" max=\"10\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 606, "\"", 625, 1);
#line 16 "/home/kimhung/RiderProjects/QLDiem/MockProject/Views/Teacher/EditMark.cshtml"
WriteAttributeValue("", 614, Model.Mark, 614, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(626, 222, true);
                WriteLiteral("/>\n                        </div>\n                        <div class=\"form-group\">\n                            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\"/>\n                        </div>\n                    ");
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
            BeginContext(855, 52, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MockProject.Models.Transcript> Html { get; private set; }
    }
}
#pragma warning restore 1591
