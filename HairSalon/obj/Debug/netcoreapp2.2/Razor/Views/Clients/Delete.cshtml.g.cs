#pragma checksum "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec02eae35de71d5f868960c28a0e7dc7ef1974f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Delete.cshtml", typeof(AspNetCore.Views_Clients_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec02eae35de71d5f868960c28a0e7dc7ef1974f2", @"/Views/Clients/Delete.cshtml")]
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 114, true);
            WriteLiteral("\n<h2>REMOVE CLIENT</h2>\n<hr />\n<h4>Are you sure you want to remove this client?</h4>\n<label>Client Name: </label>\n");
            EndContext();
            BeginContext(174, 42, false);
#line 11 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(216, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(245, 64, true);
            WriteLiteral("    <input type=\"submit\" value=\"Remove\" class=\"btn btn-danger\">\n");
            EndContext();
#line 15 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(311, 10, true);
            WriteLiteral("<hr />\n<p>");
            EndContext();
            BeginContext(322, 49, false);
#line 17 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
Write(Html.ActionLink("Return to all clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(371, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(380, 47, false);
#line 18 "/Users/thekidnamedkd/Desktop/ClairesSalon.Solution/HairSalon/Views/Clients/Delete.cshtml"
Write(Html.ActionLink("Return home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(427, 5, true);
            WriteLiteral("</p>\n");
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
