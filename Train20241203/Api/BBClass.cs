using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public class BBClass : IBBClass
    {
        public ICrypt Crypt { get; set; }

        public BBClass(ICrypt crypt)
        {
            Crypt = crypt;
        }
        public int Echo(string str)
        {
           return Crypt.Encrypt( str).Length;
        }
    }
}