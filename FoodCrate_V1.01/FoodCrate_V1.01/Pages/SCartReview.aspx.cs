﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
    }
        protected void Accept_Click(object sender, EventArgs e)
        {


            Response.Redirect("../Pages/ScartCheckOut.aspx");
        }
    }
}