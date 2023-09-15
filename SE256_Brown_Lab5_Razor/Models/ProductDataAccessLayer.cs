using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SE256_Brown_Lab5_Razor.Models;
using SE256_Brown_Lab5_Razor.Pages;

//using Microsoft.Extensions.Configuration;

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
            //product.Feedback = "happy days in the sky";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql1 = "INSERT Into ItemsTable (Items_Title, Items_Desc, Items_Category, ItemsEmail, Items_Date) VALUES (@Items_Title, @Items_Desc, @Items_Category, @ItemsEmail, @Items_Date);";

                //product.Feedback = "";


                try
                {
                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Items_Title", product.Items_Title);
                        command.Parameters.AddWithValue("@Items_Desc", product.Items_Desc);
                        command.Parameters.AddWithValue("@Items_Category", product.Items_Category);
                        command.Parameters.AddWithValue("@ItemsEmail", product.ItemsEmail);
                        command.Parameters.AddWithValue("@Items_Date", DateTime.Now);
                       

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


        public IEnumerable<OneAddProductModel> GetActiveRecords()
        {
            List<OneAddProductModel> lstItem = new List<OneAddProductModel>();

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM ItemsTable ORDER BY Items_Date;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        OneAddProductModel items = new OneAddProductModel(_configuration);

                        items.aProduct.Items_ID = Convert.ToInt32(rdr["Items_ID"]);
                        items.aProduct.Items_Title = rdr["Items_Title"].ToString();
                        items.aProduct.Items_Desc = rdr["Items_Desc"].ToString();
                        items.aProduct.Items_Category = rdr["Items_Category"].ToString();
                        items.aProduct.ItemsEmail = rdr["ItemsEmail"].ToString();
                        items.aProduct.Items_Date = DateTime.Parse(rdr["Items_Date"].ToString());

                        lstItem.Add(items);

                    }
                    con.Close();
                }
            }
            catch(Exception err)
            {
                //nothing
            }
            return lstItem;

        }


    }


}
