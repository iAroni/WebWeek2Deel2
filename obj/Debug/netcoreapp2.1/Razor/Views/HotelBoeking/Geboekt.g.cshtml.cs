#pragma checksum "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618bb19700b2d4fd17f225271d20a5f3437e1eb0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618bb19700b2d4fd17f225271d20a5f3437e1eb0", @"/Views/HotelBoeking/Geboekt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e116fe8fbbff3b562d3a661c66082855be602e", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelBoeking_Geboekt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel>
    {
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
            BeginContext(90, 77, true);
            WriteLiteral("\r\n<h2>Geboekt</h2>\r\n\r\n<div>Er is een nieuwe boeking gedaan</div>\r\n<div>Naam: ");
            EndContext();
            BeginContext(168, 15, false);
#line 12 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
      Write(Model.HotelNaam);

#line default
#line hidden
            EndContext();
            BeginContext(183, 21, true);
            WriteLiteral("</div>\r\n<div>Plaats: ");
            EndContext();
            BeginContext(205, 11, false);
#line 13 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
        Write(Model.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(216, 30, true);
            WriteLiteral("</div>\r\n<div>Aantal Personen: ");
            EndContext();
            BeginContext(247, 20, false);
#line 14 "C:\Users\megas\source\repos\WebWeek2Deel2\WebWeek2Deel2\Views\HotelBoeking\Geboekt.cshtml"
                 Write(Model.AantalPersonen);

#line default
#line hidden
            EndContext();
            BeginContext(267, 8, true);
            WriteLiteral("</div>\r\n");
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
