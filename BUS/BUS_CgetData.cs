using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CgetData
    {
        //----------------Khai báo tầng DAL
        DAL_CDBConnect cn = new DAL_CDBConnect();

        //4.---------------Viết hàm đưa đưa dữ liệu vào DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            return cn.getDataTable(dt, sql);
        }
        //5.---------------Viết hàm đọc dữ liệu từ Stored Procedure
        public SqlDataReader getDataStoredProcdure(string sql)
        {
            return cn.getDataStoredProcdure(sql);
        }
    }
}
