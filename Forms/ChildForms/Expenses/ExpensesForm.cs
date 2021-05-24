using DataAccess;
using Money;
using System;
using System.Windows.Forms;
namespace Forms.ChildForms
{
    public partial class ExpensesForm : Form
    {
        public ExpensesForm()
        {
            InitializeComponent();
        }

        private void ExpensesForm_Load(object sender, System.EventArgs e)
        {
            UserCache.CurrentExpenseSelected = false;
            UserCache.CurrentDebtSelected = false;
            ExpensesView.AutoGenerateColumns = false;
            ExpensesView.DataSource = Expense.Expenses;
        }

        private void ExpensesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetRow(e);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select one expense from the grid");
            }
        }
        private void GetRow(DataGridViewCellEventArgs e)
        {
            UserCache.CurrentExpense.ID = (int)ExpensesView.Rows[e.RowIndex].Cells["ID"].Value;
            UserCache.CurrentExpense.Description = (string)ExpensesView.Rows[e.RowIndex].Cells["Description"].Value;
            UserCache.CurrentExpense.Amount = (decimal)ExpensesView.Rows[e.RowIndex].Cells["Amount"].Value;
            UserCache.CurrentExpense.ExpenseDate = (DateTime)ExpensesView.Rows[e.RowIndex].Cells["ExpenseDate"].Value;
            UserCache.CurrentExpenseSelected = true;
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualExpenseChildState = (int)UserCache.ExpenseChildFormState.CreateExpense;
            ExpenseChild Add = new ExpenseChild();
            Add.ShowDialog();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (UserCache.CurrentExpenseSelected == false)
            {
                MessageBox.Show("Please select one Expense from the Grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SQLiteDataBase.DeleteExpense(UserCache.CurrentExpense);
                Expense.Remove(UserCache.CurrentExpense, UserCache.Account);
                MessageBox.Show("Removed!", "Process Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Failed to save changes. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        { 
            if (Expense.CopyExpenses.Count == 0)
            {
                MessageBox.Show("There's no expense to undo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Last expense undone!", "Process Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Expense.Undo(UserCache.Account);
        }

        private void EditBtn_Click(object sender, EventArgs e) // Under development
        {
            UserCache.ActualExpenseChildState = (int)UserCache.ExpenseChildFormState.UnderDevelopmentEditExpense;
            ExpenseChild Edit = new ExpenseChild();
            Edit.ShowDialog();
        }
    }
}
