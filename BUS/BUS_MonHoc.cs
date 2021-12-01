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
    public class BUS_MonHoc
    {
        DAO_MonHoc monhoc = new DAO_MonHoc();
        public DataTable GetTatCaMonHoc()
        {
            return monhoc.GetTatCaMonHoc();
        }
        public int? Insert_MonHoc(MonHoc mh)
        {
            return monhoc.Insert_MonHoc(mh);
        }
        public int? Update_MonHoc(MonHoc mh)
        {
            return monhoc.Update_MonHoc(mh);
        }
        public int? Delete_MonHoc(string mamh)
        {
            return monhoc.Delete_MonHoc(mamh);
        }
        public int CheckTonTaiMonHoc(string tenmh)
        {
            return monhoc.CheckTonTaiMonHoc(tenmh);
        }
    }
}
