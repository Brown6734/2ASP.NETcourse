using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SE256_Brown_Lab5_Razor.Models;
using Microsoft.Extensions.Configuration;


namespace SE256_Brown_Lab5_Razor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]

        public String ProdTitle { get; set; }

        private readonly IConfiguration _configuration;

        ProductDataAccessLayer factory;
        public List<OneAddProductModel> item1 { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new ProductDataAccessLayer(_configuration);
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(ProdTitle))
            {
                ProdTitle = "Title!";
            }

            item1 = factory.GetActiveRecords().ToList();
        }
    }
}
