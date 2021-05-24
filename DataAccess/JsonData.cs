using Money;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
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
        public string Currency { get; set; }
        private static string Json { get; set; }

        private static string JsonDirectoryPath 
        {
            get
            {
                return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"SavexUserData\User.json"));
            } 
        }
                

        /// <summary>
        /// This method checks if the json file is filled, if it's not it returns true
        /// and it returns false if it's filled.
        /// </summary>
        public static bool ReadJson()
        {
            Json = File.ReadAllText(JsonDirectoryPath);

            if (Json.Length == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method fill the Json if it's the first time we open the App.
        /// </summary>
        /// <param name="Account"> This is the Balance object that I Created at the First form to use the information of the user.</param>
        public static void FillJson(Balance Account, string MyCurrency)
        {
            JsonData User = new JsonData
            {
                Name = Account.Name,
                TotalBalance = Account.Amount,
                ActualSaves = Account.Saves,
                ActualDebt = 0m,
                Currency = MyCurrency
            };

            Json = JsonConvert.SerializeObject(User, Formatting.Indented);

            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    File.WriteAllText(JsonDirectoryPath, Json);
                    break;
                }
                catch (IOException) when (i <= 3)
                {
                    Thread.Sleep(1000);
                }
            }

        }
        /// <summary>
        /// This method will be use to save the current information.
        /// </summary>
        /// <param name="Account"> The current Account</param>
        /// <param name="TotalDebts"> Total sum of all current Debts</param>
        /// <param name="TotalSaves"> Total Saves</param>
        public static void UpdateJson(Balance Account, decimal TotalDebts)
        {

            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(new FileStream(JsonDirectoryPath, FileMode.Open, FileAccess.Read, FileShare.Read)))
                    {
                        Json = reader.ReadToEnd();
                    }
                    break;
                }
                catch (IOException) when (i <= 3)
                {
                    Thread.Sleep(1000);
                }
            }
            JsonData User = JsonConvert.DeserializeObject<JsonData>(Json);
            User.Name = Account.Name;
            User.TotalBalance = Account.Amount;
            User.ActualSaves = Account.Saves;
            User.ActualDebt = TotalDebts;
            Json = JsonConvert.SerializeObject(User, Formatting.Indented);
            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(JsonDirectoryPath, FileMode.Create, FileAccess.Write, FileShare.Read)))
                    {
                        writer.WriteLine(Json);
                    }
                    break;
                }
                catch (IOException) when (i <= 3)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        /// <summary>
        /// This method Takes the info from the Json file if the file its created already. 
        /// (CreateJson() returns false)
        /// </summary>
        /// <param name="Account"> The User Account</param>
        public static JsonData TakeInfo()
        {
            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    Json = File.ReadAllText(JsonDirectoryPath);
                    break;
                }
                catch (IOException) when (i <= 3)
                {
                    Thread.Sleep(1000);
                }
            }
            JsonData User = JsonConvert.DeserializeObject<JsonData>(Json);
            return User;
        }
    }
}
