#pragma checksum "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c51473bf6be3dc4da5bd22d1459a17b6f2c218d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Temp), @"mvc.1.0.view", @"/Views/Home/Temp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Temp.cshtml", typeof(AspNetCore.Views_Home_Temp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51473bf6be3dc4da5bd22d1459a17b6f2c218d0", @"/Views/Home/Temp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb72519eb0160ea640b678674a79cba3bc1b5f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Temp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Player>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeShips", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TurnX", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(17, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51473bf6be3dc4da5bd22d1459a17b6f2c218d04458", async() => {
                BeginContext(23, 196, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Index</title>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\">\r\n\r\n");
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
            BeginContext(226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(228, 1354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51473bf6be3dc4da5bd22d1459a17b6f2c218d05857", async() => {
                BeginContext(234, 72, true);
                WriteLiteral("\r\n<div id=\"babywrapper\">\r\n\r\n<Div>\r\n    <h1>LightYear</h1>\r\n    <h2>Turn ");
                EndContext();
                BeginContext(307, 28, false);
#line 15 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
        Write(ViewBag.GameState.turnNumber);

#line default
#line hidden
                EndContext();
                BeginContext(335, 54, true);
                WriteLiteral("</h2>\r\n</Div>\r\n<h3 class=\'Player1State\'>Population is ");
                EndContext();
                BeginContext(390, 30, false);
#line 17 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
                                  Write(ViewBag.GameState.p1Population);

#line default
#line hidden
                EndContext();
                BeginContext(420, 46, true);
                WriteLiteral("</h3>\r\n<h3 class=\'Player2State\'>Population is ");
                EndContext();
                BeginContext(467, 30, false);
#line 18 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
                                  Write(ViewBag.GameState.p2Population);

#line default
#line hidden
                EndContext();
                BeginContext(497, 7, true);
                WriteLiteral("</h3>\r\n");
                EndContext();
                BeginContext(613, 198, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51473bf6be3dc4da5bd22d1459a17b6f2c218d07526", async() => {
                    BeginContext(664, 140, true);
                    WriteLiteral("\r\n    <label for=\"shipNumber\">Number of Ships:</label>\r\n    <input type=\"number\" name=\"shipNumber\" id=\"\">\r\n    <button>Make Ships</button>\r\n");
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
                BeginContext(811, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(813, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51473bf6be3dc4da5bd22d1459a17b6f2c218d09633", async() => {
                    BeginContext(860, 34, true);
                    WriteLiteral("\r\n    <button>Send Ship</button>\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                BeginContext(901, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(982, 8, true);
                WriteLiteral("\r\n<br>\r\n");
                EndContext();
                BeginContext(1364, 39, true);
                WriteLiteral("<h3 class=\"CombatLog\">Combat Log</h3>\r\n");
                EndContext();
#line 43 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
 if(ViewBag.GameState.p1Damage != 0){

#line default
#line hidden
                BeginContext(1442, 17, true);
                WriteLiteral("<p>Player 1 Lost ");
                EndContext();
                BeginContext(1460, 26, false);
#line 44 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
            Write(ViewBag.GameState.p1Damage);

#line default
#line hidden
                EndContext();
                BeginContext(1486, 34, true);
                WriteLiteral(" Population</p>\r\n<p>Player 2 Lost ");
                EndContext();
                BeginContext(1521, 26, false);
#line 45 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
            Write(ViewBag.GameState.p2Damage);

#line default
#line hidden
                EndContext();
                BeginContext(1547, 17, true);
                WriteLiteral(" Population</p>\r\n");
                EndContext();
#line 46 "C:\Users\Zach\Desktop\LightYear\LightYear\Views\Home\Temp.cshtml"
}

#line default
#line hidden
                BeginContext(1567, 8, true);
                WriteLiteral("</div>\r\n");
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
