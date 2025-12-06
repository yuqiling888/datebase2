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
        private StudentClassService objStudentClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        public AddStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1; //默认不选中
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objFrmAddStudent = null;
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证

            if(this.tbStudetName.Text.Trim().Length==0)
            {
                MessageBox.Show("学生姓名不能为空","提示信息");
                tbStudetName.Focus();
                return;
            }
            //其它非空验证
            if (!this.rdoMale.Checked && !this.rdoFeMale.Checked)
            {
                MessageBox.Show("请选择学员性别", "提示信息");
                return;
            }
            if(cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }
            if(this.tbIdentityCard.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入身份证号", "提示信息");
                return;
            }
            //验证身份证格式是否正确
            if (!Common.DataValidate.IsIdentityCard(this.tbIdentityCard.Text.Trim()))
            {
                MessageBox.Show("身份证号有误！", "验证提示");
                this.tbIdentityCard.Focus();
                return;
            }
            //验证身份证是否重复
            if(objStudentService.IsIdNoExisted(this.tbIdentityCard.Text.Trim()))
            {
                MessageBox.Show("身份证不能和现在学员重复，请认真检查", "验证提示");
                this.tbIdentityCard.Focus();
                this.tbIdentityCard.SelectAll();
                return;
            }
            //验证身份证号和出生日期是否吻合
            //验证出生日期
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if(age<18||age>35)
            {
                MessageBox.Show("年龄必面在18到35岁之间", "提示信息");
                return;
            }

            #endregion
            #region 封装学生对象
            Students objStudents = new Students()
            {
                StudentName = this.tbStudetName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = Convert.ToDecimal(this.tbIdentityCard.Text.Trim()),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.tbPhoneNumber.Text.Trim(),
                StudentAddress = this.tbStudentAdderss.Text.Trim(),
                ClassId=Convert.ToInt32( this.cboClassName.SelectedValue)
            };

            #endregion
            #region 调用后台数据访问方法
            try
            {
                if(objStudentService.AddStudent(objStudents)==1)
                {
                    DialogResult result = MessageBox.Show("新学员添加成功，是否继续添加", "信息提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)//清空用户输入
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoMale.Checked = false;
                        rdoFeMale.Checked = false;
                        //清除文本信息
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                        }
                        this.tbStudetName.Focus();


                    }
                    else
                        this.Close();

                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
            }
            
            #endregion
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
