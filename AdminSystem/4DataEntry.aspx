<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4DataEntry.aspx.cs" Inherits="_4_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Entry</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #020617;
            color: #e5e7eb;
        }

        .page {
            width: 760px;
            margin: 45px auto;
        }

        .panel {
            background: #0f172a;
            border: 1px solid #1e293b;
            border-radius: 28px;
            padding: 38px;
            box-shadow: 0 25px 70px rgba(0,0,0,0.45);
        }

        .tag {
            display: inline-block;
            background: #134e4a;
            color: #5eead4;
            padding: 8px 14px;
            border-radius: 999px;
            font-weight: 800;
            margin-bottom: 18px;
        }

        h1 {
            margin: 0;
            color: white;
            font-size: 34px;
        }

        .subtitle {
            color: #94a3b8;
            margin-bottom: 28px;
        }

        label {
            display: block;
            color: #cbd5e1;
            font-weight: 800;
            margin-bottom: 8px;
        }

        .input-box {
            width: 100%;
            padding: 14px;
            background: #020617;
            color: white;
            border: 1px solid #334155;
            border-radius: 16px;
            margin-bottom: 18px;
            box-sizing: border-box;
            font-size: 15px;
        }

        .input-box:focus {
            outline: none;
            border-color: #14b8a6;
        }

        .btn {
            padding: 13px 20px;
            border: none;
            border-radius: 16px;
            font-weight: 900;
            cursor: pointer;
            margin-right: 8px;
        }

        .teal {
            background: #14b8a6;
            color: #022c22;
        }

        .gray {
            background: #475569;
            color: white;
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
        <div class="page">
            <div class="panel">

                <span class="tag">Payment Record</span>

                <h1>Transaction Entry</h1>

                <p class="subtitle">
                    Create or update payment information for a customer order.
                </p>

                <label>Order ID</label>
                <asp:TextBox ID="txtOrderID"
                    runat="server"
                    CssClass="input-box"
                    placeholder="Enter linked order ID">
                </asp:TextBox>

                <label>Amount</label>
                <asp:TextBox ID="txtAmount"
                    runat="server"
                    CssClass="input-box"
                    placeholder="Enter payment amount">
                </asp:TextBox>

                <label>Payment Method</label>
                <asp:DropDownList ID="ddlPaymentMethod"
                    runat="server"
                    CssClass="input-box">
                    <asp:ListItem>Card</asp:ListItem>
                    <asp:ListItem>Cash</asp:ListItem>
                    <asp:ListItem>Bank Transfer</asp:ListItem>
                    <asp:ListItem>Apple Pay</asp:ListItem>
                </asp:DropDownList>

                <label>Payment Date</label>
                <asp:TextBox ID="txtPaymentDate"
                    runat="server"
                    CssClass="input-box"
                    placeholder="03/06/2026">
                </asp:TextBox>

                <label>Payment Status</label>
                <asp:DropDownList ID="ddlPaymentStatus"
                    runat="server"
                    CssClass="input-box">
                    <asp:ListItem>Completed</asp:ListItem>
                    <asp:ListItem>Pending</asp:ListItem>
                    <asp:ListItem>Failed</asp:ListItem>
                    <asp:ListItem>Refunded</asp:ListItem>
                </asp:DropDownList>

                <asp:Button ID="btnOK"
                    runat="server"
                    Text="Save Transaction"
                    CssClass="btn teal"
                    OnClick="btnOK_Click" />

                <asp:Button ID="btnCancel"
                    runat="server"
                    Text="Cancel"
                    CssClass="btn gray"
                    OnClick="btnCancel_Click" />

                <br /><br />

                <asp:Label ID="lblError"
                    runat="server"
                    CssClass="error">
                </asp:Label>

            </div>
        </div>
    </form>
</body>
</html>