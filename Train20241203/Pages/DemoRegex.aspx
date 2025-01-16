<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DemoRegex.aspx.cs" Inherits="Train20241203.Pages.DemoRegex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    email:<asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
    <asp:RegularExpressionValidator ID="Regu1" runat="server" ErrorMessage="請輸入正確的Email" ControlToValidate="TextBox1" ValidationExpression="^[^\s@]+@[^\s@]+\.[^\s@]+$"></asp:RegularExpressionValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
