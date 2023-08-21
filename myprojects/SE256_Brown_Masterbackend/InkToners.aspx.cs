using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Brown_Masterbackend
{
    public partial class InkToners : System.Web.UI.Page
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

        }

        protected void SetStoreBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SetStore.aspx");
        }

        protected void loopButton_Click(object sender, EventArgs e)
        {
            //this will determine what ink or toner the user needs for their machine/printer
            //will include made up ink/toner products
            //and made up printer products

            //string variable = "ink"

            //c sharp random:
            //Random name = new Random();
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //





        }
    }
}