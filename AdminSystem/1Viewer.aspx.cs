using System;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProduct();
        }
    }

    void DisplayProduct()
    {
        Int32 WatchId = Convert.ToInt32(Session["WatchId"]);

        clsProduct AProduct = new clsProduct();

        Boolean Found = AProduct.Find(WatchId);

        if (Found == true)
        {
            lblWatchId.Text = AProduct.WatchId.ToString();
            lblBrand.Text = AProduct.Brand;
            lblModel.Text = " " + AProduct.Model;
            lblPrice.Text = "AED " + AProduct.Price.ToString("0.00");
            lblStockQuantity.Text = AProduct.StockQuantity.ToString();
            lblCategory.Text = AProduct.Category;
            lblDescription.Text = AProduct.Description;
            if (AProduct.StockQuantity > 0 && AProduct.Active == true)
            {
                lblActive.Text = "In Stock";
            }
            else
            {
                lblActive.Text = "Out of Stock";
            }
            string Brand = AProduct.Brand.ToLower();

            if (AProduct.ImagePath != "")
            {
                imgProduct.ImageUrl = AProduct.ImagePath;
            }
            else
            {
                imgProduct.ImageUrl = "~/Images/default.jpg";
            }
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("1List.aspx");
    }
}