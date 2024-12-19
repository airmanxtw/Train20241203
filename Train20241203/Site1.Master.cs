using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public Api.AdminMethods adminMethods { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                //useridLabel.Text = HttpContext.Current.User.Identity.Name;
                //useridLabel.Text = HttpContext.Current.Session["UserName"]!=null ? HttpContext.Current.Session["UserName"].ToString() : HttpContext.Current.User.Identity.Name;

                useridLabel.Text = Api.User.GetUserInfo(HttpContext.Current.User.Identity.Name).UserName;

                var b= HttpContext.Current.User.IsInRole("admin");

                if(b)
                    adminMethods.SetMethod((str) => str.Length*999);

            }
        }
    }
}