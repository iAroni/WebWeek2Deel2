#pragma checksum "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24955b10c7d20a091093170afe841fda5d721f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelBoeking_Geboekt), @"mvc.1.0.view", @"/Views/HotelBoeking/Geboekt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelBoeking/Geboekt.cshtml", typeof(AspNetCore.Views_HotelBoeking_Geboekt))]
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
#line 1 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\_ViewImports.cshtml"
using WebWeek2Deel2;

#line default
#line hidden
#line 2 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
using WebWeek2Deel2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24955b10c7d20a091093170afe841fda5d721f40", @"/Views/HotelBoeking/Geboekt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e116fe8fbbff3b562d3a661c66082855be602e", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelBoeking_Geboekt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/HotelBoeking/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
  
    ViewData["Title"] = "Geboekt";

#line default
#line hidden
            BeginContext(90, 22, true);
            WriteLiteral("\r\n<h2>Geboekt</h2>\r\n\r\n");
            EndContext();
            BeginContext(112, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62a8afba7b814b389b22fe0c81d9ea6a", async() => {
                BeginContext(172, 65, true);
                WriteLiteral("\r\n    <div>Er is een nieuwe boeking gedaan</div>\r\n    <div>Naam: ");
                EndContext();
                BeginContext(238, 15, false);
#line 13 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
          Write(Model.HotelNaam);

#line default
#line hidden
                EndContext();
                BeginContext(253, 25, true);
                WriteLiteral("</div>\r\n    <div>Plaats: ");
                EndContext();
                BeginContext(279, 11, false);
#line 14 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
            Write(Model.Datum);

#line default
#line hidden
                EndContext();
                BeginContext(290, 34, true);
                WriteLiteral("</div>\r\n    <div>Aantal Personen: ");
                EndContext();
                BeginContext(325, 20, false);
#line 15 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
                     Write(Model.AantalPersonen);

#line default
#line hidden
                EndContext();
                BeginContext(345, 67, true);
                WriteLiteral("</div>\r\n\r\n    <div><input type=\"submit\" value=\"Wijzigen\" /></div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel> Html { get; private set; }
    }
}
#pragma warning restore 1591
