#pragma checksum "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1087d80c1b21799613c1ace8c5c0bccbd15596ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\_ViewImports.cshtml"
using Agapea_MVC_NetCore;

#line default
#line hidden
#line 2 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\_ViewImports.cshtml"
using Agapea_MVC_NetCore.Models;

#line default
#line hidden
#line 1 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
using System.Collections;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1087d80c1b21799613c1ace8c5c0bccbd15596ff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ad6de2dbc8554ddbf4273f09c337a242a65795", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<String, Libro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "LibrosDe";

#line default
#line hidden
            BeginContext(105, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
     foreach (Libro unlibro in Model.Values)
    {

#line default
#line hidden
            BeginContext(185, 87, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <a href=\"#\"> ");
            EndContext();
            BeginContext(273, 14, false);
#line 12 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
                        Write(unlibro.titulo);

#line default
#line hidden
            EndContext();
            BeginContext(287, 29, true);
            WriteLiteral("</a>\r\n                <label>");
            EndContext();
            BeginContext(317, 13, false);
#line 13 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
                  Write(unlibro.autor);

#line default
#line hidden
            EndContext();
            BeginContext(330, 33, true);
            WriteLiteral("</label>\r\n                <label>");
            EndContext();
            BeginContext(364, 34, false);
#line 14 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
                  Write(unlibro.numeroDePaginas.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(398, 41, true);
            WriteLiteral("</label>\r\n                <label><strong>");
            EndContext();
            BeginContext(440, 25, false);
#line 15 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
                          Write(unlibro.precio.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(465, 41, true);
            WriteLiteral(" €</strong></label>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 506, "\"", 556, 2);
            WriteAttributeValue("", 512, "../wwwroot/images/", 512, 18, true);
#line 16 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 530, unlibro.imagen.ToString(), 530, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(557, 106, true);
            WriteLiteral("/>\r\n                <button class=\"btn btn-primary\">Comprar</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(670, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<String, Libro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
