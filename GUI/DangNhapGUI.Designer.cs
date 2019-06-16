namespace GUI
{
    partial class DangNhapGUI
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
            this.btnCancelDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkQuenMatKhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelDangNhap
            // 
            this.btnCancelDangNhap.Location = new System.Drawing.Point(461, 515);
            this.btnCancelDangNhap.Name = "btnCancelDangNhap";
            this.btnCancelDangNhap.Size = new System.Drawing.Size(200, 56);
            this.btnCancelDangNhap.TabIndex = 5;
            this.btnCancelDangNhap.Text = "Cancel";
            this.btnCancelDangNhap.Click += new System.EventHandler(this.btnCancelDangNhap_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(130, 515);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(200, 56);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "OK";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cboChiNhanh);
            this.groupControl1.Controls.Add(this.linkQuenMatKhau);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtMaNhanVien);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(38, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(748, 439);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkQuenMatKhau.Location = new System.Drawing.Point(463, 349);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(207, 33);
            this.linkQuenMatKhau.TabIndex = 2;
            this.linkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(302, 275);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '9';
            this.txtMatKhau.Size = new System.Drawing.Size(368, 50);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.EditValue = "";
            this.txtMaNhanVien.Location = new System.Drawing.Point(302, 183);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(368, 50);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 279);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 34);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 33);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Chi Nhánh:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã nhân viên:";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(302, 96);
            this.cboChiNhanh.Margin = new System.Windows.Forms.Padding(8);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(368, 41);
            this.cboChiNhanh.TabIndex = 1;
            // 
            // DangNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 614);
            this.Controls.Add(this.btnCancelDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "DangNhapGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DangNhapGUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkQuenMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cboChiNhanh;
    }
}

