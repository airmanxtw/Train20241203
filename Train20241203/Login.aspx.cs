using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.Api;

namespace Train20241203
{
    public partial class Login : System.Web.UI.Page
    {
        public IFun2 fun2 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Api.DemoLinq demoLinq = new Api.DemoLinq();
            //demoLinq.Demo();
            var name = fun2.GetLength();


            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            #pragma warning disable CS0618 // 類型或成員已經過時
            e.Authenticated = Membership.ValidateUser(Login1.UserName, Login1.Password) || 
                              FormsAuthentication.Authenticate(Login1.UserName, Login1.Password);

            

            //var isSuper = FormsAuthentication.Authenticate(Login1.UserName, Login1.Password);
            //e.Authenticated = (Login1.UserName == "admin" && Login1.Password == "admin") || isSuper;

        }
    }
}