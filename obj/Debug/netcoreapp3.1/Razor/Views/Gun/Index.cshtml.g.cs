#pragma checksum "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0655fc8a32dfdb24022afeaba77abd5adcc1730d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gun_Index), @"mvc.1.0.view", @"/Views/Gun/Index.cshtml")]
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
#line 1 "C:\Users\frane\source\repos\PO7\PO7\Views\_ViewImports.cshtml"
using PO7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\frane\source\repos\PO7\PO7\Views\_ViewImports.cshtml"
using PO7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0655fc8a32dfdb24022afeaba77abd5adcc1730d", @"/Views/Gun/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37304dad90070d5b4bf90da624e47b30eae68954", @"/Views/_ViewImports.cshtml")]
    public class Views_Gun_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PO7.Models.Gun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
  
    ViewData["Title"] = "Bronie";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Lista broni</h1>
    <a class=""btn btn-color"" href=""/Gun/Add"">Dodaj</a>
    <table class=""table table-light table-responsive-md rounded"">
        <thead>
            <tr>
                <th>Nazwa</th>
                <th>Kaliber</th>
                <th>Długość lufy</th>
                <th>Waga</th>
                <th>Edycja</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
                   Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
                   Write(item.caliber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
                   Write(item.size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
                   Write(item.weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-color\"");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 847, 2);
            WriteAttributeValue("", 829, "/Gun/Edit/", 829, 10, true);
#nullable restore
#line 27 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
WriteAttributeValue("", 839, item.id, 839, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edycja</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\frane\source\repos\PO7\PO7\Views\Gun\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PO7.Models.Gun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
