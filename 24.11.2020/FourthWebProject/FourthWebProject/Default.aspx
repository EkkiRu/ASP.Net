<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FourthWebProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Product.aspx?id2" runat="server">Карандаш</asp:HyperLink><br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Product.aspx?id1" runat="server">Ручка</asp:HyperLink><br />
            <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Product.aspx?id3" runat="server">Мобильник</asp:HyperLink><br />
            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Product.aspx?id4" runat="server">Машина</asp:HyperLink><br />
        </div>
    </form>
</body>
</html>
