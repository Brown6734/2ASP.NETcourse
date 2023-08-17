using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Brown_Masterbackend
{
    public partial class helpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void helpButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/helpPage.aspx");
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Backend/Default.aspx");
        }

        protected void shoppingCartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShoppingCart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ink page
            Response.Redirect("~/InkToners.aspx");
        }

        protected void SetStoreBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SetStore.aspx");
        }
    }
}