﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Train20241203.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            +<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            =<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="計算" OnClick="Button1_Click" />
    </form>
</body>
</html>
