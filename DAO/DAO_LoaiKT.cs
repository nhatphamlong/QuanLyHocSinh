﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LoaiKT : ConnectionString
    {
        public DAO_LoaiKT() : base() { }
        public DataTable GetTatCaLoaiKT()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCALOAIKT", conn);
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
    }
}
