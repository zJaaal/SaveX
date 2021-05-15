using System;
using System.Windows.Forms;
using DataAccess;

namespace Forms
{
    public partial class UserDataForm : Form
    {
        public UserDataForm()
        {
            InitializeComponent();
        }

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
            if(NameTBox.Text == "Ex: Josh")
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
            if (CurrencyTBox.Text == "Ex: USD")
                CurrencyTBox.Text = "";
        }

        private void SumbitbBtn_Click(object sender, EventArgs e)
        {
            decimal MyBalance;
            decimal MySave;

            if (!decimal.TryParse(BalanceTBox.Text, out MyBalance))
            {
                MessageBox.Show("Balance field it's not valid");
                BalanceTBox.Text = "";
                return;
            }
            if (!decimal.TryParse(SaveTBox.Text, out MySave))
            {
                MessageBox.Show("Actual Save Field it's not valid");
                SaveTBox.Text = "";
                return;
            }
            if(!(IsLetters(NameTBox.Text) || 
                IsLetters(LastNameTBox.Text) ||
                IsLetters(CurrencyTBox.Text)))
            {
                MessageBox.Show("Some fields are invalid");
                return;
            }

            if (!(string.IsNullOrWhiteSpace(NameTBox.Text) ||
                  string.IsNullOrWhiteSpace(LastNameTBox.Text) ||
                  string.IsNullOrWhiteSpace(BalanceTBox.Text) ||
                  string.IsNullOrWhiteSpace(SaveTBox.Text)||
                  string.IsNullOrWhiteSpace(CurrencyTBox.Text)))
            {
                UserCache.Account.Amount = MyBalance;
                UserCache.Account.Name = NameTBox.Text + " " + LastNameTBox.Text;
                UserCache.Account.Date = DateTime.Now.Date;
                UserCache.MySave = MySave;
                UserCache.Currency = CurrencyTBox.Text;

                JsonData.FillJson(UserCache.Account, UserCache.MySave, UserCache.Currency);
                MessageBox.Show("Data has been saved");
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
            }
            else if (NameTBox.Text == "Ex: Josh" ||
                    LastNameTBox.Text == "Ex: Swain" ||
                    SaveTBox.Text == "Ex: 1500" ||
                    BalanceTBox.Text == "Ex: 1000" ||
                    CurrencyTBox.Text == "Ex: USD")
                 {
                MessageBox.Show("Some fields are not filled");
                 }       
            else
            {
                MessageBox.Show("Some fields are empty or null");
            }
        }
        /// <summary>
        /// Validates a Letters string
        /// </summary>
        /// <param name="MyString"></param>
        /// <returns></returns>
        private bool IsLetters(string MyString)
        {
            foreach(char a in MyString)
            {
                if (!Char.IsLetter(a))
                    return false;
            }
            return true;
        }
    }
}
