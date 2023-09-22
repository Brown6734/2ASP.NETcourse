using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SE256_Brown_FinalProject.Models
{
    public class Employee
    {

        //employee ID (for table use) (primary key)
        //different than the employee's actual number/ID

        [Required]
        public int Employee_ID { get; set; }

        //employee First Name
        [Required]
        public String Employee_FirstName { get; set; }

        //employee last name
        [Required]
        public String Employee_LastName { get; set; }

        //employee age
        [Required]
        public int Employee_Age { get; set; }

        //employee's department
        [Required]
        [StringOptionsValidate(Allowed = new String[] { "Tech", "Office Supplies", "Printing", "Furniture" }, ErrorMessage = "Sorry.... The department value you entered is invalid. Valid Department Values are: Tech, Office Supplies, Printing, Furniture")]

        public String Employee_Department { get; set; }

        //employee contact email
        [Required, EmailAddress]
        public String Employee_Email { get; set; }

        //employee contact phone number
        [Required, Phone]
        public String Employee_Phone { get; set; }

        //employee address
        [Required, StringLength(255)]

        public String Employee_Address { get; set; }

        //employee ID/number

        [Required]
        public int Employee_Number { get; set; }

        //employee total amount of hours worked in one week
        [Required]
        public Double Employee_WeekHours { get; set; }

        //employee wage - double
        [Required]
        public Double Employee_Wage { get; set; }

        //employee start shift time - date time
        //what would be the valiation needed, if any?
        //can not be future date
        //employee start shift time has to be past date

        [Required]
        [Display(Name = "Employee Start Shift Date and Time")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future Dates not allowed. Please enter a past date for Employee Start Shift Date and Time")]

        public DateTime Employee_StartShift { get; set; }

        //employee end shift
        //can not be a future date

        [Required]
        [Display(Name = "Employee End Shift Date and Time")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future Dates not allowed. Please enter a past date for Employee End Shift Date and Time")]

        public DateTime Employee_EndShift { get; set; }

        //employee lunch out
        //can not be a future date

        [Required]
        [Display(Name = "Employee Lunch Out date and time")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future Dates not allowed. Please enter a past date for Employee Lunch Out date and time")]

        public DateTime Employee_LunchOut { get; set; }

        //employee lunch in
        //can not be a future date

        [Required]
        [Display(Name = "Employee Lunch In date and time")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future Dates not allowed. Please enter a past date for Employee Lunch In date and time")]

        public DateTime Employee_LunchIn { get; set; }

        //is employee currently working here?
        //boolean, required

       // [Required]
       // public bool Active { get; set; }

        //feedback string
        public String Feedback { get; set; }

        //what do we want 
        //employee tracking system

        //employee contact email
        //employee contact phone number

        //employee's address

        //employee ID/number
        //employee hours worked in one day

        //employee hours worked in one week

        //employee wage?

        //employee start shift

        //employee end shift

        //employee lunch out

        //employee lunch in

        //is employee currently working here?



    }
}
