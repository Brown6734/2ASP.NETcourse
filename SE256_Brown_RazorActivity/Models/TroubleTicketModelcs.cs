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
        
        public String Category { get; set; }

        public String Reporting_Email { get; set; }

        public DateTime Orig_Date { get; set; }

        public DateTime Close_Date { get; set; }

        public String Responder_Notes { get; set; }

        public String Responder_Email { get; set; }

        public bool Active { get; set; }
    }
}
