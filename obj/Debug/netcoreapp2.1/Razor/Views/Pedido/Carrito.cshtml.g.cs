#pragma checksum "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b030ae331de85884b12f9dd4f549f969a15cf9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrito), @"mvc.1.0.view", @"/Views/Pedido/Carrito.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrito.cshtml", typeof(AspNetCore.Views_Pedido_Carrito))]
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
#line 3 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\_ViewImports.cshtml"
using Agapea_MVC_NetCore.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b030ae331de85884b12f9dd4f549f969a15cf9d", @"/Views/Pedido/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a9b7bfb072538d1281a5492d319743a7368431", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Libro,int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addLibro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DropLibro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(54, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
  
    ViewData["Title"] = "Carrito";
    Layout = "_Layout_Cliente";

#line default
#line hidden
            BeginContext(134, 20, true);
            WriteLiteral("\r\n<h2>Carrito</h2>\r\n");
            EndContext();
            BeginContext(643, 37, true);
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n");
            EndContext();
#line 31 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
         foreach (KeyValuePair<Libro, int> entry in Model)
        {

#line default
#line hidden
            BeginContext(751, 100, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <span>nombre: ");
            EndContext();
            BeginContext(852, 16, false);
#line 35 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
                             Write(entry.Key.titulo);

#line default
#line hidden
            EndContext();
            BeginContext(868, 101, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <span>autor: ");
            EndContext();
            BeginContext(970, 15, false);
#line 38 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
                            Write(entry.Key.autor);

#line default
#line hidden
            EndContext();
            BeginContext(985, 104, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <span>cantidad: ");
            EndContext();
            BeginContext(1090, 22, false);
#line 41 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
                               Write(entry.Value.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1112, 178, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            ");
            EndContext();
            BeginContext(1290, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145ef9bcb46a47719ef775f8acac1df7", async() => {
                BeginContext(1544, 1, true);
                WriteLiteral("+");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 48 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = (new Dictionary<String, String>(){ {"id", @entry.Key.isbn } });

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1549, 172, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            ");
            EndContext();
            BeginContext(1721, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3570c6a821514b91be172e2d87d5e453", async() => {
                BeginContext(1976, 1, true);
                WriteLiteral("-");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 56 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = (new Dictionary<String, String>(){ {"id", @entry.Key.isbn } });

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1981, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 62 "C:\Users\34693\source\repos\Agapea_MVC_NetCore\Views\Pedido\Carrito.cshtml"
         }

#line default
#line hidden
            BeginContext(2099, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<Libro,int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
