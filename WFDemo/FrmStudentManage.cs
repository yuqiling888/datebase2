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
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        public FrmStudentManage()
        {
            InitializeComponent();
            this.comboBoxStudentClass.DataSource = objClassService.GetAllClasses();
            this.comboBoxStudentClass.DisplayMember = "ClassName";
            this.comboBoxStudentClass.ValueMember = "ClassId";
            this.comboBoxStudentClass.SelectedIndex = -1; //默认不选中
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            StudentService objStudentService = new StudentService();
            if(comboBoxStudentClass.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级", "信息提示");
                return;
            }
           //this.dataGridViewStudentList.AutoGenerateColumns = false;//禁止生成其它列
            //执行查询

            this.dataGridViewStudentList.DataSource = objStudentService.GetStudentByClass(this.comboBoxStudentClass.Text);
        }

        private void buttonSubmitQuery_Click(object sender, EventArgs e)
        {
            if(this.textBoxInStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入学号", "信息提示");
                this.textBoxInStudentId.Focus();
                return;
            }
            //进一步验证输入必须是数字，（请使用正则表达式.......）
            ExtStudent objStudent = objStudentService.GetStudentByStudentId(this.textBoxInStudentId.Text.Trim());
            if(objStudent==null)
            {
                MessageBox.Show("学员信息不存在", "信息提示");
                this.textBoxInStudentId.Focus();
                return;
            }

          
            else  //在学员详细信息窗体显示
            {
                FrmStudentInfo objFrmStudentInfo = new FrmStudentInfo(objStudent);
                objFrmStudentInfo.Show();
            }

        }

        private void textBoxInStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.textBoxInStudentId.Text.Trim().Length != 0)
            {
                buttonSubmitQuery_Click(null,null);
                
            }
        }

        private void FrmStudentManage_Load(object sender, EventArgs e)
        {

        }

        private void FrmStudentManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objFrmStudentManage = null;
        }

        private void buttonAmend_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewStudentList.RowCount==0)
            {
                MessageBox.Show("没有任何要修改的学员信息","信息提示");
                return;
            }
            if(this.dataGridViewStudentList.CurrentRow==null)
            {
                MessageBox.Show("请选中要修改的学员信息", "信息提示");
                return;
            }
            //获取学号
            string StudentId = this.dataGridViewStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            //获取要修改学员的详细信息
            ExtStudent objStudent = objStudentService.GetStudentByStudentId(StudentId);
            //显示要修改学员信息的窗口




        }
    }
}
