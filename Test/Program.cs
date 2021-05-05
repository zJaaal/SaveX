using System;
using DataAccess;
using Money;

namespace Test
{              /* ## BUG ##
                * When first created and changed in the same runtime(create and modify), 
                  changes are not saved (json is empty).
                  But when I do a second test (File already exist) the changes are saved (json filled with current info)
                    
                 ## Solution##
                * Include the file in the repository.
                * Or keep searching for solutions
                */
    class Program
    {
        /// <summary>
        /// Just for testing, Ill erase this when Project Form is created
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            decimal MyBalance = 2000.00m;
            Balance User = new Balance(DateTime.Now, "Jalinson Diaz", MyBalance); // Initialize a Balance Object

            Console.WriteLine("Json file doesn't exist : " + JsonData.CreateJson()); // Create User.json

            Console.WriteLine("SQLite file doesn't exist : " + SQLiteDataBase.CreateDataBase()); // Create UserData.sqlite

            SQLiteDataBase.CreateTables(); // Create Expenses and Debts tables

            JsonData.FillJson(User); // Fill json with User object

            User.Name = "Diego Garcia"; // Changed Name to "Diego Garcia"
            Console.WriteLine("User name = "+User.Name); // Print to confirm
            Console.WriteLine("User name in Json file = Jalinson Diaz");

            JsonData.TakeInfo(User); // Update Object info to Json Info from "Diego Garcia" to "Jalinson Diaz"
            Console.WriteLine("Object has been updated from Json File");
            Console.WriteLine("User name = " + User.Name); // Print to confirm is updated

            User.Name = "Yolima Carruyo"; // Changed name to "Yolima Carruyo"(On json its "Jalinson Diaz")
            Console.WriteLine("User name = " + User.Name);
            JsonData.UpdateJson(User, 20000.00m, 32990.3m); // Update the information on User.json
            Console.WriteLine("Json file has been updated with the current data");

            User.Name = "Jalinson Diaz"; // Changed name to "Jalinson Diaz" (On json its "Yolima Carruyo")
            Console.WriteLine("User name = " + User.Name); // Print to confirm
            Console.WriteLine("User name in Json file = Yolima Carruyo");

            JsonData.TakeInfo(User); // Update object name to "Yolima Carruyo"
            Console.WriteLine("Object has been updated to Json file data");
            Console.WriteLine("User name = " + User.Name); // Print to confirm

            Console.ReadKey(); 
        }
    }
}
