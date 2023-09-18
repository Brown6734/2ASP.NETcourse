using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_Brown_FinalProject.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_Brown_FinalProject.Pages
{
    public class EmployeeTrackModel : PageModel
    {
        [BindProperty]

        public Employee oneEmp { get; set; }

        private readonly IConfiguration _configuration;

        public EmployeeTrackModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
        }

        

        
    }
}
