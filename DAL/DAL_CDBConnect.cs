using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class DAL_CDBConnect
    {
        //1.--------------Khai báo lớp kết nối CSDL
        public static SqlConnection myconn = null;

        //2.--------------Viết hàm kết nối CSDL
        public bool DBConnect(DTO_DBConnect ty)
        {
            try
            {
                myconn = new SqlConnection(@"Data Source=LAPTOP-V3A34PN7;Initial Catalog=QL_NhaHang;Integrated Security=True");
                myconn.Open(); //Mở kết với CSDL
                return true;
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.ToString());
                return false;
            }
        }
        //3.--------------Viết hàm hủy kết nối CSDL
        public bool DisDBConnect()
        {
            try
            {
                myconn.Close(); //Hủy kết với CSDL
                return true;
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.ToString());
                return false;
            }
        }
        //4.---------------Viết hàm đưa đưa dữ liệu vào DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(sql, myconn);
                sqlDA.Fill(dt);
                return dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return null;
            }
        }
        //5.---------------Viết hàm đọc dữ liệu từ Stored Procedure
        public SqlDataReader getDataStoredProcdure(string sql)
        {
            try
            {
                if (myconn.State == ConnectionState.Closed)
                    return null;
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return null;
            }
        }
    }
}
