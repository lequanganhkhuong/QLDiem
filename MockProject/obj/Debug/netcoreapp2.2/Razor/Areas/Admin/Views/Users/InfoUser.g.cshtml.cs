#pragma checksum "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f0a344521b795e8a61ce75058aa6ed9c2b1cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_InfoUser), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/InfoUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/InfoUser.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_InfoUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f0a344521b795e8a61ce75058aa6ed9c2b1cb7", @"/Areas/Admin/Views/Users/InfoUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_InfoUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
  
    ViewData["Title"] = Model.Name + "'s profile";

#line default
#line hidden
            BeginContext(69, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(75, 10, false);
#line 7 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(85, 348, true);
            WriteLiteral(@" 's profile</h1>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-content"">
                <div class=""row"">
                    <div>
  
                        <hr />
                        <dl class=""row"">
                            <dt class = ""col-sm-2"">
                                ");
            EndContext();
            BeginContext(434, 44, false);
#line 18 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(478, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(599, 40, false);
#line 21 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(639, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(759, 44, false);
#line 24 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(803, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(924, 40, false);
#line 27 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(964, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(1084, 40, false);
#line 30 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(1245, 36, false);
#line 33 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(1401, 40, false);
#line 36 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(1562, 36, false);
#line 39 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(1718, 44, false);
#line 42 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(1883, 40, false);
#line 45 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(2043, 43, false);
#line 48 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(2207, 39, false);
#line 51 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(2366, 42, false);
#line 54 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 118, true);
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(2527, 42, false);
#line 57 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.Raw(Model.Gender ? "Male" : "Female"));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(2689, 44, false);
#line 60 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 118, true);
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(2852, 47, false);
#line 63 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.Raw(Model.IsActive ? "Active" : "Blocked"));

#line default
#line hidden
            EndContext();
            BeginContext(2899, 35, true);
            WriteLiteral("\n                            </dd>\n");
            EndContext();
            BeginContext(3301, 84, true);
            WriteLiteral("                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(3386, 43, false);
#line 72 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Faculty));

#line default
#line hidden
            EndContext();
            BeginContext(3429, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(3550, 44, false);
#line 75 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Faculty.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3594, 119, true);
            WriteLiteral("\n                            </dd>\n                            <dt class = \"col-sm-2\">\n                                ");
            EndContext();
            BeginContext(3714, 40, false);
#line 78 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3754, 120, true);
            WriteLiteral("\n                            </dt>\n                            <dd class = \"col-sm-10\">\n                                ");
            EndContext();
            BeginContext(3875, 41, false);
#line 81 "/home/khuong/RiderProjects/Git/MockProject/Areas/Admin/Views/Users/InfoUser.cshtml"
                           Write(Html.DisplayFor(model => model.Role.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3916, 174, true);
            WriteLiteral("\n                            </dd>\n                        </dl>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n<div>");
            EndContext();
            BeginContext(4090, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98f0a344521b795e8a61ce75058aa6ed9c2b1cb714754", async() => {
                BeginContext(4134, 4, true);
                WriteLiteral("back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4142, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591