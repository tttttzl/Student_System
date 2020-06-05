using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

namespace Student_System
{

    /// <summary>
    /// MySQL
    /// </summary>
    class My_Mysql
    {
        private MySqlDataReader reader;
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public bool isConnect = false;
        public My_Mysql()
        {
            ConnectMysql();
        }

        //连接
        public virtual void ConnectMysql(string server = "localhost", string port = "3306", string user = "root", string password = "root", string database = "studentsystem")
        {
            try
            {
                String connetStr = "server=" + server + ";port=" + port + ";user=" + user + ";password=" + password + ";database=" + database + ";connection timeout='1200'; Charset=utf8";
                conn = new MySqlConnection(connetStr);
                conn.Open();
                MessageBox.Show("连接成功", "连接提示");
                isConnect = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "连接提示");
            }
            finally
            {

            }
        }
        //关闭数据库
        public void Close()
        {
            conn.Close();
            isConnect = false;
        }

        //读取表全部数据
        public virtual DataTable ReadAllData(string TableName)
        {
            string cmdstr = string.Format("select * from {0}", TableName);
            DataTable table = new DataTable();
            cmd = new MySqlCommand(cmdstr, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        
        //清空表所有内容
        public virtual bool DeleAllData(string TableName)
        {
            try
            {
                cmd = new MySqlCommand("truncate table " + TableName, conn);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }

        //搜索表指定内容
        //输入搜索的表，检索名称，需要返回的数据名称
        public virtual string Search(string TableName,string data_name, string data, string searchData)
        {
            string resultback = null;
            try
            {
               string cmdstr = string.Format("select * from {0} where {1}='{2}'", TableName,data_name, data);
                cmd = new MySqlCommand(cmdstr, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultback = reader.GetString(searchData);
                }
                reader.Close();
                return resultback;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return resultback;
            }
        }

        //删除选中的
        public bool DeleSelectData(string TableName, string deledata)
        {
            try
            {
                string cmdstr = string.Format("delete  from {0} where user='{1}'", TableName, deledata);
                cmd = new MySqlCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功", "操纵提示");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }

        //插入数据
        //这里直接传入SQL语句即可
        public bool InsertData(string insertdata)
        {
            try
            {
                cmd = new MySqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功", "操纵提示");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }

        //修改数据
        //这里直接传入SQL语句即可
        public bool ChangeData(string TableName, string insertdata)
        {
            try
            {
                cmd = new MySqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功", "操纵提示");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }
    }
}
