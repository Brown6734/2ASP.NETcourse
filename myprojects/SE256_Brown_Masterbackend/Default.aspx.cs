﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Brown_Masterbackend
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        

       
        protected void shopdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/InkToners.aspx");
        }

        protected void shopdrop_TextChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/InkToners.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/SetStore.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void helpButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/helpPage.aspx");
        }

        
    }
}