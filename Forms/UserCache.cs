using Money;

namespace Forms
{
    public class UserCache
    {
        public static Balance Account = new Balance();
        public static decimal MyDebt { get; set; }
        public static decimal MySave { get; set; }
        public static string Currency { get; set; }
        public static decimal TotalExpense { get; set; }
    }
}
