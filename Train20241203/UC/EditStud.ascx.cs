using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train20241203.DB;

namespace Train20241203.UC
{
    public partial class EditStud : System.Web.UI.UserControl
    {
        public delegate void InsertedHandler();
        public event InsertedHandler Inserted;
        public DataClasses1DataContext db { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            var errors = CheckFiled();
            if (errors.Count > 0)
            {
                MsgLabel.Text = string.Join("<br/>", errors);
                return;
            }
            else
            {
                Stud newStud = new Stud
                {
                    studNo = StudNoTB.Text,
                    studName = StudNameTB.Text,
                    score = Convert.ToInt32(ScoreTB.Text),
                    createDate = DateTime.Now,
                    classNo = StudClassDD.SelectedValue
                };
                db.Stud.InsertOnSubmit(newStud);
                try
                {
                    //db.SubmitChanges();
                    MsgLabel.Text = "新增成功";
                    Inserted?.Invoke();

                }
                catch (Exception ex)
                {
                    MsgLabel.Text = string.Format("發生錯誤:{0}", ex.Message);
                }
            }
        }

        private List<string> CheckFiled()
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(StudNoTB.Text))
            {
                errors.Add("Student Number is required");
            }
            if (string.IsNullOrWhiteSpace(StudNameTB.Text))
            {
                errors.Add("請輸入姓名");
            }

            return errors;
        }

        string result = "";

        public int GetScore() => 100;

        public string GetResult(int score)=> score >= 60 ? "及格" : "不及格";

        // 執行副作用
        public void DoEffect()
        {
            result = GetResult(GetScore());
        }



    }
}