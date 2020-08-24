<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmShowBooksByAuthor.aspx.cs" Inherits="ABCBookStoreServiceClient.frmShowBooksByAuthor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book List By Author</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="title" runat="server" Text="Book List By Author"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblAuthor" runat="server" Text="Author: "></asp:Label>
        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
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
