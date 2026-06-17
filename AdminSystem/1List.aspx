<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Management</title>
    <asp:Label ID="lblLoggedInUser" runat="server"></asp:Label>

    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Arial, sans-serif;
            background: linear-gradient(135deg, #edf4fb, #f8fafc);
            color: #0f172a;
        }

        .container {
            max-width: 1250px;
            margin: 40px auto;
            background: white;
            border-radius: 24px;
            padding: 35px;
            box-shadow: 0 22px 50px rgba(15, 23, 42, 0.12);
        }

        h1 {
            text-align: center;
            font-size: 42px;
            margin: 0;
        }

        .subtitle {
            text-align: center;
            color: #64748b;
            font-size: 18px;
            margin-bottom: 35px;
        }

        .layout {
            display: grid;
            grid-template-columns: 1fr 280px;
            gap: 28px;
        }

        .catalogue {
            background: #f8fafc;
            border: 1px solid #e2e8f0;
            border-radius: 22px;
            padding: 24px;
        }

        .catalogue-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 22px;
        }

        .catalogue-header h2 {
            margin: 0;
            font-size: 26px;
        }

        .badge {
            background: #dbeafe;
            color: #1d4ed8;
            padding: 10px 18px;
            border-radius: 999px;
            font-weight: bold;
        }

        .products-grid {
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            gap: 18px;
        }

        .product-card {
            background: white;
            border: 1px solid #e2e8f0;
            border-radius: 20px;
            padding: 18px;
            display: grid;
            grid-template-columns: 170px 1fr;
            gap: 18px;
            box-shadow: 0 8px 24px rgba(15, 23, 42, 0.08);
            transition: 0.2s;
        }

        .product-card:hover {
            transform: translateY(-3px);
            box-shadow: 0 14px 32px rgba(15, 23, 42, 0.14);
        }

        .product-img {
            width: 170px;
            height: 210px;
            object-fit: contain;
            background: #f1f5f9;
            border-radius: 16px;
            padding: 10px;
        }

        .product-info h3 {
            margin: 5px 0;
            font-size: 24px;
        }

        .model {
            color: #64748b;
            margin-bottom: 18px;
        }

        .price-label {
            color: #64748b;
            font-size: 13px;
        }

        .price {
            font-size: 22px;
            color: #16a34a;
            font-weight: bold;
            margin-bottom: 14px;
        }

        .stock {
            display: inline-block;
            background: #dcfce7;
            color: #166534;
            padding: 8px 12px;
            border-radius: 12px;
            font-weight: bold;
            margin-bottom: 16px;
        }

       .view-card-btn {
    display: inline-block;
    background: #2563eb;
    color: white !important;
    text-decoration: none;
    border-radius: 12px;
    padding: 12px 22px;
    font-weight: 600;
    text-align: center;
    white-space: nowrap;
    min-width: 140px;
    border: none;
    cursor: pointer;
}

.view-card-btn:hover {
    background: #1d4ed8;
}

