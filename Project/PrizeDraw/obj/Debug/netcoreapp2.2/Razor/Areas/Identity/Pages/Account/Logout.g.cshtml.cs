#pragma checksum "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717290da7507f9329619df9fc5a00aa15ca987a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PrizeDraw.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Logout.cshtml", typeof(PrizeDraw.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), null)]
namespace PrizeDraw.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\_ViewImports.cshtml"
using PrizeDraw.Areas.Identity;

#line default
#line hidden
#line 4 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\_ViewImports.cshtml"
using PrizeDraw.Models;

#line default
#line hidden
#line 1 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PrizeDraw.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717290da7507f9329619df9fc5a00aa15ca987a3", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c426df9eac6c48a60acc342cd1ecbd930cf74db", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5299f1f2637d6beeb57b54c9d6c61c3a52717df", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
            BeginContext(65, 18, true);
            WriteLiteral("\n<header>\n    <h1>");
            EndContext();
            BeginContext(84, 17, false);
#line 8 "C:\Users\s00732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Areas\Identity\Pages\Account\Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(101, 79, true);
            WriteLiteral("</h1>\n    <p>You have successfully logged out of the application.</p>\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
