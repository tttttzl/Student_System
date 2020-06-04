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
    public partial class Admine : Form
    {
        TabControl TabControl;
        ControlFactory factory;
        public Admine()
        {
            InitializeComponent();
            factory = new Admine_Factory();
            TabControl = factory.GetTab();
            this.Controls.Add(TabControl);
        }

        private void Dele_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }
    }
}
