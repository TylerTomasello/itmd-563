// Tyler Tomasello
// ITMD 563
// Project 1
// 9/17/18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Project 1
namespace ITMD563_Project1
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        //Function called when the Add button is pressed and adds 
        //the two numbers that were in the text boxes and converts to ints.
        protected void BtnAdd_Click1(object sender, EventArgs e)
        {
            int oper1 = Convert.ToInt32(Op1.Text);
            int oper2 = Convert.ToInt32(Op2.Text);

            int result = oper1 + oper2;
            Result.Text = Convert.ToString(result);
        }

        //Function called when the Subtract button is pressed and subtracts 
        //the two numbers that were in the text boxes and converts to ints.
        protected void BtnSub_Click(object sender, EventArgs e)
        {
            int oper1 = Convert.ToInt32(Op1.Text);
            int oper2 = Convert.ToInt32(Op2.Text);

            int result = oper1 - oper2;
            Result.Text = Convert.ToString(result);
        }

        //Function called when the Multiply button is pressed and multiplies
        //the two numbers that were in the text boxes and converts to ints.
        protected void BtnMult_Click(object sender, EventArgs e)
        {
            int oper1 = Convert.ToInt32(Op1.Text);
            int oper2 = Convert.ToInt32(Op2.Text);

            int result = oper1 * oper2;
            Result.Text = Convert.ToString(result);
        }

        //Function called when the Divide button is pressed and divides
        //the two numbers that were in the text boxes.
        //Also, it converts them to double to make the value more accurate.
        protected void BtnDivide_Click(object sender, EventArgs e)
        {
            double oper1 = Convert.ToDouble(Op1.Text);
            double oper2 = Convert.ToDouble(Op2.Text);

            double result = oper1 / oper2;
            Result.Text = Convert.ToString(result);
        }
    }
}