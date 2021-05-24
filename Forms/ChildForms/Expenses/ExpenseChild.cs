using Money;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Forms.ChildForms
{
    public partial class ExpenseChild : Form
    {
        /// <summary>
        /// This lines are for dragging the form.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public ExpenseChild()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// This prepares the form to be shown with the Correct data depending on the state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpenseChild_Load(object sender, EventArgs e)
        {
            switch (UserCache.ActualExpenseChildState)
            {
                case 0: //Add Expense State
                    {
                        TitleLb.Text = "New Expense";
                        IDTBox.Text = (Expense.Expenses.Count + 1).ToString();
                        Counterlb.Text = (20 - DescriptionTBox.Text.Length).ToString();
                        Counterlb.ForeColor = Color.FromArgb(60, 238, 151);
                        if (DescriptionTBox.Text.Length >= 20)
                            Counterlb.ForeColor = Color.FromArgb(203, 19, 45);
                        break;
                    }
                case 1: //Edit Expense State
                    {
                        if (UserCache.CurrentExpenseSelected == false)
                        {
                            MessageBox.Show("Please select one expense from the grid");
                            this.Close();
                            break;
                        }
                        TitleLb.Text = "Edit Expense";
                        SumbitbBtn.Text = "Edit";
                        DescriptionTBox.Text = UserCache.CurrentExpense.Description;
                        AmountTBox.Text = UserCache.CurrentExpense.Amount.ToString();
                        IDTBox.Text = UserCache.CurrentExpense.ID.ToString();
                        ExpenseDatePicker.Value = UserCache.CurrentExpense.ExpenseDate.Date;
                        Counterlb.Text = (20 - DescriptionTBox.Text.Length).ToString();
                        Counterlb.ForeColor = Color.FromArgb(60, 238, 151);
                        if (DescriptionTBox.Text.Length >= 20)
                            Counterlb.ForeColor = Color.FromArgb(203, 19, 45);
                        break;
                    }
            }
        }
        /// <summary>
        /// This event validates the data before triggering the Edit or Add method 
        /// depending on the state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumbitbBtn_Click(object sender, EventArgs e)
        {
            decimal MyAmount;
            int MyID;
            switch (UserCache.ActualExpenseChildState)
            {
                case 0: //Add Expense State
                    {
                        if (DescriptionTBox.Text == "Ex: Electricity" ||
                            AmountTBox.Text == "Ex: 1000")
                        {
                            MessageBox.Show("Fill the fields with your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (string.IsNullOrWhiteSpace(IDTBox.Text) ||
                            string.IsNullOrWhiteSpace(DescriptionTBox.Text) ||
                            string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("Some fields may be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!Int32.TryParse(IDTBox.Text, out MyID) ||
                            !decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                            MyID <= 0 ||
                            MyAmount <= 0)
                        {
                            MessageBox.Show("Some numeric fields may be invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if(MyAmount > UserCache.Account.Amount)
                        {
                            MessageBox.Show("You don't have enough money to afford this expense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult DR = MessageBox.Show("Are you sure to add this Expense?", "Verfication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DR == DialogResult.Yes)
                        {
                            Expense.CreateAndAdd(MyID, ExpenseDatePicker.Value.Date, DescriptionTBox.Text, MyAmount, UserCache.Account);
                            MessageBox.Show("Go to Home Window and return to see changes");
                        }
                        break;
                    }
                case 1: // Edit Expense State (Under Development)
                    {
                        if (string.IsNullOrWhiteSpace(IDTBox.Text) ||
                            string.IsNullOrWhiteSpace(DescriptionTBox.Text) ||
                            string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("Some fields may be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!Int32.TryParse(IDTBox.Text, out MyID) ||
                            !decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                            MyID <= 0 ||
                            MyAmount <= 0)
                        {
                            MessageBox.Show("Some numeric fields may be invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (MyAmount > UserCache.Account.Amount)
                        {
                            MessageBox.Show("You don't have enough money to afford this expense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult DR = MessageBox.Show("Are you sure to edit this Expense?", "Verfication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DR == DialogResult.Yes)
                        {
                            Expense.Edit(Expense.Expenses[UserCache.CurrentExpense.ID - 1], MyAmount, DescriptionTBox.Text, ExpenseDatePicker.Value.Date, UserCache.Account);
                            MessageBox.Show("Go to Home window and return to see changes");
                        }
                        break;
                    }
            }
            this.Close();
        }
        /// <summary>
        /// This event update the counter label so the user knows how much charaters can be use.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTBox_TextChanged(object sender, EventArgs e)
        {
            Counterlb.Text = (20 - DescriptionTBox.Text.Length).ToString();
            Counterlb.ForeColor = Color.FromArgb(60, 238, 151);
            if (DescriptionTBox.Text.Length >= 20)
            {
                Counterlb.ForeColor = Color.FromArgb(203, 19, 45);
            }
        }
        /// <summary>
        /// Those events prepare the TBoxes to be filled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTBox_Click(object sender, EventArgs e)
        {
            if (DescriptionTBox.Text == "Ex: Electricity")
                DescriptionTBox.Text = "";
        }

        private void AmountTBox_Click(object sender, EventArgs e)
        {
            if (AmountTBox.Text == "Ex: 1000")
                AmountTBox.Text = "";
        }
        /// <summary>
        /// Dragging event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BodyPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
