using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _2_DataEntry : System.Web.UI.Page
{
    int OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);

        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderId);

        txtCustomerName.Text = Orders.ThisOrder.CustomerName;
        txtWatchId.Text = Orders.ThisOrder.WatchId.ToString();
        txtQuantity.Text = Orders.ThisOrder.Quantity.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString("yyyy-MM-dd");
        txtTotalAmount.Text = Orders.ThisOrder.TotalAmount.ToString();
        ddlOrderStatus.SelectedValue = Orders.ThisOrder.OrderStatus;
        chkActive.Checked = Orders.ThisOrder.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string Error = AnOrder.Valid(
            txtCustomerName.Text,
            txtWatchId.Text,
            txtQuantity.Text,
            txtOrderDate.Text,
            txtTotalAmount.Text,
            ddlOrderStatus.SelectedValue
        );

        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerName = txtCustomerName.Text;
            AnOrder.WatchId = Convert.ToInt32(txtWatchId.Text);
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            AnOrder.OrderStatus = ddlOrderStatus.SelectedValue;
            AnOrder.Active = chkActive.Checked;

            clsOrderCollection Orders = new clsOrderCollection();

            if (OrderId == -1)
            {
                Orders.ThisOrder = AnOrder;
                Orders.Add();
            }
            else
            {
                Orders.ThisOrder = AnOrder;
                Orders.Update();
            }

            Response.Redirect("2List.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx");
    }
}