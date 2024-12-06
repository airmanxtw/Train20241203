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
            //Button1.Attributes.Add("style", "background-color: #4CAF50; color: white; padding: 14px 20px; margin: 8px 0; border: none; cursor: pointer; width: 100%;");
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