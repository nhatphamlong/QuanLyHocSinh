using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DanhSachLop
    {
        DAO_DanhSachLop danhsachlop = new DAO_DanhSachLop();
        public DataTable GetTatCaLop()
        {
            return danhsachlop.GetTatCaLop();
        }
        public DataTable GetTatCaLopTrongKhoi(string makl)
        {
            return danhsachlop.GetTatCaLopTrongKhoi(makl);
        }
        public int? Insert_Lop(DanhSachLop lop)
        {
            return danhsachlop.Insert_Lop(lop);
        }
        public int? Update_Lop(DanhSachLop lop)
        {
            return danhsachlop.Update_Lop(lop);
        }
        public int? Delete_Lop(string malop)
        {
            return danhsachlop.Delete_Lop(malop);
        }
        public int GetSiSo(string malop, string mahk, string manh)
        {
            return danhsachlop.GetSiSo(malop, mahk, manh);
        }
        public int CheckTonTaiLop(string tenlop)
        {
            return danhsachlop.CheckTonTaiLop(tenlop);
        }
    }
}
