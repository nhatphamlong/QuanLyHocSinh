using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThamSo
    {
        DAO_ThamSo thamso = new DAO_ThamSo();
        public ThamSo GetThamSo()
        {
            return thamso.GetThamSo();
        }
        public int? UpdateThamSo(ThamSo ts)
        {
            return thamso.Update_ThamSo(ts);
        }
    }
}
