using System;

namespace Forms
{
    public static class Utilities
    {
        /// <summary>
        /// Validates a Letters string
        /// </summary>
        /// <param name="MyString"></param>
        /// <returns></returns>
        public static bool CheckString(string MyString)
        {
            foreach (char a in MyString)
            {
                if (!Char.IsLetter(a))
                    return false;
            }
            return true;
        }
        public static string GetDecimal(decimal Amount)
        {
            if (Amount == 0m)
                return "0.00" + " "+UserCache.Currency;

            return Amount.ToString("#,#") + " " + UserCache.Currency;
        }
    }
}
