using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.DB;

namespace Train20241203.UC
{
    public partial class EditStud : System.Web.UI.UserControl
    {
        public delegate void InsertedHandler();
        public event InsertedHandler Inserted;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}