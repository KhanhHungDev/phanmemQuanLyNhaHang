using BUS;
using DTO;
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
    public partial class frmDangnhap : Form
    {
        //------------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect conn = new BUS_CDBConnect();

        //-----------Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        public frmDangnhap()
        {
            InitializeComponent();
        }
        //------Khai báo các biến lưu lại thông tin đăng nhập
        public static string SV;
        public static string DB;
        public static string UI;
        public static string Pass;

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            SV = txtServername.Text.Trim();
            DB = txtDatabase.Text.Trim();
            UI = txtUserID.Text.Trim();
            Pass = txtPassword.Text.Trim();

            DTO_DBConnect lg = new DTO_DBConnect(txtServername.Text.Trim(), 
                                                 txtDatabase.Text.Trim(), 
                                                 txtUserID.Text.Trim(), 
                                                 txtPassword.Text.Trim());            
            if (conn.DBConnect(lg) == true)
            {
                mnu.CEnableMenu(false, true);
                this.Close();
            }
        }

        private void txtServername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
