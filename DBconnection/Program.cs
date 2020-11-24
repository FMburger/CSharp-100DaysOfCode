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
            if (IsServerConnected(connString) == true)
            {
                Console.WriteLine("連線成功!");
            }
            else
            {
                Console.WriteLine("連線失敗!");
            }
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
            string server = null, userID = null, password = null, database = null;
            
            Console.WriteLine("---資料庫連線測試---");
            Console.Write("伺服器名稱: ");
            server = Console.ReadLine();
            Console.Write("使用者帳號: ");
            userID = Console.ReadLine();
            Console.Write("密碼: ");
            password = Console.ReadLine();
            Console.Write("資料庫: ");
            database = Console.ReadLine();
            Console.WriteLine("");

            while  (String.IsNullOrEmpty(server) | String.IsNullOrEmpty(userID) | String.IsNullOrEmpty(password) |String.IsNullOrEmpty(database))
            {
                Console.WriteLine("---不能有空值請重新輸入---");
                Console.Write("伺服器名稱: ");
                server = Console.ReadLine();
                Console.Write("使用者帳號: ");
                userID = Console.ReadLine();
                Console.Write("密碼: ");
                password = Console.ReadLine();
                Console.Write("資料庫: ");
                database = Console.ReadLine();
                Console.WriteLine("");
            }
            var conn = new MSSQLConnection(server, userID, password, database);

            Console.ReadLine();

        }

    }
}

