#pragma checksum "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b057335f79038221ce0e3d11d96e0c4e8998c2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_user), @"mvc.1.0.view", @"/Views/Home/user.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/user.cshtml", typeof(AspNetCore.Views_Home_user))]
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
#line 1 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b057335f79038221ce0e3d11d96e0c4e8998c2b0", @"/Views/Home/user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 58, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>Name: </td>\r\n        <td>");
            EndContext();
            BeginContext(72, 10, false);
#line 6 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(82, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Alias: </td>\r\n        <td>");
            EndContext();
            BeginContext(149, 11, false);
#line 10 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml"
       Write(Model.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(160, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email: </td>\r\n        <td>");
            EndContext();
            BeginContext(227, 11, false);
#line 14 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml"
       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(238, 111, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n<hr>\r\n\r\n<table>\r\n    <tr>\r\n        <td>Total Number of Posts: </td>\r\n        <td>");
            EndContext();
            BeginContext(350, 13, false);
#line 23 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml"
       Write(ViewBag.Posts);

#line default
#line hidden
            EndContext();
            BeginContext(363, 82, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Total Number of Likes: </td>\r\n        <td>");
            EndContext();
            BeginContext(446, 13, false);
#line 27 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\user.cshtml"
       Write(ViewBag.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(459, 26, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
