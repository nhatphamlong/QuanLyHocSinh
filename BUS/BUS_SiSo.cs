using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SiSo
    {
        DAO_SiSo siso = new DAO_SiSo();
        public int GetSiSoMax()
        {
            return siso.GetSiSoMax();
        }
    }
}
