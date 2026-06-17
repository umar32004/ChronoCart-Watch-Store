<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart Main Menu</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: linear-gradient(135deg, #eef2f7, #dbe7f3);
        }

        .menu-card {
            width: 720px;
            margin: 90px auto;
            background: white;
            padding: 45px;
            border-radius: 24px;
            box-shadow: 0 20px 45px rgba(15, 23, 42, 0.14);
            text-align: center;
        }

        h1 {
            font-size: 42px;
            color: #0f172a;
            margin-bottom: 10px;
        }

        .subtitle {
            color: #64748b;
            margin-bottom: 35px;
            font-size: 18px;
        }

        .btn {
            width: 80%;
            padding: 16px;
            margin: 12px;
            border: none;
            border-radius: 14px;
            font-size: 17px;
            font-weight: bold;
            color: white;
            cursor: pointer;
        }

        .product { background: #2563eb; }
        .user { background: #16a34a; }
        .order { background: #f59e0b; }
        .payment { background: #dc2626; }

        .btn:hover {
            opacity: 0.9;
            transform: translateY(-1px);
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="menu-card">
            <h1>ChronoCart Main Menu</h1>
            <p class="subtitle">Select a component to continue</p>

            <asp:Button ID="btnProduct" runat="server"
                Text="Product & Inventory Management"
                CssClass="btn product"
                OnClick="btnProduct_Click" />

            <asp:Button ID="btnUser" runat="server"
                Text="User Management"
                CssClass="btn user"
                OnClick="btnUser_Click" />

            <asp:Button ID="btnOrder" runat="server"
                Text="Order Management"
                CssClass="btn order"
                OnClick="btnOrder_Click" />

            <asp:Button ID="btnPayment" runat="server"
                Text="Payment System"
                CssClass="btn payment"
                OnClick="btnPayment_Click" />
        </div>
    </form>
</body>
</html>