using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BangDiemMon
    {
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        DAO_BangDiemMon bangdiemmon = new DAO_BangDiemMon();
        BUS_LoaiKT loaikt = new BUS_LoaiKT();
        BUS_Diem diem = new BUS_Diem();
        public DataTable GetBangDiem(string malop, string mahk, string manh, string mamh)
        {
            DataTable result = hocsinh.GetHocSinh(malop, mahk, manh);

            result.Columns.Remove("GioiTinh");
            result.Columns.Remove("NgaySinh");
            result.Columns.Remove("DiaChi");
            result.Columns.Remove("Email");
            result.Columns.Add("1", typeof(string));
            result.Columns.Add("2", typeof(string));
            result.Columns.Add("3", typeof(string));
            result.Columns.Add("DiemTB", typeof(float));
            result.Columns.Add("STT", typeof(int));

            int stt = 1;
            foreach (DataRow row in result.Rows)
            {
                row["STT"] = stt;
                stt++;

                string mahs = row["MaHocSinh"].ToString();
                row["1"] = (object)diem.GetDiem(mahs, mahk, manh, mamh, "1") ?? DBNull.Value;
                row["2"] = (object)diem.GetDiem(mahs, mahk, manh, mamh, "2") ?? DBNull.Value;
                row["3"] = (object)diem.GetDiem(mahs, mahk, manh, mamh, "3") ?? DBNull.Value;
                row["DiemTB"] = (object)this.GetDiemTBMon(mahs, mahk, manh, mamh) ?? DBNull.Value;
            }

            return result;
        }
        public double GetDiemTBMon(string mahs, string mahk, string manh, string mamh)
        {
            return bangdiemmon.GetDiemTBMon(mahs, mahk, manh, mamh);
        }
    }
}
