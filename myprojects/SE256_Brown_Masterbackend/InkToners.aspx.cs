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
            //int num = name.Next();
            //.Next() - returns a positive random integer
            //

            Random nameGet = new Random();

            int num = nameGet.Next(1, 5);

            //can update loop button text to the value of variable num

            //12345
            //67890
            //12121
            //34653
           

            if (stuff1.Text == "printer 1" || stuff1.Text == "printer1")
            {
                inkText.Text = "ink 1";
                tonerText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            if (stuff1.Text == "printer 2" || stuff1.Text == "printer2")
            {
                inkText.Text = "ink 2";
                tonerText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            if (stuff1.Text == "printer 3" || stuff1.Text == "printer3")
            {
                inkText.Text = "ink 3";
                tonerText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            if (stuff1.Text == "printer 4" || stuff1.Text == "printer4")
            {
                tonerText.Text = "toner 1";
                inkText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            if (stuff1.Text == "printer 5" || stuff1.Text == "printer5")
            {
                tonerText.Text = "toner 2";
                inkText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            if (stuff1.Text == "printer 6" || stuff1.Text == "printer6")
            {
                tonerText.Text = "toner 3";
                inkText.Text = "_";
                printerText.Text = stuff1.Text;
            }

            

        }
    }
}