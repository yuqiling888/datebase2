<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal ID="Ltainfo" runat="server"></asp:Literal> <br />
        <br />
        <asp:Button ID="Btn1" runat="server" Text="获取1班和2班的人数" OnClick="Btn1_Click" />
        </form>
</body>
</html>
