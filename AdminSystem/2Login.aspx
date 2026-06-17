<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2Login.aspx.cs" Inherits="_2_Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart | Order Login</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #0f172a;
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .login-shell {
            width: 900px;
            min-height: 520px;
            display: grid;
            grid-template-columns: 1.1fr 0.9fr;
            background: #ffffff;
            border-radius: 28px;
            overflow: hidden;
            box-shadow: 0 30px 80px rgba(0,0,0,0.45);
        }

        .brand-panel {
            background: linear-gradient(145deg, #0f766e, #0f172a);
            color: white;
            padding: 50px;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
        }

        .brand-badge {
            background: rgba(255,255,255,0.14);
            padding: 10px 16px;
            border-radius: 999px;
            width: fit-content;
            font-size: 13px;
            letter-spacing: 1px;
            text-transform: uppercase;
        }

        .brand-title {
            font-size: 42px;
            font-weight: 800;
            margin-top: 40px;
            line-height: 1.1;
        }

        .brand-text {
            color: #ccfbf1;
            font-size: 16px;
            line-height: 1.7;
        }

        .login-panel {
            padding: 55px 45px;
            display: flex;
            flex-direction: column;
            justify-content: center;
        }

        .login-panel h1 {
            margin: 0;
            color: #0f172a;
            font-size: 30px;
        }

        .hint {
            color: #64748b;
            margin: 10px 0 30px;
        }

        .input {
            width: 100%;
            padding: 14px;
            margin-bottom: 16px;
            border: 1px solid #cbd5e1;
            border-radius: 14px;
            font-size: 15px;
            box-sizing: border-box;
            background: #f8fafc;
        }

        .input:focus {
            outline: none;
            border-color: #0f766e;
            box-shadow: 0 0 0 3px rgba(15,118,110,0.15);
        }

        .btn-login {
            width: 100%;
            padding: 14px;
            border: none;
            border-radius: 14px;
            background: #0f766e;
            color: white;
            font-weight: 700;
            font-size: 15px;
            cursor: pointer;
        }

        .btn-login:hover {
            background: #115e59;
        }

        .error {
            display: block;
            margin-top: 18px;
            color: #dc2626;
            font-weight: 600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-shell">
            <div class="brand-panel">
                <div>
                    <div class="brand-badge">Order Control Desk</div>
                    <div class="brand-title">ChronoCart<br />Order Management</div>
                    <p class="brand-text">
                        Secure staff access for managing customer orders, order status,
                        quantities and order records.
                    </p>
                </div>
                <div class="brand-text">Yousuf Component · Admin Access</div>
            </div>

            <div class="login-panel">
                <h1>Staff Login</h1>
                <div class="hint">Enter your order management credentials.</div>

                <asp:TextBox ID="txtUsername" runat="server" CssClass="input" placeholder="Username"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="input" placeholder="Password" TextMode="Password"></asp:TextBox>

                <asp:Button ID="btnLogin" runat="server" Text="Login to Orders" CssClass="btn-login" OnClick="btnLogin_Click" />

                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
                <br /><br />
<asp:Button ID="btnMainMenu" runat="server" 
    Text="Back to Main Menu" 
    CssClass="btn-login" 
    OnClick="btnMainMenu_Click" />
            </div>
        </div>
    </form>
</body>
</html>