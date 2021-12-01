using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Diem
    {
        public DAO_Diem diem = new DAO_Diem();
        public string GetDiem(string mahs, string mahk, string manh, string mamh, string makt)
        {
            string result = "";
            List<double> listDiem = diem.GetDiem(mahs, mamh, mahk, manh, makt);

            foreach(double d in listDiem)
            {
                result += d.ToString() + "; ";
            }

            return result;
        }
        public int? Insert_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            return diem.Insert_Diem(mahs, malop, mahk, manh, mamh, makt, d);
        }
        public int? Update_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            return diem.Update_Diem(mahs, malop, mahk, manh, mamh, makt, d);
        }
        public int? Delete_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt)
        {
            return diem.Delete_Diem(mahs, malop, mahk, manh, mamh, makt);
        }
        public double? GetDiemTBHK(string mahs, string manh, string tenhk)
        {
            return diem.GetDiemTBHK(mahs, manh, tenhk);
        }
    }
}
