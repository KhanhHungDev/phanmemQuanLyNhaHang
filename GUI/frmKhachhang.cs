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
    public partial class frmKhachhang : Form
    {
        //--------1.Khai báo tầng BUS
        BUS_CCustomer c = new BUS_CCustomer();
        BUS_CgetData dt = new BUS_CgetData();
        DataTable myDT = new DataTable();
        private DataRow myRow = null;
        public DataTable myTable = new DataTable();
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            
        }
        public void pr_LoadForm()
        {
            DataTable dt = c.pr_LoadForm();
            dataGridView1.DataSource = dt;
        }
        private void frmKhachhang_Load(object sender, EventArgs e)
        { 
            //Thêm giới tính khách hàng vào cb box
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT PHAI FROM KHACHHANG");
            this.cboPhai.DataSource = myDT;

            this.cboPhai.DisplayMember = "PHAI";
            this.cboPhai.DropDownStyle = ComboBoxStyle.DropDownList;

            //Hiện dữ liệu lên gridview
           
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT * FROM KHACHHANG");
            this.dataGridView1.DataSource = myDT;

            myTable.Clear();
            pr_LoadForm();
            

            
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DTO_CCustomer cus = new DTO_CCustomer(txtMsKH.Text.Trim(),
                                                  txtTenKH.Text.Trim(),
                                                  cboPhai.Text.Trim(),
                                                  txtDiachi.Text.Trim(),
                                                  txtDienthoai.Text.Trim());
            c.pr_ThemKH(cus);
            pr_LoadForm();
            
            
            
        }

        private void cboPhai_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btTim_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DTO_CCustomer cus = new DTO_CCustomer(txtMsKH.Text.Trim(),
                                                 txtTenKH.Text.Trim(),
                                                 cboPhai.Text.Trim(),
                                                 txtDiachi.Text.Trim(),
                                                 txtDienthoai.Text.Trim());
            c.pr_SuaKH(cus);
            pr_LoadForm();
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DTO_CCustomer cus = new DTO_CCustomer(txtMsKH.Text.Trim(),
                                                  txtTenKH.Text.Trim(),
                                                  cboPhai.Text.Trim(),
                                                  txtDiachi.Text.Trim(),
                                                  txtDienthoai.Text.Trim());
                c.pr_XoaKH(cus);
                pr_LoadForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



            txtMsKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cboPhai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txtDiachi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            txtMsKH.Text = "";
            txtTenKH.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            cboPhai.Text = "Nam";
            txtMsKH.SelectAll();
            txtMsKH.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             myDT = new DataTable();
            

            //-------------2.Thêm mặt hàng vào DataGridView
            
        }

        private void btKhongluu_Click_1(object sender, EventArgs e)
        {
            this.txtMsKH.Text = "";
            txtTenKH.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            cboPhai.Text = "Nam";
            txtMsKH.SelectAll();
            this.txtMsKH.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
