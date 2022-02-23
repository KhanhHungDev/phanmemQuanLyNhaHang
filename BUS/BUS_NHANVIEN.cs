using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
   public class BUS_NHANVIEN
    {
       public DataTable pr_LoadForm()
       {
           return cc.pr_LoadForm();
       }
       NHANVIEN_DAL cc = new NHANVIEN_DAL();
      public void pr_ThemNV(DTO_NHANVIEN c){
          cc.pr_themNV(c);
      }
      public void pr_SuaNV(DTO_NHANVIEN c)
      {
          cc.pr_suaNV(c);
      }
      public void pr_XoaNV(DTO_NHANVIEN c)
      {
          cc.pr_XoaNV(c);
      }
      
    }
}
