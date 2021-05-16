using System;
using System.Collections.Generic;
using System.Linq;
namespace Money
{
    /// <summary>
    /// All the validations for Value >= 0 will be done in the forms
    /// </summary>
    public class Balance : ICloneable
    {
        /// <summary>
        /// Base class for all types of money
        /// </summary>
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public decimal Saves { get; set; }
        /// <summary>
        /// Balance base constructor
        /// </summary>
        /// <param name="Date"> The date of creation, dead line or date of expense</param>
        /// <param name="Name">  The name of the account or the description of the Expense or Debt</param>
        /// <param name="Amount">The Amount of the saving,expense or debt</param>
        public Balance(DateTime Date, string Name, decimal Amount)
        {
            this.Amount = Amount;
            this.Date = Date;
            this.Name = Name;
        }
        public Balance() { }
        /// <summary>
        /// This method remove and amount from balance if the one added was an error
        /// </summary>
        /// <param name="Balance"> Account to being corrected</param>
        /// <param name="Amount"> Amount to be removing</param>
        public static void RemoveError(Balance Balance, decimal Amount)
        {
            Balance.Amount -= Amount;
        }
        /// <summary>
        /// To use an amount for a debt or a expense
        /// </summary>
        /// <param name="Amount"></param>
        /// <param name="Account"></param>
        public static void UseSaving(decimal Amount, Balance Account)
        {
            Account.Amount += Amount;
            Account.Saves -= Amount;
        }
        /// <summary>
        /// to add an amount to the saves
        /// </summary>
        /// <param name="Amount"></param>
        /// <param name="Account"></param>
        public static void AddSaving(decimal Amount, Balance Account)
        {
            Account.Amount -= Amount;
            Account.Saves += Amount;
        }

        /// <summary>
        /// This add some amount to the Account
        /// </summary>
        /// <param name="Amount"> The amount to be added</param>
        /// <param name="balance"> The Account we are going to add the amount</param>
        public static void AddBalance(decimal Amount, Balance balance) => balance.Amount += Amount;

        /// <summary>
        /// Clone method to create an Undo button. I added a List of copies for each type of balance
        /// </summary>
        /// <returns> The cloned object </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    /// <summary>
    /// This classes are child classes of Balance Class
    /// 
    /// I will just document the methods of Expense Class since the other ones are the same 
    /// with few changes of logic
    /// </summary>
    public class Expense : Balance
    {
        public DateTime ExpenseDate { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        /// <summary>
        /// A list of expenses to send and recieve from the database
        /// </summary>
        public static List<Expense> Expenses = new List<Expense>();
        public static List<Expense> CopyExpenses = new List<Expense>();
        public Expense(int ID, DateTime ExpenseDate, string Description, decimal Amount) : base(ExpenseDate, Description, Amount)
        {
            this.ExpenseDate = ExpenseDate;
            this.Description = Description;
            this.Amount = Amount;
            this.ID = ID;
        }
        /// <summary>
        /// This method create and add an expense to the list. Since it is an expense we need to subtract
        /// the amount from the account
        /// </summary>
        /// <param name="ExpenseDate"> Date of Expense</param>
        /// <param name="Description">What we bought or pay</param>
        /// <param name="Amount"> The total amount</param>
        /// <param name="Account"> The Account where we will subtract</param>
        public static void CreateAndAdd(int ID, DateTime ExpenseDate, string Description, decimal Amount, Balance Account)
        {
            Expense MyExpense = new Expense(ID, ExpenseDate, Description, Amount);
            Account.Amount -= MyExpense.Amount;
            Expenses.Add(MyExpense);
            UpdateId();
        }
        /// <summary>
        /// This method creates a copy of the Expense then we will add it to a copy list
        /// Therefore it add the amount to the account and Remove it from the Main list
        /// (Implicit remove from database since I'm willing to create a save button that send the actual state of every List)
        /// </summary>
        /// <param name="MyExpense">The expense we want to remove</param>
        /// <param name="Account"> The account we are changing</param>
        public static void Remove(Expense MyExpense, Balance Account)
        {
            Expense Copy = (Expense)MyExpense.Clone();
            CopyExpenses.Add(Copy);
            Account.Amount += MyExpense.Amount;
            Expenses.Remove(MyExpense);
            UpdateId();
        }
        /// <summary>
        /// This methods undo the remove action
        /// Creates an object from the last index of the Copy list
        /// Subtract (or Add in the case of Debts, since the remove button is the Pay Button) from the Account
        /// Therefore it the copy to the main list and delete it from the copy list
        /// </summary>
        /// <param name="Account"> The account we are changing </param>
        public static void Undo(Balance Account)
        {
            Expense MyExpense = CopyExpenses[CopyExpenses.Count - 1];
            Account.Amount -= MyExpense.Amount;
            Expenses.Add(MyExpense);
            CopyExpenses.RemoveAt(CopyExpenses.Count - 1);
            UpdateId();
        }
        private static void UpdateId()
        {
            int Count = 1;
            foreach (Expense a in Expenses)
            {
                a.ID = Count;
                Count++;
            }
        }
    }
    public class Debt : Balance
    {
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public static List<Debt> Debts = new List<Debt>();
        public static List<Debt> CopyDebts = new List<Debt>();
        public static decimal TotalDebts
        {
            get
            {
                return Debts.Select(x => x.Amount).Sum();
            }
        }
        public Debt(int ID, DateTime DeadLine, string Description, decimal Amount) : base(DeadLine, Description, Amount)
        {
            this.DeadLine = DeadLine;
            this.Description = Description;
            this.Amount = Amount;
            this.ID = ID;
        }
        public static void Pay(Debt MyDebt, Balance Account)
        {
            Account.Amount -= MyDebt.Amount;
            Debt Debtcopy = (Debt)MyDebt.Clone();
            CopyDebts.Add(Debtcopy);
            Debts.Remove(MyDebt);
            UpdateId();
        }

        public static void CreateAndAdd(int ID, DateTime DeadLine, string Description, decimal Amount)
        {
            Debt MyDebt = new Debt(ID, DeadLine, Description, Amount);
            Debts.Add(MyDebt);
            UpdateId();
        }
        public static void Undo(Balance Account)
        {
            Debt MyDebt = CopyDebts[CopyDebts.Count - 1];
            Account.Amount += MyDebt.Amount;
            Debts.Add(MyDebt);
            CopyDebts.RemoveAt(CopyDebts.Count - 1);
            UpdateId();
        }
        public static void UpdateId()
        {
            int Count = 1;
            foreach (Debt a in Debts)
            {
                a.ID = Count;
                Count++;
            }
        }
    }
}
