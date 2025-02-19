<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Train20241203.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" OnLoggedIn="Login1_LoggedIn" MembershipProvider="MyMemberShipProvider">
            <LayoutTemplate>
              
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table cellpadding="0">
                                <tr>
                                    <td align="center" colspan="2">登入</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">使用者名稱:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="必須提供使用者名稱。" ToolTip="必須提供使用者名稱。" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">密碼:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="必須提供密碼。" ToolTip="必須提供密碼。" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="記憶密碼供下次使用。" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="登入" ValidationGroup="Login1" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:Login>       
    </p>

     <div class="animate__animated animate__flash animate__infinite" id="testdiv">hello</div>


     <button id="testBtn">選擇</button>
     <span>hello herre</span>

     <button id="testBtn2">選擇2</button>
    <%-- <div id="dialog-form" title="Create new user">
        <p class="validateTips">All form fields are required.</p>
        <fieldset>
          <label for="name">Name</label>
          <input type="text" name="name" id="name" value="Jane Smith" class="text ui-widget-content ui-corner-all">
          <label for="email">Email</label>
          <input type="text" name="email" id="email" value="jane@smith.com" class="text ui-widget-content ui-corner-all">
          <label for="password">Password</label>
          <input type="password" name="password" id="password" value="xxxxxxx" class="text ui-widget-content ui-corner-all">
 
          <!-- Allow form submission with keyboard without duplicating the dialog button -->
          <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
        </fieldset>  
    </div>--%>

   
   
    


     
    <script>
        $(document).ready(function () {

            //eval("javascript:alert('hello')");

            //var timeId;
            //$("#Button1").attr("type", "button").click(function () {
            //    if (!!timeId) {
            //        clearTimeout(timeId);
            //    }
            //    timeId = setTimeout(function () {
            //        __doPostBack("ctl00$ContentPlaceHolder1$Button1", "");
            //    }, 2000);

            //})

            $("#Button1").DeBounceBtn();


            $("#Button1,#Button2").DeBounceBtn();





            //#testBtn
            var data = [{ id: 123, text: '顏大鈞' }, { id: 124, text: '顏小鈞' }, { id: 125, text: '王大頭' }]

            $("body").SelectItemDialog({
                title: "大金系統",
                headers: [{ key: 'id', title: '編號', width: '70px', align: 'center' }, { key: 'text', title: '名稱', align: 'left' }],
                items: $.extend([], data),
                selectLimit: 2,
                searchKeyCallBack: function (key) {
                    $("body").SelectItemDialog("setItems", $.grep(data, function (d) {
                        return d.text.indexOf(key) >= 0
                    }));
                },
                confirmCallBack: function (data) {
                    var t = $("body").SelectItemDialog("joinItem", { items: data, key: 'text', separator: "," });
                    $("body").SelectItemDialog("closeDialog");
                },
                closeCallBack: function () {
                    $("body").SelectItemDialog("closeDialog");
                }
            });

            $("#testBtn").click(function (event) {
                //$("body").SelectItemDialog("option", "title", "hello");
                $("body").SelectItemDialog("setItems", [{ id: 124, text: '顏X鈞' }, { id: 125, text: '顏D鈞' }, { id: 126, text: '王E頭' }])
                $("body").SelectItemDialog("openDialog");
                event.preventDefault();
            })

            $("#amountDiv").AmountSendConfirm({
                title: "提示訊息",                
                confirmBtnText:"已詳讀事項並確定完成填表"
            })
            
            $(".LB").click(function (e) {                
                e.preventDefault();
                $("#amount").AmountSendConfirm("option", { script: $(this).attr("href"), message:"<h2>溫馨的提醒您</h2><div style='font-size:24px'>自113學年度第2學期起，撥款清冊及出差旅費報告單完成校內流程後，請至帳務請購系統進行代墊核銷之動支，並於<strong>撥款清冊上填寫核銷單號</strong>再送入會計室撥款。</div>" });   
                $("#amount").AmountSendConfirm("openDialog");
                
            })

            document
                .getElementById("Button3Div")
                .addEventListener("click", function (e) {   
                    alert('button3div')
                    event.preventDefault();
                    $("#Button3").trigger("submit");
                    //$("#amount").AmountSendConfirm("openDialog");
                    //event.stopPropagation();                    
                }, true)

            //document
            //    .getElementById("Button4Div")
            //    .addEventListener("click", function (e) {
            //        alert("button4div")
            //        //event.stopPropagation();

            //    }, false)

            //$("#Button3Div").on("click", { capture: true }, function (event) {
            //    debugger;
            //    event.stopPropagation();

            //    $("#amount").AmountSendConfirm("openDialog");
            //})



            //$("#sdiv").scrollTop(parseInt($("#TopHF").val()));

            //$("#sdiv").scroll(function (event) {                
            //    $("#TopHF").val($(this).scrollTop())
            //})


            //$("#scrollBtn").click(function () {
            //    // get the scroll position
            //    var scrollPosition = $("#sdiv").scrollTop();
            //    $("#TopHF").val(scrollPosition);
            //})
           
        });      
    </script>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" ClientIDMode="Static" OnClick="Button1_Click"  />
        <asp:Button ID="Button2" runat="server" ClientIDMode="Static" OnClick="Button2_Click" Text="Button2" />
        <div id="Button3Div">
               <asp:Button ID="Button3" runat="server" ClientIDMode="Static" Text="Button3" OnClick="Button3_Click" />       
        </div>
        <div id="Button4Div">
            Button4Div
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="LB" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        
    </div>
    <div id="amountDiv">

    </div>


    <div runat="server" id="sdiv" style="height:100px;width:300px;overflow:scroll">
        <p>
            陳石輝表示，受到台積電法說會利多消息影響，台股今日開盤呈現上漲百點的格局。然而，由於農曆新年封關在即，市場籌碼出現一定程度的調節壓力，使指數波動幅度有所收斂。預計在接下來的幾個交易日內，台股將以23000點為中心上下震盪，成交量則維持在約3000億元的水準。

陳石輝指出，昨日台積電法說會調高資本支出，相關供應鏈如弘塑（3131）、萬潤（6187）、辛耘（3583）也因此受惠，今日股價整齊反彈。然而，由於台股即將封關，外資與國內法人在高檔位置進行獲利了結，市場仍須警惕短線回檔風險。

陳石輝表示，外資近來動態偏向低檔買進、高檔調節，同時期貨空單部位也在逐步減少，顯示對未來市場趨勢的看法逐漸樂觀。但由於假期間可能存在的國際變數，部分投資人選擇透過指數期貨空單避險，導致籌碼面仍有一定的不確定性。

除了台積電，陳石輝進一步分析，AI伺服器及機器人產業是2025年開春後的市場焦點，輝達即將在3月舉行GTC頂尖人工智慧大會，預期將對AI伺服器與機器人應用有進一步闡述，屆時有望帶動相關個股表現。

然而，他也提醒，投資人應避免在高檔追高。以近期表現強勢的矽光子相關個股為例，部分已經連漲數日，需謹慎操作，等待回檔後再行進場。相較之下，機器人股如和椿（6215）經過整理後的買點相對具吸引力。
        </p>
    </div>
    <button id="scrollBtn">get</button>
    <asp:HiddenField ID="TopHF" runat="server" ClientIDMode="Static" Value="0" />
    </asp:Content>
