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
    public class BUS_NamHoc
    {
        DAO_NamHoc namhoc = new DAO_NamHoc();
        public DataTable GetTatCaNH()
        {
            return namhoc.GetTatCaNamHoc();
        }
        public int? Insert_NamHoc(string nambd, string namkt)
        {
            return namhoc.Insert_NamHoc(nambd, namkt);
        }
        public int? Update_NamHoc(NamHoc nh)
        {
            return namhoc.Update_HocKy(nh);
        }
        public int? Delete_NamHoc(string manh)
        {
            return namhoc.Delete_NamHoc(manh);
        }
        public int CheckTonTaiNamHoc(string nambd, string namkt)
        {
            return namhoc.CheckTonTaiNamHoc(nambd, namkt);
        }
    }
}
