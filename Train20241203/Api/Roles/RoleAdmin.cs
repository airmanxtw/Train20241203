using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Roles
{
    public class RoleAdmin : RoleBase
    {
        public RoleAdmin(string _userid) : base(_userid)
        {
        }
        public override string GetRole()
        {
            return "ADMIN";
        }
        public override bool IsInRole()
        {
            return  userid == "admin";
        }
    }
   
    
}