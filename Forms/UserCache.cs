using Money;

namespace Forms
{
    public class UserCache
    {
        public static Balance Account = new Balance();
        public static Debt CurrentDebt = new Debt();
        public static Expense CurrentExpense = new Expense();
        public static decimal TotalDebt { get; set; }
        public static string Currency { get; set; }
        public static decimal TotalExpense { get; set; }
        public enum InputAmountState { AddBalance, RemoveError, Withdraw, AddSaving }
        public static int ActualInputAmountState { get; set; }
        public enum DebtChildFormState {CreateDebt, UnderDevelopmentEditDebt }
        public static int ActualDebtChildState { get; set; }
        public enum ExpenseChildFormState {CreateExpense, UnderDevelopmentEditExpense }
        public static int ActualExpenseChildState { get; set; }
        public static bool CurrentDebtSelected { get; set; }
        public static bool CurrentExpenseSelected { get; set; }
    }
}
