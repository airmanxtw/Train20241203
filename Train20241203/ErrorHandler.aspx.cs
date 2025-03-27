using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203
{
    public partial class ErrorHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var msg = Request.QueryString["msg"].ToString();
                ErrorLabel.Text = msg;
            }
        }
    }
}