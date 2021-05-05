using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using Money;

namespace DataAccess
{
    /// <summary>
    /// This class has all the methods to make consults to the DataBase (Testing)
    /// </summary>
    public class SQLiteDataBase
    {
        private static readonly string SQLDirectory = @"C:\Users\astef_000\Desktop\Jalinson\Programming\_SaveX\DataAccess\SavexUserData\UserBalances.sqlite";

        public static bool CreateDataBase()
        {
            if (!File.Exists(SQLDirectory))
            {
                 SQLiteConnection.CreateFile(SQLDirectory);
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method creates the table for Debts and Expenses
        /// </summary>
        public static void CreateTables()
        {
            if (File.Exists(SQLDirectory))
            {
                using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
                {
                    con.Open();

                    string CreateQuery = $"CREATE TABLE IF NOT EXISTS Debts " +
                                         $"(ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                         $"DeadLine TEXT NOT NULL, " +
                                         $"Description VARCHAR(20) NOT NULL, " +
                                         $"Amount NUM NOT NULL)";
                    SQLiteCommand command = new SQLiteCommand(CreateQuery, con);
                    command.ExecuteNonQuery();
                    CreateQuery = $"CREATE TABLE IF NOT EXISTS Expenses " +
                                  $"(ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                  $"DateTime TEXT NOT NULL, " +
                                  $"Description VARCHAR(20) NOT NULL, " +
                                  $"Amount NUM NOT NULL)";
                    SQLiteCommand command2 = new SQLiteCommand(CreateQuery, con);
                    command2.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        /// <summary>
        /// This method takes the list Debts as a param and for each debt it validates 
        /// either is or is not in the database
        /// If it is in the DataBase then Update Query Executes
        /// If it is not in the DB then Insert Query Executes 
        /// </summary>
        /// <param name="LDebt"></param>
        public static void InsertOrUpdateDebts(List<Debt> LDebt)
        {
            using(var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();

                string Insert = $"INSERT INTO Debts (ID, DeadLine, Description, Amount) " +
                                $"VALUES (?,?,?,?)";

                string Update = $"UPDATE Debts SET (ID, DeadLine, Description, Amount) " +
                                $"WHERE VALUES (?,?,?,?)";

                SQLiteCommand InsertCom = new SQLiteCommand(Insert, con);
                SQLiteCommand UpdateCom = new SQLiteCommand(Update, con);

                foreach(Debt MyDebt in LDebt)
                {
                    InsertCom.Parameters.Add(MyDebt.ID);
                    InsertCom.Parameters.Add(MyDebt.DeadLine.ToString());
                    InsertCom.Parameters.Add(MyDebt.Description);
                    InsertCom.Parameters.Add(MyDebt.Amount);
                 
                    UpdateCom.Parameters.Add(MyDebt.ID);
                    UpdateCom.Parameters.Add(MyDebt.DeadLine.ToString());
                    UpdateCom.Parameters.Add(MyDebt.Description);
                    UpdateCom.Parameters.Add(MyDebt.Amount);
                   
                    if (SearchInDebts(MyDebt))
                        UpdateCom.ExecuteNonQuery();
                    
                    InsertCom.ExecuteNonQuery();
                  
                }
                con.Close();
            }
        }
        /// <summary>
        /// Search for an specific debt
        /// </summary>
        /// <param name="MyDebt"> The debt we want to search</param>
        /// <returns></returns>
        public static bool SearchInDebts(Debt MyDebt)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT (ID, DeadLine, Description, Amount) " +
                                 $"FROM Debts WHERE VALUES (?,?,?,?)";
                SQLiteCommand Search = new SQLiteCommand(Command, con);
                Search.Parameters.Add(MyDebt.ID);
                Search.Parameters.Add(MyDebt.DeadLine.ToString());
                Search.Parameters.Add(MyDebt.Description);
                Search.Parameters.Add(MyDebt.Amount);
                
                using (SQLiteDataReader Reader = Search.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        con.Close();
                        return true;
                    }

                    con.Close();
                    return false;
                }
            }
        }
        /// <summary>
        /// Writes the DataBase on LDebt as Objects per row
        /// </summary>
        /// <param name="LDebt"></param>
        public static void TakeAllDebts(List<Debt> LDebt)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT (ID, DeadLine, Description, Amount) " +
                                 $"FROM Debts";
                SQLiteCommand TakeAll = new SQLiteCommand(Command, con);
                using (SQLiteDataReader Reader = TakeAll.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        LDebt.Add(new Debt(Reader.GetInt32(0),
                                           Reader.GetDateTime(1),
                                           Reader.GetString(2),
                                           Reader.GetDecimal(3)));
                    }
                    con.Close();
                }
            }
        }
        /// <summary>
        /// Takes an specific object and deletes it
        /// </summary>
        /// <param name="MyDebt"></param>
        public static void DeleteInDebts(Debt MyDebt)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"DELETE FROM Debts WHERE ID="+MyDebt.ID+"";
                SQLiteCommand Delete = new SQLiteCommand(Command, con);
                Delete.ExecuteNonQuery();
                con.Close();
                
            }
        }

        /// <summary>
        /// This section of the code is the same as Debt part but for Expenses.
        /// </summary>


        public static void InsertOrUpdateExpenses(List<Expense> LExpense)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();

                string Insert = $"INSERT INTO Expenses (ID, DateTime, Description, Amount) " +
                                $"VALUES (?,?,?,?)";

                string Update = $"UPDATE Expenses SET (ID, DateTime, Description, Amount) " +
                                $"WHERE VALUES (?,?,?,?)";

                SQLiteCommand InsertCom = new SQLiteCommand(Insert, con);
                SQLiteCommand UpdateCom = new SQLiteCommand(Update, con);

                foreach (Expense MyExpense in LExpense)
                {
                    InsertCom.Parameters.Add(MyExpense.ID);
                    InsertCom.Parameters.Add(MyExpense.Date.ToString());
                    InsertCom.Parameters.Add(MyExpense.Description);
                    InsertCom.Parameters.Add(MyExpense.Amount);
                   
                    UpdateCom.Parameters.Add(MyExpense.ID);
                    UpdateCom.Parameters.Add(MyExpense.Date.ToString());
                    UpdateCom.Parameters.Add(MyExpense.Description);
                    UpdateCom.Parameters.Add(MyExpense.Amount);
                    

                    if (SearchInExpenses(MyExpense))
                        UpdateCom.ExecuteNonQuery();

                    InsertCom.ExecuteNonQuery();

                }
                con.Close();
            }
        }
        public static bool SearchInExpenses(Expense MyExpense)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT (ID, DateTime, Description, Amount) " +
                                 $"FROM Expenses WHERE VALUES (?,?,?,?)";

                SQLiteCommand Search = new SQLiteCommand(Command, con);

                Search.Parameters.Add(MyExpense.ID);
                Search.Parameters.Add(MyExpense.Date.ToString());
                Search.Parameters.Add(MyExpense.Description);
                Search.Parameters.Add(MyExpense.Amount);
                
                using (SQLiteDataReader Reader = Search.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        con.Close();
                        return true;
                    }

                    con.Close();
                    return false;
                }
            }
        }
        public static void TakeAllExpenses(List<Expense> LExpenses)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT (ID, DateTime, Description, Amount) " +
                                 $"FROM Debts";
                SQLiteCommand TakeAll = new SQLiteCommand(Command, con);
                using (SQLiteDataReader Reader = TakeAll.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        LExpenses.Add(new Expense(Reader.GetInt32(0), 
                                                  Reader.GetDateTime(1), 
                                                  Reader.GetString(2), 
                                                  Reader.GetDecimal(3)));
                    }
                    con.Close();
                }
            }
        }
        public static void DeleteExpenses(Expense MyExpense)
        {
            using (var con = new SQLiteConnection(SQLDirectory))
            {
                con.Open();
                string Command = $"DELETE FROM Expenses WHERE ID=" + MyExpense.ID + "";
                SQLiteCommand Delete = new SQLiteCommand(Command, con);
                Delete.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
