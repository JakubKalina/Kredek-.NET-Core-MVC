#pragma checksum "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9ac9bad6ed8a1b663544e7ade6080457cab7cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCarByModel), @"mvc.1.0.view", @"/Views/Home/GetCarByModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetCarByModel.cshtml", typeof(AspNetCore.Views_Home_GetCarByModel))]
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
#line 1 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\_ViewImports.cshtml"
using KredekLabDotNetCoreMvc;

#line default
#line hidden
#line 2 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\_ViewImports.cshtml"
using KredekLabDotNetCoreMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9ac9bad6ed8a1b663544e7ade6080457cab7cf", @"/Views/Home/GetCarByModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cba92a75c7eb19e18e6dc7d3daec18efb20291", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCarByModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KredekLabDotNetCoreMvc.Models.CarViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
  
    ViewData["Title"] = "GetCarByModel";

#line default
#line hidden
            BeginContext(102, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(114, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f9ac9bad6ed8a1b663544e7ade6080457cab7cf3943", async() => {
                BeginContext(120, 160, true);
                WriteLiteral("\r\n    <title>Get car by model</title>\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css\">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 280, "\"", 322, 1);
#line 12 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
WriteAttributeValue("", 287, Url.Content("~/Scripts/Style.css"), 287, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(323, 38, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(370, 345, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f9ac9bad6ed8a1b663544e7ade6080457cab7cf5830", async() => {
                BeginContext(376, 76, true);
                WriteLiteral("\r\n    <br />\r\n    <div>\r\n        <!--Model samochodu-->\r\n        <h2>Model: ");
                EndContext();
                BeginContext(453, 11, false);
#line 18 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
              Write(Model.Model);

#line default
#line hidden
                EndContext();
                BeginContext(464, 52, true);
                WriteLiteral("</h2>\r\n        <!--Producent-->\r\n        <h4>Marka: ");
                EndContext();
                BeginContext(517, 18, false);
#line 20 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
              Write(Model.Manufacturer);

#line default
#line hidden
                EndContext();
                BeginContext(535, 46, true);
                WriteLiteral("</h4>\r\n        <!--Cena-->\r\n        <h4>Cena: ");
                EndContext();
                BeginContext(582, 11, false);
#line 22 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
             Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(593, 53, true);
                WriteLiteral("</h4>\r\n        <!--Zdjęcie samochodu-->\r\n        <img");
                EndContext();
                BeginWriteAttribute("src", " src=", 646, "", 676, 1);
#line 24 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
WriteAttributeValue("", 651, Url.Content(Model.Photo), 651, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=", 676, "", 693, 1);
#line 24 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\GetCarByModel.cshtml"
WriteAttributeValue("", 681, Model.Model, 681, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 15, true);
                WriteLiteral(">\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KredekLabDotNetCoreMvc.Models.CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591