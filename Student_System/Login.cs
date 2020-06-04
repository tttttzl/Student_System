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
        string Entry_Type = "AdmineUser";
        public Login()
        {
            InitializeComponent();
        }

        private void Admine_CheckedChanged(object sender, EventArgs e)
        {
            if (Admine.Checked == true)
                Entry_Type = "AdmineUser";
            else if(Teacher.Checked == true)
                Entry_Type = "TeacherUser";
            else if (Student.Checked == true)
                Entry_Type = "StudentUser";
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            Form form;
            switch (Entry_Type)
            {
                case "AdmineUser":
                    this.Hide();
                    form = new Admine();
                    form.ShowDialog();
                    this.Show();
                    break;
                case "TeacherUser":
                    this.Hide();
                    form = new Teacher();
                    form.ShowDialog();
                    this.Show();
                    break;
                case "StudentUser":
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
