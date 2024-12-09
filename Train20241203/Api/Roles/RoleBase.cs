using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Roles
{
    public abstract class RoleBase
    {
        protected readonly string _userid;
        public RoleBase(string userid)
        {
            _userid = userid;
        }

        abstract public bool IsRole();
        abstract public string GetRole();
    }
}