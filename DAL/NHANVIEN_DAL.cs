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
   public class NHANVIEN_DAL
    {
        SqlDataAdapter adapter;
        public DataTable pr_LoadForm()
        {
            adapter = new SqlDataAdapter("select* from NHANVIEN", DAL_CDBConnect.myconn);
            DataTable dtMA = new DataTable();
            adapter.Fill(dtMA);
            return dtMA;


        }
       public void pr_themNV(DTO_NHANVIEN a)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("pr_ThemNV", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = a.MANV;
               cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = a.TENNV;
               cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar, 256).Value = a.TENDANGNHAP;
               cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = a.NGAYSINH;
               cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = a.PHAI;
               cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = a.DIACHI;
               cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = a.DIENTHOAI;
               cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.NVarChar).Value = a.SO_HD_THUCHIEN1;
               cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = a.NGAYDANGNHAP1;
               cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.NVarChar, 20).Value = a.SOLANDN1;
               cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = a.QUYENHAN1;
               
               cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
               cmd.Parameters.Clear();
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message.ToString());
           }
       }
       public void pr_suaNV(DTO_NHANVIEN b){
           try
           {
               SqlCommand cmd = new SqlCommand("pr_SuaNV", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = b.MANV;
               cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = b.TENNV;
               cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar, 256).Value = b.TENDANGNHAP;
               cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = b.NGAYSINH;
               cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = b.PHAI;
               cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = b.DIACHI;
               cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = b.DIENTHOAI;
               cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.NVarChar).Value = b.SO_HD_THUCHIEN1;
               cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = b.NGAYDANGNHAP1;
               cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.NVarChar, 20).Value = b.SOLANDN1;
               cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = b.QUYENHAN1;

               cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
               cmd.Parameters.Clear();
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message.ToString());
           }
       }
       public void pr_XoaNV(DTO_NHANVIEN c)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("pr_XoaNV", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = c.MANV;

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
