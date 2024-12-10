using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Roles
{
    public class RoleSUPERADMIN : RoleBase
    {
        public RoleSUPERADMIN(string _userid) : base(_userid)
        {
        }
        public override string GetRole()
        {
            return "SUPERADMIN";
        }
        public override bool IsInRole()
        {
            return userid == "superadmin";
        }
    }
   
}