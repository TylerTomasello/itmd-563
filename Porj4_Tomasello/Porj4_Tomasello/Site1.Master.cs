using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porj4_Tomasello
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Have the timer display the day, month, date, year, hour, minutes, and seconds
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");
        }
    }
}