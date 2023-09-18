using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;



using SE256_Brown_FinalProject.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_Brown_FinalProject.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public EmployeeDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Employee employee)
        {
           using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "Insert Into EmployeeInfo (Employee_FirstName, Employee_LastName, Employee_Age, Employee_Department, Employee_Email, Employee_Phone, Employee_Address, Employee_Number, Employee_WeekHours, Employee_Wage, Employee_StartShift, Employee_EndShift, Employee_LunchOut, Employee_LunchIn VALUES(@Employee_FirstName, @Employee_LastName, @Employee_Age, @Employee_Department, @Employee_Email, @Employee_Phone, @Employee_Address, @Employee_Number, @Employee_WeekHours, @Employee_Wage, @Employee_StartShift, @Employee_EndShift, @Employee_LunchOut, @Employee_LunchIn);";

                employee.Feedback = "";

                try
                {
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Employee_FirstName", employee.Employee_FirstName);
                        command.Parameters.AddWithValue("@Employee_LastName", employee.Employee_LastName);
                        command.Parameters.AddWithValue("@Employee_Age", employee.Employee_Age);
                    }
                }
            }
        }

    }
}
