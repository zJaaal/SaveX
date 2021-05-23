using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Forms.ChildForms
{
    public partial class AmountInput : Form
    {
        public AmountInput()
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
        private void AmountTBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (AmountTBox.Text == "Ex: 1500")
                AmountTBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This button will work different for each InputAmount State.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumbitBtn_Click(object sender, EventArgs e)
        {
            decimal MyAmount;
            switch (UserCache.ActualInputAmountState)
            {
                case 0://Add Balance
                    {
                       
                        if (string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("The field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (!decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                                  MyAmount < 0)
                        {
                            MessageBox.Show("The field is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Money.Balance.AddBalance(MyAmount, UserCache.Account);
                        this.Close();
                        break;
                    }
                case 1: // Remove Error
                    {

                        if (string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("The field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (!decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                                  MyAmount < 0)
                        {
                            MessageBox.Show("The field is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (MyAmount > UserCache.Account.Amount)
                        {
                            MessageBox.Show("The amount is greater than your current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Money.Balance.RemoveError(MyAmount, UserCache.Account);
                        this.Close();
                        break;
                    }
                case 2: //Withdraw Saving
                    {
                        
                        if (string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("The field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (!decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                                  MyAmount < 0)
                        {
                            MessageBox.Show("The field is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (MyAmount > UserCache.Account.Saves)
                        {
                            MessageBox.Show("The amount is greater than your current savings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Money.Balance.WithdrawSaving(MyAmount, UserCache.Account);
                        this.Close();
                        break;
                    }
                case 3: // Add Savings
                    {
                        
                        if (string.IsNullOrWhiteSpace(AmountTBox.Text))
                        {
                            MessageBox.Show("The field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (!decimal.TryParse(AmountTBox.Text, out MyAmount) ||
                                  MyAmount < 0)
                        {
                            MessageBox.Show("The field is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else if (MyAmount > UserCache.Account.Amount)
                        {
                            MessageBox.Show("The amount is greater than your current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        Money.Balance.AddSaving(MyAmount, UserCache.Account);
                        this.Close();
                        break;
                    }

            }
        }
        /// <summary>
        /// This event is for changing input color foreach state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmountInput_Load(object sender, EventArgs e)
        {
            switch (UserCache.ActualInputAmountState)
            {
                case 0://Add Balance
                    {
                        AmountTBox.ForeColor = Color.FromArgb(123, 215, 194);
                        break;
                    }
                case 1: // Remove Error
                    {
                        AmountTBox.ForeColor = Color.FromArgb(203, 19, 45);
                        break;
                    }
                case 2: //Withdraw Saving
                    {
                        AmountTBox.ForeColor = Color.FromArgb(255, 217, 0);
                        break;
                    }
                case 3: // Add Savings
                    {
                        AmountTBox.ForeColor = Color.FromArgb(60, 238, 151);
                        break;
                    }
            }
        }
        /// <summary>
        /// Form dragging event.
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
