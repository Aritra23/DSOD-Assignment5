<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFocus.aspx.cs" Inherits="WebApplication.NewsFocus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
&nbsp; Select a news category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="148px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Sports</asp:ListItem>
            <asp:ListItem>Music</asp:ListItem>
            <asp:ListItem>Politics</asp:ListItem>
            <asp:ListItem>Education</asp:ListItem>
            <asp:ListItem>Fashion</asp:ListItem>
            <asp:ListItem>World</asp:ListItem>
            <asp:ListItem>Movies</asp:ListItem>
            <asp:ListItem>Regional</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
