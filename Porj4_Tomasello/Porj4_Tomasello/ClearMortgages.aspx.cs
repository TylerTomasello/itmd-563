﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porj4_Tomasello
{
    public partial class ClearMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            //Call the IIOHelper to clear the mortgages
            IIOHelper iOHelper = new FileIOHelper();
            iOHelper.ClearAllMortgages();
        }
    }
}