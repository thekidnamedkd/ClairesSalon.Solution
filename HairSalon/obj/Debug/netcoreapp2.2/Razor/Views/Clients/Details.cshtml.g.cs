#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca2cd7707e91d3825670a46a376c9f2a01f4e43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2cd7707e91d3825670a46a376c9f2a01f4e43a", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 42, true);
            WriteLiteral("\n<h2>Client Profile</h2>\n<hr />\n<h3>Name: ");
            EndContext();
            BeginContext(102, 42, false);
#line 9 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
     Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(144, 19, true);
            WriteLiteral("</h3>\n<h4>Stylist: ");
            EndContext();
            BeginContext(164, 41, false);
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
        Write(Html.DisplayFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
            BeginContext(205, 17, true);
            WriteLiteral("</h4>\n<h4>Style: ");
            EndContext();
            BeginContext(223, 37, false);
#line 11 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
      Write(Html.DisplayFor(model => model.Style));

#line default
#line hidden
            EndContext();
            BeginContext(260, 24, true);
            WriteLiteral("</h4>\n<h4>Phone Number: ");
            EndContext();
            BeginContext(285, 37, false);
#line 12 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
             Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(322, 9, true);
            WriteLiteral("</h4>\n<p>");
            EndContext();
            BeginContext(332, 42, false);
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Back to client", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(374, 15, true);
            WriteLiteral("</p>\n<hr />\n<p>");
            EndContext();
            BeginContext(390, 67, false);
#line 15 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Edit Client", "Edit", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(457, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(466, 71, false);
#line 16 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Delete Client", "Delete", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(537, 4, true);
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