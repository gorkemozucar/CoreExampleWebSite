#pragma checksum "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7b749ea3b1b4a441e9bcc18beb3aa85f175b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodGet), @"mvc.1.0.view", @"/Views/Food/FoodGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7b749ea3b1b4a441e9bcc18beb3aa85f175b5d", @"/Views/Food/FoodGet.cshtml")]
    public class Views_Food_FoodGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
  
    ViewData["Title"] = "FoodGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FoodGet</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
 using (Html.BeginForm("FoodUpdate", "Food", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.FoodID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Image Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 35 "C:\Users\sg_oz\Desktop\ASP.NETCORECALISMA\CoreAndFood\Views\Food\FoodGet.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
