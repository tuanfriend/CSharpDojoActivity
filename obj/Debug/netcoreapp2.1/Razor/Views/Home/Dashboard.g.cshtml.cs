#pragma checksum "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a2a889b8ba0df128d8c16caade1e443d015f53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "D:\DOJO\CSharp\BeltExamCSharp\Views\_ViewImports.cshtml"
using BeltExamCSharp;

#line default
#line hidden
#line 2 "D:\DOJO\CSharp\BeltExamCSharp\Views\_ViewImports.cshtml"
using BeltExamCSharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a2a889b8ba0df128d8c16caade1e443d015f53", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64747611eb44d3c3861b482d9bd21cd59d9135dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActConnect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 76, true);
            WriteLiteral("\r\n<div class=\"header\">\r\n    <h1>Dojo Activity Center</h1>\r\n    <h2>Welcome, ");
            EndContext();
            BeginContext(96, 22, false);
#line 5 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
            Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(118, 61, true);
            WriteLiteral("</h2>\r\n    <a href=\"/logout\">Log off</a>\r\n</div>\r\n\r\n<hr>\r\n<a>");
            EndContext();
            BeginContext(180, 17, false);
#line 10 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
Write(ViewBag.samedayrs);

#line default
#line hidden
            EndContext();
            BeginContext(197, 396, true);
            WriteLiteral(@"</a>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event Coordinator</th>
            <th scope=""col"">No. Participants</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
         foreach(var i in ViewBag.AllAct){
            DateTime CurrentTime = DateTime.Now;
   if(i.ActDate < CurrentTime)
   {
   }else
   {

#line default
#line hidden
            BeginContext(741, 31, true);
            WriteLiteral("       <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 772, "\"", 800, 2);
            WriteAttributeValue("", 779, "/detail/", 779, 8, true);
#line 30 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 787, i.ActivityId, 787, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(801, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(803, 7, false);
#line 30 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                                           Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(810, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(838, 27, false);
#line 31 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
           Write(i.ActDate.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(865, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(870, 6, false);
#line 31 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                                           Write(i.Time);

#line default
#line hidden
            EndContext();
            BeginContext(876, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 32 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
             if(i.Duration <= 60) {

#line default
#line hidden
            BeginContext(918, 5, true);
            WriteLiteral(" <td>");
            EndContext();
            BeginContext(924, 10, false);
#line 32 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                                   Write(i.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(934, 15, true);
            WriteLiteral(" Minutes</td>\r\n");
            EndContext();
#line 33 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                }
                else if(i.Duration <= 1440) 
                { 
                    int duration=i.Duration/60;

#line default
#line hidden
            BeginContext(1081, 5, true);
            WriteLiteral(" <td>");
            EndContext();
            BeginContext(1087, 8, false);
#line 36 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                                               Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 15, true);
            WriteLiteral(" Hour(s)</td>\r\n");
            EndContext();
#line 37 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                    }
                    else
                    {
                    int duration = i.Duration/1440;

#line default
#line hidden
            BeginContext(1235, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1260, 8, false);
#line 41 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                   Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 14, true);
            WriteLiteral(" Day(s)</td>\r\n");
            EndContext();
#line 42 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(1305, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1330, 23, false);
#line 43 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                   Write(i.Coordinator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1385, 17, false);
#line 44 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                   Write(i.ActtoUser.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1402, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
#line 45 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(i.ActtoUser.Count == 0){

#line default
#line hidden
            BeginContext(1463, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1489, "\"", 1539, 4);
            WriteAttributeValue("", 1496, "/joinact/", 1496, 9, true);
#line 46 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1505, i.ActivityId, 1505, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1518, "/", 1518, 1, true);
#line 46 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1519, ViewBag.User.UserId, 1519, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1540, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 47 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(1578, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 48 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(i.ActtoUser.Count > 0)
                        {
                        int resert = 0;
                        bool rsvp = false;
                        

#line default
#line hidden
#line 52 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         foreach(var y in i.ActtoUser){
                        

#line default
#line hidden
#line 53 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(y.UserId == ViewBag.User.UserId){
                        rsvp = true;
                        resert = y.ActConnectId;
                        }

#line default
#line hidden
#line 56 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         
                        }

#line default
#line hidden
#line 58 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(rsvp == true){

#line default
#line hidden
            BeginContext(2048, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2074, "\"", 2098, 2);
            WriteAttributeValue("", 2081, "/leaveact/", 2081, 10, true);
#line 59 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2091, resert, 2091, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2099, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 60 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
#line 61 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(rsvp == false){

#line default
#line hidden
            BeginContext(2183, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2209, "\"", 2259, 4);
            WriteAttributeValue("", 2216, "/joinact/", 2216, 9, true);
#line 62 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2225, i.ActivityId, 2225, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2238, "/", 2238, 1, true);
#line 62 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2239, ViewBag.User.UserId, 2239, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2260, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 63 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
#line 63 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         
                        }

#line default
#line hidden
            BeginContext(2325, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                         if(ViewBag.User.UserId == @i.UserId){

#line default
#line hidden
            BeginContext(2391, 37, true);
            WriteLiteral("                        <a> | </a> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2428, "\"", 2456, 2);
            WriteAttributeValue("", 2435, "/delete/", 2435, 8, true);
#line 67 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2443, i.ActivityId, 2443, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2457, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 68 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(2497, 42, true);
            WriteLiteral("                    </td>\r\n        </tr>\r\n");
            EndContext();
#line 71 "D:\DOJO\CSharp\BeltExamCSharp\Views\Home\Dashboard.cshtml"
   }
        }

#line default
#line hidden
            BeginContext(2556, 125, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"/addactivity\"><button type=\"button\" class=\"btn btn-primary\">Add New Activity!</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActConnect> Html { get; private set; }
    }
}
#pragma warning restore 1591
