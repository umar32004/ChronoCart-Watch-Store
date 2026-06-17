using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _4_ConfirmDelete : System.Web.UI.Page
{
    Int32 PaymentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsPaymentCollection PaymentBook = new clsPaymentCollection();

        PaymentBook.ThisPayment.Find(PaymentID);

        PaymentBook.Delete();

        Response.Redirect("4List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("4List.aspx");
    }
}