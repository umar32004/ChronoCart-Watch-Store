<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2ConfirmDelete.aspx.cs" Inherits="_2_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart | Delete Order</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: radial-gradient(circle at top, #7f1d1d, #0f172a 60%);
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            color: #0f172a;
        }

        .delete-card {
            width: 520px;
            background: white;
            border-radius: 28px;
            padding: 38px;
            box-shadow: 0 30px 80px rgba(0,0,0,0.45);
            text-align: center;
        }

        .icon {
            width: 76px;
            height: 76px;
            margin: 0 auto 22px;
            background: #fee2e2;
            color: #dc2626;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 38px;
            font-weight: 900;
        }

        h1 {
            margin: 0;
            font-size: 30px;
        }

        p {
            color: #64748b;
            line-height: 1.7;
            margin: 14px 0 28px;
        }

        .buttons {
            display: flex;
            justify-content: center;
            gap: 14px;
        }

        .btn {
            padding: 13px 22px;
            border: none;
            border-radius: 14px;
            font-weight: 800;
            cursor: pointer;
        }

        .danger {
            background: #dc2626;
            color: white;
        }

        .safe {
            background: #e2e8f0;
            color: #0f172a;
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
        <div class="delete-card">
            <div class="icon">!</div>
            <h1>Delete Order?</h1>
            <p>
                This action will permanently remove the selected order record from
                the Order Management System.
            </p>

            <div class="buttons">
                <asp:Button ID="btnYes" runat="server" Text="Yes, Delete Order" CssClass="btn danger" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="Cancel" CssClass="btn safe" OnClick="btnNo_Click" />
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>