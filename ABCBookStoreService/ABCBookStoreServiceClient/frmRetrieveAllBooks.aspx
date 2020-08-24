﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRetrieveAllBooks.aspx.cs" Inherits="ABCBookStoreServiceClient.frmRetrieveAllBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Retrieve All Book Info</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="title" runat="server" Text="List of All Books" ></asp:Label>
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
