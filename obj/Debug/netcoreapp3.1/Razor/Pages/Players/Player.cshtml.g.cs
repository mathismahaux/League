#pragma checksum "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88e893889bc3ccf957d54203f2535e2f3e5724e7ff757980ad57d30ccd8ff8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Players.Pages_Players_Player), @"mvc.1.0.razor-page", @"/Pages/Players/Player.cshtml")]
namespace League.Pages.Players
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/_ViewImports.cshtml"
using League

#nullable disable
    ;
#nullable restore
#line 2 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/_ViewImports.cshtml"
using League.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", 
    // language=Route
#nullable restore
#line 1 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
      "{id}"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"88e893889bc3ccf957d54203f2535e2f3e5724e7ff757980ad57d30ccd8ff8e6", @"/Pages/Players/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5f088290de2bf8b800def2262432c5928f679871215bc838aec033500e74ff67", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Pages_Players_Player : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
  
  ViewData["Title"] = "NFL Player - " + @Html.DisplayFor(model => model.Player.Name);

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n  <h1 class=\"display-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 195, "\"", 243, 3);
            WriteAttributeValue("", 201, "/image/nfl/logo/", 201, 16, true);
            WriteAttributeValue("", 217, 
#nullable restore
#line 10 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
                                Model.Player.TeamId

#line default
#line hidden
#nullable disable
            , 217, 22, false);
            WriteAttributeValue("", 239, ".png", 239, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            Write(
#nullable restore
#line 11 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
     Html.DisplayFor(model => model.Player.Number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    ");
            Write(
#nullable restore
#line 12 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
     Html.DisplayFor(model => model.Player.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n  </h1>\r\n</div>\r\n\r\n<div>");
            Write(
#nullable restore
#line 16 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
      Model.Player.Position

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Rating: ");
            Write(
#nullable restore
#line 18 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
              Model.Player.Rating

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Rank: ");
            Write(
#nullable restore
#line 19 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
            Model.Player.Rank

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Depth: ");
            Write(
#nullable restore
#line 20 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
             Model.Player.Depth

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Experience: ");
            Write(
#nullable restore
#line 22 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
                  Model.Player.Experience

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>College: ");
            Write(
#nullable restore
#line 23 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
               Model.Player.College

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Draft: ");
            Write(
#nullable restore
#line 24 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
             Model.Player.DraftYear

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" - ");
            Write(
#nullable restore
#line 24 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
                                       Model.Player.DraftRound

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" - ");
            Write(
#nullable restore
#line 24 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
                                                                  Model.Player.DraftPick

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Height: ");
            Write(
#nullable restore
#line 26 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
              Model.Player.Height

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Weight: ");
            Write(
#nullable restore
#line 27 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
              Model.Player.Weight

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Age ");
            Write(
#nullable restore
#line 28 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
          Model.Player.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n<div>Birthday: ");
            Write(
#nullable restore
#line 29 "/Users/mathismahaux/Projects/C#/Dotnet/Personal/League/Pages/Players/Player.cshtml"
                Model.Player.BirthDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel>)PageContext?.ViewData;
        public PlayerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
