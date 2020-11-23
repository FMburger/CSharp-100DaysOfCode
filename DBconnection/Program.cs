using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DBconnection
{
    class MSSQLConnection
    {
        private string connString;
        public MSSQLConnection(string server, string userID, string password, string database)
        {
            connString = "Server=" + server + ";Database=" + database + ";User Id=" + userID + ";Password=" + password +";";
            Console.WriteLine(IsServerConnected(connString));
        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("伺服器名稱: ");
            string server = Console.ReadLine();
            Console.WriteLine("使用者帳號: ");
            string userID = Console.ReadLine();
            Console.WriteLine("密碼: ");
            string password = Console.ReadLine();
            Console.WriteLine("資料庫: ");
            string database = Console.ReadLine();

            var conn = new MSSQLConnection(server, userID, password, database);

            Console.ReadLine();

        }

    }
}

