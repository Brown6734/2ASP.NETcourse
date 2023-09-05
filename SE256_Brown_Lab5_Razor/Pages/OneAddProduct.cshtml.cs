using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_Brown_Lab5_Razor.Models;

namespace SE256_Brown_Lab5_Razor.Pages
{
    public class OneAddProductModel : PageModel
    {
        [BindProperty]

        public ProductModels aProduct { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            if(ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                temp = Page();
            }

            return temp;

        }

    }
}
