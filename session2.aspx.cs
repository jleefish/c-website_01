using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //retrieve values
        int myInt = Convert.ToInt32(Session["myInt"]); // if session is not exist, will return 0. big...issue..
        double myDouble = Convert.ToDouble(Session["myDouble"]); // if session is not exist, will return 0. big...issue..
        string myString = Session["myString"].ToString();

        Response.Write("myInt = " + myInt+"</br>");
        Response.Write("myDouble = " + myDouble + "</br>");
        Response.Write("myString = " + myString + "</br>");

    }
}