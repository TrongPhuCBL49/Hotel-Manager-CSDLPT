﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }

        private KhachHangDAO() { }

        public DataTable DSKhachHang()
        {
            string query = "Select ID, Ten, NgaySinh, GioiTinh, Email, SDT, CMND, QuocTich, IDChiNhanh as ChiNhanh From KhachHang";
            return DataProvider.Instance.getDS(query);
        }

        public bool ThemKhachHang(KhachHangDTO khachHang)
        {
            string[] param = { "@ID", "@Ten", "@NgaySinh", "@GioiTinh", "@Email", "@SDT", "@CMND", "@QuocTich", "@IDChiNhanh" };
            object[] values = { khachHang.Id, khachHang.Ten, khachHang.NgaySinh, khachHang.GioiTinh, khachHang.Email, khachHang.Sdt, khachHang.Cmnd, khachHang.QuocTich, khachHang.IdChiNhanh };
            string query = "Insert Into KhachHang (ID, Ten, NgaySinh, GioiTinh, Email, SDT, CMND, QuocTich, IDChiNhanh) " +
                           "Values(@ID,@Ten,convert(date,@NgaySinh,105),@GioiTinh,@Email,@SDT,@CMND,@QuocTich,@IDChiNhanh)";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaKhachHang(KhachHangDTO khachHang)
        {
            string[] param = { "@ID", "@Ten", "@NgaySinh", "@GioiTinh", "@Email", "@SDT", "@CMND", "@QuocTich",  "@IDChiNhanh" };
            object[] values = { khachHang.Id, khachHang.Ten, khachHang.NgaySinh, khachHang.GioiTinh, khachHang.Email, khachHang.Sdt, khachHang.Cmnd, khachHang.QuocTich, khachHang.IdChiNhanh };
            string query = "Update KhachHang Set Ten=@Ten, NgaySinh=convert(date,@NgaySinh,105), GioiTinh=@GioiTinh, QuocTich=@QuocTich, SDT=@SDT, CMND=@CMND, Email=@Email, IDChiNhanh=@IDChiNhanh Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaKhachHang(KhachHangDTO khachHang)
        {
            string[] param = { "@ID" };
            object[] values = { khachHang.Id };
            string query = "Delete KhachHang Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool KiemTraIDKhachHang(string IDKhachHang)
        {
            string strCon = "Data Source=DESKTOP-V4ENO1N\\AUGUSTINONGUYEN2;" +
                            "Initial Catalog=SimpleQuanLyKhachSan;" +
                            "User id=sa;" +
                            "Password=04010409tete;";
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string query = "Select * From KhachHang Where ID = '" + IDKhachHang + "'";
                SqlDataAdapter dap = new SqlDataAdapter(query, con);
                dap.Fill(tbl);
            }
            return !(tbl.Rows.Count > 0);
        }
    }
}
