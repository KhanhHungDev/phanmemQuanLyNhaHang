using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmNhanVien : Form
    {
       
        BUS_CgetData dt = new BUS_CgetData();
        BUS_NHANVIEN c = new BUS_NHANVIEN();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
        public void pr_LoadForm()
        {
            DataTable dt = c.pr_LoadForm();
            dataGridView1.DataSource = dt;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //Thêm giới tính khách hàng vào cb box
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT PHAI FROM NHANVIEN");
            this.cboPhai.DataSource = myDT;

            this.cboPhai.DisplayMember = "PHAI";
            this.cboPhai.DropDownStyle = ComboBoxStyle.DropDownList;
            //hiện dữ liệu data
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT * FROM NHANVIEN");
            this.dataGridView1.DataSource = myDT;
            pr_LoadForm();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
          
            
            DTO_NHANVIEN nv = new DTO_NHANVIEN(txtMANV.Text.Trim(),txtTENNV.Text.Trim(),txtTENDN.Text.Trim(),
                txtNGAYSINH.Text.Trim(),cboPhai.Text.Trim(), txtDiachi.Text.Trim(), txtDienthoai.Text.Trim(),txtSOHDTH.Text.Trim(),
                txtNGAYDN.Text.Trim(), txtSOLANDN.Text.Trim(),txtQUYENHAN.Text.Trim());
            c.pr_ThemNV(nv);
            pr_LoadForm();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN(txtMANV.Text.Trim(), txtTENNV.Text.Trim(), txtTENDN.Text.Trim(),
                txtNGAYSINH.Text.Trim(), cboPhai.Text.Trim(), txtDiachi.Text.Trim(), txtDienthoai.Text.Trim(), txtSOHDTH.Text.Trim(),
                txtNGAYDN.Text.Trim(), txtSOLANDN.Text.Trim(), txtQUYENHAN.Text.Trim());
            c.pr_SuaNV(nv);
            pr_LoadForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMANV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTENNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTENDN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNGAYSINH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboPhai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSOHDTH.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtNGAYDN.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSOLANDN.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtQUYENHAN.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN(txtMANV.Text.Trim(), txtTENNV.Text.Trim(), txtTENDN.Text.Trim(),
                txtNGAYSINH.Text.Trim(), cboPhai.Text.Trim(), txtDiachi.Text.Trim(), txtDienthoai.Text.Trim(), txtSOHDTH.Text.Trim(),
                txtNGAYDN.Text.Trim(), txtSOLANDN.Text.Trim(), txtQUYENHAN.Text.Trim());
            c.pr_XoaNV(nv);
            pr_LoadForm();
        }
    }
}
