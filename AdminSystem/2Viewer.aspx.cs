using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _2_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            int OrderId = Convert.ToInt32(Session["OrderId"]);

            clsOrder AnOrder = new clsOrder();

            if (AnOrder.Find(OrderId))
            {
                lblOrderId.Text = AnOrder.OrderId.ToString();
                lblCustomerName.Text = AnOrder.CustomerName;
                lblWatchId.Text = AnOrder.WatchId.ToString();
                lblQuantity.Text = AnOrder.Quantity.ToString();
                lblOrderDate.Text = AnOrder.OrderDate.ToShortDateString();
                lblTotalAmount.Text = "AED " + AnOrder.TotalAmount.ToString("0.00");
                lblOrderStatus.Text = AnOrder.OrderStatus;
                lblActive.Text = AnOrder.Active.ToString();
            }
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx");
    }
}