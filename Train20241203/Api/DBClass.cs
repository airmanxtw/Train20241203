using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public class DBClass : IDBClass
    {
        private string connectionString;
        public DBClass(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Echo()
        {
            throw new NotImplementedException();
        }
    }
}