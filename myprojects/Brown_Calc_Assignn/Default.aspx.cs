using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Brown_Calc_Assignn
{
    public partial class Default : System.Web.UI.Page
    {
        string strNum1;
        string strOperand;
        double result;
        double memory;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //concatenate a 1 here in the display
            txtLCD.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            //concatenate a 2 here in the display
            txtLCD.Text += "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            //concatenate a 3 here in the display
            txtLCD.Text += "3";
        }

        protected void btnNumeric_Click(object sender, EventArgs e)
        {
            //concatenate a number from the button's text property here in the display
            Button tempButton = (Button)sender;
            txtLCD.Text += tempButton.Text;

            //double Num1 = Double.Parse(Session["Num1"].ToString());
            //memory += Double.Parse(tempButton.Text);
            //memory += Double.Parse(Session["Num1"].ToString());
        }

        protected void btnOperations_Click(object sender, EventArgs e)
        {
            //have one function for all four math operations
            Button tempButton = (Button)sender;
            //lblOperations.Text += tempButton.Text;
            //put the math operation into the lcd ?? into memory??

            //if the user clicks operation button, store it to memory? 

            Session["Num1"] = txtLCD.Text;

            Session["Operand"] = tempButton.Text;

            txtLCD.Text = "";

            //store the letter M to memory label
            lblMemory.Text = "M";
            
            //store the math operation to the operation label
            lblOperations.Text = strOperand;




        }

        /*
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            //store the value in the LCD
            Session["Num1"] = txtLCD.Text;

            //store the operand
            Session["Operand"] = "+";

            //clear the screen
            txtLCD.Text = "";

            //make memory label say M
            lblMemory.Text = "M";

        }
        */

        

        protected void btn4_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn5_Click(object sender, EventArgs e)
        {

        }

        /*
        protected void btnMult_Click(object sender, EventArgs e)
        {
            //need two values for multiplication

            //store the value in the LCD
            Session["Num1"] = txtLCD.Text;

            //store the operand
            Session["Operand"] = "*";

            //clear the screen
            txtLCD.Text = "";

            //make memory label say M
            lblMemory.Text = "M";
        }
        */



        /*
        protected void btnSub_Click(object sender, EventArgs e)
        {
            //store value in the LCD
            Session["Num1"] = txtLCD.Text;

            //store the operand
            Session["Operand"] = "-";

            //clear the screen
            txtLCD.Text = "";

            //make memory label say M
            lblMemory.Text = "M";
        }
        */



        /*
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            //store value in the LCD
            Session["Num1"] = txtLCD.Text;

            //store the operand ÷
            //alt 0247 ÷ or alt 246 ÷
            Session["Operand"] = "÷";

            //clear the screen
            txtLCD.Text = "";

            //make memory label say M
            lblMemory.Text = "M";
        }
        */

        protected void btnDecimal_Click(object sender, EventArgs e)
        {
            //to make decimal button work
            Button tempButton = (Button)sender;
            txtLCD.Text += tempButton.Text;
            //memory += Double.Parse(tempButton.Text);
            //memory += Double.Parse(Session["Num1"].ToString());
        }

        protected void btnEquals_Click(object sender, EventArgs e)
        {
            //txtLCD.Text = "";
            double Num2 = Double.Parse(txtLCD.Text);  //get the #s from txtbox and session
            double Num1 = Double.Parse(Session["Num1"].ToString());

            strOperand = Session["Operand"].ToString();   //store operand from session into local var

            if (strOperand == "+")    //perform appropriate math
            {
                result = Num1 + Num2;
            }
            if (strOperand == "*")
            {
                result = Num1 * Num2;
            }

            if (strOperand == "-")
            {
                result = Num1 - Num2;
            }

            if (strOperand == "÷")
            {
                result = Num1 / Num2;
            }

            //lbl operations; change text value to the value of strOperand
            lblOperations.Text = strOperand;

            txtLCD.Text = result.ToString();
            //output result

        }


        //protected void btnNotThere_Click(object sender, EventArgs e)
        //{
          //  btnNotThere.Text = "##";
        //}

        protected void btnMemoryStore_Click(object sender, EventArgs e)
        {
            //store memory into a memory variable
            //
            
            //session Num1 needs to be defined first - so that memory variable will work
            Session["Num1"] = txtLCD.Text;

            //set memory variable = to the value of session num 1 (as a double)
            memory += Double.Parse(Session["Num1"].ToString());

            //clear the lcd screen - so it looks nice/neat
            txtLCD.Text = "";

            //add the memory value to the lcd screen
            txtLCD.Text += memory.ToString();

        }

        protected void btnMemoryRestore_Click(object sender, EventArgs e)
        {
            //recall a piece of stored memory
            
            //first clear the lcd screen - so the next steps appear cleaner/nice
            txtLCD.Text = "";

            //set memory variable = to the value of session num 1 (as a double)
            memory += Double.Parse(Session["Num1"].ToString());

            //make lcd screen equal to the value of memory
            txtLCD.Text = memory.ToString();



        }

        protected void btnMemoryClear_Click(object sender, EventArgs e)
        {
            //clear data in memory
            
            //set memory label to CLEAR
            lblMemory.Text = "CLEAR";

            //set memory to 0
            //I don't want to set memory to NULL or undefined
            memory = 0;

            //make lcd screen equal to value of memory
            txtLCD.Text = memory.ToString();
        }
    }
}