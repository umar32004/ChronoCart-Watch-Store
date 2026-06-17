using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 WatchId;
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProductUser AnUser = (clsProductUser)Session["AnUser"];

        if (AnUser == null || AnUser.Department != "ProductAdmin")
        {
            Response.Redirect("1List.aspx");
        }

        WatchId = Convert.ToInt32(Session["WatchId"]);

        if (IsPostBack == false)
        {
            if (WatchId != -1)
            {
                DisplayProduct();
            }
        }

    }

    void DisplayProduct()
    {
        clsProductCollection ProductList = new clsProductCollection();

        ProductList.ThisProduct.Find(WatchId);

        txtWatchId.Text = ProductList.ThisProduct.WatchId.ToString();
        txtBrand.Text = ProductList.ThisProduct.Brand;
        txtModel.Text = ProductList.ThisProduct.Model;
        txtPrice.Text = ProductList.ThisProduct.Price.ToString();
        txtStockQuantity.Text = ProductList.ThisProduct.StockQuantity.ToString();
        txtCategory.Text = ProductList.ThisProduct.Category;
        txtDescription.Text = ProductList.ThisProduct.Description;
        chkActive.Checked = ProductList.ThisProduct.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();

        string Brand = txtBrand.Text;
        string Model = txtModel.Text;
        string Price = txtPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string Category = txtCategory.Text;
        string Description = txtDescription.Text;

        string Error = "";

        Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

        if (Error == "")
        {
            AProduct.WatchId = WatchId;
            AProduct.Brand = Brand;
            AProduct.Model = Model;
            AProduct.Price = Convert.ToDecimal(Price);
            AProduct.StockQuantity = Convert.ToInt32(StockQuantity);
            AProduct.Category = Category;
            AProduct.Description = Description;
            AProduct.Active = chkActive.Checked;

            clsProductCollection ProductList = new clsProductCollection();

            string ImagePath = "";

            if (fuProductImage.HasFile)
            {
                string FileName = System.IO.Path.GetFileName(fuProductImage.FileName);
                string NewFileName = DateTime.Now.Ticks.ToString() + "_" + FileName;

                string SavePath = Server.MapPath("~/Images/" + NewFileName);

                fuProductImage.SaveAs(SavePath);

                ImagePath = "~/Images/" + NewFileName;
            }
            else
            {
                if (WatchId != -1)
                {
                    ProductList.ThisProduct.Find(WatchId);
                    ImagePath = ProductList.ThisProduct.ImagePath;
                }
                else
                {
                    ImagePath = "~/Images/default.jpg";
                }
            }

            AProduct.ImagePath = ImagePath;

            if (WatchId == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(WatchId);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
            }

            Response.Redirect("1List.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("1List.aspx");
    }

}

