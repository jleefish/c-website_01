using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class qsControl2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NameValueCollection qsData = Request.QueryString;
        //2nd way of collecting data IMPORTANT!!!!
        string color = qsData["favColor"]; //[name] string
        lblInfo.Text = "Your favorite color is " + color;
    }
}