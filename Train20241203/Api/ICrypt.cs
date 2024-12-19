using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public interface ICrypt
    {
        string Encrypt(string str);
    }
}