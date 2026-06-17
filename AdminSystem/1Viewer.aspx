<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1Viewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Details</title>

    <style>
        body {
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
            background: linear-gradient(135deg, #eaf1f8, #dbe7f3);
        }

        .card {
            width: 850px;
            margin: 70px auto;
            background: white;
            border-radius: 22px;
            box-shadow: 0 15px 40px rgba(0,0,0,0.15);
            overflow: hidden;
            display: flex;
        }

        .image-section {
            width: 40%;
            background: #f1f5f9;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 30px;
        }

        .image-section img {
            width: 100%;
            max-width: 280px;
            border-radius: 18px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.18);
        }

        .details-section {
            width: 60%;
            padding: 40px;
        }

        h1 {
            margin-top: 0;
            color: #0f172a;
            font-size: 34px;
        }

        .tag {
            display: inline-block;
            background: #dbeafe;
            color: #1d4ed8;
            padding: 7px 14px;
            border-radius: 20px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .price {
            font-size: 30px;
            color: #16a34a;
            font-weight: bold;
            margin: 15px 0;
        }

        .row {
            margin: 12px 0;
            font-size: 17px;
            color: #374151;
        }

        .label {
            font-weight: bold;
            color: #111827;
        }

        .stock {
            margin-top: 18px;
            padding: 12px;
            background: #ecfdf5;
            color: #166534;
            border-radius: 10px;
            font-weight: bold;
        }

        .inactive {
            background: #fee2e2;
            color: #991b1b;
        }

        .btn {
            margin-top: 25px;
            padding: 12px 22px;
            border: none;
            border-radius: 10px;
            background: #2563eb;
            color: white;
            font-weight: bold;
            cursor: pointer;
        }

        .btn:hover {
            opacity: 0.9;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="card">

            <div class="image-section">
                <asp:Image ID="imgProduct" runat="server" Width="280px" />
            </div>

            <div class="details-section">
                <span class="tag">ChronoCart Watch</span>

                <h1>
                    <asp:Label ID="lblBrand" runat="server"></asp:Label>
                    <asp:Label ID="lblModel" runat="server"></asp:Label>
                </h1>

                <div class="price">
                    <asp:Label ID="lblPrice" runat="server"></asp:Label>
                </div>

                <div class="row">
                    <span class="label">Watch ID:</span>
                    <asp:Label ID="lblWatchId" runat="server"></asp:Label>
                </div>

                <div class="row">
                    <span class="label">Category:</span>
                    <asp:Label ID="lblCategory" runat="server"></asp:Label>
                </div>

                <div class="row">
                    <span class="label">Description:</span>
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </div>

                <div class="stock">
                    Stock Available:
                    <asp:Label ID="lblStockQuantity" runat="server"></asp:Label>
                </div>

                <div class="row">
                    <span class="label">Availability:</span>
                    <asp:Label ID="lblActive" runat="server"></asp:Label>
                </div>

                <asp:Button ID="btnBack" runat="server" Text="Back to Products" CssClass="btn" OnClick="btnBack_Click" />
            </div>

        </div>
    </form>
</body>
</html>