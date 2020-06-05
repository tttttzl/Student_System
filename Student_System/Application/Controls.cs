using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Student_System
{
    /// <summary>
    /// 用于生成Listview和TabControl和Tabcontrol
    /// </summary>
    
    class MyTabcontrol
    {
        public TabControl TabControl;
        public MyTabcontrol()
        {
            TabControl = new TabControl();
            Setting(this.TabControl);
        }

        public void Setting(TabControl tabControl)
        {
            tabControl.Name = "tabControl";
            tabControl.Location = new Point(6, 6);
            tabControl.Size = new Size(776, 503);
        }
    }

    /// <summary>
    /// Tabpage 调用AddListview就可以了直接拿到一个Tabpage
    /// </summary>
    class MyTabPage
    {
        //这个是用于绑定Listview和Tabpage用的字典
        public Dictionary<string, ListView> dictionary;

        public MyTabPage()
        {
            dictionary = new Dictionary<string, ListView>();
        }

        public void Setting(TabPage tabpage,string name,string text)
        {
            //设置控件名字
            tabpage.Name = name;
            //设置页面名
            tabpage.Text = text;
        }

        public TabPage AddListview(ListView listview, string name, string text)
        {
            TabPage page = new TabPage();
            Setting(page,name,text);
            page.Controls.Add(listview);
            dictionary.Add(name,listview);
            return page;
        }
    }


    /// <summary>
    /// 抽象Listview操作类
    /// </summary>
    abstract class MyListview
    {
        //配置属性
        public virtual void SettingListView(ListView listview)
        {
            listview.Location = new Point(6, 6);
            listview.Height = 465;
            listview.Width = 756;
            listview.GridLines = true;
            listview.FullRowSelect = true;
            listview.View = View.Details;
            listview.Scrollable = true;
            listview.MultiSelect = false;
            listview.HideSelection = false;
            listview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }

        //ListView头标题设置
        public virtual void SetTitle(ListView list, string Title, int Width = 80, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center)
        {
            ColumnHeader cn = new ColumnHeader();
            cn.Width = Width;
            cn.TextAlign = horizontalAlignment;
            cn.Text = Title;
            list.Columns.Add(cn);
        }

        public abstract ListView GetAdmine();            
    }

    /// <summary>
    /// 账号数据管理Listview 
    /// </summary>
    class UserListview : MyListview
    {
        //User Password Nmae Sex
        public override ListView GetAdmine()
        {
            ListView listview = new ListView();
            SettingListView(listview);
            SetTitle(listview, "number");
            SetTitle(listview, "User");
            SetTitle(listview, "Password");
            SetTitle(listview, "id");
            SetTitle(listview, "name");
            SetTitle(listview, "Sex");
            return listview;
        }
    }

    /// <summary>
    ///成绩数据管理Listview 
    /// </summary>
    class SorceListview : MyListview
    {
        //User Password Nmae Sex
        public override ListView GetAdmine()
        {
            ListView listview = new ListView();
            SettingListView(listview);
            SetTitle(listview, "number");
            SetTitle(listview, "id");
            SetTitle(listview, "name");
            SetTitle(listview, "class");
            SetTitle(listview, "sex");
            SetTitle(listview, "English");
            SetTitle(listview, "Math");
            return listview;
        }
    }




    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    abstract class ControlFactory
    {
        public MyTabcontrol myTabcontrol;
        public MyListview myListview;
        public MyTabPage myTabPage;

        public ControlFactory()
        {
            myTabcontrol = new MyTabcontrol();
            myTabPage = new MyTabPage();
        }

        public abstract TabControl GetTab();
    }

    class Admine_Factory: ControlFactory
    {
        public override TabControl GetTab()
        {
            myListview = new UserListview();
            myTabcontrol.TabControl.Controls.Add(myTabPage.AddListview(myListview.GetAdmine(), "adminelogin", "管理员账号"));
            myTabcontrol.TabControl.Controls.Add(myTabPage.AddListview(myListview.GetAdmine(), "studentlogin", "学生账号"));
            myTabcontrol.TabControl.Controls.Add(myTabPage.AddListview(myListview.GetAdmine(), "teacherlogin", "老师账号"));
            return myTabcontrol.TabControl;
        }
    }

    class Teacher_Factory : ControlFactory
    {
        public override TabControl GetTab()
        {
            myListview = new SorceListview();
            myTabcontrol.TabControl.Controls.Add(myTabPage.AddListview(myListview.GetAdmine(), "ClassAllData", "全体学生成绩"));
            return myTabcontrol.TabControl;
        }
    }

    class Student_Factory : ControlFactory
    {
        public override TabControl GetTab()
        {
            myListview = new SorceListview();
            myTabcontrol.TabControl.Controls.Add(myTabPage.AddListview(myListview.GetAdmine(), "ClassAllData", "个人成绩"));
            return myTabcontrol.TabControl;
        }
    }
}
