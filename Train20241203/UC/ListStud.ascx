<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListStud.ascx.cs" Inherits="Train20241203.UC.ListStud" %>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="studNo" DataSourceID="LinqDataSource1" GridLines="Horizontal" Width="100%">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <Columns>
        <asp:BoundField DataField="ClassName" HeaderText="班級" ReadOnly="True" SortExpression="ClassName" />
        <asp:BoundField DataField="studNo" HeaderText="學號" ReadOnly="True" SortExpression="studNo" />
        <asp:BoundField DataField="studName" HeaderText="studName" SortExpression="studName" />
        <asp:BoundField DataField="score" HeaderText="score" SortExpression="score" />
        <asp:BoundField DataField="createDate" HeaderText="createDate" SortExpression="createDate" />
        <asp:BoundField DataField="classNo" HeaderText="classNo" SortExpression="classNo" />
        <asp:TemplateField HeaderText="ScoreResult" SortExpression="ScoreResult">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ScoreResult") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" CssClass='<%# Eval("ScoreResultClass") %>' Text='<%# Bind("ScoreResult") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
      
    </Columns>
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>
<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Train20241203.DB.DataClasses1DataContext" EntityTypeName="" TableName="Stud">
</asp:LinqDataSource>


