#pragma checksum "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cc24e0e6fa6cff38acdd5906e9c398d5b92630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prize_Details), @"mvc.1.0.view", @"/Views/Prize/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prize/Details.cshtml", typeof(AspNetCore.Views_Prize_Details))]
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
#line 1 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\_ViewImports.cshtml"
using PrizeDraw;

#line default
#line hidden
#line 2 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\_ViewImports.cshtml"
using PrizeDraw.Models;

#line default
#line hidden
#line 3 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\_ViewImports.cshtml"
using PrizeDraw.DataLayer.Model.Identity;

#line default
#line hidden
#line 4 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cc24e0e6fa6cff38acdd5906e9c398d5b92630", @"/Views/Prize/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5525223f73bc26a7ef89b80112d64843138ff9a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Prize_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrizeDraw.DataLayer.Model.Prize>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 102, true);
            WriteLiteral("\n<div>\n    <h4>Prize</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(142, 38, false);
#line 8 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(180, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(241, 34, false);
#line 11 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(275, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(335, 40, false);
#line 14 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(375, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(436, 36, false);
#line 17 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(472, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(532, 41, false);
#line 20 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(573, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(634, 37, false);
#line 23 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(671, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(731, 44, false);
#line 26 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorId));

#line default
#line hidden
            EndContext();
            BeginContext(775, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(836, 40, false);
#line 29 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendorId));

#line default
#line hidden
            EndContext();
            BeginContext(876, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(936, 41, false);
#line 32 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(977, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1038, 37, false);
#line 35 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1135, 51, false);
#line 38 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1247, 47, false);
#line 41 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1337, 68, false);
#line 46 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Prize\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1412, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cc24e0e6fa6cff38acdd5906e9c398d5b9263010081", async() => {
                BeginContext(1434, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1450, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrizeDraw.DataLayer.Model.Prize> Html { get; private set; }
    }
}
#pragma warning restore 1591
