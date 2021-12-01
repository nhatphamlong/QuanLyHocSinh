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
    public class BUS_HocKy
    {
        DAO_HocKy hocky = new DAO_HocKy();
        public DataTable GetTatCaHK()
        {
            return hocky.GetTatCaHocKy();
        }
        public int? Insert_HocKy(string tenhk)
        {
            return hocky.Insert_HocKy(tenhk);
        }
        public int? Update_HocKy(HocKy hk)
        {
            return hocky.Update_HocKy(hk);
        }
        public int? Delete_HocKy(string mahk)
        {
            return hocky.Delete_HocKy(mahk);
        }
        public int CheckTonTaiHocKy(string tenhk)
        {
            return hocky.CheckTonTaiHocKy(tenhk);
        }
    }
}
