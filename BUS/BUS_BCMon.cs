using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BCMon
    {
        DAO_BCMon bcmon = new DAO_BCMon();
        DAO_DanhSachLop danhsachlop = new DAO_DanhSachLop();
        public int? GetSLDat(string malop, string mahk, string manh, string mamh)
        {
            return bcmon.GetSLDat(malop, mahk, manh, mamh);
        }
        public double? GetTLDat(string malop, string mahk, string manh, string mamh)
        {
            return bcmon.GetTLDat(malop, mahk, manh, mamh);
        }
        public DataTable GetBCMon(string mahk, string manh, string mamh)
        {
            DataTable result = danhsachlop.GetTatCaLop();

            result.Columns.Remove("MaKhoiLop");
            result.Columns.Add("SiSo", typeof(int));
            result.Columns.Add("SoLuongDat", typeof(int));
            result.Columns.Add("TiLe", typeof(string));
            result.Columns.Add("STT", typeof(int));

            int stt = 1;
            foreach (DataRow row in result.Rows)
            {
                row["STT"] = stt;
                stt++;

                string malop = row["MaLop"].ToString();
                row["SiSo"] = (object)danhsachlop.GetSiSo(malop, mahk, manh) ?? DBNull.Value;
                row["SoLuongDat"] = (object)this.GetSLDat(malop, mahk, manh, mamh) ?? DBNull.Value;
                row["TiLe"] = (object)this.GetTLDat(malop, mahk, manh, mamh).ToString() ?? DBNull.Value;
                row["TiLe"] = row["TiLe"] + "%";
            }

            return result;
        }
    }
}
