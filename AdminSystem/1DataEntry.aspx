<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Entry</title>
    <style>
        body {
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
            background: linear-gradient(135deg, #eef2f7, #dfe7f3);
        }

        .card {
            width: 520px;
            margin: 45px auto;
            background: white;
            padding: 35px;
            border-radius: 16px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.12);
        }

        h1 {
            text-align: center;
            color: #1f2937;
            margin-top: 0;
        }

        .form-group {
            margin-bottom: 16px;
        }

        label, .asp-label {
            font-weight: bold;
            color: #374151;
            display: block;
            margin-bottom: 6px;
        }

        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #cbd5e1;
            border-radius: 8px;
            font-size: 15px;
        }

        .checkbox-row {
            margin: 20px 0;
            color: #374151;
        }

        .error {
            color: #dc2626;
            font-weight: bold;
            display: block;
            margin-bottom: 15px;
        }

        .btn {
            padding: 11px 18px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            font-weight: bold;
            margin-right: 8px;
        }

        .btn-ok {
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

        .upload-section {
    background: #f8fafc;
    padding: 20px;
    border-radius: 15px;
    border: 1px solid #e2e8f0;
    margin-bottom: 20px;
}

.image-upload {
    width: 100%;
    padding: 12px;
    background: white;
    border: 2px dashed #cbd5e1;
    border-radius: 12px;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h1>Product Entry</h1>

            <div class="form-group">
                <asp:Label ID="lblWatchId" runat="server" Text="Watch ID" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtWatchId" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblBrand" runat="server" Text="Brand" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblModel" runat="server" Text="Model" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblPrice" runat="server" Text="Price" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblCategory" runat="server" Text="Category" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblDescription" runat="server" Text="Description" CssClass="asp-label"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </div>

            <div class="upload-section">

    <asp:Label ID="lblImage"
        runat="server"
        Text="Upload Watch Image"
        CssClass="asp-label">
    </asp:Label>

    <br /><br />

    <asp:FileUpload ID="fuProductImage"
        runat="server"
        CssClass="image-upload" />

</div>

            <div class="checkbox-row">
                <asp:CheckBox ID="chkActive" runat="server" Text=" Active" />
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>

            <asp:Button ID="btnOK" runat="server" Text="Save Product" CssClass="btn btn-ok" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-cancel" OnClick="btnCancel_Click" />
        </div>

  

    </form>
</body>
</html>