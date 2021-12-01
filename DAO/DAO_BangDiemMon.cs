using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_BangDiemMon : ConnectionString
    {
        public DAO_BangDiemMon() : base() { }
        public double GetDiemTBMon(string mahs, string mahk, string manh, string mamh)
        {
            double result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_DIEMTBMON", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);

                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["DiemTBMon"] != DBNull.Value)
                            result = double.Parse(rd["DiemTBMon"].ToString());
                        rd.Close();
                    }
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    command.Connection.Close();
                }
            }
            return result;
        }
    }
}
