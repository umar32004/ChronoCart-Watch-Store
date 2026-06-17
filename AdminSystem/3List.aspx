<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="ClassLibrary" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>User List - ChronoCart</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #f0f2f5;
            margin: 0;
            padding: 20px;
        }
        .container {
            max-width: 1200px;
            margin: auto;
            background: white;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.1);
            padding: 20px;
        }
        h2 {
            color: #2c3e50;
            margin-top: 0;
        }
        .filter-bar {
            margin-bottom: 20px;
            display: flex;
            gap: 10px;
            align-items: center;
        }
        .filter-bar input {
            flex: 1;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 6px;
        }
        .filter-bar button {
            background: #3498db;
            border: none;
            padding: 8px 15px;
            border-radius: 6px;
            color: white;
            cursor: pointer;
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }
        th {
            background: #2c3e50;
            color: white;
        }
        tr:nth-child(even) {
            background: #f9f9f9;
        }
        .action-buttons a {
            text-decoration: none;
            padding: 4px 8px;
            border-radius: 4px;
            margin-right: 5px;
            color: white;
        }
        .edit-btn {
            background: #f39c12;
        }
        .delete-btn {
            background: #e74c3c;
        }
        .add-btn {
            display: inline-block;
            background: #2ecc71;
            color: white;
            padding: 10px 15px;
            text-decoration: none;
            border-radius: 6px;
            margin-top: 20px;
        }
        .add-btn:hover { background: #27ae60; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>📋 User Management - List</h2>
            <div class="filter-bar">
                <asp:TextBox ID="txtFilter" runat="server" placeholder="Filter by Full Name..." />
                <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
                <asp:Button ID="btnShowAll" runat="server" Text="Show All" OnClick="btnShowAll_Click" />
            </div>
            <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False" OnRowCommand="gvUsers_RowCommand" CssClass="grid" BorderStyle="None" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="UserId" HeaderText="ID" />
                    <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="EditRecord" CommandArgument='<%# Eval("UserId") %>' CssClass="edit-btn" style="background:#f39c12; color:white; border:none; padding:4px 8px; border-radius:4px;" />
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="DeleteRecord" CommandArgument='<%# Eval("UserId") %>' OnClientClick="return confirm('Are you sure?');" CssClass="delete-btn" style="background:#e74c3c; color:white; border:none; padding:4px 8px; border-radius:4px;" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <a href="3DataEntry.aspx" class="add-btn">➕ Add New User</a>
            <a href="TeamMainMenu.aspx" style="margin-left: 10px;">⬅ Back to Main Menu</a>
        </div>
    </form>
    <script runat="server">
        private void BindGrid(DataTable dt)
        {
            gvUsers.DataSource = dt;
            gvUsers.DataBind();
        }

        private DataTable GetUserDataTable(System.Collections.Generic.List<clsUser> users)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(int));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("IsActive", typeof(bool));
            foreach (var u in users)
            {
                dt.Rows.Add(u.UserId, u.FullName, u.Email, u.Address, u.Phone, u.IsActive);
            }
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsUserCollection users = new clsUserCollection();
                BindGrid(GetUserDataTable(users.UserList));
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            clsUserCollection users = new clsUserCollection();
            users.FilterByFullName(txtFilter.Text);
            BindGrid(GetUserDataTable(users.UserList));
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            clsUserCollection users = new clsUserCollection();
            BindGrid(GetUserDataTable(users.UserList));
        }

        protected void gvUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int userId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "EditRecord")
            {
                Response.Redirect("3DataEntry.aspx?UserId=" + userId);
            }
            else if (e.CommandName == "DeleteRecord")
            {
                clsUser user = new clsUser();
                user.Delete(userId);
                // Refresh grid
                clsUserCollection users = new clsUserCollection();
                BindGrid(GetUserDataTable(users.UserList));
            }
        }
    </script>
</body>
</html>