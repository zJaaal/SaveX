using Money;

namespace Forms
{
    public class UserCache
    {
        public static Balance Account = new Balance();
        public static decimal TotalDebt { get; set; }
        public static string Currency { get; set; }
        public static decimal TotalExpense { get; set; }
        public enum InputAmountState { AddBalance, RemoveError, Withdraw, AddSaving }
        public static int ActualState { get; set; }
    }
}
