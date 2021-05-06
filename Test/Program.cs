using System;
using DataAccess;
using Money;
using System.Collections.Generic;
using System.Linq;

namespace Test
{              /* ## BUG ##
                * When first created and changed in the same runtime(create and modify), 
                  changes are not saved (json is empty).
                  But when I do a second test (File already exist) the changes are saved (json filled with current info)
                    
                 ## Solution ##
                * Include the file in the repository.
                * Or keep searching for solutions
                */

                // SQLiteDataBase class was hard to debug. Data Base topic its my weakness.
                // I tested Expenses and Debts. It works perfectly.
    class Program
    {
        /// <summary>
        /// Just for testing, Ill erase this when Project Form is created
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (SQLiteDataBase.CreateDataBase()) // This scope simulates the first time that the user opens the app
            {
                Debt.Debts.AddRange(
               new[]
               {
                    new Debt(1,DateTime.Now.Date, "Redmi Note 10 ", 240m),
                    new Debt(2,DateTime.Now.Date, "Glass for Redmi ", 5m),
                    new Debt(3,DateTime.Now.Date, "Asus ZenBook ", 850m),
                    new Debt(4,DateTime.Now.Date, "Xiaomi Router ", 45m),
                    new Debt(5,DateTime.Now.Date, "Case for MyPhone ", 25m)
               });
                SQLiteDataBase.CreateTables();
                SQLiteDataBase.InsertOrUpdateExpenses(Expense.Expenses);
                Expense.Expenses.Clear();
            }
            
            SQLiteDataBase.TakeAllDebts(Debt.Debts); //Download from DataBase
            PrintDebt(Debt.Debts);
            Console.WriteLine();
            Console.WriteLine("Your total debt is: " + Debt.TotalDebts.ToString());

            Debt.CreateAndAdd(1, DateTime.Now.Date, "Aerobed ", 300m); // Create and add to Local List Debts

            Console.WriteLine();
            PrintDebt(Debt.Debts);

            Console.WriteLine();
            PrintBalance(User);

            Console.WriteLine(); // Pay Button simulation
            SQLiteDataBase.DeleteDebt(Debt.Debts[3]); // Delete "Xiaomi Router" since...
            Debt.Pay(Debt.Debts[3], User);// ...We paid that debt
            PrintDebt(Debt.Debts);
            Console.WriteLine();

            PrintBalance(User);
            Console.WriteLine();

            Debt.Undo(User); // Undo button simulation
            SQLiteDataBase.InsertOrUpdateDebts(Debt.Debts); // Save changes (Added Aerobed and Re-added Xiaomi Router)
            Console.WriteLine();

            Debt.Debts.Clear();
            SQLiteDataBase.TakeAllDebts(Debt.Debts); // Verificate that this is working 
            PrintDebt(Debt.Debts);
            Console.WriteLine();

            PrintBalance(User);

            Console.ReadKey();
        }

        static Balance User = new Balance(DateTime.Today, "Jalinson Diaz", 30000m);

        private static void PrintDebt(List<Debt> MyList)
        {
            foreach (Debt X in MyList)
                Console.WriteLine(X.ID.ToString() + " | " + X.Description + " | " + X.Amount.ToString() + "$" + " | " + X.DeadLine.ToString());
        }
        private static void PrintExpense(List<Expense> MyList)
        {
            foreach (Expense X in MyList)
                Console.WriteLine(X.ID.ToString() + " | " + X.Description + " | " + X.Amount.ToString()+"$"+" | " + X.Date.ToString());
        }
        private static void PrintBalance(Balance User)
        {
            Console.WriteLine("Your actual balance is: " + User.Amount.ToString());
        }
    }
}
