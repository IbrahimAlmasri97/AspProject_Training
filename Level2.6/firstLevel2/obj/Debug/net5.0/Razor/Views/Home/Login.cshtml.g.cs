#pragma checksum "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b44649085be5348bed254fe8c10b5db14e2522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\_ViewImports.cshtml"
using firstLevel2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\_ViewImports.cshtml"
using firstLevel2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b44649085be5348bed254fe8c10b5db14e2522", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087974ffca1a7b8a263a2b522d3bf9a5101d633b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<firstLevel2.Models.UserrInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
 using (Html.BeginForm("loginbt", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
       Write(Html.TextBoxFor(model => model.UserName, htmlAttributes: new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
       Write(Html.PasswordFor(model => model.Password, htmlAttributes: new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <input type=\"submit\" value=\"login\" />\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\ابراهيم\Desktop\m6\Level2.6\firstLevel2\Views\Home\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<firstLevel2.Models.UserrInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
