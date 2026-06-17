<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="ClassLibrary" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>User Data Entry - ChronoCart</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #f0f2f5;
            margin: 0;
            padding: 20px;
        }
        .form-container {
            max-width: 600px;
            margin: auto;
            background: white;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.1);
            padding: 30px;
        }
        h2 {
            text-align: center;
            color: #2c3e50;
            margin-bottom: 30px;
        }
        .row {
            margin-bottom: 15px;
            display: flex;
            align-items: center;
        }
        .label {
            width: 120px;
            font-weight: bold;
            color: #333;
        }
        .field {
            flex: 1;
        }
        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
        }
        .checkbox-row {
            display: flex;
            align-items: center;
        }
        .checkbox-row .label {
            width: 120px;
        }
        .button-group {
            margin-top: 20px;
            text-align: center;
        }
        button, input[type="submit"] {
            background: #2ecc71;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 6px;
            cursor: pointer;
            font-size: 16px;
            margin: 5px;
        }
        .btn-find {
            background: #3498db;
        }
        .btn-cancel {
            background: #e74c3c;
        }
        .error {
            color: red;
            margin-top: 10px;
            text-align: center;
        }
        .success {
            color: green;
        }
        .btn-find:hover { background: #2980b9; }
        .btn-cancel:hover { background: #c0392b; }
        button:hover { background: #27ae60; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>👤 User Data Entry</h2>
            <asp:HiddenField ID="hdnMode" runat="server" Value="Add" />
            <div class="row">
                <div class="label">User ID:</div>
                <div class="field">
                    <asp:TextBox ID="txtUserId" runat="server" />
                </div>
                <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn-find" OnClick="btnFind_Click" />
            </div>
            <div class="row">
                <div class="label">Full Name:</div>
                <div class="field"><asp:TextBox ID="txtFullName" runat="server" /></div>
            </div>
            <div class="row">
                <div class="label">Email:</div>
                <div class="field"><asp:TextBox ID="txtEmail" runat="server" /></div>
            </div>
            <div class="row">
                <div class="label">Password:</div>
                <div class="field"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></div>
            </div>
            <div class="row">
                <div class="label">Address:</div>
                <div class="field"><asp:TextBox ID="txtAddress" runat="server" /></div>
            </div>
            <div class="row">
                <div class="label">Phone:</div>
                <div class="field"><asp:TextBox ID="txtPhone" runat="server" /></div>
            </div>
            <div class="row checkbox-row">
                <div class="label">Active:</div>
                <asp:CheckBox ID="chkActive" runat="server" />
            </div>
            <div class="button-group">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn-cancel" OnClick="btnCancel_Click" />
            </div>
            <asp:Label ID="lblError" CssClass="error" runat="server" />
        </div>
    </form>
    <script runat="server">
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userIdParam = Request.QueryString["UserId"];
                if (!string.IsNullOrEmpty(userIdParam))
                {
                    hdnMode.Value = "Edit";
                    int userId = Convert.ToInt32(userIdParam);
                    clsUser user = new clsUser();
                    if (user.Find(userId))
                    {
                        txtUserId.Text = user.UserId.ToString();
                        txtFullName.Text = user.FullName;
                        txtEmail.Text = user.Email;
                        txtPassword.Text = user.PasswordHash;
                        txtAddress.Text = user.Address;
                        txtPhone.Text = user.Phone;
                        chkActive.Checked = user.IsActive;
                        btnFind.Enabled = false;
                    }
                    else lblError.Text = "User not found.";
                }
                else
                {
                    hdnMode.Value = "Add";
                    btnFind.Enabled = true;
                }
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            int id;
            if (int.TryParse(txtUserId.Text, out id) && user.Find(id))
            {
                txtFullName.Text = user.FullName;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.PasswordHash;
                txtAddress.Text = user.Address;
                txtPhone.Text = user.Phone;
                chkActive.Checked = user.IsActive;
                lblError.Text = "";
                hdnMode.Value = "Edit";
                btnFind.Enabled = false;
            }
            else lblError.Text = "User ID not found.";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string error = "";
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) error += "Full Name required. ";
            else if (txtFullName.Text.Length < 3) error += "Full Name min 3 characters. ";
            else if (txtFullName.Text.Length > 50) error += "Full Name max 50 characters. ";

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) error += "Email required. ";
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".")) error += "Valid email required. ";

            if (error != "")
            {
                lblError.Text = error;
                return;
            }

            clsUser user = new clsUser();
            user.FullName = txtFullName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.PasswordHash = txtPassword.Text.Trim();
            user.Address = txtAddress.Text.Trim();
            user.Phone = txtPhone.Text.Trim();
            user.IsActive = chkActive.Checked;

            try
            {
                if (hdnMode.Value == "Add") user.Add();
                else { user.UserId = Convert.ToInt32(txtUserId.Text); user.Update(); }
                Response.Redirect("3List.aspx");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE") || ex.Message.Contains("duplicate"))
                    lblError.Text = "Email already exists.";
                else lblError.Text = "Database error: " + ex.Message;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("3List.aspx");
        }
    </script>
</body>
</html>