.view-card-btn:hover {
    background: #1d4ed8;
}

        .view-card-btn:hover {
            background: #2563eb;
            color: white;
        }

        .sidebar {
            background: #f8fafc;
            border: 1px solid #e2e8f0;
            border-radius: 22px;
            padding: 22px;
        }

        .btn {
            width: 100%;
            padding: 14px;
            border: none;
            border-radius: 13px;
            margin-bottom: 12px;
            font-size: 15px;
            font-weight: bold;
            cursor: pointer;
        }

        .btn-add { background: #2563eb; color: white; }
        .btn-edit { background: #f59e0b; color: white; }
        .btn-delete { background: #dc2626; color: white; }
        .btn-view { background: #16a34a; color: white; }
        .btn-filter { background: #10b981; color: white; }
        .btn-clear { background: #64748b; color: white; }

        .filter-box {
            margin-top: 22px;
            padding-top: 22px;
            border-top: 1px solid #e2e8f0;
        }

        .textbox {
            width: 100%;
            box-sizing: border-box;
            padding: 13px;
            border: 1px solid #cbd5e1;
            border-radius: 13px;
            margin: 12px 0;
        }

        .error {
            display: block;
            color: #dc2626;
            margin-top: 15px;
            font-weight: bold;
        }

        .tip {
            margin-top: 25px;
            background: #eef6ff;
            border-radius: 16px;
            padding: 15px;
            color: #334155;
            font-size: 14px;

            .edit-card-btn {
    display: inline-block;
    background: #f59e0b;
    color: white !important;
    padding: 10px 24px;
    border-radius: 10px;
    text-decoration: none;
    font-weight: 600;
}

.delete-card-btn {
    display: inline-block;
    background: #dc2626;
    color: white !important;
    padding: 10px 24px;
    border-radius: 10px;
    text-decoration: none;
    font-weight: 600;
}
        }

        .card-actions {
    margin-top: 14px;
    display: flex;
    gap: 10px;
}

.edit-card-btn,
.delete-card-btn {
    flex: 1;
    text-align: center;
    padding: 10px 0;
    border-radius: 12px;
    text-decoration: none;
    font-weight: 700;
    color: white !important;
    box-shadow: 0 8px 18px rgba(15, 23, 42, 0.12);
}

.edit-card-btn {
    background: #f59e0b;
}

.delete-card-btn {
    background: #dc2626;
}

.edit-card-btn:hover,
.delete-card-btn:hover {
    opacity: 0.9;
    transform: translateY(-1px);
}

    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>Product Management</h1>
            <p class="subtitle">Manage watches, inventory, stock and product records</p>

            <asp:HiddenField ID="hdnSelectedWatchId" runat="server" />

            <div class="layout">

                <div class="catalogue">
                    <div class="catalogue-header">
                        <div>
                            <h2>Available Watches</h2>
                            <p>Every Second Matters, Upgrade Your Style Today, More Than a Watch — A Statement.</p>
                        </div>
                        <span class="badge">ChronoCart</span>
                    </div>

                    <div class="products-grid">
                        <asp:Repeater ID="rptProducts" runat="server" OnItemCommand="rptProducts_ItemCommand">
                            <ItemTemplate>
                                <div class="product-card">
                                    <asp:Image ID="imgProduct" runat="server"
                                        CssClass="product-img"
                                        ImageUrl='<%# Eval("ImagePath") %>' />

                                    <div class="product-info">
                                        <h3><%# Eval("Brand") %></h3>
                                        <div class="model"><%# Eval("Model") %></div>

                                        <div class="price-label">Price</div>
                                        <div class="price">AED <%# Eval("Price", "{0:0.00}") %></div>

                                        <div class="stock">In Stock: <%# Eval("StockQuantity") %></div>

                                        <asp:LinkButton ID="btnSelectCard" runat="server"
                                            CssClass="view-card-btn"
                                            Text="View Details"
                                            CommandName="SelectProduct"
                                            CommandArgument='<%# Eval("WatchId") %>' />
                                        <br />
<br />

<asp:LinkButton ID="btnEditCard" runat="server"
        CssClass="edit-card-btn"
        Text="Edit"
        CommandArgument='<%# Eval("WatchId") %>'
        OnClick="btnEditCard_Click"
        Visible='<%# IsProductAdmin() %>' />

&nbsp;&nbsp;

   <asp:LinkButton ID="btnDeleteCard" runat="server"
        CssClass="delete-card-btn"
        Text="Delete"
        CommandArgument='<%# Eval("WatchId") %>'
        OnClick="btnDeleteCard_Click"
        Visible='<%# IsProductAdmin() %>' />
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>

                    <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
                </div>

                <div class="sidebar">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="btn btn-add" OnClick="btnAdd_Click" />
                   

                    <div class="filter-box">
                        <strong>Filter by Brand</strong>
                        <asp:TextBox ID="txtFilter" runat="server" CssClass="textbox" placeholder="Enter brand name..."></asp:TextBox>

                        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btn btn-filter" OnClick="btnApplyFilter_Click" />
                        <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn btn-clear" OnClick="btnClearFilter_Click" />
                        <asp:Button ID="btnMainMenu"
    runat="server"
    Text="Main Menu"
    CssClass="btn"
    OnClick="btnMainMenu_Click" />
                    </div>

                    <div class="tip">
                        Click View Details on a product card to see full information.
                    </div>
                </div>

            </div>
        </div>

    </form>
</body>
</html>