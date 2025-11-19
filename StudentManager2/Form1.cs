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

namespace StudentManager2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
