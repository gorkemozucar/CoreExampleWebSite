#pragma checksum "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16bafedba51f0dfcffa409c2d029fd3dddbe4545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16bafedba51f0dfcffa409c2d029fd3dddbe4545", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Category List</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
 using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    Food Name:");
#nullable restore
#line 12 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
                         Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <input type=\"submit\" value=\"Find\" />\r\n                </p>\r\n");
#nullable restore
#line 15 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 740, "\"", 786, 3);
            WriteAttributeValue("", 747, "/Category/CategoryDelete/", 747, 25, true);
#nullable restore
#line 30 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 772, x.CategoryId, 772, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 785, ".", 785, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 888, 2);
            WriteAttributeValue("", 853, "/Category/CategoryGet/", 853, 22, true);
#nullable restore
#line 31 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 875, x.CategoryId, 875, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-primary\">New Category</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
