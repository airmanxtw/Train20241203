using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203.Pages
{
    public partial class DemoDialog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OpenButton_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
            DiaLogStateHF.Value = "1";
        }

        protected void CloseButton2_Click(object sender, EventArgs e)
        {
            DiaLogStateHF.Value = "0";
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Parse(TimeLabel.Text).AddHours(1).ToString();
        }
    }
}