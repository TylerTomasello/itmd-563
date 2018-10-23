using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj5_grad_tomasello
{
    public partial class CalcMortgage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OtherYears.Enabled = false;
            }
        }

        //If Other year duration is selected take the text from it
        protected void Duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Duration.SelectedValue.ToLower() == "Other".ToLower())
            {
                OtherYears.Enabled = true;

            }

            else
            {
                OtherYears.Enabled = false;
                OtherYears.Text = string.Empty;
            }
        }

        //When the Compute button is clicked
        protected void Compute_Click(object sender, EventArgs e)
        {
            string princ = PrincipleAmount.Text;
            string year = OtherYears.Text;
            string rate = DropDownList1.SelectedItem.Text;
            float years = 0;
            bool check = false;

            //Make sure the value is legitamte to use
            if (float.TryParse(princ, out float principle) == false)
            {
                Result.Text = $"Error: Please enter a Priciple Amount";
                check = true;
            }

            //Check which yearly duration is chosen
            if (Duration.SelectedIndex == 0)
            {
                years = 15;
            }
            else if (Duration.SelectedIndex == 1)
            {
                years = 30;
            }
            else if (Duration.SelectedIndex == 2)
            {
                //Check to make sure inputted year is legal
                if (float.TryParse(year, out years) == false)
                {
                    Result.Text = $"Error: Please enter a Loan Duration";
                    check = true;
                }
            }

            //Make sure user selects a rate
            if (float.TryParse(rate, out float Rate) == false)
            {
                Result.Text = $"Error: Please select an Interest Rate";
                check = true;
            }

            //Call the calculate function and display the monthly payments
            if (check == false)
            {
                double month = CalcMonthlyPayment(principle, years, Rate);
                string output = string.Format("Monthly Payment is {0:C}", month);
                Result.Text = output;


                //FileIOHelper fileIOHelper = new FileIOHelper();
                //IIOHelper fileIOHelper = new FileIOHelper(ServerPathHelper.GetPath("~/app_data/log.txt"));
                IIOHelper fileIOHelper = IOFactory.CreateIOEngine();
                //fileIOHelper.AddPrinc(principle);
                //fileIOHelper.Addyear(years);
                //fileIOHelper.Addrate(Rate);
                fileIOHelper.AddMortgages(output, principle, years, Rate);
            }
        }

        //Calculate the monthly payment of the principle, years, and rate
        public static double CalcMonthlyPayment(double principle, double years, double Rate)
        {
            double top = principle * Rate / 1200.00;
            double bottom = 1 - Math.Pow(1.00 + Rate / 1200.00, -12.00 * years);
            double monthly = top / bottom;
            return monthly;
        }
    }
}