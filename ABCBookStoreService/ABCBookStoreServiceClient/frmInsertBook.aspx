<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInsertBook.aspx.cs" Inherits="ABCBookStoreServiceClient.frmInsertBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Book Info</title>
    <link href="Styles/index.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="title" runat="server" Text="Insert Book"></asp:Label>
        <br />
        <br />
        <div class="input" runat="server">
            <asp:Label ID="lblBookTitle" runat="server" Text="Book Title: "></asp:Label><br/>
            <asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblAuthorList" runat="server" Text="Author List: "></asp:Label><br/>
            <asp:TextBox ID="txtAuthorList" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblISBNNumber" runat="server" Text="ISBN Number: "></asp:Label><br/>
            <asp:TextBox ID="txtISBNNumber" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblPublishingDate" runat="server" Text="Publishing Date (yyyy-mm-dd): "></asp:Label><br/>
            <asp:TextBox ID="txtPublishingDate" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblPublisher" runat="server" Text="Publisher: "></asp:Label><br/>
            <asp:TextBox ID="txtPublisher" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblPageCount" runat="server" Text="Page count: "></asp:Label><br/>
            <asp:TextBox ID="txtPageCount" runat="server"></asp:TextBox>
        </div>
        <div class="input" runat="server">
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label><br/>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>  
        </div>
        <asp:Button ID="btnInsert" runat="server" Text="Insert Book" OnClick="btnInsert_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
        <br />
        <br />
    </form>
</body>
</html>
