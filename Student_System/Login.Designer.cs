namespace Student_System
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admine = new System.Windows.Forms.RadioButton();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Entry = new System.Windows.Forms.Button();
            this.PwdView = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(339, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "登陆界面";
            // 
            // User
            // 
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User.Location = new System.Drawing.Point(347, 187);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 21);
            this.User.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(347, 235);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(200, 21);
            this.Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(301, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(301, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // Admine
            // 
            this.Admine.AutoSize = true;
            this.Admine.Location = new System.Drawing.Point(347, 298);
            this.Admine.Name = "Admine";
            this.Admine.Size = new System.Drawing.Size(59, 16);
            this.Admine.TabIndex = 5;
            this.Admine.TabStop = true;
            this.Admine.Text = "管理员";
            this.Admine.UseVisualStyleBackColor = true;
            this.Admine.CheckedChanged += new System.EventHandler(this.Admine_CheckedChanged);
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Location = new System.Drawing.Point(428, 298);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(47, 16);
            this.Teacher.TabIndex = 6;
            this.Teacher.TabStop = true;
            this.Teacher.Text = "老师";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(500, 298);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(47, 16);
            this.Student.TabIndex = 7;
            this.Student.TabStop = true;
            this.Student.Text = "学生";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(476, 346);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(75, 23);
            this.Entry.TabIndex = 8;
            this.Entry.Text = "登录";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // PwdView
            // 
            this.PwdView.AutoSize = true;
            this.PwdView.Location = new System.Drawing.Point(562, 237);
            this.PwdView.Name = "PwdView";
            this.PwdView.Size = new System.Drawing.Size(48, 16);
            this.PwdView.TabIndex = 9;
            this.PwdView.Text = "显示";
            this.PwdView.UseVisualStyleBackColor = true;
            this.PwdView.CheckedChanged += new System.EventHandler(this.PwdView_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 491);
            this.Controls.Add(this.PwdView);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.Admine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Admine;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.CheckBox PwdView;
    }
}

