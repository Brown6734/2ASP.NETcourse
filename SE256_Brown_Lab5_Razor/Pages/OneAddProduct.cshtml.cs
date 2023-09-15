using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_Brown_Lab5_Razor.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_Brown_Lab5_Razor.Pages
{
    public class OneAddProductModel : PageModel
    {
        [BindProperty]

        public ProductModels aProduct { get; set; }


        private readonly IConfiguration _configuration;

        public OneAddProductModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

    public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //aProduct.Feedback = "1 Record Added";

            IActionResult temp;

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if(aProduct is null == false)
                {
                    

                    ProductDataAccessLayer factory = new ProductDataAccessLayer(_configuration);

                    factory.Create(aProduct);
                }
                temp = Page();
            }

            return temp;

        }

    }
}
