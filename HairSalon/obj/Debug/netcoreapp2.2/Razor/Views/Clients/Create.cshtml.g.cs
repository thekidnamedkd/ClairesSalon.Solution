#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51920d29ab9f993bd3a46fba2d7a5b18cfbcf2e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51920d29ab9f993bd3a46fba2d7a5b18cfbcf2e", @"/Views/Clients/Create.cshtml")]
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
            BeginContext(59, 22, true);
            WriteLiteral("\n<h4>NEW CLIENT</h4>\n\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(109, 24, true);
            WriteLiteral("    <label>Name</label>\n");
            EndContext();
            BeginContext(138, 42, false);
#line 12 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(187, 35, false);
#line 14 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Style));

#line default
#line hidden
            EndContext();
            BeginContext(228, 37, false);
#line 15 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.Style));

#line default
#line hidden
            EndContext();
            BeginContext(272, 35, false);
#line 17 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(313, 37, false);
#line 18 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(357, 37, false);
#line 20 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Stylist));

#line default
#line hidden
            EndContext();
            BeginContext(400, 30, false);
#line 21 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(432, 66, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new client\" class=\"button\" />\n");
            EndContext();
#line 24 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
}

#line default
#line hidden
            BeginContext(500, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(504, 44, false);
#line 25 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.ActionLink("Show all clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(548, 4, true);
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
