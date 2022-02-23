namespace GUI
{
    partial class frmBCDSMoiMHReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBaocao = new System.Windows.Forms.Button();
            this.Denngay = new System.Windows.Forms.DateTimePicker();
            this.Tungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewerP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btBaocao);
            this.groupBox1.Controls.Add(this.Denngay);
            this.groupBox1.Controls.Add(this.Tungay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1001, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập từ ngày - đến ngày";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(726, 29);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 31);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBaocao
            // 
            this.btBaocao.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btBaocao.Location = new System.Drawing.Point(591, 29);
            this.btBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(97, 31);
            this.btBaocao.TabIndex = 3;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.UseVisualStyleBackColor = false;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // Denngay
            // 
            this.Denngay.CustomFormat = "dd/MM/yyyy";
            this.Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Denngay.Location = new System.Drawing.Point(372, 35);
            this.Denngay.Margin = new System.Windows.Forms.Padding(2);
            this.Denngay.Name = "Denngay";
            this.Denngay.Size = new System.Drawing.Size(147, 27);
            this.Denngay.TabIndex = 2;
            // 
            // Tungay
            // 
            this.Tungay.CustomFormat = "dd/MM/yyyy";
            this.Tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Tungay.Location = new System.Drawing.Point(124, 35);
            this.Tungay.Margin = new System.Windows.Forms.Padding(2);
            this.Tungay.Name = "Tungay";
            this.Tungay.Size = new System.Drawing.Size(147, 27);
            this.Tungay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // crystalReportViewerP
            // 
            this.crystalReportViewerP.ActiveViewIndex = -1;
            this.crystalReportViewerP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerP.Location = new System.Drawing.Point(0, 81);
            this.crystalReportViewerP.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewerP.Name = "crystalReportViewerP";
            this.crystalReportViewerP.Size = new System.Drawing.Size(1001, 440);
            this.crystalReportViewerP.TabIndex = 1;
            this.crystalReportViewerP.ToolPanelWidth = 145;
            // 
            // frmBCDSMoiMHReport
            // 
            this.AcceptButton = this.btBaocao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(1001, 521);
            this.Controls.Add(this.crystalReportViewerP);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBCDSMoiMHReport";
            this.Text = "Báo cáo doanh số cho mỗi mặt hàng [Từ ngày - Đến ngày]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DateTimePicker Denngay;
        private System.Windows.Forms.DateTimePicker Tungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerP;
    }
}