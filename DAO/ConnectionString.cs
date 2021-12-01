using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class ConnectionString
    {
        protected string connectionString = null;
        protected string GetConnectionString()
        {
            if (connectionString != null)
                return connectionString;
            string result = null;
            string[] pathSplit = Directory.GetCurrentDirectory().ToString().Split('\\');
            int pathSplitLenght = pathSplit.Length;
            for (int i = 0; i < pathSplitLenght; i++)
                if (pathSplit[i] != "QuanLyHocSinh")
                    result += pathSplit[i] + @"\";
                else
                    if (pathSplit[i] == "QuanLyHocSinh")
                    break;
            result += @"QuanLyHocSinh\DAO\CoSoDuLieu.mdf";
            result = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + result + "; Integrated Security = True";
            connectionString = result;
            //string result = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CoSoDuLieu.mdf;Integrated Security=True";
            Console.WriteLine(result);
            return result;
        }
    }
}
