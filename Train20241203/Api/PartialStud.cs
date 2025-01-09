using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Train20241203.DB
{
     public partial class Stud
    {
        public string ClassName 
        { 
            get
            {
                return SchoolClass?.className;
            } 
        }
        public string ScoreResult
        {
            get
            {
                return score >= 60 ? "及格" : "不及格";
               
            }
        }

        public string ScoreResultClass
        {
            get
            {
                return score >= 60 ? "" : "animate__animated animate__flash animate__fast animate__infinite";
            }
        }

        public string StudName(string extName)
        {
            return $"{studName} {extName}";
        }


    }
}