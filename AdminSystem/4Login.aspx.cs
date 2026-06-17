using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using ClassLibrary;

public partial class _4_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsPaymentUser AUser = new clsPaymentUser();

        bool Found = AUser.Login(txtUserName.Text, txtPassword.Text);

        if (Found == true)
        {
            Session["UserName"] = AUser.UserName;
            Session["Role"] = AUser.Role;

            Response.Redirect("4List.aspx");
        }
        else
        {
            lblError.Text = "Invalid username or password.";
        }
    }
}