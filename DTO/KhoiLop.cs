using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoiLop
    {
        public long MaKhoiLop { get; set; }
        public string TenKhoiLop { get; set; }
        public KhoiLop() { }
        public KhoiLop(long makhoi, string tenkhoi)
        {
            MaKhoiLop = makhoi;
            TenKhoiLop = tenkhoi;
        } 
    }
}
