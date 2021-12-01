using DTO;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_HocSinh : ConnectionString
    {
        public DAO_HocSinh() : base() { }
        public int? Insert_HocSinh(HocSinh hocsinh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_HOCSINH", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = hocsinh.HoTen;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = hocsinh.GioiTinh;
                command.Parameters.Add("@NGAYSINH", SqlDbType.SmallDateTime).Value = hocsinh.NgaySinh;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hocsinh.DiaChi;
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = hocsinh.Email;
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
        public int? Update_HocSinh(HocSinh hocsinh)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_HOCSINH", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = hocsinh.MaHocSinh;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = hocsinh.HoTen;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = hocsinh.GioiTinh;
                command.Parameters.Add("@NGAYSINH", SqlDbType.SmallDateTime).Value = hocsinh.NgaySinh;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hocsinh.DiaChi;
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = hocsinh.Email;
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
        public int? Delete_HocSinh(string MaHS)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_HOCSINH", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(MaHS);
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
        public DataTable GetTatCaHocSinh()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCAHS", conn);
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
        public DataTable GetHocSinhCho(string mahk, string manh)
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_HOCSINHCHO", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
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
        public DataTable GetHocSinh(string malop, string mahk, string manh)
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_HOCSINHTHEOLOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
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
        public int? AddHocSinhVaoLop(string MaHS, string MaLop, string MaHocKy, string MaNamHoc)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_HS_INTO_LOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(MaHS);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(MaLop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(MaHocKy);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(MaNamHoc);
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
        public int? Delete_HSTrongLop(string MaHS, string MaLop, string MaHocKy, string MaNamHoc)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_HSTRONGLOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(MaHS);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(MaLop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(MaHocKy);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(MaNamHoc);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    command.Connection.Close();
                }
            }
            return result;
        }

        public string GetLop(string mahs, string manh)
        {
            string result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_LOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["TenLop"] != DBNull.Value)
                            result = rd["TenLop"].ToString();
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
