using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace QLBNCV19
{
    public partial class BLL_HeThong 
    {
        Database data;

        
        public BLL_HeThong()
        {
            data = new Database();
        }
        public bool KiemTraKetNoi(ref string err)
        {
            if (data == null)
                return false;
            if (!data.KiemTraKetNoi(ref err))
                return false;
            return true;
        }

        public DataTable KiemTraDangNhap(ref string err, string taiKhoan, string matKhau)
        {
            return data.GetDataTable(ref err, "PSD_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TenTaiKhoan", taiKhoan),
                new SqlParameter("@MatKhau", matKhau));
        }

        public DataTable LayDanhSachBenhNhan(ref string err)
        {
            return data.GetDataTable(ref err, "PSD_LayDanhSachBenhNhan", CommandType.StoredProcedure, null);
        }

        public DataTable LayTongBenhNhan(ref string err,int tong)
        {
            return data.GetDataTable(ref err, "PSD_TongBenhNhan", CommandType.StoredProcedure, new SqlParameter("@Tong",tong));
        }
        public DataTable LayDanhSachBenhNhanDuongTinh(ref string err)
        {
            return data.GetDataTable(ref err, "PSD_DuongTinh_Select", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachBenhNhanAmTinh(ref string err)
        {
            return data.GetDataTable(ref err, "PSD_AmTinh_Select", CommandType.StoredProcedure, null);
        }
        public DataTable LayDanhSachBenhNhanTuVong(ref string err)
        {
            return data.GetDataTable(ref err, "PSD_TuVong_Select", CommandType.StoredProcedure, null);
        }

        public bool CapNhatBenhNhan(ref string err, ref int count,  DTO_QLBN dTO_QLBN)
        {
            return data.myExcutenonQuery(ref err, "PSD_CapNhat", CommandType.StoredProcedure,
                new SqlParameter("@MaBN", dTO_QLBN.MaBN),
                new SqlParameter("@HoVaTen", dTO_QLBN.HoVaTen),
                new SqlParameter("@NgaySinh", dTO_QLBN.NgaySinh),
                new SqlParameter("@DiaChi", dTO_QLBN.DiaChi),
                new SqlParameter("@HoVaTenBS", dTO_QLBN.HoVaTenBS),
                new SqlParameter("@TinhTrang", dTO_QLBN.TinhTrang),
                new SqlParameter("@MoTa",dTO_QLBN.MoTa) 
                );
        }
    }
}
