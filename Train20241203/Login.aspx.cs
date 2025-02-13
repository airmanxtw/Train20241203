using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.Api;
using Train20241203.DB;
using Train20241203.Models;

namespace Train20241203
{
    public partial class Login : System.Web.UI.Page
    {
      

        public ICrypt crypt { get; set; }
        public IBBClass bbClass { get; set; }

        public DBClass dbc { get; set; }

        public DataClasses1DataContext dc { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            


            //Api.DemoLinq demoLinq = new Api.DemoLinq();
            //demoLinq.Demo();
            var s= crypt.Encrypt("abc");  
            var n = bbClass.Echo("abc");

           

            var result = Enumerable.Range(1, 10)
                         .Select(a => Enumerable.Range(1, 10).Select(b => Enumerable.Range(1, 10).Select(c => Tuple.Create(a, b, c))))
                         .SelectMany(x => x)
                         .SelectMany(x => x)
                         .Where(t => Math.Pow(t.Item1, 2) + Math.Pow(t.Item2, 2) == Math.Pow(t.Item3, 2) && (t.Item1+t.Item2+t.Item3==24) );

            var reulst2 = from a in Enumerable.Range(1, 10)
                          from b in Enumerable.Range(1, 10)
                          from c in Enumerable.Range(1, 10)
                          where Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && (a + b + c == 24)
                          select Tuple.Create(a, b, c);

            var result3 = dbc.Echo();

            
            
          


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

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            var s = User.Identity.Name;
            int? i = 100;
            var i2 = i?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(s?.Trim()))
            {
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text="hello:" + DateTime.Now.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToString();  
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToString();
        }
    }
}