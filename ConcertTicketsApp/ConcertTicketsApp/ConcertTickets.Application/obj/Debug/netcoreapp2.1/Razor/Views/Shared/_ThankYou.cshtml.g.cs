#pragma checksum "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5407c957d26f219c3849a0f6c69a9ce179712bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThankYou), @"mvc.1.0.view", @"/Views/Shared/_ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThankYou.cshtml", typeof(AspNetCore.Views_Shared__ThankYou))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5407c957d26f219c3849a0f6c69a9ce179712bec", @"/Views/Shared/_ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f3dbad3b0f4beb609c64d5eda630d298edd63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_ThankYou.cshtml"
   ViewBag.Title = "Thank You"; 

#line default
#line hidden
            BeginContext(34, 199, true);
            WriteLiteral("<div class=\"jumbotron\">\n    <h1>Thank you for getting your tickets with us</h1>\n    <p>Order again or leave us a feedback so we can improve!</p>\n    <p>\n        <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(234, 47, false);
#line 6 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_ThankYou.cshtml"
                                         Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(281, 25, true);
            WriteLiteral("</button>\n    </p>\n</div>");
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