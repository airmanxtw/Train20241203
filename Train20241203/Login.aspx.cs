﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var isSuper = FormsAuthentication.Authenticate(Login1.UserName, Login1.Password);
            e.Authenticated = (Login1.UserName == "admin" && Login1.Password == "admin") || isSuper;
    
        }
    }
}