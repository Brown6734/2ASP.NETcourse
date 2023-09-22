using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SE256_Brown_FinalProject.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_Brown_FinalProject.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]

        public String EmpFName { get; set; }

        private readonly IConfiguration _configuration;

        EmployeeDataAccessLayer factory;

        public List<Employee> emp1 { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new EmployeeDataAccessLayer(_configuration);

        }

        //public IndexModel(ILogger<IndexModel> logger)
       // {
     //       _logger = logger;
     //  }

        public void OnGet()
        {
            emp1 = factory.GetActiveRecords().ToList();

        }
    }
}
