using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL;
using StudentManagermo;

namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        //创建数据访问类对象
        private SysAdminsServer ObjSysAdminServer = new SysAdminsServer();
        public FrmUserLogin()
        {
            InitializeComponent();
        }

            


    
        private void btnLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //【1】数据验证
            if (this.txtLoginId.Text.Length == 0)
            {
                MessageBox.Show("请输入登录帐号");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入登录密码");
                this.txtLoginPwd.Focus();
                return;
            }
            //【2】封装对象(实际封装的是用户输入的帐号和密码）
            SysAdmin ObjAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginpPwd = this.txtLoginPwd.Text.Trim()
            };
            //【3】和后台交互，验证登录帐号的密码是否正确
            try
            {
                ObjAdmin = ObjSysAdminServer.AdminLogin(ObjAdmin);
                if (ObjAdmin != null)
                {
                    //保存登录信息
                    Program.ObjCurrentAdmin = ObjAdmin;
                    //设置登录窗体的返回值
                    this.DialogResult = DialogResult.OK;
                    //关闭窗体
                    this.Close();

                }
                else
                {
                    MessageBox.Show("登录帐号或密码有误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据访问出现异常，登录失败" + ex.Message);
            }

        }
    }
}
