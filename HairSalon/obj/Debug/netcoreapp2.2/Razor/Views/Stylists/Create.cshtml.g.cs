#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef8006c84405e106e636d8e06b1c968ed1ed6ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Create.cshtml", typeof(AspNetCore.Views_Stylists_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef8006c84405e106e636d8e06b1c968ed1ed6ee", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 28, true);
            WriteLiteral("\n<h4>Add a new stylist</h4>\n");
            EndContext();
#line 8 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(121, 28, false);
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.Label("Stylist Name: "));

#line default
#line hidden
            EndContext();
            BeginContext(155, 70, false);
#line 11 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.StylistName, new {required="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(226, 52, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new stylist\" />\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
            BeginContext(280, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(284, 45, false);
#line 14 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.ActionLink("Show all stylists", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(329, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
