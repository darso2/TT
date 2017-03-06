<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="edittable" runat="server">
        Name:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        Address:&nbsp; <asp:TextBox ID="TextBox2" runat="server" style="margin-top: 0px; margin-bottom: 0px" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" onServerClick="Button1_Click" OnClick="Button1_Click" style="height: 26px" />
    </div>
    </form>
</body>
</html>
