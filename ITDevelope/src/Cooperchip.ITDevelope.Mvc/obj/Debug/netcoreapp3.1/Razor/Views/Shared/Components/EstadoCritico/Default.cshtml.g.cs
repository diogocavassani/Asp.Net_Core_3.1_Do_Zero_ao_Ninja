#pragma checksum "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6742d6814ead5b07689e3059250a95958c048d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EstadoCritico_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EstadoCritico/Default.cshtml")]
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
#nullable restore
#line 1 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDevelope.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDevelope.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6742d6814ead5b07689e3059250a95958c048d7f", @"/Views/Shared/Components/EstadoCritico/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec33828ddc18fa813d2c7a6be649d1a4e7d9894", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EstadoCritico_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDevelope.Mvc.ViewComponents.Helpers.ContadorEstadoPaciente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 88, "\"", 117, 1);
#nullable restore
#line 4 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
WriteAttributeValue("", 96, Model.ClassContainer, 96, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"panel-heading\">\r\n        <h4 class=\"panel-title\">");
#nullable restore
#line 6 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
                           Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"panel-body pt0\">\r\n        <div class=\"progressbar-stats-1\">\r\n            <div class=\"stats\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 346, "\"", 368, 1);
#nullable restore
#line 11 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
WriteAttributeValue("", 354, Model.IconeLg, 354, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                <div class=\"stats-number\" data-from=\"0\" data-to=1>");
#nullable restore
#line 12 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
                                                             Write(Model.Parcial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"progress animated-bar flat transparent progress-bar-xs mb10 mt0\">\r\n                <div class=\"progress-bar progress-bar-white\" role=\"progressbar\" data-transitiongoal=\"");
#nullable restore
#line 15 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
                                                                                                Write(Model.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">0</div>\r\n\r\n            </div>\r\n            <div class=\"comparison\">\r\n                <p class=\"mb0\"><i");
            BeginWriteAttribute("class", " class=\"", 795, "\"", 817, 1);
#nullable restore
#line 19 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
WriteAttributeValue("", 803, Model.IconeSm, 803, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 19 "E:\Nuvem\CURSOS - FACULDADE\ASP.Net - zero ao nija\ITDevelope - Copia\src\Cooperchip.ITDevelope.Mvc\Views\Shared\Components\EstadoCritico\Default.cshtml"
                                                         Write(Model.Percentual);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % sobre total</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDevelope.Mvc.ViewComponents.Helpers.ContadorEstadoPaciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
