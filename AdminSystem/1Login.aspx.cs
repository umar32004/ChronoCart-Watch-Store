using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsProductUser AnUser = new clsProductUser();

        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = AnUser.FindUser(UserName, Password);

        if (UserName == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (Password == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Session["AnUser"] = AnUser;
            Session["UserName"] = txtUserName.Text;
            Session["Department"] = AnUser.Department;


            Response.Redirect("1List.aspx");
        }
        else
        {
            lblError.Text = "Login details are incorrect. Please try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

}