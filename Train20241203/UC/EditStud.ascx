<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditStud.ascx.cs" Inherits="Train20241203.UC.EditStud" %>
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

                <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckName" ControlToValidate="StudNameTB" ErrorMessage="必須姓顏" Font-Bold="True" ForeColor="#CC0000"></asp:CustomValidator>

            </td>
        </tr>
        <tr>
            <td class="right">
                成績:
            </td>
            <td class="left">

                <asp:TextBox ID="ScoreTB" runat="server" TextMode="Number" ></asp:TextBox>

                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ScoreTB" ErrorMessage="請輸入0~100" ForeColor="#CC0000"></asp:RangeValidator>

            </td>
        </tr>
        <tr>
            <td class="right">
                班級:
            </td>
            <td class="left">
                <asp:DropDownList ID="StudClassDD" runat="server" DataSourceID="LinqDataSource1" DataTextField="className" DataValueField="classNo">
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Train20241203.DB.DataClasses1DataContext" EntityTypeName="" TableName="SchoolClass">
                </asp:LinqDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="InsertButton" runat="server" Text="新增" />
                <div style="margin-top:3px">
                    <asp:Label ID="MsgLabel" runat="server" Text="" EnableViewState="False" ForeColor="#CC0000" Font-Bold="True"></asp:Label>
                </div>
            </td>
        </tr>

    </table>
</div>

