using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_Brown_RazorActivity.Models;

namespace SE256_Brown_RazorActivity.Pages
{
    public class AddTicketModel : PageModel
    {
        [BindProperty]

        public TroubleTicketModelcs tTicket { get; set; }
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
                temp = Page();
            }
            return temp;
        }
    }
}
