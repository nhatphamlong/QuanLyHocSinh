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
    public class DAO_DanhSachLop : ConnectionString
    {
        public DAO_DanhSachLop() : base() { }
        public DataTable GetTatCaLop()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCALOP", conn);
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
        public DataTable GetTatCaLopTrongKhoi(string makl)
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCALOPTRONGKHOI", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAKHOILOP", SqlDbType.Decimal).Value = long.Parse(makl);
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
        public int? Insert_Lop(DanhSachLop lop)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_LOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop.TenLop;
                command.Parameters.Add("@MAKHOILOP", SqlDbType.Decimal).Value = lop.MaKhoiLop;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    //Console.WriteLine(ex.Message);
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Update_Lop(DanhSachLop lop)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_LOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = lop.MaLop;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop.TenLop;
                command.Parameters.Add("@MAKHOILOP", SqlDbType.Decimal).Value = lop.MaKhoiLop;
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
        public int? Delete_Lop(string malop)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_LOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
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
        public int GetSiSo(string malop, string mahk, string manh)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_SISO", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    result = int.Parse(dt.Rows[0][0].ToString());
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int CheckTonTaiLop(string tenlop)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("CHECK_TONTAILOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = tenlop;
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
