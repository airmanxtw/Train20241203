<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sub.aspx.cs" Inherits="Train20241203.Sub" %>
<%@ Register Src="~/UC/ucComputer.ascx" TagName="ucComputer" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <uc1:ucComputer  ID="ucComputer1" runat="server" OnCompute="ucComputer1_Compute" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   
    </asp:Content>
