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
                string sql = "INSERT Into EmployeeInfo (Employee_ID, Employee_FirstName, Employee_LastName, Employee_Age, Employee_Department, Employee_Email, Employee_Phone, Employee_Address, Employee_Number, Employee_WeekHours, Employee_Wage, Employee_StartShift, Employee_EndShift, Employee_LunchOut, Employee_LunchIn) VALUES(@Employee_ID, @Employee_FirstName, @Employee_LastName, @Employee_Age, @Employee_Department, @Employee_Email, @Employee_Phone, @Employee_Address, @Employee_Number, @Employee_WeekHours, @Employee_Wage, @Employee_StartShift, @Employee_EndShift, @Employee_LunchOut, @Employee_LunchIn);";

                employee.Feedback = "";

                try
                {
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@Employee_ID", employee.Employee_ID);
                        command.Parameters.AddWithValue("@Employee_FirstName", employee.Employee_FirstName);
                        command.Parameters.AddWithValue("@Employee_LastName", employee.Employee_LastName);
                        command.Parameters.AddWithValue("@Employee_Age", employee.Employee_Age);
                        command.Parameters.AddWithValue("@Employee_Department", employee.Employee_Department);
                        command.Parameters.AddWithValue("@Employee_Email", employee.Employee_Email);
                        command.Parameters.AddWithValue("@Employee_Phone", employee.Employee_Phone);
                        command.Parameters.AddWithValue("@Employee_Address", employee.Employee_Address);
                        command.Parameters.AddWithValue("@Employee_Number", employee.Employee_Number);
                        command.Parameters.AddWithValue("@Employee_WeekHours", employee.Employee_WeekHours);
                        command.Parameters.AddWithValue("@Employee_Wage", employee.Employee_Wage);
                        command.Parameters.AddWithValue("@Employee_StartShift", employee.Employee_StartShift);
                        command.Parameters.AddWithValue("@Employee_EndShift", employee.Employee_EndShift);
                        command.Parameters.AddWithValue("@Employee_LunchOut", employee.Employee_LunchOut);
                        command.Parameters.AddWithValue("@Employee_LunchIn", employee.Employee_LunchIn);

                        connection.Open();

                        employee.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";

                        connection.Close();
                    }
                }
                catch (Exception err)
                {
                    employee.Feedback = "ERROR: " + err.Message;
                }
            }
        }

        public IEnumerable<Employee> GetActiveRecords()
        {
            List<Employee> listEmp = new List<Employee>();

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM EmployeeInfo ORDER BY Employee_LastName;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Employee employee = new Employee();

                        employee.Employee_ID = Convert.ToInt32(rdr["Employee_ID"]);
                        employee.Employee_FirstName = rdr["Employee_FirstName"].ToString();
                        employee.Employee_LastName = rdr["Employee_LastName"].ToString();
                        //Employee_Age, int
                        employee.Employee_Age = Convert.ToInt32(rdr["Employee_Age"]);
                        employee.Employee_Department = rdr["Employee_Department"].ToString();
                        employee.Employee_Email = rdr["Employee_Email"].ToString();
                        //Employee_Phone, int
                        employee.Employee_Phone = rdr["Employee_Phone"].ToString();
                        employee.Employee_Address = rdr["Employee_Address"].ToString();
                        //Employee_Number, int
                        employee.Employee_Number = Convert.ToInt32(rdr["Employee_Number"]);
                        //Employee_WeekHours, double
                        employee.Employee_WeekHours = Convert.ToDouble(rdr["Employee_WeekHours"]);
                        //Employee_Wage, double
                        employee.Employee_Wage = Convert.ToDouble(rdr["Employee_Wage"]);
                        //Employee_StartShift
                        employee.Employee_StartShift = DateTime.Parse(rdr["Employee_StartShift"].ToString());
                        //Employee_EndShift
                        employee.Employee_EndShift = DateTime.Parse(rdr["Employee_EndShift"].ToString());
                        //Employee_LunchOut
                        employee.Employee_LunchOut = DateTime.Parse(rdr["Employee_LunchOut"].ToString());
                        //Employee_LunchIn
                        employee.Employee_LunchIn = DateTime.Parse(rdr["Employee_LunchIn"].ToString());

                        listEmp.Add(employee);

                    }
                    con.Close();
                }
            }
            catch (Exception err)
            {
                //nothing for now
            }
            return listEmp;
        }

    }
}
