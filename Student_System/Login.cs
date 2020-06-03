﻿using System;
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
                    form = new Admine();
                    form.Show();
                    this.Hide();
                    break;
                case "TeacherUser":
                    form = new Teacher();
                    form.Show();
                    this.Hide();
                    break;
                case "StudentUser":
                    form = new Student();
                    form.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
