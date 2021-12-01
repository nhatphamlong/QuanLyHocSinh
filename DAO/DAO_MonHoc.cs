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
    public class DAO_MonHoc : ConnectionString
    {
        public DAO_MonHoc() : base() { }
        public DataTable GetTatCaMonHoc()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCAMONHOC", conn);
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
        public int? Insert_MonHoc(MonHoc mh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_MONHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENMONHOC", SqlDbType.NVarChar).Value = mh.TenMonHoc;
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
        public int? Update_MonHoc(MonHoc mh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_MONHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = mh.MaMonHoc;
                command.Parameters.Add("@TENMONHOC", SqlDbType.NVarChar).Value = mh.TenMonHoc;
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
        public int? Delete_MonHoc(string mamh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_MONHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
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
        public int CheckTonTaiMonHoc(string tenmh)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("CHECK_TONTAIMONHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENMONHOC", SqlDbType.NVarChar).Value = tenmh;
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
