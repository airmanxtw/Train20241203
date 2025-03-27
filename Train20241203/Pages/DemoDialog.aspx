<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DemoDialog.aspx.cs" Inherits="Train20241203.Pages.DemoDialog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        dialog::backdrop {
            background-color: rgba(0, 0, 0, 0.5);
            backdrop-filter: blur(2px);            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Button ID="OpenButton" runat="server" Text="打開Dialog,並填入Server時間" OnClick="OpenButton_Click" />

    <dialog id="timeDialog" style="width:500px">        
        <h2>Server時間</h2>
        <asp:Label ID="TimeLabel" runat="server" Text="TimeLabe" ForeColor="#0066FF" Font-Bold="True"></asp:Label>
        <div style="text-align:center">
            <span>
               <asp:Button ID="AddButton" runat="server" Text="加一個小時" OnClick="AddButton_Click" />
            </span>            
            <span style="margin-left:10px">
                <asp:Button ID="CloseButton2" runat="server" Text="關閉Dialog" OnClick="CloseButton2_Click" />
            </span>            
        </div>        
    </dialog>


    <asp:HiddenField ID="DiaLogStateHF" runat="server" Value="0" ClientIDMode="Static" />

    <script>        
        if (document.getElementById("DiaLogStateHF").value == "1")
            document.getElementById("timeDialog").showModal();
        
    </script>
</asp:Content>
