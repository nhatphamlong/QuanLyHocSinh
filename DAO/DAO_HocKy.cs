using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_HocKy : ConnectionString
    {
        public DAO_HocKy() : base() { }
        public DataTable GetTatCaHocKy()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCAHK", conn);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    result = new DataTable();
                    da.Fill(result);
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Insert_HocKy(string tenhk)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_HOCKY", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENHOCKY", SqlDbType.NVarChar).Value = tenhk;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Update_HocKy(HocKy hocky)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_HOCKY", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = hocky.MaHocKy;
                command.Parameters.Add("@TENHOCKY", SqlDbType.NVarChar).Value = hocky.TenHocKy;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Delete_HocKy(string mahk)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_HOCKY", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int CheckTonTaiHocKy(string tenhk)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("CHECK_TONTAIHOCKY", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENHOCKY", SqlDbType.NVarChar).Value = tenhk;
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        result++;
                    }
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    command.Connection.Close();
                }
            }
            return result;
        }
    }
}
