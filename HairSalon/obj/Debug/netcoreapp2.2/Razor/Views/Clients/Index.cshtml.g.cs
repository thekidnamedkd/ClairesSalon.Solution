#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51f2060287285ce6492c01416aed6e4b689e30f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 5 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f2060287285ce6492c01416aed6e4b689e30f4", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(91, 29, true);
            WriteLiteral("\n<h1>ALL CLIENTS</h1>\n<hr />\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(146, 48, true);
            WriteLiteral("  <h3>You have not listed any clients yet!</h3>\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(197, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 foreach (Client client in Model)
{

#line default
#line hidden
            BeginContext(234, 8, true);
            WriteLiteral("  <h4>+ ");
            EndContext();
            BeginContext(243, 80, false);
#line 17 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
   Write(Html.ActionLink($"{client.ClientName}", "Details", new { id = client.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(323, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(327, 26, false);
#line 17 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
                                                                                       Write(client.Stylist.StylistName);

#line default
#line hidden
            EndContext();
            BeginContext(353, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 18 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(361, 10, true);
            WriteLiteral("<hr />\n<p>");
            EndContext();
            BeginContext(372, 43, false);
#line 20 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Add new client", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(415, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(425, 40, false);
#line 22 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(465, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
