using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Roles
{
    public class RoleAdmin : RoleBase
    {
        public RoleAdmin(string userid) : base(userid)
        {
        }

        public override string GetRole()
        {            
            return "ADMIN";
        }

        public override bool IsRole()=> _userid == "admin";
      
    }
}