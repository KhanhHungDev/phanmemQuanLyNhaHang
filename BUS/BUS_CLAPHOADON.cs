using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CLAPHOADON
    {
        //----------Khai báo tầng DAL
        DAL_CLAPHOADON lhd = new DAL_CLAPHOADON();

        //---------1.Viết hàm gọi Stored Procedure thêm hóa đơn
        public void pr_ThemHD(DTO_CLAPHOADON c)
        {
            lhd.pr_ThemHD(c);
        }

    }
}