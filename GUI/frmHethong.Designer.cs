namespace GUI
{
    partial class frmHethong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHethong));
            this.menuHethong = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHKN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDTBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDTBHNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDTBTMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTG = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHethong
            // 
            this.menuHethong.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuHethong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDM,
            this.mnuHD,
            this.mnuBC,
            this.mnuTG,
            this.trợGiúpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuHethong.Location = new System.Drawing.Point(0, 0);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuHethong.Size = new System.Drawing.Size(1167, 36);
            this.menuHethong.TabIndex = 0;
            this.menuHethong.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.toolStripSeparator1,
            this.mnuHKN,
            this.toolStripSeparator2,
            this.mnuBR,
            this.toolStripSeparator3,
            this.mnuThoat});
            this.mnuHT.Image = ((System.Drawing.Image)(resources.GetObject("mnuHT.Image")));
            this.mnuHT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(111, 32);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(215, 26);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // mnuHKN
            // 
            this.mnuHKN.Name = "mnuHKN";
            this.mnuHKN.Size = new System.Drawing.Size(215, 26);
            this.mnuHKN.Text = "Hủy kết nối";
            this.mnuHKN.Click += new System.EventHandler(this.mnuHKN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // mnuBR
            // 
            this.mnuBR.Name = "mnuBR";
            this.mnuBR.Size = new System.Drawing.Size(215, 26);
            this.mnuBR.Text = "Backup and Restore";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(215, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMH,
            this.mnuNV,
            this.mnuKH});
            this.mnuDM.Image = ((System.Drawing.Image)(resources.GetObject("mnuDM.Image")));
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(116, 32);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuMH
            // 
            this.mnuMH.Name = "mnuMH";
            this.mnuMH.Size = new System.Drawing.Size(181, 26);
            this.mnuMH.Text = "Món ăn";
            this.mnuMH.Click += new System.EventHandler(this.mnuMH_Click);
            // 
            // mnuNV
            // 
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(181, 26);
            this.mnuNV.Text = "Nhân viên";
            this.mnuNV.Click += new System.EventHandler(this.mnuNV_Click);
            // 
            // mnuKH
            // 
            this.mnuKH.Name = "mnuKH";
            this.mnuKH.Size = new System.Drawing.Size(181, 26);
            this.mnuKH.Text = "Khách hàng";
            this.mnuKH.Click += new System.EventHandler(this.mnuKH_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLHD});
            this.mnuHD.Image = ((System.Drawing.Image)(resources.GetObject("mnuHD.Image")));
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(107, 32);
            this.mnuHD.Text = "Hóa đơn";
            // 
            // mnuLHD
            // 
            this.mnuLHD.Name = "mnuLHD";
            this.mnuLHD.Size = new System.Drawing.Size(181, 26);
            this.mnuLHD.Text = "Lập hóa đơn";
            this.mnuLHD.Click += new System.EventHandler(this.mnuLHD_Click);
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInHD,
            this.mnuDTBH});
            this.mnuBC.Image = ((System.Drawing.Image)(resources.GetObject("mnuBC.Image")));
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(103, 32);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuInHD
            // 
            this.mnuInHD.Name = "mnuInHD";
            this.mnuInHD.Size = new System.Drawing.Size(219, 26);
            this.mnuInHD.Text = "In hóa đơn";
            // 
            // mnuDTBH
            // 
            this.mnuDTBH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDTBHNV,
            this.mnuDTBTMH});
            this.mnuDTBH.Name = "mnuDTBH";
            this.mnuDTBH.Size = new System.Drawing.Size(219, 26);
            this.mnuDTBH.Text = "Doanh thu bán hàng";
            // 
            // mnuDTBHNV
            // 
            this.mnuDTBHNV.Name = "mnuDTBHNV";
            this.mnuDTBHNV.Size = new System.Drawing.Size(272, 26);
            this.mnuDTBHNV.Text = "Doanh số cho mỗi nhân viên";
            // 
            // mnuDTBTMH
            // 
            this.mnuDTBTMH.Name = "mnuDTBTMH";
            this.mnuDTBTMH.Size = new System.Drawing.Size(272, 26);
            this.mnuDTBTMH.Text = "Doanh số cho mỗi món ăn";
            this.mnuDTBTMH.Click += new System.EventHandler(this.mnuDTBTMH_Click);
            // 
            // mnuTG
            // 
            this.mnuTG.Name = "mnuTG";
            this.mnuTG.Size = new System.Drawing.Size(12, 32);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúpToolStripMenuItem.Image")));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmHethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 587);
            this.Controls.Add(this.menuHethong);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHethong;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHethong";
            this.Text = "Hệ thống quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHethong_Load);
            this.menuHethong.ResumeLayout(false);
            this.menuHethong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHethong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuDM;
        public System.Windows.Forms.ToolStripMenuItem mnuMH;
        public System.Windows.Forms.ToolStripMenuItem mnuNV;
        public System.Windows.Forms.ToolStripMenuItem mnuKH;
        public System.Windows.Forms.ToolStripMenuItem mnuHD;
        public System.Windows.Forms.ToolStripMenuItem mnuLHD;
        public System.Windows.Forms.ToolStripMenuItem mnuBC;
        public System.Windows.Forms.ToolStripMenuItem mnuInHD;
        public System.Windows.Forms.ToolStripMenuItem mnuDTBHNV;
        public System.Windows.Forms.ToolStripMenuItem mnuDTBTMH;
        public System.Windows.Forms.ToolStripMenuItem mnuTG;
        public System.Windows.Forms.ToolStripMenuItem mnuDTBH;
        public System.Windows.Forms.ToolStripMenuItem mnuHT;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuHKN;
        public System.Windows.Forms.ToolStripMenuItem mnuBR;
        public System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

