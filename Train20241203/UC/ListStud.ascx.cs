using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.DB;

namespace Train20241203.UC
{
    public partial class ListStud : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if (((Stud)e.Row.DataItem).score < 60)
                    e.Row.CssClass = "ui-state-error";

            }
           
        }
    }
}