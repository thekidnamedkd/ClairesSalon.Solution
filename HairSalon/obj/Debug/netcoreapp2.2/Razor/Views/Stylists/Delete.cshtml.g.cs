#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1965a61f086a328128b3a1a92483aa7eea3d6d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Delete), @"mvc.1.0.view", @"/Views/Stylists/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Delete.cshtml", typeof(AspNetCore.Views_Stylists_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1965a61f086a328128b3a1a92483aa7eea3d6d4", @"/Views/Stylists/Delete.cshtml")]
    public class Views_Stylists_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 57, true);
            WriteLiteral("\n<h2>Are you sure you want to remove this stylist?</h2>\n\n");
            EndContext();
            BeginContext(118, 47, false);
#line 9 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.StylistName));

#line default
#line hidden
            EndContext();
            BeginContext(165, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(194, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Remove\" />\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(240, 48, false);
#line 14 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Stylists/Delete.cshtml"
Write(Html.ActionLink("Back to all stylists", "Index"));

#line default
#line hidden
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
