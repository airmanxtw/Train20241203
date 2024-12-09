using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Provider
{
    public class MySiteMapProvider: XmlSiteMapProvider
    {
        public override bool IsAccessibleToUser(HttpContext context,SiteMapNode node)=>
        node.Roles != null
        && node.Roles.Count != 0
        && context.User.Identity.IsAuthenticated
        && ((ArrayList)node.Roles).Cast<string>().ToArray().ToList().Select(r => r == "*" || context.User.IsInRole(r)).Any(b=>b);
      
    }
}