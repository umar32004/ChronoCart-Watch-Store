using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _2_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        lstOrders.Items.Clear();

        for (int i = 0; i < Orders.Count; i++)
        {
            string DisplayText =
                Orders.OrderList[i].OrderId + " - " +
                Orders.OrderList[i].CustomerName + " - " +
                Orders.OrderList[i].OrderStatus + " - AED " +
                Orders.OrderList[i].TotalAmount;

            lstOrders.Items.Add(new System.Web.UI.WebControls.ListItem(DisplayText, Orders.OrderList[i].OrderId.ToString()));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("2DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstOrders.SelectedIndex != -1)
        {
            Session["OrderId"] = Convert.ToInt32(lstOrders.SelectedValue);
            Response.Redirect("2DataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select an order to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstOrders.SelectedIndex != -1)
        {
            Session["OrderId"] = Convert.ToInt32(lstOrders.SelectedValue);
            Response.Redirect("2ConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select an order to delete.";
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        if (lstOrders.SelectedIndex != -1)
        {
            Session["OrderId"] = Convert.ToInt32(lstOrders.SelectedValue);
            Response.Redirect("2Viewer.aspx");
        }
        else
        {
            lblError.Text = "Please select an order to view.";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerName(txtFilter.Text);

        lstOrders.Items.Clear();

        for (int i = 0; i < Orders.Count; i++)
        {
            string DisplayText =
                Orders.OrderList[i].OrderId + " - " +
                Orders.OrderList[i].CustomerName + " - " +
                Orders.OrderList[i].OrderStatus + " - AED " +
                Orders.OrderList[i].TotalAmount;

            lstOrders.Items.Add(new System.Web.UI.WebControls.ListItem(DisplayText, Orders.OrderList[i].OrderId.ToString()));
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtFilter.Text = "";
        DisplayOrders();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}