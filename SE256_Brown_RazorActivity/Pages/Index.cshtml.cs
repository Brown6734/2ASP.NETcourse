using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SE256_Brown_RazorActivity.Models;
using Microsoft.Extensions.Configuration;


namespace SE256_Brown_RazorActivity.Pages
{
    public class IndexModel : PageModel
    {
        //BindProperty connects property with a Post
        //adding the SupportsGet allows data to come via URL
        [BindProperty(SupportsGet = true)]

        public String FName { get; set; }

        private readonly IConfiguration _configuration;

        TroubleTicketDataAccessLayer factory;
        public List<TroubleTicketModelcs> tix { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new TroubleTicketDataAccessLayer(_configuration);
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }

            tix = factory.GetActiveRecords().ToList();
        }
    }
}
