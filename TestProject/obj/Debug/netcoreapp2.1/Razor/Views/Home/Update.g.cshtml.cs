#pragma checksum "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "344941854fc391b3c4aedf971f13baa03df99cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Update.cshtml", typeof(AspNetCore.Views_Home_Update))]
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
#line 1 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#line 2 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344941854fc391b3c4aedf971f13baa03df99cf1", @"/Views/Home/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestProject.Models.Students>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
  
    ViewData["Title"] = "github.com/Herbert-sv";

#line default
#line hidden
            BeginContext(93, 92, true);
            WriteLiteral("\r\n<h3 class=\"text-primary\">Update List </h3>\r\n<br />\r\n\r\n<div class=\"form-horizontal \">\r\n    ");
            EndContext();
            BeginContext(185, 1742, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b174298e763474f8f60d8e9f1db74e4", async() => {
                BeginContext(247, 206, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"StudentId\">Student Id</label>\r\n            <br />\r\n            <div class=\"col-md-6\"> <input type=\"number\" name=\"StudentId\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 453, "\"", 477, 1);
#line 15 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 461, Model.StudentId, 461, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(478, 235, true);
                WriteLiteral(" readonly /></div>\r\n           </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"FirstName\">First Name</label>\r\n            <br />\r\n            <div class=\"col-md-6\">\r\n                <input type=\"text\" name=\"FirstName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 713, "\"", 737, 1);
#line 21 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 721, Model.FirstName, 721, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(738, 238, true);
                WriteLiteral(" class=\"form-control \" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"LastName\">Last Name</label>\r\n            <br />\r\n            <div class=\"col-md-6\"><input type=\"text\" name=\"LastName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 976, "\"", 999, 1);
#line 27 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 984, Model.LastName, 984, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1000, 217, true);
                WriteLiteral(" class=\"form-control \" /></div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"Career\">Career</label>\r\n            <br />\r\n            <div class=\"col-md-6\"><input type=\"text\" name=\"Career\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1217, "\"", 1238, 1);
#line 32 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 1225, Model.Career, 1225, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1239, 231, true);
                WriteLiteral(" class=\"form-control\" /></div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"Institution\">Institution</label>\r\n            <br />\r\n            <div class=\"col-md-6\"><input type=\"text\" name=\"Institution\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1470, "\"", 1496, 1);
#line 37 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 1478, Model.Institution, 1478, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1497, 229, true);
                WriteLiteral(" class=\"form-control\" /></div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"YearlyCost\">Yearly Cost</label>\r\n            <br />\r\n            <div class=\"col-md-6\"><input type=\"text\" name=\"YearlyCost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1726, "\"", 1751, 1);
#line 42 "C:\Users\tiger\Documents\Visual Studio 2017\Projects\GitHubCrud\TestProject\Views\Home\Update.cshtml"
WriteAttributeValue("", 1734, Model.YearlyCost, 1734, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1752, 168, true);
                WriteLiteral(" class=\"form-control\" /></div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button class=\"btn btn-default\">Update Info</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1927, 829, true);
            WriteLiteral(@"
    <button class=""btn btn-block btn-danger"" id=""Cform"">Clear form</button>
</div>


<div class=""container-fluid"">
    <h3 class=""well"">-Repository --</h3>
    <p>
        In revision control systems, a repository[1] is a data structure which stores metadata for a set of files or
        directory structure. Depending on whether the version control system in use is distributed (for instance, Git or Mercurial) or
        centralized (Subversion or Perforce, for example), the whole set of information in the repository may be duplicated on
        every user's system or may be maintained on a single server. Some of the metadata that a repository contains includes, among other things:
    </p>
</div>

<script>
    $('#Cform').click(function () {
        $('input:text').val("""","""");
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestProject.Models.Students> Html { get; private set; }
    }
}
#pragma warning restore 1591
