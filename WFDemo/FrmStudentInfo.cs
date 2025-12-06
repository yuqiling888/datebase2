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

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }
        public FrmStudentInfo(ExtStudent objExStudent) : this()
        {
            
            this.textBoxStudentName.Text = objExStudent.StudentName;
            this.textBoxGender.Text = objExStudent.Gender;
            this.textBoxBirthday.Text = objExStudent.Birthday.ToShortDateString();
            this.textBoxClass.Text = objExStudent.ClassName;
            this.textBoxStudentIdNo.Text= objExStudent.StudentIdNo.ToString();
            this.textBoxCard.Text = objExStudent.CardNo;
            this.textBoxPhoneNumber.Text = objExStudent.PhoneNumber.ToString();
            this.textBoxFamliyAddress.Text = objExStudent.StudentAddress;
        }


        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
