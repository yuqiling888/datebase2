using datebase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            StudentServer objStuServer = new StudentServer();
            int Class1 = objStuServer.GetStuCountByClassId("1");
            int Class2 = objStuServer.GetStuCountByClassId("2");
            this.Ltainfo.Text = string.Format("1班的学生总数为{0}   2班的学生总数为{1}", Class1, Class2);
        }
    }
}