#pragma checksum "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af81d7badda0fb6f35ec94d2ea41babe5a198fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af81d7badda0fb6f35ec94d2ea41babe5a198fd5", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fd711e29db2bfd8d44c50b4c200d064187647", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("brand-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 1022, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81d7badda0fb6f35ec94d2ea41babe5a198fd55983", async() => {
                BeginContext(29, 97, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <title>");
                EndContext();
                BeginContext(127, 13, false);
#line 6 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(140, 898, true);
                WriteLiteral(@"</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.2/css/all.css"" integrity=""sha384-oS3vJWv+0UjzBfQzYUhtDYW+Pj2yciDJxpsK1OYPAYjqT085Qq/1cq5FLXAZQ7Ay"" crossorigin=""anonymous"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""/client/css/adminlte.min.css""/>

    <!--admin lte 2-->
    <link rel=""stylesheet"" href=""/client/css/_all-skins.min.css""/>
    <link rel=""stylesheet"" href=""/client/css/AdminLTE.min.css""/>
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1045, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1046, 5307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81d7badda0fb6f35ec94d2ea41babe5a198fd58501", async() => {
                BeginContext(1089, 429, true);
                WriteLiteral(@"
<!-- Site wrapper -->
<div class=""wrapper"">
    <!-- Navbar -->
    <nav class=""main-header navbar navbar-expand navbar-white navbar-light border-bottom"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"">
                <i class=""fas fa-bars""></i>
            </a>
        </li>
    </ul>

    <ul class=""navbar-nav ml-8"">
");
                EndContext();
#line 38 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
     if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
                BeginContext(1560, 143, true);
                WriteLiteral("    <li class=\"dropdown user user-menu\">\n    <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">\n        <span class=\"hidden-xs\">Hello ");
                EndContext();
                BeginContext(1704, 32, false);
#line 42 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
                                 Write(User.FindFirst("UserName").Value);

#line default
#line hidden
                EndContext();
                BeginContext(1736, 180, true);
                WriteLiteral("</span>\n    </a>\n    <ul class=\"dropdown-menu\">\n        <li class=\"user-body\">\n            <div class=\"row\">\n                <div class=\"col-md-4 text-center\">\n                    ");
                EndContext();
                BeginContext(1916, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81d7badda0fb6f35ec94d2ea41babe5a198fd510309", async() => {
                    BeginContext(1995, 7, true);
                    WriteLiteral("Profile");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 48 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
                                                                  WriteLiteral(User.Identity.Name);

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
                BeginContext(2006, 241, true);
                WriteLiteral("\n                </div>\n                <div class=\"col-md-8 text-center\">\n                    <a href=\"#\">Change PassWord</a>\n                </div>\n\n            </div>\n        </li>\n        <li class=\"user-footer text-center\">\n            ");
                EndContext();
                BeginContext(2247, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81d7badda0fb6f35ec94d2ea41babe5a198fd513219", async() => {
                    BeginContext(2315, 8, true);
                    WriteLiteral("Sign out");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2327, 35, true);
                WriteLiteral("\n        </li>\n    </ul>\n    </li>\n");
                EndContext();
#line 61 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
}

#line default
#line hidden
                BeginContext(2364, 152, true);
                WriteLiteral("    </ul>\n\n\n</nav>\n<!-- /.navbar -->\n\n<!-- Main Sidebar Container -->\n<aside class=\"main-sidebar sidebar-dark-primary elevation-4\">\n<!-- Brand Logo -->\n");
                EndContext();
                BeginContext(2516, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81d7badda0fb6f35ec94d2ea41babe5a198fd515381", async() => {
                    BeginContext(2579, 65, true);
                    WriteLiteral("\n    <span class=\"brand-text font-weight-light\">.NET TEAM</span>\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2648, 172, true);
                WriteLiteral("\n<!-- Sidebar -->\n<div class=\"sidebar\">\n<!-- Sidebar user (optional) -->\n<div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\n\n    <div class=\"info\">\n        <a class=\"d-block\">\n");
                EndContext();
#line 81 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
                BeginContext(2882, 27, true);
                WriteLiteral("                <p>Hello : ");
                EndContext();
                BeginContext(2910, 32, false);
#line 83 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
                      Write(User.FindFirst("UserName").Value);

#line default
#line hidden
                EndContext();
                BeginContext(2942, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 84 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(2961, 2521, true);
                WriteLiteral(@"        </a>
                </div>
            </div>
        
            <!-- Sidebar Menu -->
            <nav class=""mt-2"">
                <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                    <!-- Add icons to the links using the .nav-icon class
                    with font-awesome or any other icon font library -->

                    <li class=""nav-item has-treeview"">
                        <a href=""#"" class=""nav-link"">
                            <i class=""fas fa-align-justify""></i>
                            <p>
                                Transcipt
                                <i class=""right fas fa-angle-left""></i>
                            </p>
                        </a>
                        <ul class=""nav nav-treeview"">
                            <li class=""nav-item"">
                                <a href=""../../Students"" class=""nav-link"">
                                    <i class=""far fa-circle n");
                WriteLiteral(@"av-icon""></i>
                                    <p>Transcrips</p>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""../../index2.html"" class=""nav-link"">
                                    <i class=""far fa-circle nav-icon""></i>
                                    <p>Dashboard v2</p>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""../../index3.html"" class=""nav-link"">
                                    <i class=""far fa-circle nav-icon""></i>
                                    <p>Dashboard v3</p>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""../widgets.html"" class=""nav-link"">
                            <i class=""nav-icon fas fa-th""><");
                WriteLiteral(@"/i>
                            <p>
                                Widgets
                                <span class=""right badge badge-danger"">New</span>
                            </p>
                        </a>
                    </li>
                </ul>
            </nav>
            <!-- /.sidebar-menu -->
        </div>
        <!-- /.sidebar -->
    </aside>

    <!-- Content Wrapper. Contains page content -->
    <div class=""content-wrapper"">
        ");
                EndContext();
                BeginContext(5483, 12, false);
#line 142 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5495, 817, true);
                WriteLiteral(@"
    </div>

<footer class=""main-footer"">
    <div class=""float-right d-none d-sm-block"">
        <b>Version</b> 3.0.0-beta.1
    </div>
    Member Intern .NET : <strong> Nguyễn Tâm, Nguyễn Kim Hùng</strong>
    </footer>

    <!-- Control Sidebar -->
    <aside class=""control-sidebar control-sidebar-dark"">
        <!-- Control sidebar content goes here -->
    </aside>
    <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

<!-- jQuery -->
<script src=""/client/jquery/jquery.min.js""></script>
<!-- Bootstrap 4 -->
<script src=""/client/bootstrap/js/bootstrap.bundle.min.js""></script>
<!-- FastClick -->
<script src=""/client/fastclick/fastclick.js""></script>
<!-- AdminLTE App -->
<script src=""/client/js/adminlte.min.js""></script>
<!-- AdminLTE for demo purposes -->
<script src=""/client/js/demo.js""></script>

");
                EndContext();
                BeginContext(6313, 31, false);
#line 171 "/home/khuong/RiderProjects/Git/MockProject/Views/Shared/_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(6344, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6353, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
