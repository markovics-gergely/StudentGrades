#pragma checksum "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86daf193b00fae203b159de4256274d06b0212fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\_ViewImports.cshtml"
using StudentGrades.APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\_ViewImports.cshtml"
using StudentGrades.APP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86daf193b00fae203b159de4256274d06b0212fc", @"/Views/Students/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20888cfe64feda8966425874521574dbd288c185", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentGrades.BLL.DTOs.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
 using (Html.BeginForm("Create", "Students", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card bg-secondary"">
        <div class=""card-body"">
            <h2 class=""card-title text-center text-white"">Add new student</h2>
            <div class=""form-group row"">
                <div class=""col mb-1 col-md-4 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 20 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                       Write(Html.LabelFor(m => m.Name, new { @class = "col-form-label mx-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col mb-1 col-md-8 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row mx-3"">
                                ");
#nullable restore
#line 28 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Name, new { placeholder = "Student name", @class = "form-control col-md-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 29 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger ml-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>


            </div>
            <div class=""form-group row"">
                <div class=""col mb-1 col-md-4 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 41 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                       Write(Html.LabelFor(m => m.Year, new { @class = "col-form-label mx-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col mb-1 col-md-8 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row mx-3"">
                                ");
#nullable restore
#line 49 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.EditorFor(m => m.Year, new { htmlAttributes = new { @class = "form-control col-md-6", placeholder = "Select year", min = "1", max = "12" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 50 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Year, "", new { @class = "text-danger ml-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col mb-1 col-md-4 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 60 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                       Write(Html.LabelFor(m => m.BirthDate, new { @class = "col-form-label mx-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col mb-1 col-md-8 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row mx-3"">
                                ");
#nullable restore
#line 68 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.EditorFor(m => m.BirthDate, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 69 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.BirthDate, "", new { @class = "text-danger ml-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col mb-1 col-md-4 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 79 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                       Write(Html.LabelFor(m => m.PhoneNumber, new { @class = "col-form-label mx-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col mb-1 col-md-8 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row mx-3"">
                                ");
#nullable restore
#line 87 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.EditorFor(m => m.PhoneNumber, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 88 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger ml-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col-12"">
                    <button type=""submit"" class=""btn btn-secondary btn-outline-light"" style=""width:100%"">Submit</button>
                </div>
            </div>
        </div>
    </div>");
#nullable restore
#line 100 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Create.cshtml"
          }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentGrades.BLL.DTOs.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
