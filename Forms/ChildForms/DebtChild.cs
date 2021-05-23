using Money;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Forms.ChildForms
{
    public partial class DebtChild : Form
    {
        /// <summary>
        /// This lines are for dragging the form.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public DebtChild()
        {
            InitializeComponent();
        }
        private void DebtChild_Load(object sender, EventArgs e)
        {
            switch (UserCache.ActualDebtChildState)
            {
                case 0: //Add Debt State
                    {
                        IDTBox.Text = (Debt.Debts.Count + 1).ToString();
                        Counterlb.Text = (20 - DescriptionTBox.Text.Length).ToString();
                        Counterlb.ForeColor = Color.FromArgb(60, 238, 151);
                        if (DescriptionTBox.Text.Length >= 20)
                            Counterlb.ForeColor = Color.FromArgb(203, 19, 45);
                        break;
                    }
                case 1: // Edit Debt State (Under Development)
                    {
                        break;
                    }
            }
        }

        private void DescriptionTBox_Click(object sender, EventArgs e)
        {
            if (DescriptionTBox.Text == "Ex: Pay to Joe")
                DescriptionTBox.Text = "";
        }

        private void AmountTBox_Click(object sender, EventArgs e)
        {
            if (AmountTBox.Text == "Ex: 1000")
                AmountTBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SumbitbBtn_Click(object sender, EventArgs e)
        {
            decimal MyAmount;
            int MyID;
            switch (UserCache.ActualDebtChildState)
            {
                case 0: //Add Debt State
                    {
                        if (DescriptionTBox.Text == "Ex: Pay to Joe" ||
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
                        if (DateTime.Compare(DateTime.Now, DeadLinePicker.Value) > 0)
                        {
                            MessageBox.Show("DeadLine is before today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult DR = MessageBox.Show("Are you sure to add this Debt?", "Verfication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DR == DialogResult.Yes)
                        {
                            Debt.CreateAndAdd(MyID, DeadLinePicker.Value.Date, DescriptionTBox.Text, MyAmount);
                        }
                        break;
                    }
                case 1: // Edit Debt State (Under Development)
                    {
                        MessageBox.Show("Under Development...");
                        break;
                    }
            }
            this.Close();
        }

        private void DescriptionTBox_TextChanged(object sender, EventArgs e)
        {
            Counterlb.Text = (20 - DescriptionTBox.Text.Length).ToString();
            Counterlb.ForeColor = Color.FromArgb(60, 238, 151);
            if (DescriptionTBox.Text.Length >= 20)
            {
                Counterlb.ForeColor = Color.FromArgb(203, 19, 45);
            }

        }
        private void BodyPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
