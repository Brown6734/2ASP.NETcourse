#pragma checksum "C:\Users\Brown\source\repos\2ASP.NETcourse\SE256_Brown_Lab5_Razor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc224f6b7c9f0d60bc53aaa6638917a121aae8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SE256_Brown_Lab5_Razor.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SE256_Brown_Lab5_Razor.Pages.Pages_Index), null)]
namespace SE256_Brown_Lab5_Razor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Brown\source\repos\2ASP.NETcourse\SE256_Brown_Lab5_Razor\Pages\_ViewImports.cshtml"
using SE256_Brown_Lab5_Razor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc224f6b7c9f0d60bc53aaa6638917a121aae8e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b8a26ec696e2c74bb8d7f96441fe5b486518b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Brown\source\repos\2ASP.NETcourse\SE256_Brown_Lab5_Razor\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 63, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
            EndContext();
            BeginContext(135, 15, false);
#line 8 "C:\Users\Brown\source\repos\2ASP.NETcourse\SE256_Brown_Lab5_Razor\Pages\Index.cshtml"
                             Write(Model.ProdTitle);

#line default
#line hidden
            EndContext();
            BeginContext(150, 3484, true);
            WriteLiteral(@"</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<!--dd
    
    _Layout.cshtml

    Layout allows us to add a common layout and C# functionality for each of our pages in our site

    add (for lab, change it up)

    <li class='nav-item'>
        <a class='nav-link text-[color]' asp-area="""" asp-page=""/[pageName]"">words </a>

    </li>

    <li class=""nav-item"">
        <a class=""nav-link text-[color]"" asp-area="""" asp-page""/loginpage"">Login</a>
    </li>


    Index.cshtml :

    add

    atS page
    atS model IndexModel
    atS{
        ViewData[""Title""] = ""Home Page"";
    }

    Index.cshtml.cs part:

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    namespace title.Pages{
    
        public class IndexModel: Page Model{
            [BindProperty(SupportsGet = true)]

            public String value/Name {get; set;}
            
    
            p");
            WriteLiteral(@"ublic void OnGet(){
            }


    
        }
    
    }

    
    add to Index.cshtml:

    <h1 class=""display-4"">Welcome atS Model.value</h1>

    add to Index.cshtml.cs:

    public void OnGet(){
        if(string.IsNullOrWhiteSpace(stringValue)){
            
            stringValue = ""word"";
        
        }
    
    
    }


    add to Pages:

    Pages, add, New Folder

    Name the new subfolder ""Admin""

    Lab/Overall name, Add, New Folder

    Name this folder ""Models""

    Models, Add, Class

    Class name = something pertaining to the lab (for now - examples)

    add to examples.cs:

    namespace ...{
        

        public class name{
            
            public int value {get; set;}

            public string value {get; set;}

            public DateTime value {get; set;}

            public string value {get; set;}

            public bool value {get; set;}

    
        }
    
    
    }

    Pages, add, Razor Pa");
            WriteLiteral(@"ge

    Razor page v1.0.0.0

    Name - something pertaining to lab (for now it will be AddExample)

    AddExample.cshtml:

    atS page
    atS model pageName.Pages.addNameModel
    atS{
        ViewData[""Title""] = ""AddExample"";
    }


    AddExample.cshtml.cs:

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using labName.Models;

    public class nameModel: PageModel{
        
        [BindProperty]

        public nameModel modelValue {get; set;}
    
    
    }

    AddExample.cshtml:

    <form method=""post"">

        <input type=""text"" asp-for=""modelValue.prop"" placeholder=""word"">
    do as many inputs as needed

        <button type=""submit"">Submit</button>

    </form>


    AddExample.cshtml.cs:

    public IActionResult OnPost(){
    
        IActionResult temp;

        if(ModelState.IsValid == false){
        
            temp = Page();
        
        }
        else{
        
            temp = Red");
            WriteLiteral(@"irectToPage("" /Index"");
        
        }
        
        return temp;
    
    }

    modify _Layout.cshtml:

    asp-Page=""/AddExample"">Add Example </a>


    AddExample.cshtml:

    atS{
        if(Model.value is null == false){
            <h1>Results</h1>

            <p>AtS Model.value.prop</p>
            <p>AtS Model.value.prop</p>

    
        }
    
    }

    
    -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591