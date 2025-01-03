using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Train20241203.DB;


namespace Train20241203.DB
{
    public partial class DataClasses1DataContext : System.Data.Linq.DataContext
    {
        public DataClasses1DataContext() : base(ConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString, mappingSource)
        {
            
        }
    }
}