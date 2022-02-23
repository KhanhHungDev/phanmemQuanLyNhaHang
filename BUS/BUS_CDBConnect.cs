using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBConnect
    {
        //----------Khai báo lớp DAL_CDBConnect
        DAL_CDBConnect conn = new DAL_CDBConnect();

        //----------Viết hàm gọi hàm kết nối với CSDL
        public bool DBConnect(DTO_DBConnect lg)
        {
            return conn.DBConnect(lg);
        }

        //----------Viết hàm gọi hàm hủy kết nối CSDL
        public bool DisDBConnect()
        {
            return conn.DisDBConnect();
        }
    }
}
