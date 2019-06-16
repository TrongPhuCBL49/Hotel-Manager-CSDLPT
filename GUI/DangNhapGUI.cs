using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class DangNhapGUI : DevExpress.XtraEditors.XtraForm
    {
        public static string IdNhanVien = "";
        public static int IdChucDanh = -1;

        public DangNhapGUI()
        {
            InitializeComponent();
            //Load danh sách Chi Nhánh
            List<String> ChiNhanhs = loadChiNhanh();
            ChiNhanhs.Add("Server Tổng");
            cboChiNhanh.DataSource = ChiNhanhs;
            txtMaNhanVien.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            login();
        }

        void login()
        {
            // Lấy Tên server dựa vào lựa chọn chi nhánh
            DangNhapBUS.getDataSource(dataSource(cboChiNhanh.SelectedIndex));
            // Kiểm tra đăng nhập
            if (DangNhapBUS.Instance.KiemTraUser(txtMaNhanVien.Text, txtMatKhau.Text))
            {
                IdNhanVien = txtMaNhanVien.Text;
                IdChucDanh = DangNhapBUS.Instance.IdChucDanh(IdNhanVien);
                Form f = new MainGUI();
                //Xử lý khi đóng form con thì sẽ chạy event show lại form này
                f.FormClosed += F_FormClosed;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                this.Hide();
                txtMaNhanVien.Text = "";
                txtMatKhau.Text = "";
            }
            else
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCancelDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhapGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private string dataSource(int index)
        {
            switch (index)
            {
                case 0:
                    return "DESKTOP-V4ENO1N\\AUGUSTINONGUYEN1";
                    break;
                case 1:
                    return "DESKTOP-V4ENO1N\\AUGUSTINONGUYEN3";
                    break;
                default:
                    return "DESKTOP-V4ENO1N\\AUGUSTINONGUYEN2";
                    break;
            }
        }
        // Load danh sách Chi Nhánh lên form đăng nhập
        public List<String> loadChiNhanh()
        {
            List<String> list = new List<string>();
            string strCon = "Data Source=" + dataSource(2) + ";" +
                            "Initial Catalog=SimpleQuanLyKhachSan;" +
                            "User id=sa;" +
                            "Password=04010409tete;";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                DataTable tbl = new DataTable();
                string sql = "Select * From ChiNhanh";
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(tbl);
                foreach (DataRow row in tbl.Rows)
                    list.Add(row["Ten"].ToString());
            }
            return list;
        }

    }
}
