using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using SE256_Brown_Masterbackend.App_Code;

namespace SE256_Brown_Masterbackend.Backend
{
    public partial class ProductMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //good...can stay here
            }
            else
            {
                Response.Redirect("~/Backend/Default.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Product temp = new Product();

            //fields for Products3 table
            //Products3_ID - int
            //ProductName
            //ProductManu
            //ProductPrice
            //Available
            //ProductDesc
            //ManuDate
            //QuantOnHand-
            //txtProdName
            //txtProdManu 
            //searchProducts - name and manu

            DataSet ds = temp.SearchProducts3_DS(txtName.Text, txtManu.Text);

            dgResults.DataSource = ds;
            dgResults.DataMember = ds.Tables[0].TableName;
            dgResults.DataBind();

            SqlDataReader dr = null;

            dr = temp.SearchProducts3_DR(txtName.Text, txtManu.Text);

            rptSearch.DataSource = dr;
            rptSearch.DataBind();

            dr = temp.SearchProducts3_DR(txtName.Text, txtManu.Text);

            litResults.Text = "<table>";

            litResults.Text += "<th>Product Name</th>" +
                "<th>Product Manu </th>" +
                "<th>Product Price </th" +
                "<th>Edit Link </th>";

            while (dr.Read())
            {
                litResults.Text += "<tr>" +
                    "<td>" + dr["ProductName"].ToString() +
                    "</td>" +
                    "<td>" + dr["ProductManu"].ToString() +
                    "</td>" +
                    "<td>" + dr["ProductPrice"].ToString() +
                    "</td>" +
                    "<td>" + "<a href='Product2.aspx?Products3_ID=" + dr["Products3_ID"].ToString() +
                    "'>Edit</a></td>" +
                    "</tr>";
            }

            litResults.Text += "</table>";

        }
    }
}