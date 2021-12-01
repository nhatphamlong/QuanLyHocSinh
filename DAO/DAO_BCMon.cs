using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_BCMon : ConnectionString
    {
        public DAO_BCMon() : base() { }
        public int? GetSLDat(string malop, string mahk, string manh, string mamh)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_SLDATMON", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);

                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["SLDatMon"] != DBNull.Value)
                            result = int.Parse(rd["SLDatMon"].ToString());
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
        public double? GetTLDat(string malop, string mahk, string manh, string mamh)
        {
            double? result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TLDATMON", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);

                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["TLDatMon"] != DBNull.Value)
                            result = ((int)(float.Parse(rd["TLDatMon"].ToString()) * 100))/100f;
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
