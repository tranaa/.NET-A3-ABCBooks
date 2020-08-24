<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDeleteBook.aspx.cs" Inherits="ABCBookStoreServiceClient.frmDeleteBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Book Info</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="title" runat="server" Text="Delete Book"></asp:Label>
        <br /><br />
        <div class="input" runat="server">
            <asp:Label ID="lblISBNNumber" runat="server" Text="ISBN Number: "></asp:Label><br/>
            <asp:TextBox ID="txtISBNNumber" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" Text="Delete Book" OnClick="btnDelete_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvAllBooks" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
        <br />
        <br />
    </form>
</body>
</html>
