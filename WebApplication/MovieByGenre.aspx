<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieByGenre.aspx.cs" Inherits="WebApplication.MovieByGenre" %>
<%@ OutputCache Duration="20" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cache is implemented in this page.<br />
        <br />
&nbsp;Enter the genre of the movie&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="133px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem Value="28">Action</asp:ListItem>
            <asp:ListItem Value="10749">Romance</asp:ListItem>
            <asp:ListItem Value="18">Comedy</asp:ListItem>
            <asp:ListItem Value="22">Adventure</asp:ListItem>
            <asp:ListItem Value="16">Science Fiction</asp:ListItem>
            <asp:ListItem Value="14">War</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
