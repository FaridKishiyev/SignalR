#pragma checksum "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab69d57dde4f46a330b7e8cdf3413d70cf1ed0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
#line 1 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab69d57dde4f46a330b7e8cdf3413d70cf1ed0a", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c72b4ec699536514264caac58c39e4ab06dbe89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">&nbsp;</div>
    <div class=""row"">
        <div class=""col-2"">User</div>
        <div class=""col-4""><input type=""text"" id=""userInput"" /></div>
    </div>
    <div class=""row"">
        <div class=""col-2"">Message</div>
        <div class=""col-4""><input type=""text"" id=""messageInput"" /></div>
    </div>
    <div class=""row"">&nbsp;</div>
    <div class=""row"">
        <div class=""col-6"">
            <input type=""button"" id=""sendButton"" value=""Send Message"" />
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <hr />
    </div>
</div>
<div class=""row"">
    <div class=""col-6"">
        <ul id=""messagesList""></ul>
    </div>
</div>
<ul class=""list-group"">
");
#nullable restore
#line 34 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <span>");
#nullable restore
#line 36 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
        Write(item.ConnectionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n       <li class=\"list-group-item\" style=\"width:150px\"><span");
            BeginWriteAttribute("class", " class=\"", 935, "\"", 994, 1);
#nullable restore
#line 37 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
WriteAttributeValue("", 943, item.ConnectionId==null?"bg-offline":"bg-online", 943, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border:1px solid black;border-radius:50%;display:inline-block;width:15px;height:15px\"></span>");
#nullable restore
#line 37 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
                                                                                                                                                                                                                        Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 38 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\Chat-main\WebApplication1\WebApplication1\Views\Home\Chat.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n \n</ul>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab69d57dde4f46a330b7e8cdf3413d70cf1ed0a6803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
        connection.start();
        document.getElementById(""sendButton"").addEventListener(""click"", function () {
            let user = $(""#userInput"").val();
            let message = $(""#messageInput"").val();
            connection.invoke(""SendMessage"", user, message);       
        })
        connection.on(""RecieveMessage"", function (user, message, date) {
            var li = document.createElement(""li"");
            document.getElementById(""messagesList"").appendChild(li);
           
            li.textContent = `${user} says ${message}`;
        })
        connection.on(""connect"",function(id){
            $('#$id}').find(""span"").removeClass(""bg-offline"");
            $('#${id}').find(""span"").addClass(""bg-online"");
        })
        connection.on(""disconnect"",function(id){
            $('#${id}').find(""span"").removeClass(""bg-online"");
            $('#${id}').find(""span"").addClass(""bg-offline"");
");
                WriteLiteral("\n        })\n    </script>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
