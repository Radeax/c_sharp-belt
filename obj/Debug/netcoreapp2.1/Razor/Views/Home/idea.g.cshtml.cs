#pragma checksum "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5b82e2b24c62d357fa10fe5ede9d016306d56c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_idea), @"mvc.1.0.view", @"/Views/Home/idea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/idea.cshtml", typeof(AspNetCore.Views_Home_idea))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d5b82e2b24c62d357fa10fe5ede9d016306d56c", @"/Views/Home/idea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_idea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Like>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 33, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(53, 15, false);
#line 5 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
       Write(ViewBag.Creator);

#line default
#line hidden
            EndContext();
            BeginContext(68, 26, true);
            WriteLiteral(" says: </td>\r\n        <td>");
            EndContext();
            BeginContext(95, 12, false);
#line 6 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
       Write(ViewBag.Idea);

#line default
#line hidden
            EndContext();
            BeginContext(107, 190, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n<hr>\r\n<table>\r\n    <tr>\r\n        <th colspan=\"2\">People who liked this post:</th>\r\n    </tr>\r\n    <tr>\r\n        <th>Alias</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 18 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
     foreach (Like like in Model)
    {

#line default
#line hidden
            BeginContext(339, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(370, 15, false);
#line 21 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
           Write(like.User.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(385, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(409, 14, false);
#line 22 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
           Write(like.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(423, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Jennifer\Google Drive\Education\Coding Dojo\csharp_stack\exam\BrightIdeas\Views\Home\idea.cshtml"
    }

#line default
#line hidden
            BeginContext(452, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Like>> Html { get; private set; }
    }
}
#pragma warning restore 1591