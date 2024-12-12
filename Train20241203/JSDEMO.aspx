<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="JSDEMO.aspx.cs" Inherits="Train20241203.JSDEMO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='demodiv'></div>
    <hr />
    <button id="sb">setB</button>
    <script>
        $(document).ready(function () {
            $("#demodiv").Cal({
                a: 1, b: 2,
                formula: function (a, b) { return a - b },
                resultCallBack: function (result) {
                    alert(result);
                }
            });

            $("#sb").click(function (event) {
                
                $("#demodiv").Cal("setB", 1999);
                event.preventDefault();
            })

        });
        
    </script>
</asp:Content>
