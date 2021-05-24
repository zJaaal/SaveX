using DataAccess;
using Money;
using System;
using System.Windows.Forms;

namespace Forms.ChildForms
{
    public partial class DebtsForm : Form
    {
        public DebtsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the forms load. Make those property false. So it cannot bug when 
        /// there's no selected cell. And the DataGridView doesn't duplicate the Columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtsForm_Load(object sender, EventArgs e)
        {
            UserCache.CurrentExpenseSelected = false;
            UserCache.CurrentDebtSelected = false;
            DebtsView.AutoGenerateColumns = false;
            DebtsView.DataSource = Debt.Debts;
        }

        private void BodyPanel_Click(object sender, EventArgs e)
        {
            DebtsView.DataSource = Debt.Debts;
        }
        /// <summary>
        /// This event triggers the GetRow Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetRow(e);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select one debt from the grid");
            }
            
        }
        /// <summary>
        /// This method gets the full row when the user clicks on a cell of the DataGridView.
        /// </summary>
        /// <param name="e"></param>
        private void GetRow(DataGridViewCellEventArgs e)
        {
            UserCache.CurrentDebt.ID = (int)DebtsView.Rows[e.RowIndex].Cells["ID"].Value;
            UserCache.CurrentDebt.Description = (string)DebtsView.Rows[e.RowIndex].Cells["Description"].Value;
            UserCache.CurrentDebt.Amount = (decimal)DebtsView.Rows[e.RowIndex].Cells["Amount"].Value;
            UserCache.CurrentDebt.DeadLine = (DateTime)DebtsView.Rows[e.RowIndex].Cells["DeadLine"].Value;
            UserCache.CurrentDebtSelected = true;
        }
        /// <summary>
        /// This method triggers the Pay Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (UserCache.CurrentDebtSelected == false)
            {
                MessageBox.Show("Please select one debt from the Grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if(UserCache.CurrentDebt.Amount > UserCache.Account.Amount)
            {
                MessageBox.Show("Your debt is greater than your actual balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SQLiteDataBase.DeleteDebt(UserCache.CurrentDebt);
                Debt.Pay(UserCache.CurrentDebt, UserCache.Account);
                MessageBox.Show("Payed!", "Process Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Failed to save changes. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// This event triggers the Undo Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if(Debt.CopyDebts.Count == 0)
            {
                MessageBox.Show("There's no payment to undo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Last payment undone!", "Process Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Debt.Undo(UserCache.Account);
        }
        /// <summary>
        /// This events are for opening the Debtchild Form on a specfic state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDebtBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualDebtChildState = (int)UserCache.DebtChildFormState.CreateDebt;
            DebtChild AddDebt = new DebtChild();
            AddDebt.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)// Under Development...
        {
            UserCache.ActualDebtChildState = (int)UserCache.DebtChildFormState.UnderDevelopmentEditDebt;
            DebtChild AddDebt = new DebtChild();
            AddDebt.ShowDialog();
        }
    }
}
