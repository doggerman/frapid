﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Account;
    
    #line 1 "..\..\Views\SignUp\Welcome.cshtml"
    using Frapid.i18n;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SignUp/Welcome.cshtml")]
    public partial class _Views_SignUp_Welcome_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_SignUp_Welcome_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\SignUp\Welcome.cshtml"
  
    ViewBag.Title = "Welcome";
    Layout = ViewBag.LayoutPath + ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\SignUp\Welcome.cshtml"
 if (CultureManager.IsRtl())
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 171), Tuple.Create("\"", 219)
            
            #line 9 "..\..\Views\SignUp\Welcome.cshtml"
, Tuple.Create(Tuple.Create("", 178), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page-rtl.css")
            
            #line default
            #line hidden
, 178), false)
);

WriteLiteral(" />\r\n");

            
            #line 10 "..\..\Views\SignUp\Welcome.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 263), Tuple.Create("\"", 307)
            
            #line 13 "..\..\Views\SignUp\Welcome.cshtml"
, Tuple.Create(Tuple.Create("", 270), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page.css")
            
            #line default
            #line hidden
, 270), false)
);

WriteLiteral(" />\r\n");

            
            #line 14 "..\..\Views\SignUp\Welcome.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"ui attached padded signup left aligned segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui header\"");

WriteLiteral(">Welcome</div>\r\n        <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n        <p>\r\n            Thank you registering on our website. Your acco" +
"unt has been successfully activated.\r\n        </p>\r\n        <a");

WriteLiteral(" href=\"/account/sign-in\"");

WriteLiteral(" class=\"ui small padded positive button\"");

WriteLiteral(">Sign In</a>\r\n        <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(" class=\"ui small padded purple button\"");

WriteLiteral(">Return Home</a>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591