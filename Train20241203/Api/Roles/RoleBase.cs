using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Roles
{
    public abstract class RoleBase
    {
        protected readonly string userid;
        public RoleBase(string _userid)
        {
            userid = _userid;
        }

        public abstract bool IsInRole();
        public abstract string GetRole();

      


    }
}