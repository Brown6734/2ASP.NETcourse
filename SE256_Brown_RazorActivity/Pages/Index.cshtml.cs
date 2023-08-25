using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_Brown_RazorActivity.Pages
{
    public class IndexModel : PageModel
    {
        //BindProperty connects property with a Post
        //adding the SupportsGet allows data to come via URL
        [BindProperty(SupportsGet = true)]

        public String FName { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }
        }
    }
}
