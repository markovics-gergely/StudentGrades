#pragma checksum "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1383440e9b26fe4dde7d81c77bb8da368443d9d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1383440e9b26fe4dde7d81c77bb8da368443d9d1", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20888cfe64feda8966425874521574dbd288c185", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentGrades.BLL.DTOs.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
   ViewBag.Title = "Students";
    Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"mb-3\">");
#nullable restore
#line 6 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
            Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
 if (User.Identity.Name != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 229, "\"", 288, 3);
            WriteAttributeValue("", 239, "location.href=\'", 239, 15, true);
#nullable restore
#line 10 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
WriteAttributeValue("", 254, Url.Action("Create", "Students"), 254, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 287, "\'", 287, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add new Student</button>\r\n    <button class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 353, "\"", 417, 3);
            WriteAttributeValue("", 363, "location.href=\'", 363, 15, true);
#nullable restore
#line 11 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
WriteAttributeValue("", 378, Url.Action("CreateGrade", "Students"), 378, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 416, "\'", 416, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add new Grade</button>\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 15 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
         foreach (var student in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col mb-4 col-12\">\r\n                <div class=\"card bg-secondary\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title text-center text-white\">");
#nullable restore
#line 23 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                                 Write(Html.DisplayFor(model => student.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <div class=""row"">
                            <div class=""col col-md-4 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 28 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col col-md-8 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 35 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayFor(model => student.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(@". year</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col col-md-4 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 44 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col col-md-8 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 51 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayFor(model => student.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col col-md-4 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 60 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col col-md-8 col-12 mb-1"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 67 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                        Write(Html.DisplayFor(model => student.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""dropdown"">
                            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Grades
                            </button>
                            <div class=""dropdown-menu"">
");
#nullable restore
#line 77 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                 foreach (var grade in student.Grades)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"dropdown-item disabled\">");
#nullable restore
#line 79 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                                   Write(Html.DisplayFor(model => grade.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
#nullable restore
#line 79 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>");
#nullable restore
#line 84 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> ");
#nullable restore
#line 85 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No students found.</p>");
#nullable restore
#line 88 "C:\Users\User\source\repos\StudentGrades\StudentGrades.APP\Views\Students\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentGrades.BLL.DTOs.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591