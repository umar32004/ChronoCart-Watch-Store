<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2Viewer.aspx.cs" Inherits="_2_Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart | Order Details</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #020617;
            color: #0f172a;
        }

        .page {
            max-width: 850px;
            margin: 45px auto;
            padding: 0 20px;
        }

        .ticket {
            background: white;
            border-radius: 30px;
            overflow: hidden;
            box-shadow: 0 25px 70px rgba(0,0,0,0.45);
        }

        .ticket-head {
            background: linear-gradient(135deg, #0f766e, #14b8a6);
            color: white;
            padding: 34px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .ticket-head h1 {
            margin: 0;
            font-size: 32px;
        }

        .ticket-head p {
            margin: 8px 0 0;
            color: #ccfbf1;
        }

        .stamp {
            border: 2px solid rgba(255,255,255,0.7);
            padding: 10px 16px;
            border-radius: 12px;
            font-weight: 800;
            transform: rotate(-3deg);
        }

        .details {
            padding: 34px;
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 18px;
        }

        .detail-card {
            background: #f8fafc;
            border: 1px solid #e2e8f0;
            padding: 18px;
            border-radius: 18px;
        }

        .label {
            color: #64748b;
            font-size: 13px;
            font-weight: 700;
            text-transform: uppercase;
            letter-spacing: .5px;
            margin-bottom: 8px;
        }

        .value {
            font-size: 20px;
            font-weight: 800;
            color: #0f172a;
        }

        .footer {
            padding: 0 34px 34px;
        }

        .btn {
            padding: 12px 22px;
            border: none;
            border-radius: 14px;
            background: #0f172a;
            color: white;
            font-weight: 800;
            cursor: pointer;
        }

        @media (max-width: 650px) {
            .details {
                grid-template-columns: 1fr;
            }

            .ticket-head {
                flex-direction: column;
                align-items: flex-start;
                gap: 18px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="ticket">
                <div class="ticket-head">
                    <div>
                        <h1>Order Details</h1>
                        <p>Complete selected order record summary.</p>
                    </div>
                    <div class="stamp">ORDER</div>
                </div>

                <div class="details">
                    <div class="detail-card">
                        <div class="label">Order ID</div>
                        <div class="value"><asp:Label ID="lblOrderId" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Customer Name</div>
                        <div class="value"><asp:Label ID="lblCustomerName" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Watch ID</div>
                        <div class="value"><asp:Label ID="lblWatchId" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Quantity</div>
                        <div class="value"><asp:Label ID="lblQuantity" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Order Date</div>
                        <div class="value"><asp:Label ID="lblOrderDate" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Total Amount</div>
                        <div class="value"><asp:Label ID="lblTotalAmount" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Order Status</div>
                        <div class="value"><asp:Label ID="lblOrderStatus" runat="server"></asp:Label></div>
                    </div>

                    <div class="detail-card">
                        <div class="label">Active</div>
                        <div class="value"><asp:Label ID="lblActive" runat="server"></asp:Label></div>
                    </div>
                </div>

                <div class="footer">
                    <asp:Button ID="btnBack" runat="server" Text="Back to Orders" CssClass="btn" OnClick="btnBack_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>