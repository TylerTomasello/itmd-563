using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porj4_Tomasello
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

        protected void Compute_Click(object sender, EventArgs e)
        {
            string princ = PrincipleAmount.Text;
            string year = OtherYears.Text;
            string rate = DropDownList1.SelectedItem.Text;
            double years = 0;
            bool check = false;

            if (double.TryParse(princ, out double principle) == false)
            {
                Result.Text = $"Error: Please enter a Priciple Amount";
                check = true;
            }

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
                if (double.TryParse(year, out years) == false)
                {
                    Result.Text = $"Error: Please enter a Loan Duration";
                    check = true;
                }
            }

            if (double.TryParse(rate, out double Rate) == false)
            {
                Result.Text = $"Error: Please select an Interest Rate";
                check = true;
            }

            if (check == false)
            {
                double month = CalcMonthlyPayment(principle, years, Rate);
                string output = string.Format("Monthly Payment is {0:C}", month);
                Result.Text = output;

                FileIOHelper fileIOHelper = new FileIOHelper();
                fileIOHelper.AddMortgages(output);
            }
        }

        public static double CalcMonthlyPayment(double principle, double years, double Rate)
        {
            double top = principle * Rate / 1200.00;
            double bottom = 1 - Math.Pow(1.00 + Rate / 1200.00, -12.00 * years);
            double monthly = top / bottom;
            return monthly;
        }
    }
}