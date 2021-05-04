using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Data.SQLite;
using Money;

namespace DataAccess
{
    public class SQLiteDataBase
    {
        private static string SQLDirectory = @"C:\Users\astef_000\Desktop\Jalinson\Programming\_SaveX\DataAccess\SavexUserData\UserBalances.sqlite";

        public static bool CreateDataBase()
        {
            if (!File.Exists(SQLDirectory))
            {
                 SQLiteConnection.CreateFile(SQLDirectory);
                return true;
            }
            return false;
        }
        public static void CreateTable()
        {
            if (File.Exists(SQLDirectory))
            {
                using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
                {
                    con.Open();

                    string CreateQuery = $"CREATE TABLE IF NOT EXISTS Balances " +
                                         $"(Type TEXT NOT NULL, " +
                                         $"Description TEXT NOT NULL, " +
                                         $"Amount NUM NOT NULL, " +
                                         $"DateTime TEXT NOT NULL)";
                    SQLiteCommand command = new SQLiteCommand(CreateQuery, con);
                    command.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
    }
}
