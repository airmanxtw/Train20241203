using Autofac;
using Autofac.Integration.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.Api;

namespace Train20241203
{
    public partial class Add : System.Web.UI.Page
    {
        public ICrypt crypt { get; set; }
        public IBBClass bbClass { get; set; }

        public AdminMethods adminMethods { get; set; }




        protected void Page_Load(object sender, EventArgs e)
        {
           

            var r=crypt.Encrypt("abc");
            var x =bbClass.Echo("abc");

            var y = adminMethods.GetLength("abc");


            //var container = builder.Build();
            //var t = container.IsRegistered<ICrypt>();


            ucComputer1.SetFormulas((float a, float b) => a + b);
        }

        protected void ucComputer1_Compute(float result)
        {
            Label1.Text = result.ToString();
        }
    }
}