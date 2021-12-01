using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuaTrinh
    {
        public long MaQuaTrinh { get; set; }
        public long MaHocSinh { get; set; }
        public long MaLop { get; set; }
        public long MaHocKy { get; set; }
        public long MaNamHoc { get; set; }
        public float DiemTBHocKy { get; set; }
        public QuaTrinh() { }
    }
}
