using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_Brown_Lab5_Razor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]

        public String ProdTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(ProdTitle))
            {
                ProdTitle = "Title!";
            }
        }
    }
}
