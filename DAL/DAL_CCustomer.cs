using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace DAL
{
    public class DAL_CCustomer
    {
        SqlDataAdapter adapter;
        public DataTable pr_LoadForm()
        {
            adapter = new SqlDataAdapter("select* from KHACHHANG", DAL_CDBConnect.myconn);
            DataTable dtKH = new DataTable();
            adapter.Fill(dtKH);
            return dtKH;


        }
        //---------1.Viết hàm gọi Stored Procedure thêm khách hàng 
        public void pr_ThemKH(DTO_CCustomer c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = c.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 30).Value = c.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 5).Value = c.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = c.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = c.DIENTHOAI;
                cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
          


        //---------2.Viết hàm gọi Stored Procedure sửa khách hàng: Sinh viên tự viết
        public void pr_SuaKH(DTO_CCustomer d)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = d.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 30).Value = d.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 5).Value = d.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = d.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = d.DIENTHOAI;
                cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        //---------3.Viết hàm gọi Stored Procedure xóa khách hàng: Sinh viên tự viết
        public void pr_XoaKH(DTO_CCustomer e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = e.MsKH;
                
                cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
       

        
        
        

        
    }
}
