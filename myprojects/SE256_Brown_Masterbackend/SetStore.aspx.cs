using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Brown_Masterbackend
{
    public partial class SetStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void inkPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InkToners.aspx");
        }

        protected void storeSearch_Click(object sender, EventArgs e)
        {
            //if the zip code is #
            //update text field

            //set int zip code = storeFind (textBox)

            int zipCode = Int32.Parse(storeFind.Text);

            //if zip code == 12345
            //67890
            //12121
            //34653

            if (zipCode == 12345)
            {
                //yourStore (textBox)
                yourStore.Text = "Fender, DE";
            }
            if (zipCode == 67890)
            {
                yourStore.Text = "Place, DS";
            }
            if (zipCode == 12121)
            {
                yourStore.Text = "Great, SD";
            }
            if (zipCode == 34653)
            {
                yourStore.Text = "Ting, DF";
            }


        }
    }
}