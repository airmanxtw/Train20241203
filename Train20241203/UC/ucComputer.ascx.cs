using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train20241203.UC
{
    public partial class ucComputer : System.Web.UI.UserControl
    {
        public delegate void ComputeHandler(float result);
        public event ComputeHandler Compute;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Func<float, float, float> Formula { get; set; } = null;
        public void SetFormulas(Func<float, float, float> formula)
        {
            Formula = formula;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Compute != null)
            {
                var result = Formula(float.Parse(TextBox1.Text), float.Parse(TextBox2.Text));
                Compute(result);
            }
        }
    }
}