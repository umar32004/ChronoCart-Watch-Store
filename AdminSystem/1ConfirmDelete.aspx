<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <style>
        body {
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
            background: linear-gradient(135deg, #fee2e2, #f8fafc);
        }

        .card {
            width: 480px;
            margin: 90px auto;
            background: white;
            padding: 35px;
            border-radius: 16px;
            text-align: center;
            box-shadow: 0 10px 30px rgba(0,0,0,0.14);
        }

        h1 {
            color: #991b1b;
            margin-top: 0;
        }

        .message {
            color: #374151;
            font-size: 17px;
            margin: 20px 0 30px 0;
            display: block;
        }

        .btn {
            padding: 12px 26px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            font-weight: bold;
            margin: 0 8px;
        }

        .btn-yes {
            background: #dc2626;
            color: white;
        }

        .btn-no {
            background: #6b7280;
            color: white;
        }

        .btn:hover {
            opacity: 0.88;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h1>Confirm Delete</h1>

            <asp:Label ID="lblMessage" runat="server"
                Text="Are you sure you want to delete this product?"
                CssClass="message"></asp:Label>

            <asp:Button ID="btnYes" runat="server" Text="Yes, Delete" CssClass="btn btn-yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="Cancel" CssClass="btn btn-no" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>