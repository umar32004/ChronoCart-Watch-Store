<%@ Page Language="C#" AutoEventWireup="true" %>
<!DOCTYPE html>
<html>
<head><title>Viewer</title></head>
<body>
    <h2>Viewer Page (Placeholder)</h2>
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    <script runat="server">
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("3DataEntry.aspx");
        }
    </script>
</body>
</html>