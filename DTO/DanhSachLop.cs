using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachLop
    {
        public long MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public long MaKhoiLop { get; set; }
        public DanhSachLop() { }
    }
}
