<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLandingPage.aspx.cs" Inherits="ABCBookStoreServiceClient.frmLandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Landing Page</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" style="text-align:Center;">
        <asp:Label ID="title" runat="server" Text="ABC Bookstore"></asp:Label>
        <p>
            Assignment No.: 4<br />
            Course Code: PROG32356<br />
            Your Name: Aaron Tran<br />
            Your Id: 991525227<br />
            Instructor’s name: Syed Tanbeer
        </p>
        <asp:Label ID="menu" runat="server" Text="Main Menu:"></asp:Label>
        <br /><br />
        <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        <br /><br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert Book" OnClick="btnInsert_Click" />
        <br /><br />
        <asp:Button ID="btnViewAll" runat="server" Text="Show All Books" OnClick="btnViewAll_Click" />
        <br /><br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Book" OnClick="btnUpdate_Click" />
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete Book" OnClick="btnDelete_Click" />
        <br /><br />
        <asp:Button ID="btnViewByAuthor" runat="server" Text="Book List By Author" OnClick="btnViewByAuthor_Click" />
        <br /><br />
        <asp:Button ID="btnViewByPublisher" runat="server" Text="Book Info By Publisher" OnClick="btnViewByPublisher_Click" />
        <br /><br />
        <asp:Button ID="btnViewByPrice" runat="server" Text="Book Info By Min Price" OnClick="btnViewByPrice_Click" />
        <br /><br />
        <asp:Button ID="btnViewByDate" runat="server" Text="Book Info By Min Date" OnClick="btnViewByDate_Click" />
        <br />
        <br />
    </form>
</body>
</html>
