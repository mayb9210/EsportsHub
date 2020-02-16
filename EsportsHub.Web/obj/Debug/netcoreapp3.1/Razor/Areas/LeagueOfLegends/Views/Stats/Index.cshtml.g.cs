#pragma checksum "C:\Users\Brandon\source\repos\EsportsHub\EsportsHub.Web\Areas\LeagueOfLegends\Views\Stats\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682e1860457a22b43838439233f1e18dac2f8187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_LeagueOfLegends_Views_Stats_Index), @"mvc.1.0.view", @"/Areas/LeagueOfLegends/Views/Stats/Index.cshtml")]
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
#line 1 "C:\Users\Brandon\source\repos\EsportsHub\EsportsHub.Web\Areas\LeagueOfLegends\Views\_ViewImports.cshtml"
using EsportsHub.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brandon\source\repos\EsportsHub\EsportsHub.Web\Areas\LeagueOfLegends\Views\_ViewImports.cshtml"
using EsportsHub.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682e1860457a22b43838439233f1e18dac2f8187", @"/Areas/LeagueOfLegends/Views/Stats/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"594a6ab64e3647ea363dd625cbe1f371a1822410", @"/Areas/LeagueOfLegends/Views/_ViewImports.cshtml")]
    public class Areas_LeagueOfLegends_Views_Stats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Brandon\source\repos\EsportsHub\EsportsHub.Web\Areas\LeagueOfLegends\Views\Stats\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<div ng-controller=""myCtrl""></div>
<table id=""homeTable"">
    <thead>
        <tr>
            <th>Image</th>
            <th>Name</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>

<script>
    // series id: 4198
    // tournament id: 2378
    app.controller('myCtrl', function ($scope, $http) {
        //$http({
        //    method: 'GET',
        //    url: ''
        //}).then(function (resp) {
        //    console.log(resp);
        //});
    });
    $(document).ready(function () {
        $('#homeTable').DataTable({
            processing: true,
            serverSide: true,
            ajax: {
                url: ""https://localhost:44395/api/lol/Tournaments/GetPlayers?id=2378"",
                type: ""GET"",
                success: function (json) {
                    console.log(json);
                },
            },
            columns: [
                //{ data: ""image_url"", render: function (d) { return ""<img src=\"""" + d.image_ur");
            WriteLiteral(@"l + ""\"" />"" } },
                //{ data: ""name"", render: ""<a asp-area=\""LeagueOfLegends\"" asp-controller=\""Stats\"" asp-action=\""Player\"""" }
                { data: ""image_url"" },
                { data: ""name"" }
            ]
        });
        //$.ajax({
        //    url: ""https://localhost:44395/api/lol/Tournaments/GetPlayers?id=2378"",
        //    type: ""GET"",
        //    dataSrc: function (json) {
        //        //var jsonData = JSON.parse(json.data);
        //        return json.data;
        //    },
        //    success: function (json) {
        //        console.log(json);
        //        var jsonData = JSON.parse(json.data);
        //        $('#homeTable').DataTable({
        //            //processing: true,
        //            //serverSide: true,
        //            //ajax: {
        //            //    url: ""https://localhost:44395/api/lol/Tournaments/GetPlayers?id=2378"",
        //            //    type: ""GET"",
        //            //    dataSrc: functi");
            WriteLiteral(@"on (json) {
        //            //        //var jsonData = JSON.parse(json.data);
        //            //        return json.data;
        //            //    },
        //            //    success: function (json) {
        //            //        console.log(json);
        //            //    },
        //            //},
        //            data: jsonData,
        //            columns: [
        //                //{ data: ""image_url"", render: function (d) { return ""<img src=\"""" + d.image_url + ""\"" />"" } },
        //                //{ data: ""name"", render: ""<a asp-area=\""LeagueOfLegends\"" asp-controller=\""Stats\"" asp-action=\""Player\"""" }
        //                { data: ""image_url"" },
        //                { data: ""name"" }
        //            ]
        //        });
        //    },
        //});
        
        
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
