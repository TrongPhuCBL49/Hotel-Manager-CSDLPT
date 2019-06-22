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
        public static int IndexChiNhanh;

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
            // Kiểm tra đăng nhập
            if (DangNhapBUS.KiemTraUser(dataSource(cboChiNhanh.SelectedIndex), txtMaNhanVien.Text, txtMatKhau.Text))
            {
                IdNhanVien = txtMaNhanVien.Text;
                IdChucDanh = idChucDanh(IdNhanVien);
                IndexChiNhanh = cboChiNhanh.SelectedIndex;
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
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
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
        public int idChucDanh(string idNhanVien)
        {
            string strCon = "Data Source=" + dataSource(2) + ";" +
                            "Initial Catalog=SimpleQuanLyKhachSan;" +
                            "User id=sa;" +
                            "Password=04010409tete;";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                DataTable tbl = new DataTable();
                string sql = "Select IDChucDanh From NhanVien Where ID = '" + idNhanVien + "'";
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(tbl);
                return int.Parse(tbl.Rows[0]["IDChucDanh"].ToString());
            }
        }
    }
}
