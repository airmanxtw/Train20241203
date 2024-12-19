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
    public partial class Logout : System.Web.UI.Page
    {
        public ICrypt crypt { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var t=crypt.Encrypt("abc");
            FormsAuthentication.SignOut();
        }
    }
}