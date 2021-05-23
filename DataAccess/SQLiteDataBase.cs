using Money;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

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
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {


                string Insert = $"INSERT INTO Debts (ID, DeadLine, Description, Amount) " +
                                $"VALUES (@ID,@DL,@DES,@AMO)";

                string Update = $"UPDATE Debts SET ID = @ID, DeadLine = @DL, Description = @DES, Amount = @AMO " +
                                $"WHERE ID = @ID";

                SQLiteCommand InsertCom = new SQLiteCommand(Insert, con);
                SQLiteCommand UpdateCom = new SQLiteCommand(Update, con);
                foreach (Debt MyDebt in LDebt)
                {


                    InsertCom.Parameters.Add("@ID", System.Data.DbType.Int32).Value = MyDebt.ID;
                    InsertCom.Parameters.Add("@DL", System.Data.DbType.String).Value = MyDebt.DeadLine.ToString();
                    InsertCom.Parameters.Add("@DES", System.Data.DbType.String).Value = MyDebt.Description;
                    InsertCom.Parameters.Add("@AMO", System.Data.DbType.Decimal).Value = MyDebt.Amount;

                    UpdateCom.Parameters.Add("@ID", System.Data.DbType.Int32).Value = MyDebt.ID;
                    UpdateCom.Parameters.Add("@DL", System.Data.DbType.String).Value = MyDebt.DeadLine.ToString();
                    UpdateCom.Parameters.Add("@DES", System.Data.DbType.String).Value = MyDebt.Description;
                    UpdateCom.Parameters.Add("@AMO", System.Data.DbType.Decimal).Value = MyDebt.Amount;


                    if (SearchInDebts(MyDebt))
                    {
                        con.Open();
                        UpdateCom.ExecuteNonQuery();
                        con.Close();
                        continue;
                    }

                    con.Open();
                    InsertCom.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        /// <summary>
        /// Search for an specific debt
        /// </summary>
        /// <param name="MyDebt"> The debt we want to search</param>
        /// <returns></returns>
        public static bool SearchInDebts(Debt MyDebt)
        {
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT ID, DeadLine, Description, Amount " +
                                 $"FROM Debts WHERE ID =" + MyDebt.ID;

                SQLiteCommand Search = new SQLiteCommand(Command, con);

                using (SQLiteDataReader Reader = Search.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        Reader.Close();
                        con.Close();

                        return true;
                    }

                    Reader.Close();
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
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT ID, DeadLine, Description, Amount " +
                                 $"FROM Debts";
                SQLiteCommand TakeAll = new SQLiteCommand(Command, con);
                using (SQLiteDataReader Reader = TakeAll.ExecuteReader())
                {
                    while (Reader.Read())
                    {

                        LDebt.Add(new Debt(Reader.GetInt32(0),
                                                  DateTime.Parse(Reader.GetString(1)),
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
        public static void DeleteDebt(Debt MyDebt)
        {
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {
                con.Open();
                string Command = $"DELETE FROM Debts WHERE ID=" + MyDebt.ID + "";
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
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {


                string Insert = $"INSERT INTO Expenses (ID, DateTime, Description, Amount) " +
                                $"VALUES (@ID,@DT,@DES,@AMO)";

                string Update = $"UPDATE Expenses SET ID = @ID, DateTime = @DT, Description = @DES, Amount = @AMO " +
                                $"WHERE ID = @ID";

                SQLiteCommand InsertCom = new SQLiteCommand(Insert, con);
                SQLiteCommand UpdateCom = new SQLiteCommand(Update, con);

                foreach (Expense MyExpense in LExpense)
                {


                    InsertCom.Parameters.Add("@ID", System.Data.DbType.Int32).Value = MyExpense.ID;
                    InsertCom.Parameters.Add("@DT", System.Data.DbType.String).Value = MyExpense.ExpenseDate.ToString();
                    InsertCom.Parameters.Add("@DES", System.Data.DbType.String).Value = MyExpense.Description;
                    InsertCom.Parameters.Add("@AMO", System.Data.DbType.Decimal).Value = MyExpense.Amount;

                    UpdateCom.Parameters.Add("@ID", System.Data.DbType.Int32).Value = MyExpense.ID;
                    UpdateCom.Parameters.Add("@DT", System.Data.DbType.String).Value = MyExpense.ExpenseDate.ToString();
                    UpdateCom.Parameters.Add("@DES", System.Data.DbType.String).Value = MyExpense.Description;
                    UpdateCom.Parameters.Add("@AMO", System.Data.DbType.Decimal).Value = MyExpense.Amount;


                    if (SearchInExpenses(MyExpense))
                    {
                        con.Open();
                        UpdateCom.ExecuteNonQuery();
                        con.Close();
                        continue;
                    }

                    con.Open();
                    InsertCom.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static bool SearchInExpenses(Expense MyExpense)
        {
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT ID, DateTime, Description, Amount " +
                                 $"FROM Expenses WHERE ID =" + MyExpense.ID;

                SQLiteCommand Search = new SQLiteCommand(Command, con);

                using (SQLiteDataReader Reader = Search.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        Reader.Close();
                        con.Close();

                        return true;
                    }

                    Reader.Close();
                    con.Close();

                    return false;
                }
            }
        }
        public static void TakeAllExpenses(List<Expense> LExpenses)
        {
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
            {
                con.Open();
                string Command = $"SELECT ID, DateTime, Description, Amount " +
                                 $"FROM Expenses";
                SQLiteCommand TakeAll = new SQLiteCommand(Command, con);
                using (SQLiteDataReader Reader = TakeAll.ExecuteReader())
                {
                    while (Reader.Read())
                    {

                        LExpenses.Add(new Expense(Reader.GetInt32(0),
                                                  DateTime.Parse(Reader.GetString(1)),
                                                  Reader.GetString(2),
                                                  Reader.GetDecimal(3)));
                    }
                    con.Close();
                }
            }
        }
        public static void DeleteExpenses(Expense MyExpense)
        {
            using (var con = new SQLiteConnection("Data Source =" + SQLDirectory))
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
