using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Brown_Masterbackend
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void shoppingCartButton_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/ShoppingCart.aspx");
        }

        protected void inkPage(object sender, EventArgs e)
        {
            Response.Redirect("~/InkToners.aspx");
        }

        protected void SetStoreBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SetStore.aspx");
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

            //someidk
        }

        protected void updateCart_Click(object sender, EventArgs e)
        {
            Random items = new Random();

            int cart = items.Next(1, 4);

            if (cart == 1)
            {
                //update itemNum (and itemNum2) labels
                itemNum.Text = "1 Item";
                itemNum2.Text = "1 Item";
            }
            if (cart == 2)
            {
                itemNum.Text = "2 Items";
                itemNum2.Text = "2 Items";
            }
            if (cart == 3)
            {
                itemNum.Text = "3 Items";
                itemNum2.Text = "3 Items";
            }

        }
    }
}