#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb2647766ef6b911a44c5ae48648aab23ba6460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
#line 5 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb2647766ef6b911a44c5ae48648aab23ba6460", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Stylist>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(92, 30, true);
            WriteLiteral("\n<h2>ALL STYLISTS</h2>\n<hr />\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(148, 44, true);
            WriteLiteral("  <h3>No stylists have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(195, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
 foreach (Stylist stylist in Model)
{

#line default
#line hidden
            BeginContext(234, 8, true);
            WriteLiteral("  <h4>+ ");
            EndContext();
            BeginContext(243, 84, false);
#line 17 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
   Write(Html.ActionLink($"{stylist.StylistName}", "Details", new { id = stylist.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(327, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 18 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
}

#line default
#line hidden
            BeginContext(335, 10, true);
            WriteLiteral("<hr />\n<p>");
            EndContext();
            BeginContext(346, 44, false);
#line 20 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Add new stylist", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(390, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(399, 47, false);
#line 21 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Return home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(446, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Stylist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
