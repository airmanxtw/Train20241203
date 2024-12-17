using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api
{
    public class Fun2 : IFun2
    {
        private readonly IFun _fun;
        public Fun2(IFun fun)
        {
            _fun = fun;
        }
        public int GetLength()
        {
            return _fun.GetName().Length;
        }
    }
}