using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_Brown_RazorActivity.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_Brown_RazorActivity.Pages
{
    public class AddTicketModel : PageModel
    {
        [BindProperty]

        public TroubleTicketModelcs tTicket { get; set; }

        private readonly IConfiguration _configuration;

        public AddTicketModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if(tTicket is null == false)
                {
                    TroubleTicketDataAccessLayer factory = new TroubleTicketDataAccessLayer(_configuration);

                    factory.Create(tTicket);

                }

                temp = Page();
            }
            return temp;
        }
    }
}
