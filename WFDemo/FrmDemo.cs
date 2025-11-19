using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using StudentManagermo;


namespace StudentManager
{
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {
            InitializeComponent();
            string connString = DAL.SQLHelper.connString;
            //显示用户名
            this.lblCurretUser.Text = Program.ObjCurrentAdmin.AdminName;


        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            StudentServer objStuServer = new StudentServer();
            int Class1 = objStuServer.GetStuCountByClassId("1");
            int Class2 = objStuServer.GetStuCountByClassId("2");
            this.lblnfo.Text = string.Format("1班的学生总数为{0}   2班的学生总数为{1}", Class1, Class2);
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
