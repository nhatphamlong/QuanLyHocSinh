using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NamHoc
    {
        public long MaNamHoc { get; set; }
        public int NamBD { get; set; }
        public int NamKT { get; set; }
        public string NamHoc_Full
        {
            get
            {
                return NamBD.ToString() + " - " + NamKT.ToString();
            }
        }
    }
}
