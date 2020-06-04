using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Student_System
{
    /// <summary>
    ///     对于数据库和Listview交互类
    /// </summary>

    abstract class MylistviewOper
    {
        //加载表全部数据
        public abstract void ListviewLoadData(string TableNmae, ListView listview);
        //删除选中的数据
        public abstract void ListviewDeleteData(string TableName, ListView listView);
        //插入数据
        public abstract void ListviewInsertData(string[] str, ListView list);
        //修改数据
        public abstract void ListviewChangeData(string data, ListView list);
        //搜索数据
        public abstract void ListviewSearchData(string data, ListView list, int index);
    }

    class ConcertOperation: MylistviewOper
    {
        Product pdt;
        int number = 1;

        public ConcertOperation(Product pdt)
        {
            this.pdt = pdt;
        }

        public override void ListviewLoadData(string TableNmae, ListView listview)
        {
            number = 1;
            DataTable table = pdt.mysql.ReadAllData(TableNmae);
            listview.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                string[] str = new string[dr.ItemArray.Length];
                ListViewItem lvi = new ListViewItem();
                listview.BeginUpdate();
                lvi.Text = number++.ToString();
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    str[i] = dr[i].ToString();
                }
                lvi.SubItems.AddRange(str);
                listview.EndUpdate();
                listview.Items.Add(lvi);
            }
        }

        public override void ListviewDeleteData(string TableName, ListView listView)
        {
            listView.Items.Remove(listView.SelectedItems[0]);
        }

        public override void ListviewInsertData(string[] str, ListView list)
        {
            int Number = list.Items.Count;
            ListViewItem lvi = new ListViewItem();
            list.BeginUpdate();
            lvi.Text = number++.ToString();
            lvi.SubItems.AddRange(str);
            list.EndUpdate();
            list.Items.Add(lvi);
        }

        //这里也要修改
        public override void ListviewChangeData(string data, ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                list.SelectedItems[0].SubItems[2].Text = data;
            }
            else
                return;
        }

        public override void ListviewSearchData(string data, ListView list, int index)
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.SubItems[index].Text == data)
                {
                    item.Selected = true;
                    item.EnsureVisible();
                    return;
                }
            }

            MessageBox.Show("未找到数据", "操作提示");
        }
    }
}
