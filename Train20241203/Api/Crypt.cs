using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public class Crypt : ICrypt
    {
        // md5加密
        public string Encrypt(string str)
        {
            // md5 
            //return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");

            // sha1
            //return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "SHA1");

            // sha256
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "SHA256");
        }

    }
}