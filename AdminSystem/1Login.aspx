<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1Login.aspx.cs" Inherits="_1Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
            background: linear-gradient(135deg, #1e3a8a, #0f172a);
        }

        .login-card {
            width: 420px;
            margin: 90px auto;
            background: white;
            padding: 38px;
            border-radius: 18px;
            box-shadow: 0 12px 35px rgba(0,0,0,0.25);
        }

        h1 {
            text-align: center;
            color: #1f2937;
            margin-top: 0;
        }

        .subtitle {
            text-align: center;
            color: #6b7280;
            margin-bottom: 28px;
        }

        .form-group {
            margin-bottom: 18px;
        }

        .asp-label {
            display: block;
            font-weight: bold;
            color: #374151;
            margin-bottom: 6px;
        }

        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 11px;
            border: 1px solid #cbd5e1;
            border-radius: 8px;
            font-size: 15px;
        }

        .error {
            color: #dc2626;
            font-weight: bold;
            display: block;
            margin-bottom: 15px;
            text-align: center;
        }

        .btn {
            width: 100%;
            padding: 12px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            font-weight: bold;
            margin-bottom: 10px;
        }

        .btn-login {
            background: #2563eb;
            color: white;
        }

        .btn-cancel {
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
        <div class="login-card">
            <h1>ChronoCart Login</h1>
            <p class="subtitle">Product Management Access</p>

            <div class="form-group">
                <asp:Label ID="lblUserName" runat="server" Text="User Name" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-cancel" OnClick="btnCancel_Click" />
           
        </div>
    </form>
</body>
</html>