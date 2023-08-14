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
    public partial class Products2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //good stay here
            }
            else
            {
                Response.Redirect("~/Backend/Default.aspx");
            }

            string strProducts3_ID = "";
            int intProducts3_ID = 0;

            if ((!IsPostBack) && Request.QueryString["Products3_ID"] != null)
            {
                btnAdd.Visible = false;
                btnAdd.Enabled = false;

                strProducts3_ID = Request.QueryString["Products3_ID"].ToString();
                lblProduct_ID.Text = strProducts3_ID;

                intProducts3_ID = Convert.ToInt32(strProducts3_ID);

                Product temp = new Product();

                SqlDataReader dr = temp.FindOneProduct(intProducts3_ID);

                while (dr.Read())
                {
                    //fields for Products3 table
                    //Products3_ID - int
                    //ProductName
                    //ProductManu
                    //ProductPrice
                    //Available
                    //ProductDesc
                    //ManuDate
                    //QuantOnHand
                    //txtProdName
                    //txtProdManu 
                    //searchProducts - name and manu

                    txtProdName.Text = dr["ProductName"].ToString();
                    txtProdManu.Text = dr["ProductManu"].ToString();
                    txtProdPrice.Text = dr["ProductPrice"].ToString();
                    checkAvaiable.Checked = bool.Parse(dr["Available"].ToString());
                    txtProdDescrip.Text = dr["ProductDesc"].ToString();
                    calManuDate.VisibleDate = DateTime.Parse(dr["ManuDate"].ToString()).Date;
                    calManuDate.SelectedDate = DateTime.Parse(dr["ManuDate"].ToString()).Date;
                    txtQuantOnHand.Text = dr["QuantOnHand"].ToString();
                }

            }
            if (Request.QueryString["Products3_ID"] == null)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        protected void btnpAdd_Click(object sender, EventArgs e)
        {
            Product temp = new Product();

            //temp.thing = txtthing.text;

            //ProductName
            //ProductManu
            //ProductPrice - double
            //Available - bool
            //ProductDesc
            //ManuDate - datetime
            //QuantOnHand - double

            temp.ProductName = lblProduct_ID.Text;
            temp.ProductManu = txtProdManu.Text;
            temp.ProductPrice = double.Parse(txtProdPrice.Text);
            temp.Available = checkAvaiable.Checked;
            temp.ProductDesc = txtProdDescrip.Text;
            temp.ManuDate = calManuDate.SelectedDate;
            temp.QuantOnHand = double.Parse(txtQuantOnHand.Text);

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.AddARecord();
            }

            //if temp.Feedback.contains ERROR
            //show error

            //else
            //set lblFeedback.txt equal to add a record function/thing

            
            

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
            //QuantOnHand

            //txtProdName
            //txtProdManu
            //txtProdPrice
            //checkAvaiable
            //txtProdDescrip
            //calManuDate
            //txtQuantOnHand

            temp.Products3_ID = Int32.Parse(lblProduct_ID.Text);
            temp.ProductName = txtProdName.Text;
            temp.ProductManu = txtProdManu.Text;
            temp.ProductPrice = Int32.Parse(txtProdPrice.Text);
            temp.Available = checkAvaiable.Checked;
            temp.ProductDesc = txtProdDescrip.Text;
            temp.ManuDate = calManuDate.SelectedDate;
            temp.QuantOnHand = Double.Parse(txtQuantOnHand.Text);

            if (temp.Feedback.Contains("ERROR: "))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.UpdateARecord();
            }
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 intProducts3_ID = Convert.ToInt32(lblProduct_ID.Text);

            Product temp = new Product();

            lblFeedback.Text = temp.DeleteOneProduct(intProducts3_ID);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Backend/ControlPanel");
        }
    }
}