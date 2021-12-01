using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HocSinh
    {
        DAO_HocSinh hocsinh = new DAO_HocSinh();
        BUS_Diem diem = new BUS_Diem();
        public DataTable GetTatCaHS()
        {
            return hocsinh.GetTatCaHocSinh();
        }
        public int? Insert_HocSinh(HocSinh hs)
        {
            return hocsinh.Insert_HocSinh(hs);
        }
        public int? Update_HocSinh(HocSinh hs)
        {
            return hocsinh.Update_HocSinh(hs);
        }
        public int? Delete_HocSinh(string MaHS)
        {
            return hocsinh.Delete_HocSinh(MaHS);
        }
        public DataTable GetHocSinhCho(string mahk, string manh)
        {
            return hocsinh.GetHocSinhCho(mahk, manh);
        }
        public DataTable GetHocSinh(string malop, string mahk, string manh)
        {
            return hocsinh.GetHocSinh(malop, mahk, manh);
        }
        public int? AddHocSinhVaoLop(string mahs, string malop, string mahk, string manh)
        {
            return hocsinh.AddHocSinhVaoLop(mahs, malop, mahk, manh);
        }
        public int? Delete_HSTrongLop(string mahs, string malop, string mahk, string manh)
        {
            return hocsinh.Delete_HSTrongLop(mahs, malop, mahk, manh);
        }
        public DataTable GetThongTinTraCuu(string hoten, string manh, string tenlop)
        {
            DataTable result = this.GetTatCaHS();

            result.Columns.Remove("GioiTinh");
            result.Columns.Remove("NgaySinh");
            result.Columns.Remove("DiaChi");
            result.Columns.Remove("Email");

            result.Columns.Add("TenLop", typeof(string));
            result.Columns.Add("TBHKI", typeof(float));
            result.Columns.Add("TBHKII", typeof(float));

            result.Columns.Add("SoThuTu", typeof(int));
            int stt = 1;
            foreach (DataRow row in result.Rows)
            {
                if (!row["HoTen"].ToString().ToUpper().Contains(hoten.ToUpper()))
                {
                    row.Delete();
                    continue;
                }

                string mahs = row["MaHocSinh"].ToString();
                row["SoThuTu"] = stt;
                stt++;

                row["TenLop"] = (object)this.GetLop(mahs, manh) ?? DBNull.Value;
                row["TBHKI"] = (object)diem.GetDiemTBHK(mahs, manh, "Học kỳ 1") ?? DBNull.Value;
                row["TBHKII"] = (object)diem.GetDiemTBHK(mahs, manh, "Học kỳ 2") ?? DBNull.Value;

                if (row["TenLop"].ToString() != tenlop && tenlop != null)
                {
                    stt--;
                    row.Delete();
                    continue;
                }
            }

            return result;
        }
        public string GetLop(string mahs, string manh)
        {
            return hocsinh.GetLop(mahs, manh);
        }
    }
}
