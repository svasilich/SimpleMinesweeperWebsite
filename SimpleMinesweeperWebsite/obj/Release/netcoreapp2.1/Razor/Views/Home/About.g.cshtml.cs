#pragma checksum "D:\Projects\Git\SimpleMinesweeperWebsite\SimpleMinesweeperWebsite\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ca5aa92b3dc23491aa134ad37d60de10a9715d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\Projects\Git\SimpleMinesweeperWebsite\SimpleMinesweeperWebsite\Views\_ViewImports.cshtml"
using SimpleMinesweeperWebsite;

#line default
#line hidden
#line 2 "D:\Projects\Git\SimpleMinesweeperWebsite\SimpleMinesweeperWebsite\Views\_ViewImports.cshtml"
using SimpleMinesweeperWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ca5aa92b3dc23491aa134ad37d60de10a9715d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bd3ab227a6746065377dd8b0ece45979606b32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Git\SimpleMinesweeperWebsite\SimpleMinesweeperWebsite\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Как играть?";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 17, false);
#line 4 "D:\Projects\Git\SimpleMinesweeperWebsite\SimpleMinesweeperWebsite\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(69, 1461, true);
            WriteLiteral(@"</h2>

<p>Сапёр - игра очень простая. Здесь вы можете ознакомиться с правилами игры.</p>
<p>
    В игре существует три стандартных уровня сложности и один пользовательский. Стандартные уровни сложности:
    <ul>
        <li><b>Новичок.</b> Поле 9х9, на котором находятся 10 мин.</li>
        <li><b>Любитель.</b> Поле 16х16, на котором находятся 40 мин.</li>
        <li><b>Профессионал.</b> Поле 30х16, 99 мин.</li>
    </ul>
    Установить сложность можно с помощью меню игры или страницы настроек.
</p>
<p>
    Чтобы начать игру, нажмите на одну из клеток минного поля. Эта клетка откроется. Если вам повезёт, клетка будет пустой и откроется ещё несколько соседних клеток. Если нет, клетка будет обозначена цифрой. Проиграть на первом ходу невозможно.
</p>
<p>
    Цифра указывает на количество мин, расположенных вокруг этой клетки. Допустимы значения от 1 до 8.
</p>
<p>
    Нажав правой кнопкой мыши по неоткрытой клетке, можно установить отметку – флажок. Отмечайте флажками клетки, которые, по ваш");
            WriteLiteral(@"ему мнению, заминированы. Если вы случайно нажмёте левой кнопкой мыши по установленному флажку, ничего не произойдёт. Нажмите на флажок правой кнопкой мыши, чтобы убрать отметку.
</p>
<p>
    Если вы откроете клетку, в которой расположена мина, игра будет проиграна.
</p>
<p>
    Чтобы выиграть, откройте все незаминированные клетки. Постарайтесь сделать это как можно быстрее, чтобы оставить своё имя в таблице рекордов!
</p>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
