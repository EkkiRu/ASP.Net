﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="" ></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="+1" Width="49px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="+2" Width="46px" OnClick="Button2_Click" />



        </div>
    </form>
</body>
</html>
