<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="WebApplication1.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Записать в VievState" style ="margin-right:30px" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Прочесть из VievState" OnClick="Button2_Click" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="204px"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="203px"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
