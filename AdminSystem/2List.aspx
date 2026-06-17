<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2List.aspx.cs" Inherits="_2_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart | Orders</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #e2e8f0;
            color: #0f172a;
        }

        .layout {
            display: grid;
            grid-template-columns: 260px 1fr;
            min-height: 100vh;
        }

        .sidebar {
            background: #0f172a;
            color: white;
            padding: 32px 24px;
        }

        .logo {
            font-size: 25px;
            font-weight: 800;
            margin-bottom: 6px;
        }

        .role {
            color: #94a3b8;
            font-size: 13px;
            margin-bottom: 40px;
        }

        .nav-card {
            background: rgba(255,255,255,0.08);
            border-radius: 18px;
            padding: 18px;
            margin-bottom: 18px;
        }

        .nav-card strong {
            display: block;
            margin-bottom: 8px;
        }

        .nav-card span {
            color: #cbd5e1;
            font-size: 13px;
            line-height: 1.5;
        }

        .main {
            padding: 34px;
        }

        .topbar {
            background: white;
            border-radius: 22px;
            padding: 26px 30px;
            box-shadow: 0 10px 30px rgba(15,23,42,0.08);
            margin-bottom: 24px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .topbar h1 {
            margin: 0;
            font-size: 30px;
        }

        .topbar p {
            margin: 8px 0 0;
            color: #64748b;
        }

        .status-pill {
            background: #ccfbf1;
            color: #115e59;
            padding: 10px 16px;
            border-radius: 999px;
            font-weight: 700;
            font-size: 13px;
        }

        .panel {
            background: white;
            border-radius: 22px;
            padding: 26px;
            box-shadow: 0 10px 30px rgba(15,23,42,0.08);
        }

        .listbox {
            width: 100%;
            height: 330px;
            border: 1px solid #cbd5e1;
            border-radius: 16px;
            padding: 12px;
            font-size: 15px;
            background: #f8fafc;
            box-sizing: border-box;
        }

        .actions {
            margin-top: 22px;
            display: flex;
            gap: 12px;
            flex-wrap: wrap;
        }

        .btn {
            padding: 11px 18px;
            border: none;
            border-radius: 12px;
            font-weight: 700;
            cursor: pointer;
            color: white;
        }

        .add { background: #0f766e; }
        .edit { background: #2563eb; }
        .delete { background: #dc2626; }
        .view { background: #7c3aed; }
        .clear { background: #475569; }
        .filterBtn { background: #f59e0b; color: #111827; }

        .filter-row {
            margin-top: 26px;
            padding-top: 22px;
            border-top: 1px solid #e2e8f0;
            display: flex;
            gap: 12px;
            align-items: center;
            flex-wrap: wrap;
        }

        .filter-label {
            font-weight: 700;
        }

        .filter-input {
            padding: 11px 14px;
            border-radius: 12px;
            border: 1px solid #cbd5e1;
            width: 260px;
        }

        .error {
            display: block;
            margin-top: 18px;
            color: #dc2626;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="layout">
            <aside class="sidebar">
                <div class="logo">ChronoCart</div>
                <div class="role">Order Management Module</div>

                <div class="nav-card">
                    <strong>Dashboard</strong>
                    <span>View and manage customer order records.</span>
                </div>

                <div class="nav-card">
                    <strong>Operations</strong>
                    <span>Add, update, delete and search orders from one control screen.</span>
                </div>

                <div class="nav-card">
                    <strong>Component Owner</strong>
                    <span>Yousuf · Order Management System</span>
                </div>
            </aside>

            <main class="main">
                <div class="topbar">
                    <div>
                        <h1>Order Control Panel</h1>
                        <p>Manage order details, quantities, status and totals.</p>
                    </div>
                    <div class="status-pill">Admin Mode</div>
                </div>

                <section class="panel">
                    <asp:ListBox ID="lstOrders" runat="server" CssClass="listbox"></asp:ListBox>

                    <div class="actions">
                        <asp:Button ID="btnAdd" runat="server" Text="+ New Order" CssClass="btn add" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnEdit" runat="server" Text="Edit Selected" CssClass="btn edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete Selected" CssClass="btn delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnView" runat="server" Text="View Details" CssClass="btn view" OnClick="btnView_Click" />
                    </div>

                    <div class="filter-row">
                        <asp:Label ID="lblFilter" runat="server" Text="Customer Filter:" CssClass="filter-label"></asp:Label>
                        <asp:TextBox ID="txtFilter" runat="server" CssClass="filter-input" placeholder="Enter customer name"></asp:TextBox>
                        <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" CssClass="btn filterBtn" OnClick="btnFilter_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn clear" OnClick="btnClear_Click" />
                        <asp:Button ID="btnMainMenu" runat="server" 
    Text="Main Menu" 
    CssClass="btn clear" 
    OnClick="btnMainMenu_Click" />
                    </div>

                    <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
                </section>
            </main>
        </div>
    </form>
</body>
</html>