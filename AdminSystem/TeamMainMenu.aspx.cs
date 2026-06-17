using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("1Login.aspx");
    }

    protected void btnUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("3Login.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("2Login.aspx");
    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("4Login.aspx");
    }
}