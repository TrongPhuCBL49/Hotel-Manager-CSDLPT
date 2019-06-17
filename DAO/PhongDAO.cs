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
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return instance;
            }
        }

        private PhongDAO() { }

        public DataTable DSPhong()
        {
            string query = "Select p.ID, p.Ten, lp.Ten as LoaiPhong, tt.Ten as TrangThai, p.IDChiNhanh as ChiNhanh " +
                           "From Phong as p, LoaiPhong as lp, TrangThai as tt Where p.IDLoai=lp.ID and p.IDTrangThai=tt.ID";
            return DataProvider.Instance.getDS(query);
        }

        public bool ThemPhong(PhongDTO phong)
        {
            string[] param = { "@ID", "@Ten", "@IDLoai", "@IdTrangThai", "@IDChiNhanh" };
            object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai, phong.IdChiNhanh };
            string query = "Insert Into Phong (ID, Ten, IDLoai, IDTrangThai, IDChiNhanh) Values(@ID,@Ten,@IDLoai,@IDTrangThai,@IDChiNhanh)";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaPhong(PhongDTO phong)
        {
            string[] param = { "@ID", "@Ten", "@IDLoai", "@IDTrangThai", "@IDChiNhanh" };
            object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai, phong.IdChiNhanh };
            string query = "Update Phong Set Ten=@Ten, IDLoai=@IDLoai, IDTrangThai=@IDTrangThai, IDChiNhanh=@IDChiNhanh Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaPhong(PhongDTO phong)
        {
            string[] param = { "@ID" };
            object[] values = { phong.Id };
            string query = "Delete Phong Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public int IdLoaiPhong(string loaiPhong)
        {
            string query = "Select ID From LoaiPhong Where Ten = N'" + loaiPhong + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["ID"].ToString());
        }
        public int IdTrangThai(string trangThai)
        {
            string query = "Select ID From TrangThai Where Ten = N'" + trangThai + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["ID"].ToString());
        }
        public bool KiemTraIDPhong(string IDPhong)
        {
            string strCon = "Data Source=DESKTOP-V4ENO1N\\AUGUSTINONGUYEN2;" +
                            "Initial Catalog=SimpleQuanLyKhachSan;" +
                            "User id=sa;" +
                            "Password=04010409tete;";
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string query = "Select * From Phong Where ID = '" + IDPhong + "'";
                SqlDataAdapter dap = new SqlDataAdapter(query, con);
                dap.Fill(tbl);
            }
            return !(tbl.Rows.Count > 0);
        }
    }
}
