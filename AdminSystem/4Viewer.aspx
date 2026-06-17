<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4Viewer.aspx.cs" Inherits="_4_Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Details</title>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #020617;
            color: #e5e7eb;
        }

        .page {
            width: 760px;
            margin: 50px auto;
        }

        .receipt {
            background: #f8fafc;
            color: #0f172a;
            border-radius: 28px;
            overflow: hidden;
            box-shadow: 0 25px 70px rgba(0,0,0,0.5);
        }

        .receipt-top {
            background: linear-gradient(135deg, #0f766e, #14b8a6);
            color: white;
            padding: 35px;
        }

        .receipt-top h1 {
            margin: 0;
            font-size: 34px;
        }

        .receipt-top p {
            margin-bottom: 0;
            color: #ccfbf1;
        }

        .receipt-body {
            padding: 35px;
        }

        .row {
            display: flex;
            justify-content: space-between;
            border-bottom: 1px dashed #cbd5e1;
            padding: 16px 0;
            font-size: 17px;
        }

        .row span:first-child {
            font-weight: 800;
            color: #475569;
        }

        .status-box {
            margin-top: 25px;
            background: #ecfdf5;
            color: #047857;
            padding: 16px;
            border-radius: 16px;
            font-weight: 900;
            text-align: center;
        }

        .footer {
            padding: 0 35px 35px 35px;
        }

        .btn {
            padding: 13px 20px;
            border: none;
            border-radius: 16px;
            font-weight: 900;
            cursor: pointer;
            background: #0f766e;
            color: white;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="receipt">

                <div class="receipt-top">
                    <h1>Payment Receipt</h1>
                    <p>Transaction details for the selected ChronoCart order payment.</p>
                </div>

                <div class="receipt-body">
                    <div class="row">
                        <span>Payment ID</span>
                        <asp:Label ID="lblPaymentID" runat="server"></asp:Label>
                    </div>

                    <div class="row">
                        <span>Order ID</span>
                        <asp:Label ID="lblOrderID" runat="server"></asp:Label>
                    </div>

                    <div class="row">
                        <span>Amount</span>
                        <span>£<asp:Label ID="lblAmount" runat="server"></asp:Label></span>
                    </div>

                    <div class="row">
                        <span>Payment Method</span>
                        <asp:Label ID="lblPaymentMethod" runat="server"></asp:Label>
                    </div>

                    <div class="row">
                        <span>Payment Date</span>
                        <asp:Label ID="lblPaymentDate" runat="server"></asp:Label>
                    </div>

                    <div class="status-box">
                        Status: <asp:Label ID="lblPaymentStatus" runat="server"></asp:Label>
                    </div>
                </div>

                <div class="footer">
                    <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" CssClass="btn" OnClick="btnBack_Click" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>