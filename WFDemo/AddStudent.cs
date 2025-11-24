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
using DAL.Models;


namespace StudentManager
{
    public partial class AddStudent : Form
    {
        private StudentClassService objStudentService = new StudentClassService();
        public AddStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objFrmAddStudent = null;
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Common.DataValidate.IsIdentityCard(this.tbIdentityCard.Text.Trim()))
            {
                MessageBox.Show("身份证号有误！", "验证提示");
                this.tbIdentityCard.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
