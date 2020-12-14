<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FourthWebProject2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="Main.aspx" method="post">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="151px"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Next" Width="195px" />
        </div>
    </form>
</body>
</html>
