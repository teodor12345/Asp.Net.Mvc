#pragma checksum "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69a95213d6ada6f544846ffad577bb8840c1a34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\_ViewImports.cshtml"
using ConcertTickets.Application;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\_ViewImports.cshtml"
using ConcertTickets.Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69a95213d6ada6f544846ffad577bb8840c1a34", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f3dbad3b0f4beb609c64d5eda630d298edd63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConcertTicketsApp.BusinessModels.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Home\Index.cshtml"
   ViewBag.Title = "Buy Tickets Now!"; 

#line default
#line hidden
            BeginContext(107, 251, true);
            WriteLiteral("\n<div class=\"jumbotron\">\n    <h1>Buy Concert Tickets app</h1>\n    <p>Check out our varaity of Concert Tickets in Available Tickets!!!</p>\n    <p>And come back and Order your Ticket Now by one press of the button!!!</p>\n\n\n    <h3>Order Ticket Now</h3>\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(394, 236, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-2\">\n        <div class=\"input-group\">\n            <span class=\"input-group-btn\">\n                <button class=\"btn btn-success\" type=\"submit\">Order Now!</button>\n            </span>\n            ");
            EndContext();
            BeginContext(631, 72, false);
#line 20 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.NumberOfTickets, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(703, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
            EndContext();
#line 23 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Home\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(738, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConcertTicketsApp.BusinessModels.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
