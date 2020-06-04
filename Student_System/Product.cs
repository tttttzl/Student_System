using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    /// <summary>
    /// 中间层
    /// </summary>
    class Product
    {
        public My_Mysql mysql;
        public Product()
        {
            mysql = new My_Mysql();
        }
    }
}
