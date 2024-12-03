using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ucComputer1.SetFormulas((float a, float b) => a + b);
        }

        protected void ucComputer1_Compute(float result)
        {
            Label1.Text = result.ToString();
        }
    }
}