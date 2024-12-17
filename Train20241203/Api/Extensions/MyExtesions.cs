using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train20241203.Api.Extensions
{
    public static  class MyExtesions
    {
        public static string ToDateString(this DateTime dt)
        {
            return string.Format("{0:yyyy/MM/dd}", dt);
        }

        public static string GetOddNums(this IEnumerable<int> nums,Func<int,bool> f)
        {
            return string.Join(",", nums.Where(n => n % 2 == 1).Where(f));
        }
    }
}