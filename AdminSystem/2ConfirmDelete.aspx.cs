using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _2_ConfirmDelete : System.Web.UI.Page
{
    int OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ThisOrder.Find(OrderId);
        Orders.Delete();

        Response.Redirect("2List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx");
    }
}