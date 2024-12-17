using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Train20241203.DB
{
     public partial class Stud
    {
        public string ClassName 
        { 
            get
            {
                return SchoolClass?.className;
            } 
        }
    }
}