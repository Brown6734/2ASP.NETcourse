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

        public int Product_ID { get; set; }

        [Required, StringLength(255)]

        public String Product_Title { get; set; }

        [Required]

        public String Product_Desc { get; set; }

        [Required]

        public String Product_Category { get; set; }

        public DateTime Manu_Date { get; set; }

        public bool Active { get; set; }

        //public int (at least 1)
        //public String (at least 2)
        //public DateTime (at least 1)
        //public bool
    }
}
