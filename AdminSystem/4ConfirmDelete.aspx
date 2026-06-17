<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4ConfirmDelete.aspx.cs" Inherits="_4_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Payment</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #020617;
            color: #e5e7eb;
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .delete-card {
            width: 560px;
            background: #0f172a;
            border: 1px solid #1e293b;
            border-radius: 30px;
            padding: 45px;
            text-align: center;
            box-shadow: 0 25px 70px rgba(0,0,0,0.5);
        }

        .danger-icon {
            width: 90px;
            height: 90px;
            margin: 0 auto 25px auto;
            border-radius: 50%;
            background: #7f1d1d;
            color: #fecaca;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 46px;
            font-weight: 900;
        }

        h1 {
            margin: 0;
            font-size: 32px;
            color: white;
        }

        .subtitle {
            color: #94a3b8;
            line-height: 1.6;
            margin: 18px 0 30px 0;
        }

        .warning {
            background: #450a0a;
            color: #fecaca;
            padding: 16px;
            border-radius: 16px;
            margin-bottom: 28px;
            font-weight: 700;
        }

        .btn {
            padding: 13px 22px;
            border: none;
            border-radius: 16px;
            font-weight: 900;
            cursor: pointer;
            margin-right: 8px;
        }

        .red {
            background: #fb7185;
            color: #4c0519;
        }

        .gray {
            background: #475569;
            color: white;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="delete-card">

            <div class="danger-icon">!</div>

            <h1>Confirm Payment Deletion</h1>

            <p class="subtitle">
                This action will remove the selected payment transaction from the system.
            </p>

            <div class="warning">
                Deleted payment records cannot be restored from this page.
            </div>

            <asp:Button ID="btnYes" runat="server" Text="Delete Payment" CssClass="btn red" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="Cancel" CssClass="btn gray" OnClick="btnNo_Click" />

        </div>
    </form>
</body>
</html>