using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhoiLop
    {
        DAO_KhoiLop khoilop = new DAO_KhoiLop();
        public DataTable GetTatCaKhoiLop()
        {
            return khoilop.GetTatCaKhoiLop();
        }
    }
}
