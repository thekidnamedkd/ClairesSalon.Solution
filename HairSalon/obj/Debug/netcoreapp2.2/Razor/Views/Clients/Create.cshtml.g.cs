#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4d1ea11873fb8cecf581d2e4ba68ae17f0320a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Create.cshtml", typeof(AspNetCore.Views_Clients_Create))]
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
#line 5 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4d1ea11873fb8cecf581d2e4ba68ae17f0320a", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(84, 22, true);
            WriteLiteral("\n<h4>NEW CLIENT</h4>\n\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(134, 25, true);
            WriteLiteral("    <label>Name:</label>\n");
            EndContext();
            BeginContext(164, 42, false);
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(208, 26, true);
            WriteLiteral("    <label>Style:</label>\n");
            EndContext();
            BeginContext(239, 37, false);
#line 16 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.Style));

#line default
#line hidden
            EndContext();
            BeginContext(278, 26, true);
            WriteLiteral("    <label>Phone:</label>\n");
            EndContext();
            BeginContext(309, 37, false);
#line 19 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(353, 39, false);
#line 21 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
            BeginContext(398, 30, false);
#line 22 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(430, 62, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add Client\" class=\"button\" />\n");
            EndContext();
#line 25 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
}

#line default
#line hidden
            BeginContext(494, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(498, 44, false);
#line 26 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.ActionLink("Show all clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(542, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
