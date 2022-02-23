using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_MONAN
    {
        DAL_MONAN cc = new DAL_MONAN();
        public DataTable pr_LoadForm()
        {
            return cc.pr_LoadForm();
        }
        public void pr_ThemMonAN(DTO_MONAN c) {
            cc.pr_ThemMonAn(c);
        }
        public void pr_SuaMonAn(DTO_MONAN c)
        {
            cc.pr_SuaMonAn(c);
        }
        public void pr_XoaMonAn(DTO_MONAN c)
        {
            cc.pr_XoaMonAn(c);
        }
    }
}
