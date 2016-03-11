﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class qsPage2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NameValueCollection qsData = Request.QueryString;
        string color = qsData.Get("favColor");
        if (color == null)
        {
            Response.Redirect("qsPage1.aspx");
        }
        Response.Write("Your favorite color is: "+color);
    }
}