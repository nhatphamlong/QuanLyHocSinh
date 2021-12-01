using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh
    {
        public long MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public short GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public HocSinh() { }
        public HocSinh(long mahs, string hten, short gtinh, DateTime ngsinh, string dchi, string em)
        {
            MaHocSinh = mahs;
            HoTen = hten;
            GioiTinh = gtinh;
            NgaySinh = ngsinh;
            DiaChi = dchi;
            Email = em;
        }
    }
}
