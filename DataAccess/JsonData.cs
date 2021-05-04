using Money;
using Newtonsoft.Json;
using System.IO;
using System;
namespace DataAccess
{
    public class JsonData
    {
        /// <summary>
        /// This class contais the objects and methods to fill, create and update a Json file
        /// </summary>
        public string Name { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal ActualDebt { get; set; }
        public decimal ActualSaves { get; set; }

        public static string JsonDirectoryPath = @"C:\Users\astef_000\Desktop\Jalinson\Programming\_SaveX\DataAccess\SavexUserData\User.json";


        /// <summary>
        /// This method checks if there is a json file, if it's not there then it create it
        /// and returns true to enter to the form to fill the Json.
        /// </summary>
        public static bool CreateJson()
        {
            if (!File.Exists(JsonDirectoryPath))
            {
                File.Create(JsonDirectoryPath);
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method fill the Json if it's the first time we open the App.
        /// </summary>
        /// <param name="Account"> This is the Balance object that I Created at the First form to use the information of the user.</param>
        public static void FillJson(Balance Account)
        {
            JsonData User = new JsonData
            {
                Name = Account.Name,
                TotalBalance = Account.Amount,
                ActualSaves = 0,
                ActualDebt = 0
            };
            string Json = JsonConvert.SerializeObject(User, Formatting.Indented);
            File.WriteAllText(JsonDirectoryPath, Json);
        }
        /// <summary>
        /// This method will be use to save the current information.
        /// </summary>
        /// <param name="Account"> The current Account</param>
        /// <param name="TotalDebts"> Total sum of all current Debts</param>
        /// <param name="TotalSaves"> Total sum of all current Saves</param>
        public static void UpdateJson(Balance Account, decimal TotalDebts, decimal TotalSaves)
        {   
            string Json = File.ReadAllText(JsonDirectoryPath);
            JsonData User = JsonConvert.DeserializeObject<JsonData>(Json);
            User.Name = Account.Name;
            User.TotalBalance = Account.Amount;
            User.ActualSaves = TotalSaves;
            User.ActualDebt = TotalDebts;
            Json = JsonConvert.SerializeObject(User, Formatting.Indented);
            File.WriteAllText(JsonDirectoryPath, Json);
        }
        /// <summary>
        /// This method Takes the info from the Json file if the file its created already. 
        /// (CreateJson() returns false)
        /// </summary>
        /// <param name="Account"> The User Account</param>
        public static void TakeInfo(Balance Account)
        {
            string Json = File.ReadAllText(JsonDirectoryPath);
            JsonData User = JsonConvert.DeserializeObject<JsonData>(Json);
            Account.Name = User.Name;
            Account.Amount = User.TotalBalance;
            Account.Date = DateTime.Now;
        }
    }
}
