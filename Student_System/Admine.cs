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
    partial class Admine : Form
    { 
        Product pdt;
        TabControl TabControl;
        ControlFactory factory;
        MylistviewOper listviewoper;
        Dictionary<string, TextBox> textboxdic;
        int column_number = 1;

        public Admine(Product pdt)
        {
            this.pdt = pdt;
            InitializeComponent();
            textboxdic = new Dictionary<string, TextBox>();
            factory = new Admine_Factory();
            listviewoper = new ConcertOperation(pdt);
            TabControl = factory.GetTab();
            this.Controls.Add(TabControl);
            EevetBind();
            BindTextbox();
        }

        public void EevetBind()
        {
            TabControl.SelectedIndexChanged += new System.EventHandler(this.Loading_Click);

            foreach (ListView item in factory.myTabPage.dictionary.Values)
            {
                item.SelectedIndexChanged += new System.EventHandler(this.ListviewSelect);
            } 
        }

        public void BindTextbox()
        {
            textboxdic.Add("User",User);
            textboxdic.Add("Password", Password);
            textboxdic.Add("id", id);
            textboxdic.Add("name", name);
            textboxdic.Add("Sex", Sex);

        }

        private void Dele_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确定删除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
                return;

            if (factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems.Count > 0)
            {
                if (pdt.mysql.DeleSelectData(TabControl.SelectedTab.Name,factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems[0].SubItems[1].Text))
                    listviewoper.ListviewDeleteData(TabControl.SelectedTab.Name, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
            }
        }

        private void Loading_Click(object sender, EventArgs e)
        {
            listviewoper.ListviewLoadData(TabControl.SelectedTab.Name,factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确定添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
                return;
            string[] str = new string[] { User.Text, Password.Text,id.Text,name.Text,Sex.Text };
            if (pdt.mysql.InsertData(string.Format("insert into {0} values(\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\")", TabControl.SelectedTab.Name, str[0], str[1],str[2],str[3],str[4])))
            {
                listviewoper.ListviewInsertData(str, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确定修改", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
                return;

            string[] str_arraay = new string[] { User.Text, Password.Text, id.Text, name.Text, Sex.Text };
       
            if (pdt.mysql.ChangeData(TabControl.SelectedTab.Name, string.Format("update {0} set password='{1}',id='{2}',name='{3}',sex='{4}' where user='{5}'; ", TabControl.SelectedTab.Name,str_arraay[1], str_arraay[2],str_arraay[3],str_arraay[4],str_arraay[0])))
            {
                listviewoper.ListviewChangeData(textboxdic, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
            }
        }

        private void ListviewSelect(object sender, EventArgs e)
        {
            if (factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems.Count > 0)
            {
                for (int i = 1; i < factory.myTabPage.dictionary[TabControl.SelectedTab.Name].Columns.Count; i++)
                {
                    textboxdic[factory.myTabPage.dictionary[TabControl.SelectedTab.Name].Columns[i].Text].Text = factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            listviewoper.ListviewSearchData(SearchTextBox.Text,factory.myTabPage.dictionary[TabControl.SelectedTab.Name],column_number);
        }
    }
}
