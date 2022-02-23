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
   public class DAL_MONAN
   {
       SqlDataAdapter adapter;
       public DataTable pr_LoadForm()
       {
           adapter = new SqlDataAdapter("select* from MONAN", DAL_CDBConnect.myconn);
           DataTable dtMA = new DataTable();
           adapter.Fill(dtMA);
           return dtMA;


       }
       public void pr_ThemMonAn(DTO_MONAN a)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("pr_ThemMon", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MAMON", System.Data.SqlDbType.Char, 10).Value = a.MAMON;
               cmd.Parameters.Add("@TENMON", System.Data.SqlDbType.NVarChar, 30).Value = a.TENMON;
               cmd.Parameters.Add("@SL", System.Data.SqlDbType.Int).Value = a.SL;
               cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float).Value = a.DONGIA;
               cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 10).Value = a.DONVITINH;
               cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
               cmd.Parameters.Clear();
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message.ToString());
           }
       }
       public void pr_SuaMonAn(DTO_MONAN b)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("pr_SuaMonAN", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MAMON", System.Data.SqlDbType.Char, 10).Value = b.MAMON;
               cmd.Parameters.Add("@TENMON", System.Data.SqlDbType.NVarChar, 30).Value = b.TENMON;
               cmd.Parameters.Add("@SL", System.Data.SqlDbType.Int).Value = b.SL;
               cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float).Value = b.DONGIA;
               cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 10).Value = b.DONVITINH;
               cmd.ExecuteNonQuery(); //----Thực hiện Stored Procedure
               cmd.Parameters.Clear();
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message.ToString());
           }
       }
       public void pr_XoaMonAn(DTO_MONAN c)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("pr_XoaMonAn", DAL_CDBConnect.myconn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.Add("@MAMON", System.Data.SqlDbType.Char, 10).Value = c.MAMON;

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
