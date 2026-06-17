<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4List.aspx.cs" Inherits="_4_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Dashboard</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #020617;
            color: #e5e7eb;
        }

        .layout {
            display: flex;
            min-height: 100vh;
        }

        .sidebar {
            width: 250px;
            background: #0f172a;
            padding: 30px 22px;
            box-shadow: 8px 0 25px rgba(0,0,0,0.35);
        }

        .logo {
            font-size: 24px;
            font-weight: 800;
            color: #2dd4bf;
            margin-bottom: 8px;
        }

        .side-text {
            color: #94a3b8;
            font-size: 14px;
            margin-bottom: 35px;
        }

        .side-box {
            background: #1e293b;
            border-radius: 18px;
            padding: 18px;
            margin-bottom: 18px;
            color: #cbd5e1;
        }

        .main {
            flex: 1;
            padding: 35px;
        }

        .topbar {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 28px;
        }

        h1 {
            margin: 0;
            font-size: 34px;
            color: white;
        }

        .subtitle {
            color: #94a3b8;
            margin-top: 7px;
        }

        .dashboard-card {
            background: #0f172a;
            border: 1px solid #1e293b;
            border-radius: 24px;
            padding: 28px;
            box-shadow: 0 20px 60px rgba(0,0,0,0.3);
        }

        label {
            color: #cbd5e1;
            font-weight: 700;
        }

        .search-box {
            width: 320px;
            padding: 13px;
            border-radius: 14px;
            border: 1px solid #334155;
            background: #020617;
            color: white;
            margin-right: 10px;
        }

        .listbox {
            width: 100%;
            height: 350px;
            margin-top: 24px;
            background: #020617;
            color: #e5e7eb;
            border: 1px solid #334155;
            border-radius: 18px;
            padding: 15px;
            font-size: 15px;
            box-sizing: border-box;
        }

      .btn {
    padding: 12px 18px;
    border: none;
    border-radius: 14px;
    font-weight: 800;
    cursor: pointer;
    margin-right: 0;
}

        .teal { background: #14b8a6; color: #022c22; }
        .blue { background: #38bdf8; color: #082f49; }
        .purple { background: #a78bfa; color: #2e1065; }
        .red { background: #fb7185; color: #4c0519; }
        .gray { background: #475569; color: white; }
        .yellow { background: #facc15; color: #422006; }

        .actions {
    margin-top: 24px;
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
}

        .error {
            display: block;
            color: #fb7185;
            font-weight: bold;
            margin-top: 18px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="layout">

            <div class="sidebar">
                <div class="logo">PaymentHub</div>
                <div class="side-text">ChronoCart Payment Control</div>

                <div class="side-box">
                    <strong>Module</strong><br />
                    Payment System
                </div>

                <div class="side-box">
                    <strong>Admin</strong><br />
                    Abdullah
                </div>

                <div class="side-box">
                    <strong>Functions</strong><br />
                    Add, Edit, Delete, View, Search
                </div>
            </div>

            <div class="main">

                <div class="topbar">
                    <div>
                        <h1>Payment Dashboard</h1>
                        <p class="subtitle">Manage order payments and transaction records.</p>
                    </div>

                    <asp:Button ID="btnMainMenu" runat="server" Text="MainMenu" CssClass="btn red" OnClick="btnMainMenu_Click" />
                </div>

                <div class="dashboard-card">

                    <label>Search Payment Status</label><br /><br />

                    <asp:TextBox ID="txtFilter" runat="server" CssClass="search-box" placeholder="Completed, Pending, Failed"></asp:TextBox>

                    <asp:Button ID="btnApplyFilter" runat="server" Text="Search" CssClass="btn teal" OnClick="btnApplyFilter_Click" />
                    <asp:Button ID="btnClearFilter" runat="server" Text="Clear" CssClass="btn gray" OnClick="btnClearFilter_Click" />

                    <asp:ListBox ID="lstPaymentList" runat="server" CssClass="listbox"></asp:ListBox>

                    <div class="actions">
                        <asp:Button ID="btnAdd" runat="server" Text="+ Add Payment" CssClass="btn teal" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnEdit" runat="server" Text="Edit Status" CssClass="btn blue" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete Record" CssClass="btn red" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnView" runat="server" Text="View Details" CssClass="btn yellow" OnClick="btnView_Click" />
                    </div>

                    <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>

                </div>

            </div>
        </div>
    </form>
</body>
</html>