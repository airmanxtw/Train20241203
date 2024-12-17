using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Train20241203.DB;
namespace Train20241203.Api
{
    public partial class CounMaster
    {
        public string Text
        {
            get
            {
                Stud1 stud1 = new Stud1();
                
                return "";
            }
        }
    }

    public partial class Stud1
    {
        public string no { get; set; }
        public string name { get; set; }
    }

    public partial class Stud1
    {
        public string text
        {
            get
            {
                return string.Format("{0} {1}", this.no, this.name);
            }
        }

    }



}