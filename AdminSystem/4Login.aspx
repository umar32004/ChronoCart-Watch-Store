<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4Login.aspx.cs" Inherits="_4_Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Login</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: radial-gradient(circle at top left, #0f766e, #020617 45%, #000000);
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .login-shell {
            width: 900px;
            min-height: 520px;
            display: flex;
            border-radius: 30px;
            overflow: hidden;
            box-shadow: 0 30px 80px rgba(0,0,0,0.55);
        }

        .left-panel {
            flex: 1;
            background: linear-gradient(160deg, #14b8a6, #0f172a);
            color: white;
            padding: 55px;
        }

        .left-panel h1 {
            font-size: 42px;
            margin-bottom: 15px;
        }

        .left-panel p {
            font-size: 17px;
            line-height: 1.6;
            color: #ccfbf1;
        }

        .badge {
            display: inline-block;
            background: rgba(255,255,255,0.16);
            padding: 10px 16px;
            border-radius: 999px;
            margin-bottom: 30px;
            font-weight: bold;
        }

        .right-panel {
            flex: 1;
            background: #ffffff;
            padding: 55px;
        }

        .right-panel h2 {
            margin: 0;
            color: #0f172a;
            font-size: 30px;
        }

        .subtitle {
            color: #64748b;
            margin-bottom: 30px;
        }

        label {
            display: block;
            font-weight: 700;
            margin-bottom: 8px;
            color: #334155;
        }

        .input-box {
            width: 100%;
            padding: 14px;
            border: 2px solid #e2e8f0;
            border-radius: 14px;
            margin-bottom: 20px;
            font-size: 15px;
            box-sizing: border-box;
        }

        .input-box:focus {
            outline: none;
            border-color: #14b8a6;
        }

        .btn-login {
            width: 100%;
            padding: 15px;
            background: #0f766e;
            color: white;
            border: none;
            border-radius: 14px;
            font-size: 16px;
            font-weight: bold;
            cursor: pointer;
        }

        .btn-login:hover {
            background: #115e59;
        }

        .error {
            display: block;
            margin-top: 18px;
            color: #dc2626;
            font-weight: bold;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="login-shell">

            <div class="left-panel">
                <span class="badge">Secure Payment Admin</span>
                <h1>ChronoCart Payments</h1>
                <p>
                    Manage payment records, transaction statuses, payment methods,
                    and order payment verification from one secure admin portal.
                </p>
            </div>

            <div class="right-panel">
                <h2>Admin Login</h2>
                <p class="subtitle">Abdullah's Payment Management System</p>

                <label>Username</label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="input-box" placeholder="Enter username"></asp:TextBox>

                <label>Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="input-box" TextMode="Password" placeholder="Enter password"></asp:TextBox>

                <asp:Button ID="btnLogin" runat="server" Text="Access Payment Dashboard" CssClass="btn-login" OnClick="btnLogin_Click" />

                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>