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
    public partial class Teacher : Form
    {
        TabControl TabControl;
        ControlFactory factory;
        public Teacher()
        {
            InitializeComponent();
            factory = new Teacher_Factory();
            TabControl = factory.GetTab();
            this.Controls.Add(TabControl);
        }
    }
}
