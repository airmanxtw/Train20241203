<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DemoStud.aspx.cs" Inherits="Train20241203.DemoStud" %>
<%@ Register Src="~/UC/EditStud.ascx" TagName="editStud" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:editStud ID="editStud1" runat="server" />
</asp:Content>
