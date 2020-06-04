using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class Login : Form
    {
        Product pdt;
        string Entry_Type = "AdmineLogin";
        public Login()
        {
            pdt = new Product();
            InitializeComponent();
        }

        private void Admine_CheckedChanged(object sender, EventArgs e)
        {
            if (Admine.Checked == true)
                Entry_Type = "AdmineLogin";
            else if(Teacher.Checked == true)
                Entry_Type = "TeacherLogin";
            else if (Student.Checked == true)
                Entry_Type = "StudentLogin";
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            Form form;
            if (!(pdt.mysql.Search(Entry_Type, "User", User.Text, "Password") == Password.Text))
            {
                MessageBox.Show("账号或者密码错误", "错误提示");
                return;
            }
            switch (Entry_Type)
            {
                case "AdmineLogin":
                    this.Hide();
                    form = new Admine(this.pdt);
                    form.ShowDialog();
                    this.Show();
                    break;
                case "TeacherLogin":
                    this.Hide();
                    form = new Teacher();
                    form.ShowDialog();
                    this.Show();
                    break;
                case "StudentLogin":
                    this.Hide();
                    form = new Student();
                    form.ShowDialog();
                    this.Show();
                    break;
            }
        }

        private void PwdView_CheckedChanged(object sender, EventArgs e)
        {
            if (PwdView.Checked)
                Password.PasswordChar = new char();
            else
                Password.PasswordChar = '*';
        }
    }
}
