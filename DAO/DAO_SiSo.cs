using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_SiSo : ConnectionString
    {
        public DAO_SiSo() : base() { }
        public int GetSiSoMax()
        {
            int result = 0;
            
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_SISOMAX", conn);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        result = int.Parse(row["SiSoMax"].ToString());
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
