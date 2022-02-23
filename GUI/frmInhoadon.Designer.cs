namespace GUI
{
    partial class frmInhoadon
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btInhoadon = new System.Windows.Forms.Button();
            this.txtMasohoadon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewerHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btThoat.Location = new System.Drawing.Point(645, 19);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(124, 40);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btInhoadon
            // 
            this.btInhoadon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btInhoadon.Location = new System.Drawing.Point(500, 18);
            this.btInhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btInhoadon.Name = "btInhoadon";
            this.btInhoadon.Size = new System.Drawing.Size(124, 40);
            this.btInhoadon.TabIndex = 2;
            this.btInhoadon.Text = "In hóa đơn";
            this.btInhoadon.UseVisualStyleBackColor = false;
            this.btInhoadon.Click += new System.EventHandler(this.btInhoadon_Click);
            // 
            // txtMasohoadon
            // 
            this.txtMasohoadon.Location = new System.Drawing.Point(221, 21);
            this.txtMasohoadon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasohoadon.Multiline = true;
            this.txtMasohoadon.Name = "txtMasohoadon";
            this.txtMasohoadon.Size = new System.Drawing.Size(213, 35);
            this.txtMasohoadon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số hóa đơn:";
            // 
            // crystalReportViewerHD
            // 
            this.crystalReportViewerHD.ActiveViewIndex = -1;
            this.crystalReportViewerHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHD.Location = new System.Drawing.Point(0, 67);
            this.crystalReportViewerHD.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewerHD.Name = "crystalReportViewerHD";
            this.crystalReportViewerHD.Size = new System.Drawing.Size(963, 504);
            this.crystalReportViewerHD.TabIndex = 3;
            this.crystalReportViewerHD.ToolPanelWidth = 145;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btInhoadon);
            this.groupBox1.Controls.Add(this.txtMasohoadon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(963, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập mã số hóa đơn";
            // 
            // frmInhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 571);
            this.Controls.Add(this.crystalReportViewerHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInhoadon";
            this.Text = "In hoá đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btInhoadon;
        private System.Windows.Forms.TextBox txtMasohoadon;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHD;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}