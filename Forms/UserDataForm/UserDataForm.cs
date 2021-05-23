using DataAccess;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Forms
{
    public partial class UserDataForm : Form
    {
        public UserDataForm()
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NameTbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (NameTBox.Text == "Ex: Josh")
                NameTBox.Text = "";
        }

        private void LastNameTbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (LastNameTBox.Text == "Ex: Swain")
                LastNameTBox.Text = "";
        }

        private void BalanceTBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (BalanceTBox.Text == "Ex: 1000")
                BalanceTBox.Text = "";
        }

        private void SaveTbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SaveTBox.Text == "Ex: 1500")
                SaveTBox.Text = "";
        }
        private void CurrencyTBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (CurrencyTBox.Text == "Ex: USD, EUR, BTC")
                CurrencyTBox.Text = "";
        }
        /// <summary>
        /// This event validates all fields before Json is filled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumbitbBtn_Click(object sender, EventArgs e)
        {
            decimal MyBalance;
            decimal MySave;

            if ((string.IsNullOrWhiteSpace(NameTBox.Text) ||
                  string.IsNullOrWhiteSpace(LastNameTBox.Text) ||
                  string.IsNullOrWhiteSpace(BalanceTBox.Text) ||
                  string.IsNullOrWhiteSpace(SaveTBox.Text) ||
                  string.IsNullOrWhiteSpace(CurrencyTBox.Text)))
            {
                MessageBox.Show("Some fields may be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (NameTBox.Text == "Ex: Josh" ||
                    LastNameTBox.Text == "Ex: Swain" ||
                    SaveTBox.Text == "Ex: 1500" ||
                    BalanceTBox.Text == "Ex: 1000" ||
                    CurrencyTBox.Text == "Ex: USD, EUR, BTC")
            {
                MessageBox.Show("Some fields are filled with examples.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(Utilities.CheckString(NameTBox.Text) ||
                Utilities.CheckString(LastNameTBox.Text) ||
                Utilities.CheckString(CurrencyTBox.Text)))
            {
                MessageBox.Show("Some fields may be invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(BalanceTBox.Text, out MyBalance) || !decimal.TryParse(SaveTBox.Text, out MySave) ||
                      MyBalance < 0 || MySave < 0)
            {
                MessageBox.Show("Numeric fields may be invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserCache.Account.Amount = MyBalance;
                UserCache.Account.Name = NameTBox.Text + " " + LastNameTBox.Text;
                UserCache.Account.Date = DateTime.Now.Date;
                UserCache.Account.Saves= MySave;
                UserCache.Currency = CurrencyTBox.Text;

                JsonData.FillJson(UserCache.Account, UserCache.Currency);
                MessageBox.Show("Data has been saved.");
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
            }
        }
        
        /// <summary>
        /// Form dragging event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Body_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
