#pragma checksum "C:\Users\Neslihan Ak\Documents\Visual Studio 2017\Projects\DieticianWebSite\DieticianWebSite\DieticianWebSite\Views\SignIn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b660dce96b22569224e030350ee32dc18c5390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SignIn_Index), @"mvc.1.0.view", @"/Views/SignIn/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SignIn/Index.cshtml", typeof(AspNetCore.Views_SignIn_Index))]
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
#line 1 "C:\Users\Neslihan Ak\Documents\Visual Studio 2017\Projects\DieticianWebSite\DieticianWebSite\DieticianWebSite\Views\_ViewImports.cshtml"
using DieticianWebSite;

#line default
#line hidden
#line 3 "C:\Users\Neslihan Ak\Documents\Visual Studio 2017\Projects\DieticianWebSite\DieticianWebSite\DieticianWebSite\Views\_ViewImports.cshtml"
using DieticianWebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b660dce96b22569224e030350ee32dc18c5390", @"/Views/SignIn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147f2fee9dc4bfa83749f3f8d2600acedcdf0a89", @"/Views/_ViewImports.cshtml")]
    public class Views_SignIn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DieticianWebSite.Models.Uye>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("my-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Neslihan Ak\Documents\Visual Studio 2017\Projects\DieticianWebSite\DieticianWebSite\DieticianWebSite\Views\SignIn\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 40, true);
            WriteLiteral("\r\n<center><h4>Uye olunuz</h4></center>\r\n");
            EndContext();
            BeginContext(2535, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2537, 3800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122b19a8cdbe4e2bbf2cdc0a1305a145", async() => {
                BeginContext(2572, 3758, true);
                WriteLiteral(@"
    <div class=""form-group row"">
        <label for=""full_name"" class=""col-md-4 col-form-label text-md-right"">İsim</label>
        <div class=""col-md-6"">
            <input type=""text"" id=""full_name"" class=""form-control"" name=""Adi"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""full_name"" class=""col-md-4 col-form-label text-md-right"">Soyisim</label>
        <div class=""col-md-6"">
            <input type=""text"" id=""full_name"" class=""form-control"" name=""Soyadi"">
        </div>
    </div>

    <div class=""form-group row"">
        <label for=""email_address"" class=""col-md-4 col-form-label text-md-right"">E-Mail Adresi</label>
        <div class=""col-md-6"">
            <input type=""text"" id=""email_address"" class=""form-control"" name=""email"">
        </div>
    </div>

    <div class=""form-group row"">
        <label for=""user_name"" class=""col-md-4 col-form-label text-md-right"">Kullanıcı Adı</label>
        <div class=""col-md-6"">
            <input type=""text"" i");
                WriteLiteral(@"d=""user_name"" class=""form-control"" name=""username"">
        </div>
    </div>


    <div class=""form-group row"">
        <label for=""present_address"" class=""col-md-4 col-form-label text-md-right"">Parola</label>
        <div class=""col-md-6"">
            <input type=""password"" id=""present_address"" class=""form-control"" name=""Parola"">
        </div>
    </div>

    <div class=""form-group row"">
        <label for=""permanent_address"" class=""col-md-4 col-form-label text-md-right"">Parola Tekrar</label>
        <div class=""col-md-6"">
            <input type=""password"" id=""permanent_address"" class=""form-control"" name=""ParolaTekrar"">
        </div>
    </div>

    <div class=""form-group row"">
        <label for=""nid_number"" class=""col-md-4 col-form-label text-md-right"">Cinsiyet</label>
        <div class=""col-md-6"">
            <input type=""radio"" id=""nid_number"" name=""CinsiyetKız"">Kız
            <input type=""radio"" id=""nid_number""  name=""CinsiyetErkek"">Erkek
        </div>
    </div>

    <");
                WriteLiteral(@"div class=""form-group row"">
        <label for=""nid_number"" class=""col-md-4 col-form-label text-md-right"">Doğum Tarihi</label>
        <div class=""col-md-6"">
            <input type=""date"" id=""nid_number"" class=""form-control"" name=""DogumTarihi"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""nid_number"" class=""col-md-4 col-form-label text-md-right"">Kilo</label>
        <div class=""col-md-6"">
            <input type=""number"" id=""nid_number"" class=""form-control"" name=""Kilo"">
        </div>
    </div>

    <div class=""form-group row"">
        <label for=""nid_number"" class=""col-md-4 col-form-label text-md-right"">Boy </label>
        <div class=""col-md-6"">
            <input type=""number"" id=""nid_number"" class=""form-control"" name=""Boy"">
        </div>
    </div>

    <div class=""col-md-6 offset-md-4"">
        <button type=""submit"" class=""btn btn-primary"" name=""submitButton"" value=""Kayit"">
            Kayıt
        </button>
        &nbsp;&nbsp;&nbsp;&nbsp;&nb");
                WriteLiteral(@"sp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <button type=""submit"" class=""btn btn-primary"" name=""submitButton"" value=""Danisman"">
            Online Diyet için devam et
        </button>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DieticianWebSite.Models.Uye> Html { get; private set; }
    }
}
#pragma warning restore 1591
