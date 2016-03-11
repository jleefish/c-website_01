using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page //extends base page class. QUIZ4!!
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            Response.Write("IsPostBack = true");
        }
        else
        {
            Response.Write("First page load...IsPostBack = false");
        }
    }
    protected void cmdHello_Click(object sender, EventArgs e)
    {
        lblHello.Text = "Hello, " + txtName.Text;
    }
}