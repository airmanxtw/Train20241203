﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    
    public class AdminMethods
    {
        public Func<string, int> GetLength = (str) => str.Length;
        public void SetMethod(Func<string, int> method)
        {
            GetLength = method;
        }

    }
}