#pragma checksum "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13001086263d523b9030e66460fe0e0c1d917022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GameScreen), @"mvc.1.0.view", @"/Views/Home/GameScreen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GameScreen.cshtml", typeof(AspNetCore.Views_Home_GameScreen))]
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
#line 1 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\_ViewImports.cshtml"
using LightYear;

#line default
#line hidden
#line 2 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\_ViewImports.cshtml"
using LightYear.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13001086263d523b9030e66460fe0e0c1d917022", @"/Views/Home/GameScreen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb72519eb0160ea640b678674a79cba3bc1b5f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GameScreen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Player>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeShips", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TurnX", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(50, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13001086263d523b9030e66460fe0e0c1d9170224841", async() => {
                BeginContext(56, 202, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Game Screen</title>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\">\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(265, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(267, 4813, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13001086263d523b9030e66460fe0e0c1d9170226246", async() => {
                BeginContext(273, 294, true);
                WriteLiteral(@"
    <div id=""babywrapper"">
        <Div class=""TopDisplayBox"">
            <!---->
            <div class=""columns"">
                <h3 align='center' class='Player1State'>
                    <p>
                        Player 1
                    </p>
                        Pop ");
                EndContext();
                BeginContext(568, 30, false);
#line 20 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                       Write(ViewBag.GameState.p1Population);

#line default
#line hidden
                EndContext();
                BeginContext(598, 82, true);
                WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        Ship ");
                EndContext();
                BeginContext(681, 15, false);
#line 23 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                        Write(ViewBag.p1Ships);

#line default
#line hidden
                EndContext();
                BeginContext(696, 307, true);
                WriteLiteral(@"
                    </p>


                </h3>
            </div>
            <!---->
            <div class=""columns"">
                <!-- <h1 class='babybattlelogtitle' align=""center"">LightYear</h1> -->
                <br>
                <h2 class=""babybattlelogtitle""align='center'>Month ");
                EndContext();
                BeginContext(1004, 28, false);
#line 33 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                                                              Write(ViewBag.GameState.turnNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1032, 524, true);
                WriteLiteral(@" </h2>
                <br>
                <br>
                <br>
                <div align=""center"" class=""col-sm-14"">
                
                    <table class=""table table-striped"">
                        <h2 class='babybattlelogtitle'>Battle Log</h2>
                                <tr>
                                    <th class=""Player1State"">Player 1</th>
                                    <th class=""Player1State"">Lost</th>
                                    <th class=""Player1State"">");
                EndContext();
                BeginContext(1557, 26, false);
#line 44 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                                                        Write(ViewBag.GameState.p1Damage);

#line default
#line hidden
                EndContext();
                BeginContext(1583, 380, true);
                WriteLiteral(@" thousand</th>
                                    <th class=""Player1State"">Population</th>
                                </tr>
                                <tr>
                                    <th class=""Player2State"">Player 2</th>
                                    <th class=""Player2State"">Lost</th>
                                    <th class=""Player2State"">");
                EndContext();
                BeginContext(1964, 26, false);
#line 50 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                                                        Write(ViewBag.GameState.p2Damage);

#line default
#line hidden
                EndContext();
                BeginContext(1990, 435, true);
                WriteLiteral(@" thousand</th>
                                    <th class=""Player2State"">Population</th>
                                </tr>  
                    </table>
                </div>
            </div>
            <!---->
            <div class=""columns"">
                <h3 align='center'class='Player2State'>
                    <p>
                        Player 2
                    </p>
                        Pop ");
                EndContext();
                BeginContext(2426, 30, false);
#line 62 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                       Write(ViewBag.GameState.p2Population);

#line default
#line hidden
                EndContext();
                BeginContext(2456, 82, true);
                WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        Ship ");
                EndContext();
                BeginContext(2539, 15, false);
#line 65 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\GameScreen.cshtml"
                        Write(ViewBag.p2Ships);

#line default
#line hidden
                EndContext();
                BeginContext(2554, 1914, true);
                WriteLiteral(@"
                    </p>
                </h3>
            </div>
            <!---->
        </Div>
        
        <!-- <div class=""MidDisplayBox"">
            <div align=""center"" class=""col-sm-14"">
                
                <table class=""table table-striped"">
                    <h1 class='babybattlelogtitle'>Battle Log</h1>
                            <tr>
                                <th>Player 1</th>
                                <th>Lost</th>
                                <th>xthousand</th>
                                <th>Population</th>
                            </tr>
                            <tr>
                                <th>Player 2</th>
                                <th>Lost</th>
                                <th>xthousand</th>
                                <th>Population</th>
                            </tr>  
                </table>
            </div>
        </div> -->

        <div class=""undercolumns"">
            <h3 align=""");
                WriteLiteral(@"center"" class=""babybattlelogtitle"">Orbital Ship Yard</h3>

            <div class=""dropdown-test-ship"">
                <span class=""shipDetails"">Ship Details</span>
                <div class=""dropdown-content-test-ship"">
                    <p>
                        <h4>
                            Type: Fighter
                        </h4>
                        <p>
                            Cost: 5
                        </p>
                        <p>
                            Health: 5
                        </p>
                        <p>
                            Damage: 5
                        </p>
                        <p>
                            Description: This fighter is state of the art..
                        </p>
                    </p>
                </div>
            </div>
            <div>
                ");
                EndContext();
                BeginContext(4468, 347, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13001086263d523b9030e66460fe0e0c1d91702213407", async() => {
                    BeginContext(4520, 288, true);
                    WriteLiteral(@"
                    <label class='numshipslabel' for=""shipNumber"">Number of Ships:</label>
                    <input class='shipnumbut' type=""number"" name=""shipNumber"" id="""">
                    <p align='center'><button class='shipyardbutton'>Purchase</button></p>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4815, 72, true);
                WriteLiteral("\r\n            </div>\r\n            <div align=\"center\">\r\n                ");
                EndContext();
                BeginContext(4887, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13001086263d523b9030e66460fe0e0c1d91702215737", async() => {
                    BeginContext(4934, 92, true);
                    WriteLiteral("\r\n                    <button class=\'shipyardbutton\'>End Turn --></button>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5033, 40, true);
                WriteLiteral("\r\n            </div>\r\n    </div>\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5080, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
