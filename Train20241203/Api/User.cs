using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using Train20241203.Models;

namespace Train20241203.Api
{
    public class User
    {
        private const string key= "User20241210";
        public static UserInfo GetUserInfo(string userid)
        {            
            if (HttpContext.Current.Session[key] == null)
            {
                return new UserInfo
                {
                    UserId = userid,
                    UserName = userid == "superadmin" ? "超级管理員" : "管理員"
                };
            }
            return (UserInfo)HttpContext.Current.Session[key];
        }
    }
}