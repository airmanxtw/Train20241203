using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using Train20241203.Api.Extensions;
using Train20241203.DB;
using Train20241203.Models;

namespace Train20241203.Api
{
    public class Demo11
    {
        public static int n = 0;
        public static int Add() => n = n + 1;
    }

    public class DemoLinq
    {
        private readonly List<UserInfo> userInfos = new List<UserInfo>
        {
            new UserInfo { UserId = "admin", UserName = "管理員" },
            new UserInfo { UserId = "superadmin", UserName = "超级管理員" }
        };

        private readonly List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        private readonly List<int> nums2 = new List<int> { 50, 100 };


        public int plus1(int n) => n + 1;
        public int plus2(int n) => n * n;
        public int computeN(int n)=>
        (new List<int> { n })
        .Select(plus1)
        .Select(plus1)
        .Select(plus2).First();

        public IEnumerable<int> getRange()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
        

        public void Demo()
        {
            var oddNums1 = Enumerable.Where(nums, n => n % 2 == 1);
            var oddNums2 = Enumerable.Select(nums, n => n + 1);

            var oddNums3 = nums.Where(n => n % 2 == 1).Where(n => n > 10);
            var oddNums4 = nums.Where(n => n % 2 == 1).ToList().Where(n => n > 10);

            var oddNums5 = from n in nums where n % 2 == 1
                           select n;

            var oddNums6 = nums.Select(n1 => nums2.Select(n2 => n1 * n2)).SelectMany(n => n);

            var oddNums7= from n1 in nums
                          from n2 in nums2
                          select n1 * n2;

            var oddNums8 = nums.Where(n => n > 1).GetOddNums(n=> n > 10);

            //get configuration connection string

            var conn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString;

            var db = new DataClasses1DataContext(conn);

            var oddNums9 = from item in db.CounSubject select item;



            var dd = DateTime.Now.ToDateString();

            var result2 = getRange().Where(n =>n> 2);

            
            
           




















        }




    }
}