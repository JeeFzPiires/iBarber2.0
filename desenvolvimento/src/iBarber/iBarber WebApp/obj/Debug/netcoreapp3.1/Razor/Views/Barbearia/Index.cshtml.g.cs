#pragma checksum "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\Barbearia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54ff96d57460f7014a27497dc7945e7fcce92fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barbearia_Index), @"mvc.1.0.view", @"/Views/Barbearia/Index.cshtml")]
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
#line 1 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\_ViewImports.cshtml"
using iBarber_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\_ViewImports.cshtml"
using iBarber_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54ff96d57460f7014a27497dc7945e7fcce92fe", @"/Views/Barbearia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0142e128d132376ab7d09c7fc185e399cd9487b", @"/Views/_ViewImports.cshtml")]
    public class Views_Barbearia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iBarber.Modelos.Barbearia>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 4 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\Barbearia\Index.cshtml"
Write(Model.CNPJ);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n<h4>\r\n    ");
#nullable restore
#line 8 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\Barbearia\Index.cshtml"
Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h4>\r\n\r\n\r\n<input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 120, "\"", 139, 1);
#nullable restore
#line 12 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\Barbearia\Index.cshtml"
WriteAttributeValue("", 128, Model.CNPJ, 128, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n<br />\r\n<input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 192, "\"", 211, 1);
#nullable restore
#line 14 "C:\Users\Jeferson Piires\Documents\Visual Studio 2019\iBarber-main\iBarber2.0\desenvolvimento\src\iBarber\iBarber WebApp\Views\Barbearia\Index.cshtml"
WriteAttributeValue("", 200, Model.Nome, 200, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<br />\r\n<br />\r\n<button class=\"btn btn-block btn-success\">\r\n    SUCESSO!\r\n</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iBarber.Modelos.Barbearia> Html { get; private set; }
    }
}
#pragma warning restore 1591
