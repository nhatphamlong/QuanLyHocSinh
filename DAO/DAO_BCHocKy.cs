using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_BCHocKy : ConnectionString
    {
        public DAO_BCHocKy() : base() { }
        public int? GetSLDat(string malop, string mahk, string manh)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_SOLUONGDAT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);

                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["SLDat"] != DBNull.Value)
                            result = int.Parse(rd["SLDat"].ToString());
                        rd.Close();
                    }
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public double? GetTLDat(string malop, string mahk, string manh)
        {
            double? result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TILEDAT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);

                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["TLDat"] != DBNull.Value)
                            result = ((int)(float.Parse(rd["TLDat"].ToString()) * 100))/100f;
                        rd.Close();
                    }
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
    }
}
