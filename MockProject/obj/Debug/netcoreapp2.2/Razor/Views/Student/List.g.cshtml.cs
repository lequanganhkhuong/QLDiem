#pragma checksum "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e10b6fa3f21c7b22a5bee16be1077f36cc327a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_List), @"mvc.1.0.view", @"/Views/Student/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/List.cshtml", typeof(AspNetCore.Views_Student_List))]
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
#line 1 "/home/khuong/RiderProjects/Git/MockProject/Views/_ViewImports.cshtml"
using MockProject;

#line default
#line hidden
#line 2 "/home/khuong/RiderProjects/Git/MockProject/Views/_ViewImports.cshtml"
using MockProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e10b6fa3f21c7b22a5bee16be1077f36cc327a5", @"/Views/Student/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MockProject.Models.ViewModels.StudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(129, 127, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1>Transcript</h1>\n</div>\n\n<div class=\"container-fluid\">\n    <div class=\"card-header\">\n        ");
            EndContext();
            BeginContext(256, 1863, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a56048", async() => {
                BeginContext(293, 156, true);
                WriteLiteral("\n            <div class=\"col-md-12\">\n                <span>Chọn năm học</span>\n                <select name=\"year\" style=\"width: 25%\" class=\"form-control\">\n");
                EndContext();
#line 17 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                      
                        var filteryear = ViewBag.ListYear;
                        var check = ViewBag.Year;

#line default
#line hidden
                BeginContext(581, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(605, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a56963", async() => {
                    BeginContext(623, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(635, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 21 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                        foreach (var a in filteryear)
                        {

                            if (a.Equals(check))
                            {


#line default
#line hidden
                BeginContext(797, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(829, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a58807", async() => {
                    BeginContext(869, 1, false);
#line 27 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                                                  Write(a);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 27 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                                       WriteLiteral(a);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(879, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 28 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                            }
                            else
                            {


#line default
#line hidden
                BeginContext(974, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1006, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a511242", async() => {
                    BeginContext(1026, 1, false);
#line 32 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                              Write(a);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                   WriteLiteral(a);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1036, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 33 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                            }

                        }
                    

#line default
#line hidden
                BeginContext(1116, 181, true);
                WriteLiteral("                </select>\n            </div>\n            <div>\n                <span>Chọn học kì</span>\n                <select name=\"name\" style=\"width: 25%\" class=\"form-control\">\n");
                EndContext();
#line 42 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                      
                            
                        var filter = ViewBag.ListName;
                        var checkn = ViewBag.HK;

#line default
#line hidden
                BeginContext(1453, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1477, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a514098", async() => {
                    BeginContext(1495, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1507, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 47 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                        foreach (var a in filter)
                        {

                            if (a.Equals(checkn))
                            {


#line default
#line hidden
                BeginContext(1666, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1698, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a515944", async() => {
                    BeginContext(1738, 1, false);
#line 53 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                                                  Write(a);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 53 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                                       WriteLiteral(a);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1748, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 54 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                            }
                            else
                            {


#line default
#line hidden
                BeginContext(1843, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1875, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a518383", async() => {
                    BeginContext(1895, 1, false);
#line 58 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                              Write(a);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 58 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                   WriteLiteral(a);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1905, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 59 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                            }

                        }
                    

#line default
#line hidden
                BeginContext(1985, 127, true);
                WriteLiteral("                </select>\n            </div>\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\"/>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2119, 115, true);
            WriteLiteral("\n\n    </div>\n    <table id=\"myTable\" class=\"table\" >\n        <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(2235, 47, false);
#line 73 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
           Write(Html.DisplayNameFor(model => model.TeacherName));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2335, 47, false);
#line 76 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
           Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
            EndContext();
            BeginContext(2382, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2435, 40, false);
#line 79 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
           Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 180, true);
            WriteLiteral("\n            </th>\n            <th>\n                Pass\n            </th>\n            <th>\n                Infor\n            </th>\n        </tr>\n        </thead>\n        <tbody>\n\n");
            EndContext();
#line 91 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2702, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(2761, 46, false);
#line 95 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
               Write(Html.DisplayFor(modelItem => item.TeacherName));

#line default
#line hidden
            EndContext();
            BeginContext(2807, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2872, 46, false);
#line 98 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubjectName));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2983, 39, false);
#line 101 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(3022, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3087, 40, false);
#line 104 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
               Write(Html.Raw( item.IsPass ? "Pass" : "Fail"));

#line default
#line hidden
            EndContext();
            BeginContext(3127, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3191, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e10b6fa3f21c7b22a5bee16be1077f36cc327a525626", async() => {
                BeginContext(3279, 72, true);
                WriteLiteral("\n                        <i class=\"far fa-eye\"></i>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3355, 42, true);
            WriteLiteral(" \n                </td>\n            </tr>\n");
            EndContext();
#line 112 "/home/khuong/RiderProjects/Git/MockProject/Views/Student/List.cshtml"
        }

#line default
#line hidden
            BeginContext(3407, 40, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MockProject.Models.ViewModels.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
