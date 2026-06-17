using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using ClassLibrary;

public partial class _2_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsDataConnection DB = new clsDataConnection();

        DB.AddParameter("@UserName", txtUsername.Text);
        DB.AddParameter("@Password", txtPassword.Text);

        DB.Execute("sproc_tblOrderUsers_Login");

        if (DB.Count == 1)
        {
            Session["UserName"] = txtUsername.Text;
            Session["Department"] = DB.DataTable.Rows[0]["Department"].ToString();

            Response.Redirect("2List.aspx");
        }
        else
        {
            lblError.Text = "Invalid username or password.";
        }
    }
    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}