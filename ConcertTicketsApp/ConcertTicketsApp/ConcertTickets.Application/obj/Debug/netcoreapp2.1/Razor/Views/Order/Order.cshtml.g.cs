#pragma checksum "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7ff44844704950338a1af13c1a6a387a138574c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order.cshtml", typeof(AspNetCore.Views_Order_Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ff44844704950338a1af13c1a6a387a138574c", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f3dbad3b0f4beb609c64d5eda630d298edd63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConcertTicketsApp.BusinessModels.ViewModels.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
   ViewBag.Title = "Order Concert Ticket"; 

#line default
#line hidden
            BeginContext(112, 30, true);
            WriteLiteral("<h1>Order ticket now</h1>\n<h3>");
            EndContext();
            BeginContext(143, 13, false);
#line 5 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(156, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(190, 138, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">\n        <div class=\"input-group input-group-md\">\n            <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(329, 31, false);
#line 11 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(360, 20, true);
            WriteLiteral("</span>\n            ");
            EndContext();
            BeginContext(381, 70, false);
#line 12 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
       Write(Html.TextBox("model.FirstName", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(451, 147, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-6\">\n        <div class=\"input-group input-group-md\">\n            <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(599, 30, false);
#line 17 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(629, 20, true);
            WriteLiteral("</span>\n            ");
            EndContext();
            BeginContext(650, 69, false);
#line 18 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
       Write(Html.TextBox("model.LastName", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(719, 236, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n                <div class=\"row\">\n                    <div class=\"col-md-6\">\n                        <div class=\"input-group input-group-md\">\n                            <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(956, 29, false);
#line 25 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                                       Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
            EndContext();
            BeginContext(985, 36, true);
            WriteLiteral("</span>\n                            ");
            EndContext();
            BeginContext(1022, 68, false);
#line 26 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                       Write(Html.TextBox("model.Address", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 227, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"col-md-6\">\n                        <div class=\"input-group input-group-md\">\n                            <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(1318, 27, false);
#line 31 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                                       Write(Html.LabelFor(x => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 36, true);
            WriteLiteral("</span>\n                            ");
            EndContext();
            BeginContext(1382, 67, false);
#line 32 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                       Write(Html.TextBox($"model.Phone", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 82, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                 for (int i = 0; i < Model.Tickets.Count; i++)
                                {

#line default
#line hidden
            BeginContext(1644, 31, true);
            WriteLiteral("                <h1>Ticket no: ");
            EndContext();
            BeginContext(1677, 5, false);
#line 38 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                           Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1683, 288, true);
            WriteLiteral(@"</h1>
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""input-group input-group-md"">
                                                <span class=""input-group-addon"">");
            EndContext();
            BeginContext(1972, 50, false);
#line 42 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                                                           Write(Html.Label(expression: $"model.Tickets[{i}].Name"));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 56, true);
            WriteLiteral("</span>\n                                                ");
            EndContext();
            BeginContext(2079, 149, false);
#line 43 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                           Write(Html.TextBox($"model.Tickets[{i}].Name", Model.Tickets[i].Name, null,
                                               new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2228, 327, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""input-group input-group-md"">
                                                <span class=""input-group-addon"">");
            EndContext();
            BeginContext(2556, 54, false);
#line 49 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                                                           Write(Html.Label(expression: $"model.Tickets[{i}].Category"));

#line default
#line hidden
            EndContext();
            BeginContext(2610, 56, true);
            WriteLiteral("</span>\n                                                ");
            EndContext();
            BeginContext(2667, 265, false);
#line 50 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                           Write(Html.DropDownList($"model.Tickets[{i}].Category",
                                               Html.GetEnumSelectList(Model.Tickets[i].Category.GetType()), 
                                               new { Model.Tickets[i].Category, @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2932, 141, true);
            WriteLiteral("\n                                            </div>\n                                        </div>\n                                    </div>");
            EndContext();
#line 55 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                          }

#line default
#line hidden
            BeginContext(3075, 114, true);
            WriteLiteral("                                                <button class=\"btn btn-danger\" type=\"submit\"> Order Now! </button>");
            EndContext();
#line 56 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Order\Order.cshtml"
                                                                                                                  }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConcertTicketsApp.BusinessModels.ViewModels.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
