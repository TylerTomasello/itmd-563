using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porj4_Tomasello
{
    public partial class ListMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IIOHelper iOHelper = new FileIOHelper();
            var list = iOHelper.ListAllMortgages();

            if (list.Count == 0)
            {
                list.Add("No Data");
            }

            GridView.DataSource = list;
            GridView.DataBind();
        }
    }
}