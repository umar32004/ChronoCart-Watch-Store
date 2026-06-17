using System;
using ClassLibrary;


public partial class _4_DataEntry : System.Web.UI.Page
{
    Int32 PaymentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("4Login.aspx");
        }

        if (Session["PaymentID"] == null)
        {
            Session["PaymentID"] = -1;
        }

        PaymentID = Convert.ToInt32(Session["PaymentID"]);

        if (IsPostBack == false)
        {
            if (PaymentID != -1)
            {
                DisplayPayment();
            }
        }
    }

    void DisplayPayment()
    {
        clsPayment APayment = new clsPayment();

        if (APayment.Find(PaymentID))
        {
            txtOrderID.Text = APayment.OrderID.ToString();
            txtAmount.Text = APayment.Amount.ToString();
            ddlPaymentMethod.SelectedValue = APayment.PaymentMethod;
            txtPaymentDate.Text = APayment.PaymentDate.ToShortDateString();
            ddlPaymentStatus.SelectedValue = APayment.PaymentStatus;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPayment APayment = new clsPayment();

        string Error = APayment.Valid(
                            txtOrderID.Text,
                            txtAmount.Text,
                            ddlPaymentMethod.SelectedValue,
                            txtPaymentDate.Text,
                            ddlPaymentStatus.SelectedValue);

        if (Error == "")
        {
            clsPaymentCollection PaymentBook = new clsPaymentCollection();

            APayment.OrderID = Convert.ToInt32(txtOrderID.Text);
            APayment.Amount = Convert.ToDecimal(txtAmount.Text);
            APayment.PaymentMethod = ddlPaymentMethod.SelectedValue;
            APayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
            APayment.PaymentStatus = ddlPaymentStatus.SelectedValue;

            if (PaymentID == -1)
            {
                PaymentBook.ThisPayment = APayment;
                PaymentBook.Add();
            }
            else
            {
                APayment.PaymentID = PaymentID;
                PaymentBook.ThisPayment = APayment;
                PaymentBook.Update();
            }

            Response.Redirect("4List.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("4List.aspx");
    }
}