using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{

    public class BUS_CCustomer
    {
        public DataTable pr_LoadForm()
        {
            return cc.pr_LoadForm();
        }

        //---------Khai báo tầng DAL
        DAL_CCustomer cc = new DAL_CCustomer();

        //---------1.Viết hàm gọi Stored Procedure thêm khách hàng
        public void pr_ThemKH(DTO_CCustomer c)
        {
            cc.pr_ThemKH(c);
        }
        public void pr_SuaKH(DTO_CCustomer c)
        {
            cc.pr_SuaKH(c);
        }
        public void pr_XoaKH(DTO_CCustomer c)
        {
            cc.pr_XoaKH(c);
        }

    }
}
