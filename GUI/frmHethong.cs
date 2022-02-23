using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHethong : Form
    {
        //---------Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //---------Khai báo lớp: 
        BUS_CDBConnect cn = new BUS_CDBConnect();

        public frmHethong()
        {
            InitializeComponent();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            mnu.CEnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.Show();
        }

        private void mnuHKN_Click(object sender, EventArgs e)
        {
            if (cn.DisDBConnect() == true)
            {
                mnu.CEnableMenu(true, false);
            }
        }

        private void mnuKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void mnuDTBTMH_Click(object sender, EventArgs e)
        {
            frmBCDSMoiMHReport frm = new frmBCDSMoiMHReport();
            frm.ShowDialog();
        }

        private void mnuLHD_Click(object sender, EventArgs e)
        {
            frmHoadon frm = new frmHoadon();
            frm.ShowDialog();
        }

        private void mnuNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void mnuMH_Click(object sender, EventArgs e)
        {
            frmMonAn frm = new frmMonAn();
            frm.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info frm = new info();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
