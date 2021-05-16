using System.Windows.Forms;
using Money;
using DataAccess;
using System.Runtime.InteropServices;
using System;
using System.Linq;
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeLb.Text = "Welcome! " + UserCache.Account.Name;
            DateTimeLabel.Text = DateTime.Now.ToString("D");
            UserCache.TotalExpense = Expense.Expenses.Select(x => x.Amount).Sum();
            BalanceAmountLb.Text = UserCache.Account.Amount.ToString("#,#") + " " + UserCache.Currency;
            ExpenseAmountLb.Text = UserCache.TotalExpense.ToString("#,#") + " " + UserCache.Currency;
            SavingAmountLb.Text = UserCache.MySave.ToString("#,#") + " " + UserCache.Currency;
            DebtAmountLb.Text = UserCache.MyDebt.ToString("#,#") + " " + UserCache.Currency;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
