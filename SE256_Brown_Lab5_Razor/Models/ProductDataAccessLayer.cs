using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SE256_Brown_Lab5_Razor.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_Brown_Lab5_Razor.Models
{
    public class ProductDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public ProductDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(ProductModels product)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT Into FunProducts (Product_Title, Product_Desc, Product_Category, ProdEmail, Manu_Date) VALUES (@Product_Title, @Product_Desc, @Product_Category, @ProdEmail, @Manu_Date);";

                product.Feedback = "";


                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Product_Title", product.Product_Title);
                        command.Parameters.AddWithValue("@Product_Desc", product.Product_Desc);
                        command.Parameters.AddWithValue("@Product_Category", product.Product_Category);
                        command.Parameters.AddWithValue("@ProdEmail", product.ProdEmail);
                        command.Parameters.AddWithValue("@Manu_Date", DateTime.Now);
                       

                        connection.Open();

                        product.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";

                        connection.Close();
                    }
                }

                catch (Exception err)
                {
                    product.Feedback = "ERROR: " + err.Message;
                }

            }

            
        }
    }
}
