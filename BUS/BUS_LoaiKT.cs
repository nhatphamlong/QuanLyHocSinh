using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiKT
    {
        DAO_LoaiKT loaikt = new DAO_LoaiKT();
        public DataTable GetTatCaLoaiKT()
        {
            return loaikt.GetTatCaLoaiKT();
        }
    }
}
