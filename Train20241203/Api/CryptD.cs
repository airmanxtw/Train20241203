using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public class CryptD : ICrypt
    {
        public string Encrypt(string str)
        {
            // SHA256
            return str;
        }
    }
}