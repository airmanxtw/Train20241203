using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Red;
            Button1.ForeColor = System.Drawing.Color.White;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}