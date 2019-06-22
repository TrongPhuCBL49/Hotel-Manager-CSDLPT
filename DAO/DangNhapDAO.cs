using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }
        }
        private DangNhapDAO() { }

        //public bool KiemTraUser(UserDTO userDTO)
        //{
        //    string query = "Select * From Users Where IDNhanVien = '" + userDTO.IdNhanVien + "' and Pass = '" + userDTO.Pass + "'";
        //    DataTable dtb = DataProvider.Instance.getDS(query);
        //    return (dtb.Rows.Count > 0);
        //}

        public int IdChucDanh(string idNhanVien)
        {
            string query = "Select IDChucDanh From NhanVien Where ID = '" + idNhanVien + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["IDChucDanh"].ToString());
        }

        public static bool KiemTraUser(string dataSource, string maNhanVien, string matKhau)
        {
            DataProvider.getDataSource(dataSource, maNhanVien, matKhau);
            try
            {
                string query = "Select * From NhanVien";
                DataTable dtb = DataProvider.Instance.getDS(query);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
