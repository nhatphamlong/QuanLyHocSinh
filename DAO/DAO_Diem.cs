using DTO;
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
    public class DAO_Diem : ConnectionString
    {
        public DAO_Diem() : base() { }
        public List<double> GetDiem(string mahs, string mamon, string mahk, string manh, string makt)
        {
            List<double> result = new List<double>();
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamon);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach(DataRow row in dt.Rows)
                    {
                        result.Add(double.Parse(row["DiemSo"].ToString()));
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
        public int? Insert_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                command.Parameters.Add("@DIEMSO", SqlDbType.Float).Value = d;

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
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
        public int? Update_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                command.Parameters.Add("@DIEMSO", SqlDbType.Float).Value = d;

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
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
        public int? Delete_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
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
        public double? GetDiemTBHK(string mahs, string manh, string tenhk)
        {
            double? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_DIEMTBHK", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@TENHOCKY", SqlDbType.NVarChar).Value = tenhk;
                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["DiemTBHocKy"] != DBNull.Value)
                            result = double.Parse(rd["DiemTBHocKy"].ToString());
                        rd.Close();
                    }
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    command.Connection.Close();
                }
            }
            Console.WriteLine("Result: " + result.ToString());
            return result;
        }
    }
}
