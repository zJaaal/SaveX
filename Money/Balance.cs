using System;
using System.Collections.Generic;
namespace Money
{
    /// <summary>
    /// All the validations for Value >= 0 will be done in the forms
    /// </summary>
    public abstract class Balance : ICloneable 
    {
        /// <summary>
        /// Base class for all types of money
        /// </summary>
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Balance base constructor
        /// </summary>
        /// <param name="Date"> The date of creation, dead line or date of expense</param>
        /// <param name="Description"> The description of the Expense, Saving or Debt</param>
        /// <param name="Amount">The Amount of the saving,expense or debt</param>
        public Balance(DateTime Date, string Description,decimal Amount)
        {
            this.Amount = Amount;
            this.Date = Date;
            this.Name = Description;
        }
        /// <summary>
        /// This method undo a removing error 
        /// </summary>
        /// <param name="Account"> Account being changed</param>
        public abstract void Undo(Balance Account);
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
        public string Description  { get; set; }
        /// <summary>
        /// A list of expenses to send and recieve from the database
        /// </summary>
        public static List<Expense> Expenses = new List<Expense>();
        public static List<Expense> CopyExpenses = new List<Expense>();
        public Expense(DateTime ExpenseDate, string Description, decimal Amount) : base(ExpenseDate, Description, Amount)
        {
            this.ExpenseDate = ExpenseDate;
            this.Description = Description;
            this.Amount = Amount;
        }
        /// <summary>
        /// This method create and add an expense to the list. Since it is an expense we need to subtract
        /// the amount from the account
        /// </summary>
        /// <param name="ExpenseDate"> Date of Expense</param>
        /// <param name="Description">What we bought or pay</param>
        /// <param name="Amount"> The total amount</param>
        /// <param name="Account"> The Account where we will subtract</param>
        public static void CreateAndAdd(DateTime ExpenseDate, string Description, decimal Amount, Balance Account)
        {
            Expense MyExpense = new Expense(ExpenseDate, Description, Amount);
            Account.Amount -= MyExpense.Amount;
            Expenses.Add(MyExpense);
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
        }
        /// <summary>
        /// This methods undo the remove action
        /// Creates an object from the last index of the Copy list
        /// Subtract (or Add in the case of Debts, since the remove button is the Pay Button) from the Account
        /// Therefore it the copy to the main list and delete it from the copy list
        /// </summary>
        /// <param name="Account"> The account we are changing </param>
        public override void Undo(Balance Account)
        {
            Expense MyExpense = CopyExpenses[CopyExpenses.Count - 1];
            Account.Amount -= MyExpense.Amount;
            Expenses.Add(MyExpense);
            CopyExpenses.RemoveAt(CopyExpenses.Count - 1);
        }
    }
    public class Debt : Balance
    {
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public static List<Debt> Debts = new List<Debt>();
        public static List<Debt> CopyDebts = new List<Debt>();
        public Debt(DateTime DeadLine, string Description, decimal Amount) : base(DeadLine, Description, Amount)
        {
            this.DeadLine = DeadLine;
            this.Description = Description;
            this.Amount = Amount;
        }
        public static void Pay(Debt MyDebt, Balance Account)
        {
            Account.Amount -= MyDebt.Amount;
            Debt Debtcopy = (Debt)MyDebt.Clone();
            CopyDebts.Add(Debtcopy);
            Debts.Remove(MyDebt);
        }

        public static void CreateAndAdd(DateTime DeadLine, string Description, decimal Amount)
        {
            Debt MyDebt = new Debt(DeadLine, Description, Amount);
            Debts.Add(MyDebt);
        }
        /// <summary>
        /// This method Pay all the debts 
        /// I did a foreach because undo button will save someone from errors
        /// </summary>
        /// <param name="Account"> Account to change</param>
        public static void PayAll(Balance Account)
        {
            foreach(Debt X in Debts)
            {
                Pay(X, Account);
            }
        }
        public override void Undo(Balance Account)
        {
            Debt MyDebt = CopyDebts[CopyDebts.Count - 1];
            Account.Amount += MyDebt.Amount;
            Debts.Add(MyDebt);
            CopyDebts.RemoveAt(CopyDebts.Count - 1);
        }
    }
    public class Saving : Balance
    {
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public static List<Saving> Saves = new List<Saving>();
        public static List<Saving> CopySaves = new List<Saving>();
        public Saving(DateTime CreationDate, string Description, decimal Amount) : base(CreationDate, Description, Amount)
        {
            this.CreationDate = CreationDate;
            this.Description = Description;
            this.Amount = Amount;
        }

        public static void CreateAndAdd(DateTime CreationDate, string Description, decimal Amount, Balance Account)
        {
            Saving MySave = new Saving(CreationDate, Description, Amount);
            Saves.Add(MySave);
            Account.Amount -= MySave.Amount;
        }
        /// <summary>
        /// Remove Method for make your saving part of your balance
        /// </summary>
        /// <param name="MySave"></param>
        /// <param name="Account"></param>
        public static void UseSaving(Saving MySave, Balance Account)
        {
            Saving CopySave = (Saving)MySave.Clone();
            CopySaves.Add(CopySave);
            Account.Amount += MySave.Amount;
            Saves.Remove(MySave);
        }
        /// <summary>
        /// This method make your savings part of your balance
        /// I did a foreach because undo button will save someone from errors
        /// </summary>
        /// <param name="Account"> Account to change</param>
        public static void UseAllSaving(Balance Account)
        {
            foreach( Saving X in Saves)
            {
                UseSaving(X, Account);
            }
        }
        public override void Undo(Balance Account)
        {
            Saving MySave = CopySaves[CopySaves.Count - 1];
            Account.Amount -= MySave.Amount;
            Saves.Add(MySave);
            CopySaves.RemoveAt(CopySaves.Count - 1);
        }
    }
}
