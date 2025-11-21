
namespace StudentManager
{
    partial class FrmDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnfo = new System.Windows.Forms.Label();
            this.BtnGet = new System.Windows.Forms.Button();
            this.lblCurretUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnfo
            // 
            this.lblnfo.AutoSize = true;
            this.lblnfo.Location = new System.Drawing.Point(87, 164);
            this.lblnfo.Name = "lblnfo";
            this.lblnfo.Size = new System.Drawing.Size(71, 12);
            this.lblnfo.TabIndex = 0;
            this.lblnfo.Text = "1班学生总数";
            this.lblnfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGet.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnGet.Location = new System.Drawing.Point(82, 272);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(178, 54);
            this.BtnGet.TabIndex = 2;
            this.BtnGet.Text = "获取1班和2班学生总数";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // lblCurretUser
            // 
            this.lblCurretUser.AutoSize = true;
            this.lblCurretUser.Location = new System.Drawing.Point(116, 425);
            this.lblCurretUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurretUser.Name = "lblCurretUser";
            this.lblCurretUser.Size = new System.Drawing.Size(41, 12);
            this.lblCurretUser.TabIndex = 3;
            this.lblCurretUser.Text = "用户名";
            this.lblCurretUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前用户：";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(82, 13);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "添加学生";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurretUser);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.lblnfo);
            this.Name = "FrmDemo";
            this.Text = "测试前台代码和后台代码分离";
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnfo;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Label lblCurretUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
    }
}

