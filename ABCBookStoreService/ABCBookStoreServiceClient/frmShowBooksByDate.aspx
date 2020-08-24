<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmShowBooksByDate.aspx.cs" Inherits="ABCBookStoreServiceClient.frmShowBooksByDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book List By Date</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="title" runat="server" Text="Book List By Date"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date (YYYY-MM-DD): "></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <br />
        <div>
            <asp:GridView ID="gvAllBooks" runat="server">
            </asp:GridView>
            <asp:Label ID="lblWarning" runat="server" Text=""></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
        </p>
        <br />
        <br />
    </form>
</body>
</html>
