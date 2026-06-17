using System;
using ClassLibrary;

public partial class _4_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("4Login.aspx");
        }

        if (IsPostBack == false)
        {
            DisplayPayments();
        }
    }
    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();

        lstPaymentList.Items.Clear();

        foreach (clsPayment payment in Payments.PaymentList)
        {
            string display =
                "PaymentID: " + payment.PaymentID +
                " | OrderID: " + payment.OrderID +
                " | Amount: £" + payment.Amount +
                " | Method: " + payment.PaymentMethod +
                " | Status: " + payment.PaymentStatus;

            lstPaymentList.Items.Add(new System.Web.UI.WebControls.ListItem(display, payment.PaymentID.ToString()));
        }
    }

    void DisplayFilteredPayments(string status)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();

        lstPaymentList.Items.Clear();

        foreach (clsPayment payment in Payments.PaymentList)
        {
            if (payment.PaymentStatus.ToLower().Contains(status.ToLower()))
            {
                string display =
                    "PaymentID: " + payment.PaymentID +
                    " | OrderID: " + payment.OrderID +
                    " | Amount: £" + payment.Amount +
                    " | Method: " + payment.PaymentMethod +
                    " | Status: " + payment.PaymentStatus;

                lstPaymentList.Items.Add(new System.Web.UI.WebControls.ListItem(display, payment.PaymentID.ToString()));
            }
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        DisplayFilteredPayments(txtFilter.Text);
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        txtFilter.Text = "";
        DisplayPayments();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = -1;
        Response.Redirect("4DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstPaymentList.SelectedIndex != -1)
        {
            Session["PaymentID"] = Convert.ToInt32(lstPaymentList.SelectedValue);
            Response.Redirect("4DataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstPaymentList.SelectedIndex != -1)
        {
            Session["PaymentID"] = Convert.ToInt32(lstPaymentList.SelectedValue);
            Response.Redirect("4ConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to delete.";
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        if (lstPaymentList.SelectedIndex != -1)
        {
            Session["PaymentID"] = Convert.ToInt32(lstPaymentList.SelectedValue);
            Response.Redirect("4Viewer.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to view.";
        }
    }
    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}