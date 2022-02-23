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
    public partial class frmMonAn : Form
    {
        BUS_CgetData dt = new BUS_CgetData();
        BUS_MONAN c = new BUS_MONAN();
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            
            DTO_MONAN cus = new DTO_MONAN(txtMAMON.Text.Trim(), txtTENMON.Text.Trim(),
                txtSL.Text.Trim(), txtDONGIA.Text.Trim(), txtDVT.Text.Trim());
            c.pr_ThemMonAN(cus);
            pr_LoadForm();
        }
        public void pr_LoadForm()
        {
            DataTable dt = c.pr_LoadForm();
            dataGridView1.DataSource = dt;
        }
        private void frmMonAn_Load(object sender, EventArgs e)
        {
           DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT * FROM MONAN");
            this.dataGridView1.DataSource = myDT;

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DTO_MONAN cus = new DTO_MONAN(txtMAMON.Text.Trim(), txtTENMON.Text.Trim(),
                txtSL.Text.Trim(), txtDONGIA.Text.Trim(), txtDVT.Text.Trim());
            c.pr_SuaMonAn(cus);
            pr_LoadForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMAMON.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTENMON.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDONGIA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDVT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DTO_MONAN cus = new DTO_MONAN(txtMAMON.Text.Trim(), txtTENMON.Text.Trim(),
               txtSL.Text.Trim(), txtDONGIA.Text.Trim(), txtDVT.Text.Trim());
            c.pr_XoaMonAn(cus);
          pr_LoadForm();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            txtMAMON.Text = "";
            txtTENMON.Text = "";
            txtSL.Text = "";
            txtDONGIA.Text = "";
            txtDVT.Text = "";
            txtMAMON.SelectAll();
            txtMAMON.Focus();
        }
    }
}
