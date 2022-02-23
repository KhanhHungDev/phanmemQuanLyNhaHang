using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_CEnableMenu
    {
        //--------Constructure
        public GUI_CEnableMenu() { }

        //--------Khai báo form hệ thống
        public static frmHethong frmHT = new frmHethong();

        //--------Viết hàm gọi form hệ thống
        public static void Main()
        {
            Application.Run(frmHT);
        }

        //---------Ẩn/Hiện menu hệ thống
        public void CEnableMenu(bool d1, bool d2)
        {   
            frmHT.mnuDN.Enabled = d1;   //---Đăng nhập
            frmHT.mnuHKN.Enabled = d2;  //---Hủy kết nối
            frmHT.mnuDM.Enabled = d2;   //---Danh mục
            frmHT.mnuHD.Enabled = d2;   //---Hóa đơn
            frmHT.mnuBC.Enabled = d2;   //---Báo cáo
            frmHT.mnuBR.Enabled = d2;   //---Backup and Restore
        }
    }
}
