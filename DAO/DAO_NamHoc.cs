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
    public class DAO_NamHoc : ConnectionString
    {
        public DAO_NamHoc() : base() { }
        public DataTable GetTatCaNamHoc()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCANH", conn);
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
        public int? Insert_NamHoc(string nambd, string namkt)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_NAMHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NAMBD", SqlDbType.Int).Value = int.Parse(nambd);
                command.Parameters.Add("@NAMKT", SqlDbType.Int).Value = int.Parse(namkt);
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
        public int? Update_HocKy(NamHoc namhoc)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_NAMHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = namhoc.MaNamHoc;
                command.Parameters.Add("@NAMBD", SqlDbType.Int).Value = namhoc.NamBD;
                command.Parameters.Add("@NAMKT", SqlDbType.Int).Value = namhoc.NamKT;
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
        public int? Delete_NamHoc(string manh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_NAMHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
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
        public int CheckTonTaiNamHoc(string nambd, string namkt)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("CHECK_TONTAINAMHOC", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NAMBD", SqlDbType.Int).Value = int.Parse(nambd);
                command.Parameters.Add("@NAMKT", SqlDbType.Int).Value = int.Parse(namkt);
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
