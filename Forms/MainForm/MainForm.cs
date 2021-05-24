using DataAccess;
using Money;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This lines are for dragging the form.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// This event charges all the needed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeLb.Text = "Welcome! " + UserCache.Account.Name;
            DateTimeLabel.Text = DateTime.Now.ToString("D");
            UserCache.TotalExpense = Expense.TotalExpenses;
            UserCache.TotalDebt = Debt.TotalDebts;
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
            ExpenseAmountLb.Text = Utilities.GetDecimal(UserCache.TotalExpense);
            SavingAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Saves);
            DebtAmountLb.Text = Utilities.GetDecimal(UserCache.TotalDebt);
        }
        /// <summary>
        /// This event Saves current data and close the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Form dragging event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// This events get the current state for the InputAmount Form. 
        /// So it can work properly for each state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBalanceBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualInputAmountState = (int) UserCache.InputAmountState.AddBalance;
            ChildForms.AmountInput Input = new ChildForms.AmountInput();
            Input.ShowDialog();
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
        }

        private void RemoveBalanceBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualInputAmountState = (int)UserCache.InputAmountState.RemoveError;
            ChildForms.AmountInput Input = new ChildForms.AmountInput();
            Input.ShowDialog();
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualInputAmountState = (int)UserCache.InputAmountState.Withdraw;
            ChildForms.AmountInput Input = new ChildForms.AmountInput();
            Input.ShowDialog();
            SavingAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Saves);
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
        }

        private void AddSavingBtn_Click(object sender, EventArgs e)
        {
            UserCache.ActualInputAmountState =(int) UserCache.InputAmountState.AddSaving;
            ChildForms.AmountInput Input = new ChildForms.AmountInput();
            Input.ShowDialog();
            SavingAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Saves);
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
        }
        private Form ActiveForm = null;
        /// <summary>
        /// This methd prepare the Child form before opening.
        /// </summary>
        /// <param name="ChildForm"></param>
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            BodyPanel.Controls.Add(ChildForm);
            BodyPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        /// <summary>
        /// Event for each button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.DebtsForm());
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.ExpensesForm());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (ActiveForm == null)
                return;

            UserCache.TotalExpense = Expense.TotalExpenses;
            UserCache.TotalDebt = Debt.TotalDebts;
            BalanceAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Amount);
            ExpenseAmountLb.Text = Utilities.GetDecimal(UserCache.TotalExpense);
            SavingAmountLb.Text = Utilities.GetDecimal(UserCache.Account.Saves);
            DebtAmountLb.Text = Utilities.GetDecimal(UserCache.TotalDebt);
            ActiveForm.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                JsonData.UpdateJson(UserCache.Account, Debt.TotalDebts);
                SQLiteDataBase.InsertOrUpdateDebts(Debt.Debts);
                SQLiteDataBase.InsertOrUpdateExpenses(Expense.Expenses);
                MessageBox.Show("Data saved succesfully.");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Data may not have been saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
