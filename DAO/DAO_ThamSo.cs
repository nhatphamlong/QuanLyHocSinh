using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_ThamSo : ConnectionString
    {
        public DAO_ThamSo() : base() { }
        public int? Update_ThamSo(ThamSo thamso)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_THAMSO", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@TUOIMIN", System.Data.SqlDbType.Int).Value = thamso.TuoiToiThieu;
                command.Parameters.Add("@TUOIMAX", System.Data.SqlDbType.Int).Value = thamso.TuoiToiDa;
                command.Parameters.Add("@SISOMAX", System.Data.SqlDbType.Int).Value = thamso.SiSoToiDa;
                command.Parameters.Add("@DIEMMIN", System.Data.SqlDbType.Float).Value = thamso.DiemToiThieu;
                command.Parameters.Add("@DIEMMAX", System.Data.SqlDbType.Float).Value = thamso.DiemToiDa;
                command.Parameters.Add("@DIEMDAT", System.Data.SqlDbType.Float).Value = thamso.DiemDat;
                command.Parameters.Add("@DIEMDATMON", System.Data.SqlDbType.Float).Value = thamso.DiemDatMon;

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
        public ThamSo GetThamSo()
        {
            ThamSo result = new ThamSo();
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_THAMSO", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    Console.WriteLine("-------------------------------");
                    if (rd.Read())
                    {
                        result.TuoiToiThieu = Convert.ToInt32(rd["TuoiToiThieu"]);
                        //Console.WriteLine(result.TuoiToiThieu);
                        result.TuoiToiDa = Convert.ToInt32(rd["TuoiToiDa"]);
                        result.SiSoToiDa = Convert.ToInt32(rd["SiSoToiDa"]);
                        result.DiemToiThieu = Convert.ToDouble(rd["DiemToiThieu"]);
                        result.DiemToiDa = Convert.ToDouble(rd["DiemToiDa"]);
                        result.DiemDat = Convert.ToDouble(rd["DiemDat"]);
                        result.DiemDatMon = Convert.ToDouble(rd["DiemDatMon"]);
                        rd.Close();
                    }
                    Console.WriteLine("---------------------------------");
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int GetTuoiMax()
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_THAMSO", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@TUOIMAX", System.Data.SqlDbType.TinyInt).Direction = System.Data.ParameterDirection.Output;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = Convert.ToInt32(command.Parameters["@TUOIMAX"].Value);
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int GetTuoiMin()
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_THAMSO", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@TUOIMIN", System.Data.SqlDbType.TinyInt).Direction = System.Data.ParameterDirection.Output;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = Convert.ToInt32(command.Parameters["@TUOIMIN"].Value);
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int GetSiSoMax()
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_THAMSO", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@SISOMAX", System.Data.SqlDbType.TinyInt).Direction = System.Data.ParameterDirection.Output;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = Convert.ToInt32(command.Parameters["@SISOMAX"].Value);
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
