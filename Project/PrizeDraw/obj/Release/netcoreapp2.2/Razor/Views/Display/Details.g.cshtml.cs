#pragma checksum "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172dc41e5f2af97b37a817622e9b38eba4a71db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Display_Details), @"mvc.1.0.view", @"/Views/Display/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Display/Details.cshtml", typeof(AspNetCore.Views_Display_Details))]
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
#line 5 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
using PrizeDraw.DataLayer.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172dc41e5f2af97b37a817622e9b38eba4a71db6", @"/Views/Display/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5525223f73bc26a7ef89b80112d64843138ff9a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Display_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayWinningTicketsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Display", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_DisplayLayout.cshtml";

#line default
#line hidden
            BeginContext(162, 46, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-lg-12\">\n");
            EndContext();
#line 9 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
         if (Model.NextPrizeId.HasValue)
        {

#line default
#line hidden
            BeginContext(259, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(271, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172dc41e5f2af97b37a817622e9b38eba4a71db65879", async() => {
                BeginContext(392, 10, true);
                WriteLiteral("Next Prize");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                                                                                    WriteLiteral(Model.NextPrizeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(440, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(452, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172dc41e5f2af97b37a817622e9b38eba4a71db68927", async() => {
                BeginContext(535, 4, true);
                WriteLiteral("Done");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 16 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(554, 82, true);
            WriteLiteral("            <span class=\"h3 text-secondary float-right\" id=\"prizesLeftToDrawText\">");
            EndContext();
            BeginContext(638, 106, false);
#line 17 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                                                              Write((Model.TotalNumberOfUnwonPrizes < 1) ? Model.TotalNumberOfUnwonPrizes : Model.TotalNumberOfUnwonPrizes - 1);

#line default
#line hidden
            EndContext();
            BeginContext(745, 136, true);
            WriteLiteral(" Prizes Left to Draw</span>\n    </div>\n</div>\n<div class=\"row\">\n     <div class=\"col-lg-5\">\n        <p class=\"display-4\" id=\"prizeName\">");
            EndContext();
            BeginContext(882, 15, false);
#line 22 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                       Write(Model.PrizeName);

#line default
#line hidden
            EndContext();
            BeginContext(897, 68, true);
            WriteLiteral("</p>\n        <p class=\"h2 text-secondary\"><span id=\"numberOfPrizes\">");
            EndContext();
            BeginContext(966, 21, false);
#line 23 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                                          Write(Model.PrizesAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(987, 22, true);
            WriteLiteral("</span> Available</p>\n");
            EndContext();
#line 24 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
         if (Model.PrizeImage != null)
        {

#line default
#line hidden
            BeginContext(1058, 67, true);
            WriteLiteral("            <img class=\"displayPrizeImage\" height=\"100\" width=\"100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1125, "\"", 1197, 2);
            WriteAttributeValue("", 1131, "data:image;base64,", 1131, 18, true);
#line 26 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
WriteAttributeValue("", 1149, System.Convert.ToBase64String(Model.PrizeImage), 1149, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1198, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 27 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1212, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 28 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.SponsorName))
        {

#line default
#line hidden
            BeginContext(1282, 40, true);
            WriteLiteral("            <p class=\"h3\">Sponsored By: ");
            EndContext();
            BeginContext(1323, 17, false);
#line 30 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                   Write(Model.SponsorName);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 31 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
             if (Model.SponsorLogo != null)
            {

#line default
#line hidden
            BeginContext(1403, 71, true);
            WriteLiteral("                <img class=\"displayPrizeImage\" height=\"300\" width=\"300\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1474, "\"", 1547, 2);
            WriteAttributeValue("", 1480, "data:image;base64,", 1480, 18, true);
#line 33 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
WriteAttributeValue("", 1498, System.Convert.ToBase64String(Model.SponsorLogo), 1498, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1548, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 34 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
            }

#line default
#line hidden
#line 34 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1576, 54, true);
            WriteLiteral("    </div>\n     <div class=\"col-lg-7\" id=\"rightSide\">\n");
            EndContext();
#line 38 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
          if (Model.NumberOfBallots > 0)
         {

#line default
#line hidden
            BeginContext(1682, 289, true);
            WriteLiteral(@"             <span class=""display-4"">Winners </span>
             <hr />
             <div class=""winnerName"" id=""winnerSpinner"">
                 <div class=""lds-ring""><div></div><div></div><div></div><div></div></div>
             </div>
             <ul class=""inline"" id=""winnerList"">
");
            EndContext();
#line 46 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                  foreach (Attendee winner in Model.Winners)
                 {

#line default
#line hidden
            BeginContext(2051, 87, true);
            WriteLiteral("                     <li class=\"winnerName\">\n                         <span class=\"h1\">");
            EndContext();
            BeginContext(2139, 16, false);
#line 49 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                     Write(winner.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2155, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2157, 15, false);
#line 49 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                                       Write(winner.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2172, 56, true);
            WriteLiteral("</span>\n                         <a class=\'btn\' href=\'#\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 2228, "\'", 2273, 3);
            WriteAttributeValue("", 2238, "redrawPrizeWinner(this,", 2238, 23, true);
#line 50 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
WriteAttributeValue(" ", 2261, winner.Id, 2262, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2272, ")", 2272, 1, true);
            EndWriteAttribute();
            BeginContext(2274, 82, true);
            WriteLiteral("> X</a>\n                         <br />\n                         <span class=\'h3\'>");
            EndContext();
            BeginContext(2357, 14, false);
#line 52 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                     Write(winner.Company);

#line default
#line hidden
            EndContext();
            BeginContext(2371, 35, true);
            WriteLiteral("</span>\n                     </li>\n");
            EndContext();
#line 54 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                 }

#line default
#line hidden
            BeginContext(2425, 19, true);
            WriteLiteral("             </ul>\n");
            EndContext();
#line 56 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
         }
         else
         {

#line default
#line hidden
            BeginContext(2480, 69, true);
            WriteLiteral("             <p class=\'text-danger\'>Not Enough Ballots For Prize</p>\n");
            EndContext();
#line 60 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
         }

#line default
#line hidden
            BeginContext(2560, 19, true);
            WriteLiteral("     </div>\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2597, 52, true);
                WriteLiteral("\n    <script>\n        var numberOfAvailablePrizes = ");
                EndContext();
                BeginContext(2650, 21, false);
#line 65 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                                 Write(Model.PrizesAvailable);

#line default
#line hidden
                EndContext();
                BeginContext(2671, 912, true);
                WriteLiteral(@";
        var allowRedraw = true;

        $(document).ready(function () {
            showHideSpinner(true);
        });

        document.addEventListener(""keyup"", function (event) {
            if (event.keyCode === 13) {
                event.preventDefault();

                drawWinner();
            }
        });

        function showHideSpinner(hidden) {
            if (hidden) {
                $('#winnerSpinner').hide();
            } else {
                $('#winnerSpinner').show();
            }
        }


        function drawWinner() {
            if (numberOfAvailablePrizes > 0) {
                numberOfAvailablePrizes--;

                showHideSpinner(false);

                $.ajax({
                    dataType: ""json"",
                    type: ""POST"",
                    contentType: 'application/json',
                    data: JSON.stringify({
                        Id: ");
                EndContext();
                BeginContext(3584, 13, false);
#line 100 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                       Write(Model.PrizeId);

#line default
#line hidden
                EndContext();
                BeginContext(3597, 47, true);
                WriteLiteral("\n                }),\n                    url: \"");
                EndContext();
                BeginContext(3645, 38, false);
#line 102 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                     Write(Url.Action("DrawPrizeWinner", "Prize"));

#line default
#line hidden
                EndContext();
                BeginContext(3683, 1262, true);
                WriteLiteral(@""",
                    success: drawWinnerSuccess,
                    error: function (xhr) {
                        console.log(xhr);

                        showHideSpinner(true);
                    }
                });
            }
        }

        function updateNumberOfPrizesDisplay() {
            $('#numberOfPrizes').html(numberOfAvailablePrizes);
        }

        function showWinner(winnerObj) {
            $('#winnerList').prepend(""<li class='winnerName'><span class='h1'>"" + winnerObj.name + ""</span>"" +
                ""<a class='btn' href='#' onclick='redrawPrizeWinner(this,"" + winnerObj.attendeeId + "")'> X</a><br /><span class='h4'>"" +
                winnerObj.organizationName + ""</span></li>"").fadeIn();
        }

        function redrawPrizeWinner(listElement, attendeeId) {
            // Gaurd to prevent double tapping button
            if (allowRedraw) {
                allowRedraw = false;

                showHideSpinner(false);

                $(listElement).closest('.winnerName");
                WriteLiteral("\').hide();\n\n                $.ajax({\n                    dataType: \"json\",\n                    type: \"POST\",\n                    contentType: \'application/json\',\n                    data: JSON.stringify({\n                        PrizeId: ");
                EndContext();
                BeginContext(4946, 13, false);
#line 137 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                            Write(Model.PrizeId);

#line default
#line hidden
                EndContext();
                BeginContext(4959, 99, true);
                WriteLiteral(",\n                        AttendeeId: attendeeId\n                    }),\n                    url: \"");
                EndContext();
                BeginContext(5059, 35, false);
#line 140 "C:\Users\100732221\Desktop\OCCCIO_PrizeDrawSystem-master\OCCCIO_PrizeDrawSystem-master\PrizeDraw\Views\Display\Details.cshtml"
                     Write(Url.Action("RedrawWinner", "Prize"));

#line default
#line hidden
                EndContext();
                BeginContext(5094, 738, true);
                WriteLiteral(@""",
                    success: drawWinnerSuccess,
                    error: function (xhr) {
                        alert(""Well this isn't good...Error drawing winners"");
                        console.log(xhr);
                    }
                });
            }
        }

        function drawWinnerSuccess(winnerObj, statusText, xhr) {
            allowRedraw = true;

            showHideSpinner(true);

            if (xhr.status == 200) {
                console.log(winnerObj);

                updateNumberOfPrizesDisplay();
                showWinner(winnerObj);
            } else {
                console.log(""Came back from ballot box empty handed...Anyone available to win?"");
            }
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisplayWinningTicketsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591