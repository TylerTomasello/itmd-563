using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj5_grad_tomasello
{
    public partial class ListMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IIOHelper iOHelper = new FileIOHelper(ServerPathHelper.GetPath("~/app_data/log.txt"));
            //IIOHelper iOHelper = IOFactory.CreateIOEngine();
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