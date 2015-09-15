<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        This is the home page of the Online Movie Information . Here you can see the links of the web services that are being implemented by us during the course of the project work.<br />
        <br />
        The links to the web services are given below.<br />
        <br />
        <br />
        1. The information of movies based by genre is given here&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get" Width="59px" />
        <br />
        <br />
        <br />
        2. The information of movies based by year is given here.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get" Width="62px" />
        <br />
        <br />
        <br />
        3. The news information about specific categories can be obtained here.&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get" Width="56px" />
        <br />
        <br />
        <br />
        4. The nearest hotel information of the specific region can be obtained here.&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text=" Get" Width="61px" />
        <br />
        <br />
        <br />
        5. The crime data rate of the particular region can be obtained here.&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get" Width="65px" />
&nbsp;
        <br />
        <br />
        <br />
        <br />
        6. The payment validation and the credit card validation.&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Text="Get" Width="45px" />
        <br />
        <br />
        <br />
        7. Find the nearest store service&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Get" Width="48px" />
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
