using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        clsProductUser AnUser = (clsProductUser)Session["AnUser"];

        if (AnUser == null || AnUser.Department != "ProductAdmin")
        {
            Response.Redirect("1List.aspx");
        }

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        Int32 WatchId;

        WatchId = Convert.ToInt32(Session["WatchId"]);

        clsProductCollection ProductList = new clsProductCollection();

        ProductList.ThisProduct.Find(WatchId);

        ProductList.Delete();

        Response.Redirect("1List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("1List.aspx");
    }

}