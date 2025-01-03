﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditStud.ascx.cs" Inherits="Train20241203.UC.EditStud" %>
<style>
    .left {
        text-align: left;
    }
    .right{
        text-align:right
    }
</style>
<div style="width:100%">
    <table style="border-style: solid; border-width: 1px; width:400px; margin-left:auto; margin-right:auto">
        <tr>
            <td class="right">
                學號:
            </td>
            <td class="left">
                <asp:TextBox ID="StudNoTB" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="StudNoTB" ErrorMessage="請輸入學號" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="right">
                姓名:
            </td>
            <td class="left">

                <asp:TextBox ID="StudNameTB" runat="server"></asp:TextBox>

                <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckName" ControlToValidate="StudNameTB" ErrorMessage="必須姓顏" Font-Bold="True" ForeColor="#CC0000" ValidateEmptyText="True"></asp:CustomValidator>

            </td>
        </tr>
        <tr>
            <td class="right">
                成績:
            </td>
            <td class="left">

                <asp:TextBox ID="ScoreTB" runat="server" TextMode="Number" ></asp:TextBox>

                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ScoreTB" ErrorMessage="請輸入0~100" ForeColor="#CC0000" Display="Dynamic" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ScoreTB" Display="Dynamic" ErrorMessage="請輸入" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td class="right">
                班級:
            </td>
            <td class="left">
                <asp:DropDownList ID="StudClassDD" runat="server" DataSourceID="LinqDataSource1" DataTextField="className" DataValueField="classNo" AppendDataBoundItems="True">
                    <asp:ListItem Selected="True" Value="-1">==請選擇==</asp:ListItem>
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Train20241203.DB.DataClasses1DataContext" EntityTypeName="" TableName="SchoolClass">
                </asp:LinqDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="StudClassDD" ErrorMessage="請選擇班級" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="InsertButton" runat="server" Text="新增" OnClick="InsertButton_Click" />
                <div style="margin-top:3px">
                    <asp:Label ID="MsgLabel" runat="server" Text="" EnableViewState="False" ForeColor="#CC0000" Font-Bold="True"></asp:Label>
                </div>
            </td>
        </tr>

    </table>
</div>

