using System;
using ClassLibrary;

public partial class _4_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            Int32 PaymentID = Convert.ToInt32(Session["PaymentID"]);

            clsPayment APayment = new clsPayment();

            APayment.Find(PaymentID);

            lblPaymentID.Text = APayment.PaymentID.ToString();
            lblOrderID.Text = APayment.OrderID.ToString();
            lblAmount.Text = APayment.Amount.ToString();
            lblPaymentMethod.Text = APayment.PaymentMethod;
            lblPaymentDate.Text = APayment.PaymentDate.ToShortDateString();
            lblPaymentStatus.Text = APayment.PaymentStatus;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("4List.aspx");
    }
}