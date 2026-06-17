using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();

            clsProductUser AnUser = (clsProductUser)Session["AnUser"];

            if (AnUser == null || AnUser.Department != "ProductAdmin")
            {
                btnAdd.Visible = false;

            }
        }
        if (!IsPostBack)
        {
            lblLoggedInUser.Text = "Logged in as: " +
                                   Convert.ToString(Session["UserName"]);
        }
        if (IsProductAdmin() == false)
        {
            btnAdd.Visible = false;
        }
    }

    void DisplayProducts()
    {
        clsProductCollection Products = new clsProductCollection();

        rptProducts.DataSource = Products.ProductList;
        rptProducts.DataBind();
    }

    public string GetProductImage(object brandObj)
    {
        string Brand = brandObj.ToString().ToLower();

        if (Brand.Contains("rolex"))
        {
            return "~/Images/rolex.jpg";
        }
        else if (Brand.Contains("casio"))
        {
            return "~/Images/casio.jpg";
        }
        else if (Brand.Contains("seiko"))
        {
            return "~/Images/seiko.jpg";
        }
        else if (Brand.Contains("tissot"))
        {
            return "~/Images/tissot.jpg";
        }
        else
        {
            return "~/Images/default.jpg";
        }
    }

    protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "SelectProduct")
        {
            hdnSelectedWatchId.Value = e.CommandArgument.ToString();
            Session["WatchId"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("1Viewer.aspx");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["WatchId"] = -1;
        Response.Redirect("1DataEntry.aspx");
    }



    protected void btnEditCard_Click(object sender, EventArgs e)
    {
        LinkButton btn = (LinkButton)sender;

        Session["WatchId"] = Convert.ToInt32(btn.CommandArgument);

        Response.Redirect("1DataEntry.aspx");
    }



    protected void btnDeleteCard_Click(object sender, EventArgs e)
    {
        LinkButton btn = (LinkButton)sender;

        Session["WatchId"] = Convert.ToInt32(btn.CommandArgument);

        Response.Redirect("1ConfirmDelete.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();

        Products.ReportByBrand(txtFilter.Text);

        rptProducts.DataSource = Products.ProductList;
        rptProducts.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        txtFilter.Text = "";
        DisplayProducts();
    }

    public bool IsProductAdmin()
    {
        if (Session["Department"] != null &&
            Session["Department"].ToString() == "ProductAdmin")
        {
            return true;
        }

        return false;
    }
    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}