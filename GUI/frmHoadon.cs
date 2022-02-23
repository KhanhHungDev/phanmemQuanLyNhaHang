using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }
        //--------------1.Khai báo tầng BUS
        BUS_CgetData dt = new BUS_CgetData();
        BUS_CLAPHOADON hd = new BUS_CLAPHOADON();

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            //-------------1.Đưa dữ liệu vào ComboBox Món ăn
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MAMON, TENMON FROM MONAN");
            this.cboMathang.DataSource = myDT;
            this.cboMathang.ValueMember = "MAMON";
            this.cboMathang.DisplayMember = "TENMON";
            this.cboMathang.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.cboMathang.SelectedIndex = 0;

            //-------------2.Đưa dữ liệu vào ComboxBox Khách hàng
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MsKH, TENKH FROM KHACHHANG");
            this.cboKhachang.DataSource = myDT;
            this.cboKhachang.ValueMember = "MsKH";
            this.cboKhachang.DisplayMember = "TENKH";
            this.cboKhachang.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.cboKhachang.SelectedIndex = 0;

            //-------------3.Đưa dữ liệu vào ComboxBox Nhân Viên
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MANV, TENNV FROM NHANVIEN");
            this.cboNhanvien.DataSource = myDT;
            this.cboNhanvien.ValueMember = "MANV";
            this.cboNhanvien.DisplayMember = "TENNV";
            this.cboNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            ///this.cboNhanvien.SelectedIndex = 0;

            //-------------4.Lấy thông tin khách hàng
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT DIACHI, PHAI, DIENTHOAI FROM KHACHHANG WHERE MsKH = '"+this.cboKhachang.SelectedValue.ToString()+"'");
            this.txtDiachi.Text = myDT.Rows[0][0].ToString();
            this.txtDienthoai.Text = myDT.Rows[0][2].ToString();
            this.cboPhai.Text = myDT.Rows[0][1].ToString();

            //-------------5.Gọi hàm tạo Mã số hóa đơn
            SqlDataReader dr = dt.getDataStoredProcdure("pr_TaoMAHD");

          
            if (dr.Read() == true)
            {
                this.txtMsHD.Text = dr.GetSqlString(0).ToString(); //---Đọc mahd gán vào TextBox Mã hóa đơn
                dr.Close();     //----Đóng DataReader
            }
        }

        

private void btKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }
        //-----------Khai báo các DataRow và DataTable
        private DataRow myRow = null;
        private DataTable myTable = new DataTable();

        private void btThemMH_Click(object sender, EventArgs e)
        {
            //-------------1.Đưa dữ liệu vào DataTable
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT DONGIA, DONVITINH FROM MONAN WHERE MAMON = '" + this.cboMathang.SelectedValue.ToString() + "'");
            
            //-------------2.Thêm mặt hàng vào DataGridView
            myTable = this.dataSetMH.Tables[0];
            myRow = myTable.NewRow();
            myRow[1] = this.cboMathang.SelectedValue.ToString();
            myRow[2] = this.cboMathang.Text.Trim();
            myRow[3] = myDT.Rows[0][1].ToString();
            myRow[4] = int.Parse(this.txtSoluong.Text.Trim());
            myRow[5] = double.Parse(myDT.Rows[0][0].ToString());
            myRow[6] = int.Parse(this.txtSoluong.Text.Trim()) * double.Parse(myDT.Rows[0][0].ToString());
            myTable.Rows.Add(myRow);
            this.dGVMathang.DataSource = myTable;

            //--------------3.Tính tổng tiền
            double tongtien = 0.0;
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                tongtien = tongtien + double.Parse(myTable.Rows[i][6].ToString());
            }
            this.txtTongtien.Text = tongtien.ToString();
        }
        //-----------Khai báo biến lưu mã số hóa đơn
        public static string Masohoadon = string.Empty;

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Masohoadon = txtMsHD.Text.Trim();
           // ------------Khai báo tầng DTO
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                DTO_CLAPHOADON lhd = new DTO_CLAPHOADON(txtMsHD.Text.Trim(),
                                                        cboNhanvien.SelectedValue.ToString(),
                                                         cboKhachang.SelectedValue.ToString(),
                                                       dTPNgayLHD.Value.ToShortDateString(),
                                                        float.Parse(txtTongtien.Text.Trim()),
                                                        myTable.Rows[i][1].ToString(),
                                                        int.Parse(myTable.Rows[i][4].ToString()),
                                                        float.Parse(myTable.Rows[i][6].ToString()));
                hd.pr_ThemHD(lhd);
            }
            //------------Gọi form In hóa đơn
            frmInhoadon frm = new frmInhoadon();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtDiachi.Text = "";
            this.txtDienthoai.Text = "";
            this.txtMsHD.Text = "";
            this.txtSoluong.Text = "";
            this.txtTongtien.Text = "";
            this.cboKhachang.Text = "";
            this.cboMathang.Text = "";
            this.cboNhanvien.Text = "";
            this.cboPhai.Text = "";
            this.cboNhanvien.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMonAn frm = new frmMonAn();
            frm.ShowDialog();
        }
    }
}
