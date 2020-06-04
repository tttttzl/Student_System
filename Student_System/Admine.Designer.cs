namespace Student_System
{
    partial class Admine
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
            this.Dele = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Dele
            // 
            this.Dele.Location = new System.Drawing.Point(969, 410);
            this.Dele.Name = "Dele";
            this.Dele.Size = new System.Drawing.Size(75, 23);
            this.Dele.TabIndex = 0;
            this.Dele.Text = "删除";
            this.Dele.UseVisualStyleBackColor = true;
            this.Dele.Click += new System.EventHandler(this.Dele_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(862, 410);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(969, 459);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(75, 23);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "刷新";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(862, 459);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 3;
            this.Change.Text = "修改";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(900, 28);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(144, 21);
            this.SearchTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "搜索";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(862, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 305);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息显示";
            // 
            // Admine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Dele);
            this.Name = "Admine";
            this.Text = "Admine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dele;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}