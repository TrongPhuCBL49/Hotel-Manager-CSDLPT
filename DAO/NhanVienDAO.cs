using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }

        private NhanVienDAO() { }

        public DataTable DSNhanVien()
        {
            string query = "Select nv.ID, nv.Ten, cd.Ten as ChucDanh, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SDT, nv.CMND, nv.Email, nv.IDChiNhanh as ChiNhanh " +
                           "From NhanVien as nv, ChucDanh as cd Where nv.IDChucDanh=cd.ID";
            return DataProvider.Instance.getDS(query);
        }

        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            string[] param = { "@ID", "@Ten", "@IDChucDanh", "@NgaySinh", "@GioiTinh", "@DiaChi", "@SDT", "@CMND", "@Email", "@IDChiNhanh" };
            object[] values = { nhanVien.Id, nhanVien.Ten, nhanVien.IdChucDanh, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.Cmnd, nhanVien.Email, nhanVien.IdChiNhanh };
            string query = "Insert Into NhanVien (ID, Ten, NgaySinh, GioiTinh, DiaChi, SDT, CMND, Email, IDChucDanh, IDChiNhanh)" +
                           "Values(@ID,@Ten,convert(date,@NgaySinh,105),@GioiTinh,@DiaChi,@SDT,@CMND,@Email,@IDChucDanh,@IDChiNhanh)";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaNhanVien(NhanVienDTO nhanVien)
        {
            string[] param = { "@ID", "@Ten", "@IDChucDanh", "@NgaySinh", "@GioiTinh", "@DiaChi", "@SDT", "@CMND", "@Email", "@IDChiNhanh" };
            object[] values = { nhanVien.Id, nhanVien.Ten, nhanVien.IdChucDanh, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.Cmnd, nhanVien.Email, nhanVien.IdChiNhanh };
            string query = "Update NhanVien Set Ten=@Ten, IDChucDanh=@IDChucDanh, NgaySinh=convert(date,@NgaySinh,105), GioiTinh=@GioiTinh, DiaChi=@DiaChi, SDT=@SDT, CMND=@CMND, Email=@Email, IDChiNhanh=@IDChiNhanh Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaNhanVien(NhanVienDTO nhanVien)
        {
            string[] param = { "@ID" };
            object[] values = { nhanVien.Id };
            string query = "Delete NhanVien Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public int IdChucDanh(string chucDanh)
        {
            string query = "Select ID From ChucDanh Where Ten = N'" + chucDanh + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["ID"].ToString());
        }
        public bool KiemTraIDNhanVien(string IDNhanVien)
        {
            string strCon = "Data Source=DESKTOP-V4ENO1N\\AUGUSTINONGUYEN2;" +
                            "Initial Catalog=SimpleQuanLyKhachSan;" +
                            "User id=sa;" +
                            "Password=04010409tete;";
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string query = "Select * From NhanVien Where ID = '" + IDNhanVien + "'";
                SqlDataAdapter dap = new SqlDataAdapter(query, con);
                dap.Fill(tbl);
            }
            return !(tbl.Rows.Count > 0);
        }
    }
}
