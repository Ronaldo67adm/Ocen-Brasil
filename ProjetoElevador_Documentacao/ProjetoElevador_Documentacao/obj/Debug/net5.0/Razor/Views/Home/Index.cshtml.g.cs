#pragma checksum "C:\Users\roliv\Documents\C#\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217a519d4cab75cbabc0cc9f445c89a4191d711a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\roliv\Documents\C#\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\roliv\Documents\C#\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"217a519d4cab75cbabc0cc9f445c89a4191d711a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\roliv\Documents\C#\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Projeto elevador</h1>
    <p>Trabalho de conclus??o do curso <b>""Forma????o MS-DEV""</b>da Ocean Brasil.</p>
    <h2>Escopo do projeto</h2>
</div>
<div class=""text-justified"">
    <p>Aplicar o conhecimento adquirido no curso para criar um software interativo que tem como fun????o o gerenciamento de um elevador, tendo as fun????es inicializar, entrar, sair, subir e descer</p>
</div>
<div class=""text-center"">
    <h2>Funcionamento</h2>
</div>
<div class=""text-justified"">
<p>O programa tem uma classe ""main"" denominada Elevador que armazena as informa????es pertinentes a um elevador dentro de um pr??dio tais como o total de andares no pr??dio, a capacidade do elevador e quantas pessoas est??o presentes.</p>
<p style=""text-align:justify""><img");
            BeginWriteAttribute("alt", " alt=\"", 846, "\"", 852, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""/Imagens/ClasseElevador.PNG""/ height=""200"" width=""400""></p>
<p>A classe Elevador disponibiliza os seguintes m??todos:</p>
<ul>
<li>Inicializar: Recebe do usu??rio os par??metros capacidade do elevador e total de andares no pr??dio;</li>
<p style=""text-align:justify""><img");
            BeginWriteAttribute("alt", " alt=\"", 1130, "\"", 1136, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""/Imagens/Parametros.PNG""/ height=""200"" width=""400""></p>
<li>Entrar : Permite ao usu??rio acrescentar pessoas no elevador, dentro da capacidade por ele estabelecida;</li>
<li>Sair : Permite ao usu??rio remover pessoas do elevador, consoante com n??mero de ocupantes por ele determinado;</li>
<p style=""text-align:justify""><img");
            BeginWriteAttribute("alt", " alt=\"", 1468, "\"", 1474, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"/Imagens/SairEntrar.PNG\"/ height=\"200\" width=\"400\"></p>\r\n<li>Subir : Permite ao usu??rio mover o elevador para andares superiores ao atual entre o andar inicial \"0\" (t??rreo) e o topo do pr??dio;</li>\r\n<p style=\"text-align:justify\"><img");
            BeginWriteAttribute("alt", " alt=\"", 1714, "\"", 1720, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""/Imagens/Subir.PNG""/ height=""200"" width=""400""></p>
<li>Descer : Permite ao usu??rio mover o elevador para andares inferiores ao atual at?? o t??rreo.</li>
</ul>
<p>O usu??rio fornece todos os paramentros e comandos digitando dados n??mericos em resposta a perguntas feitas pelo software.</p>
<p>O software emite mensagens de erro para o usu??rio caso os comandos fornecidos excedam a capacidade do elvador, extrapolem os limites do pr??dio ou levem a situa????es que n??o fa??am sentido (total de passageiros negativo ou mover o elevador para um andar onde j?? se encontra, por exemplo).</p>
</div>
<p style=""text-align:justify""><img");
            BeginWriteAttribute("alt", " alt=\"", 2354, "\"", 2360, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"/Imagens/ErroTotal.PNG\"/ height=\"200\" width=\"400\"></p>\r\n\r\n");
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
