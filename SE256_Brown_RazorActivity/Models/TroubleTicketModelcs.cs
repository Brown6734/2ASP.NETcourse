using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SE256_Brown_RazorActivity.Models
{
    public class TroubleTicketModelcs
    {
        [Required]
        public int Ticket_ID { get; set; }

        [Required, StringLength(255)]
        public String Ticket_Title { get; set; }

        [Required]
        public String Ticket_Desc { get; set; }

        [Required]
        
        [StringOptionsValidate(Allowed = new String[] { "Monitor", "Computer", "Printer", "Software Install", "Software Upgrade", "Configuration", "Internet" }, ErrorMessage = "Sorry...Category is invalid. Categories: Monitor, Computer, Printer, Software Install, Software Upgrade, Configuration, Internet")]


        public String Category { get; set; }


        [Required, EmailAddress]
        public String Reporting_Email { get; set; }


        [Required]
        [Display(Name = "Original date of the problem.")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future data entry not allowed")]

        public DateTime Orig_Date { get; set; }


        [Required]
        [Display(Name = "Date of solutions/closure")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]


        public DateTime Close_Date { get; set; }

        public String Responder_Notes { get; set; }


        [EmailAddress]

        public String Responder_Email { get; set; }


        [Required]
        public bool Active { get; set; }

        public String Feedback { get; set; }
    }
}
