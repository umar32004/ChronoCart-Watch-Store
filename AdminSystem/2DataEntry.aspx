<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2DataEntry.aspx.cs" Inherits="_2_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoCart | Order Entry</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: #f1f5f9;
            color: #0f172a;
        }

        .page {
            max-width: 980px;
            margin: 38px auto;
            padding: 0 20px;
        }

        .header {
            background: #0f172a;
            color: white;
            border-radius: 26px;
            padding: 30px;
            margin-bottom: 24px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .header h1 {
            margin: 0;
            font-size: 32px;
        }

        .header p {
            margin: 8px 0 0;
            color: #cbd5e1;
        }

        .badge {
            background: #0f766e;
            padding: 10px 16px;
            border-radius: 999px;
            font-weight: 700;
            font-size: 13px;
        }

        .form-card {
            background: white;
            border-radius: 26px;
            padding: 32px;
            box-shadow: 0 14px 35px rgba(15,23,42,0.09);
        }

        .grid {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 22px;
        }

        .field {
            display: flex;
            flex-direction: column;
        }

        .field label, .asp-label {
            font-weight: 700;
            margin-bottom: 8px;
            color: #334155;
        }

        .input {
            padding: 13px 14px;
            border: 1px solid #cbd5e1;
            border-radius: 14px;
            background: #f8fafc;
            font-size: 15px;
        }

        .input:focus {
            outline: none;
            border-color: #0f766e;
            box-shadow: 0 0 0 3px rgba(15,118,110,0.14);
        }

        .active-box {
            margin-top: 24px;
            background: #ecfdf5;
            color: #065f46;
            padding: 15px;
            border-radius: 16px;
            font-weight: 700;
        }

        .buttons {
            margin-top: 28px;
            display: flex;
            gap: 14px;
        }

        .btn {
            padding: 12px 22px;
            border: none;
            border-radius: 14px;
            color: white;
            font-weight: 800;
            cursor: pointer;
        }

        .save { background: #0f766e; }
        .cancel { background: #475569; }

        .error {
            display: block;
            margin-top: 20px;
            color: #dc2626;
            font-weight: 700;
        }

        @media (max-width: 700px) {
            .grid {
                grid-template-columns: 1fr;
            }

            .header {
                flex-direction: column;
                align-items: flex-start;
                gap: 14px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="header">
                <div>
                    <h1>Order Data Entry</h1>
                    <p>Create or update customer order information.</p>
                </div>
                <div class="badge">Yousuf Module</div>
            </div>

            <div class="form-card">
                <div class="grid">
                    <div class="field">
                        <asp:Label runat="server" Text="Customer Name" CssClass="asp-label"></asp:Label>
                        <asp:TextBox ID="txtCustomerName" runat="server" CssClass="input" placeholder="e.g. Ahmed Khan"></asp:TextBox>
                    </div>

                    <div class="field">
                        <asp:Label runat="server" Text="Watch ID" CssClass="asp-label"></asp:Label>
                        <asp:TextBox ID="txtWatchId" runat="server" CssClass="input" placeholder="e.g. 1"></asp:TextBox>
                    </div>

                    <div class="field">
                        <asp:Label runat="server" Text="Quantity" CssClass="asp-label"></asp:Label>
                        <asp:TextBox ID="txtQuantity" runat="server" CssClass="input" placeholder="e.g. 2"></asp:TextBox>
                    </div>

                    <div class="field">
                        <asp:Label runat="server" Text="Order Date" CssClass="asp-label"></asp:Label>
                        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="input" TextMode="Date"></asp:TextBox>
                    </div>

                    <div class="field">
                        <asp:Label runat="server" Text="Total Amount" CssClass="asp-label"></asp:Label>
                        <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="input" placeholder="e.g. 5000.00"></asp:TextBox>
                    </div>

                    <div class="field">
                        <asp:Label runat="server" Text="Order Status" CssClass="asp-label"></asp:Label>
                        <asp:DropDownList ID="ddlOrderStatus" runat="server" CssClass="input">
                            <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                            <asp:ListItem Text="Processing" Value="Processing"></asp:ListItem>
                            <asp:ListItem Text="Completed" Value="Completed"></asp:ListItem>
                            <asp:ListItem Text="Cancelled" Value="Cancelled"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="active-box">
                    <asp:CheckBox ID="chkActive" runat="server" Text=" Active Order Record" Checked="true" />
                </div>

                <div class="buttons">
                    <asp:Button ID="btnOK" runat="server" Text="Save Order" CssClass="btn save" OnClick="btnOK_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn cancel" OnClick="btnCancel_Click" />
                </div>

                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>