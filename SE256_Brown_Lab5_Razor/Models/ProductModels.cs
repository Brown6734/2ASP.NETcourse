using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SE256_Brown_Lab5_Razor.Models
{
    public class ProductModels
    {
        [Required]

        public int Items_ID { get; set; }


        [Required, StringLength(255)]

        public String Items_Title { get; set; }

        [Required]

        public String Items_Desc { get; set; }

        [Required]
        [StringOptionsValidate(Allowed = new String[] {"Cat1", "Cat2", "Cat3", "Cat4"}, ErrorMessage = "Sorry.. category is invalid. Can only be: Cat1, Cat2, Cat3, Cat4")]

        public String Items_Category { get; set; }

        [Required, EmailAddress]
        public String ItemsEmail { get; set; }

        


        [Required]
        [Display(Name = "original date of manufacture for the product ")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future date entry not allowed")]

        public DateTime Items_Date { get; set; }

       

        public String Feedback { get; set; }

        //public int (at least 1)
        //public String (at least 2)
        //public DateTime (at least 1)
        //public bool
    }
}
