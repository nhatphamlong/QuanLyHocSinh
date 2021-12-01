using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BCHocKy
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        DAO_BCHocKy bchocky = new DAO_BCHocKy();

        public int? GetSLDat(string malop, string mahk, string manh)
        {
            return bchocky.GetSLDat(malop, mahk, manh);
        }
        public double? GetTLDat(string malop, string mahk, string manh)
        {
            return bchocky.GetTLDat(malop, mahk, manh);
        }
        public DataTable GetBCHocKy(string mahk, string manh)
        {
            DataTable result = danhsachlop.GetTatCaLop();

            result.Columns.Remove("MaKhoiLop");
            result.Columns.Add("SiSo", typeof(int));
            result.Columns.Add("SoLuongDat", typeof(int));
            result.Columns.Add("TiLe", typeof(string));
            result.Columns.Add("STT", typeof(int));

            int stt = 1;
            foreach(DataRow row in result.Rows)
            {
                row["STT"] = stt;
                stt++;

                string malop = row["MaLop"].ToString();
                row["SiSo"] = (object)danhsachlop.GetSiSo(malop, mahk, manh) ?? DBNull.Value;
                row["SoLuongDat"] = (object)this.GetSLDat(malop, mahk, manh) ?? DBNull.Value;
                row["TiLe"] = (object)this.GetTLDat(malop, mahk, manh).ToString() ?? DBNull.Value;
                row["TiLe"] = row["TiLe"] + "%";
            }

            return result;
        }
    }
}
