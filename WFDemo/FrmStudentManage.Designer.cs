
namespace StudentManager
{
    partial class FrmStudentManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxStudentClass = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonAmend = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelQuerybystudentId = new System.Windows.Forms.Label();
            this.labelQueryByStudent = new System.Windows.Forms.Label();
            this.textBoxInStudentId = new System.Windows.Forms.TextBox();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmitQuery = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.frmUserLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUserLoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClass.Location = new System.Drawing.Point(52, 46);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(72, 16);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "学员班级";
            // 
            // comboBoxStudentClass
            // 
            this.comboBoxStudentClass.FormattingEnabled = true;
            this.comboBoxStudentClass.Location = new System.Drawing.Point(143, 46);
            this.comboBoxStudentClass.Name = "comboBoxStudentClass";
            this.comboBoxStudentClass.Size = new System.Drawing.Size(121, 20);
            this.comboBoxStudentClass.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFind.Location = new System.Drawing.Point(319, 46);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "查询";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonAmend
            // 
            this.buttonAmend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAmend.Location = new System.Drawing.Point(447, 46);
            this.buttonAmend.Name = "buttonAmend";
            this.buttonAmend.Size = new System.Drawing.Size(75, 23);
            this.buttonAmend.TabIndex = 3;
            this.buttonAmend.Text = "修改";
            this.buttonAmend.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(579, 46);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelQuerybystudentId
            // 
            this.labelQuerybystudentId.AutoSize = true;
            this.labelQuerybystudentId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuerybystudentId.Location = new System.Drawing.Point(52, 350);
            this.labelQuerybystudentId.Name = "labelQuerybystudentId";
            this.labelQuerybystudentId.Size = new System.Drawing.Size(120, 16);
            this.labelQuerybystudentId.TabIndex = 6;
            this.labelQuerybystudentId.Text = "按学号精确查询";
            // 
            // labelQueryByStudent
            // 
            this.labelQueryByStudent.AutoSize = true;
            this.labelQueryByStudent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQueryByStudent.Location = new System.Drawing.Point(52, 384);
            this.labelQueryByStudent.Name = "labelQueryByStudent";
            this.labelQueryByStudent.Size = new System.Drawing.Size(120, 16);
            this.labelQueryByStudent.TabIndex = 7;
            this.labelQueryByStudent.Text = "按学号精确查询";
            // 
            // textBoxInStudentId
            // 
            this.textBoxInStudentId.Location = new System.Drawing.Point(187, 384);
            this.textBoxInStudentId.Name = "textBoxInStudentId";
            this.textBoxInStudentId.Size = new System.Drawing.Size(207, 21);
            this.textBoxInStudentId.TabIndex = 8;
            this.textBoxInStudentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInStudentId_KeyDown);
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.ClassName});
            this.dataGridViewStudentList.Location = new System.Drawing.Point(55, 85);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.RowTemplate.Height = 23;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(639, 242);
            this.dataGridViewStudentList.TabIndex = 9;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.Frozen = true;
            this.StudentId.HeaderText = "学号";
            this.StudentId.MinimumWidth = 8;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // buttonSubmitQuery
            // 
            this.buttonSubmitQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSubmitQuery.Location = new System.Drawing.Point(414, 384);
            this.buttonSubmitQuery.Name = "buttonSubmitQuery";
            this.buttonSubmitQuery.Size = new System.Drawing.Size(89, 23);
            this.buttonSubmitQuery.TabIndex = 10;
            this.buttonSubmitQuery.Text = "提交查询";
            this.buttonSubmitQuery.UseVisualStyleBackColor = true;
            this.buttonSubmitQuery.Click += new System.EventHandler(this.buttonSubmitQuery_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.Location = new System.Drawing.Point(588, 384);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "关闭窗口";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // frmUserLoginBindingSource
            // 
            this.frmUserLoginBindingSource.DataSource = typeof(StudentManager.FrmUserLogin);
            // 
            // FrmStudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSubmitQuery);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.textBoxInStudentId);
            this.Controls.Add(this.labelQueryByStudent);
            this.Controls.Add(this.labelQuerybystudentId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAmend);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxStudentClass);
            this.Controls.Add(this.labelClass);
            this.Name = "FrmStudentManage";
            this.Text = "查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStudentManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmStudentManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUserLoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxStudentClass;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAmend;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelQuerybystudentId;
        private System.Windows.Forms.Label labelQueryByStudent;
        private System.Windows.Forms.TextBox textBoxInStudentId;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Button buttonSubmitQuery;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource frmUserLoginBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}