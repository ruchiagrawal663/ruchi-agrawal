#pragma checksum "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf89cf032c0931e3ab72c2cee8fbd05c9c303c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf89cf032c0931e3ab72c2cee8fbd05c9c303c3", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2369768eb70623acf1b455032a9a618096237c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApexRestaurant.Mvc.Models.CustomerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
  

ViewBag.Title = "Index";
Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Index</h2>\r\n<p>\r\n    ");
#nullable restore
#line 9 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n<tr>\r\n<th> \r\n    ");
#nullable restore
#line 14 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 17 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 20 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 23 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.PhoneRes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 26 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.PhoneMob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 29 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.EnrollDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
#nullable restore
#line 32 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th></th>\r\n</tr>\r\n");
#nullable restore
#line 36 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n<td>\r\n    ");
#nullable restore
#line 39 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 42 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 45 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 48 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.PhoneRes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n<td>\r\n    ");
#nullable restore
#line 52 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.PhoneMob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 55 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.EnrollDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 58 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 61 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 62 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 63 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n</tr>\r\n");
#nullable restore
#line 66 "D:\ruchi\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApexRestaurant.Mvc.Models.CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
