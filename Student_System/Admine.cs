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
        //TabControl一个页面一个
        TabControl TabControl;
        //控件工厂
        ControlFactory factory;
        //Listview操作
        MylistviewOper listviewoper;
        //用于存储界面控件
        Dictionary<string, TextBox> textboxdic;
        //用于搜索用的Index，用来查找Column
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
            //进入界面后先加载一次
            listviewoper.ListviewLoadData(TabControl.SelectedTab.Name, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
        }

        //事件绑定
        public void EevetBind()
        {
            TabControl.SelectedIndexChanged += new System.EventHandler(this.Loading_Click);

            foreach (ListView item in factory.myTabPage.dictionary.Values)
            {
                item.SelectedIndexChanged += new System.EventHandler(this.ListviewSelect);
            } 
        }

        //绑定控件便于查找
        public void BindTextbox()
        {
            textboxdic.Add("User",User);
            textboxdic.Add("Password", Password);
            textboxdic.Add("id", id);
            textboxdic.Add("name", name);
            textboxdic.Add("Sex", Sex);

        }

        //删除按钮事件
        private void Dele_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确定删除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
                return;

            if (factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems.Count > 0)
            {
                if (pdt.mysql.DeleSelectData(TabControl.SelectedTab.Name, factory.myTabPage.dictionary[TabControl.SelectedTab.Name].SelectedItems[0].SubItems[1].Text))
                {
                    listviewoper.ListviewDeleteData(TabControl.SelectedTab.Name, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
                    listviewoper.ListviewLoadData(TabControl.SelectedTab.Name, factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
                }
            }
        }

        //刷新按钮事件
        private void Loading_Click(object sender, EventArgs e)
        {
            listviewoper.ListviewLoadData(TabControl.SelectedTab.Name,factory.myTabPage.dictionary[TabControl.SelectedTab.Name]);
        }

        //添加按钮事件
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

        //修改按钮事件
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

        //Listview选择行触发事件
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

        //搜索框触发事件
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            listviewoper.ListviewSearchData(SearchTextBox.Text,factory.myTabPage.dictionary[TabControl.SelectedTab.Name],column_number);
        }
    }
}
