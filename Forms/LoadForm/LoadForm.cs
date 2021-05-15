using System;
using System.Threading;
using System.Windows.Forms;
using DataAccess;
using Money;

namespace Forms
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            ReportLb.Text = "Validating Files...";
        }
        private void LoadForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Thread.Sleep(3000);
                if (JsonData.ReadJson())
                {
                    ReportLb.Text = "Initializing DataBase...";
                    progressBar1.Value = 30;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    if (SQLiteDataBase.CreateDataBase())
                    {
                        ReportLb.Text = "Creating tables...";
                        progressBar1.Value = 50;
                        SQLiteDataBase.CreateTables();
                        Application.DoEvents();
                        Thread.Sleep(1000);
                    }

                    ReportLb.Text = "Welcome to SaveX!";
                    progressBar1.Value = 100;
                    Application.DoEvents();
                    Thread.Sleep(3000);
                    UserDataForm UserData = new UserDataForm();
                    UserData.Show();
                    this.Hide();
                }
                else
                {
                    ReportLb.Text = "Charging Data...";
                    JsonData.TakeInfo(UserCache.Account, UserCache.MySave, UserCache.MyDebt, UserCache.Currency);
                    progressBar1.Value = 30;
                    Application.DoEvents();
                    Thread.Sleep(1000);

                    ReportLb.Text = "Downloading tables...";
                    SQLiteDataBase.TakeAllDebts(Debt.Debts);
                    progressBar1.Value = 50;
                    SQLiteDataBase.TakeAllExpenses(Expense.Expenses);
                    progressBar1.Value = 80;
                    Application.DoEvents();
                    Thread.Sleep(1000);

                    progressBar1.Value = 100;
                    ReportLb.Text = "Opening App...";
                    Application.DoEvents();
                    Thread.Sleep(2000);
                    MainForm Main = new MainForm();
                    Main.Show();
                    this.Hide();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
