using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
namespace Train20241203
{
    /// <summary>
    /// MyValid 的摘要描述
    /// </summary>
    public class MyValid : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var js =new JavaScriptSerializer();
            context.Response.ContentType = "application/json";
            var name = context.Request["name"].ToString();
            var valid = name.StartsWith("顏");
            context.Response.Write(js.Serialize(valid));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}