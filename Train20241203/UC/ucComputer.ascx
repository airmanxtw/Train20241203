<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucComputer.ascx.cs" Inherits="Train20241203.UC.ucComputer" %>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>

<p>
    x:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    y:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg" runat="server" Text="計算" OnClick="Button1_Click" />

    <button type="button">Base class</button>
</p>

