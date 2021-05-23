namespace Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UpPanel = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.WelcomeLb = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.YellowPanel = new System.Windows.Forms.Panel();
            this.LightBluePanel = new System.Windows.Forms.Panel();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.ExpensesBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.DebtsBtn = new System.Windows.Forms.Button();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.AddBalanceBtn = new System.Windows.Forms.Button();
            this.RemoveBalanceBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.AddSavingBtn = new System.Windows.Forms.Button();
            this.BalancePanel = new System.Windows.Forms.Panel();
            this.BalanceAmountLb = new System.Windows.Forms.Label();
            this.BalanceLb = new System.Windows.Forms.Label();
            this.ExpensesPanel = new System.Windows.Forms.Panel();
            this.ExpenseLb = new System.Windows.Forms.Label();
            this.ExpenseAmountLb = new System.Windows.Forms.Label();
            this.SavingsPanel = new System.Windows.Forms.Panel();
            this.SavingAmountLb = new System.Windows.Forms.Label();
            this.SavingLb = new System.Windows.Forms.Label();
            this.DebtsPanel = new System.Windows.Forms.Panel();
            this.DebtAmountLb = new System.Windows.Forms.Label();
            this.DebtLb = new System.Windows.Forms.Label();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.BalancePanel.SuspendLayout();
            this.ExpensesPanel.SuspendLayout();
            this.SavingsPanel.SuspendLayout();
            this.DebtsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.Black;
            this.UpPanel.Controls.Add(this.DateTimeLabel);
            this.UpPanel.Controls.Add(this.MinimizeBtn);
            this.UpPanel.Controls.Add(this.ExitBtn);
            this.UpPanel.Controls.Add(this.WelcomeLb);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(517, 61);
            this.UpPanel.TabIndex = 0;
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.DateTimeLabel.Location = new System.Drawing.Point(13, 33);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(79, 15);
            this.DateTimeLabel.TabIndex = 2;
            this.DateTimeLabel.Text = "DateTime Now";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(460, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 15);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(486, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 15);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WelcomeLb
            // 
            this.WelcomeLb.AutoSize = true;
            this.WelcomeLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.WelcomeLb.Location = new System.Drawing.Point(13, 12);
            this.WelcomeLb.Name = "WelcomeLb";
            this.WelcomeLb.Size = new System.Drawing.Size(77, 21);
            this.WelcomeLb.TabIndex = 0;
            this.WelcomeLb.Text = "Welcome!";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Black;
            this.MenuPanel.Controls.Add(this.YellowPanel);
            this.MenuPanel.Controls.Add(this.LightBluePanel);
            this.MenuPanel.Controls.Add(this.RedPanel);
            this.MenuPanel.Controls.Add(this.ExpensesBtn);
            this.MenuPanel.Controls.Add(this.HomeBtn);
            this.MenuPanel.Controls.Add(this.DebtsBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPanel.Location = new System.Drawing.Point(0, 397);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(517, 53);
            this.MenuPanel.TabIndex = 0;
            // 
            // YellowPanel
            // 
            this.YellowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.YellowPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.YellowPanel.Location = new System.Drawing.Point(301, 0);
            this.YellowPanel.Name = "YellowPanel";
            this.YellowPanel.Size = new System.Drawing.Size(74, 8);
            this.YellowPanel.TabIndex = 3;
            // 
            // LightBluePanel
            // 
            this.LightBluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.LightBluePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.LightBluePanel.Location = new System.Drawing.Point(224, 0);
            this.LightBluePanel.Name = "LightBluePanel";
            this.LightBluePanel.Size = new System.Drawing.Size(74, 8);
            this.LightBluePanel.TabIndex = 3;
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RedPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RedPanel.Location = new System.Drawing.Point(147, 0);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(74, 8);
            this.RedPanel.TabIndex = 3;
            // 
            // ExpensesBtn
            // 
            this.ExpensesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExpensesBtn.FlatAppearance.BorderSize = 0;
            this.ExpensesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpensesBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpensesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ExpensesBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExpensesBtn.Location = new System.Drawing.Point(301, 3);
            this.ExpensesBtn.Name = "ExpensesBtn";
            this.ExpensesBtn.Size = new System.Drawing.Size(74, 53);
            this.ExpensesBtn.TabIndex = 2;
            this.ExpensesBtn.Text = "Expenses";
            this.ExpensesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExpensesBtn.UseVisualStyleBackColor = true;
            this.ExpensesBtn.Click += new System.EventHandler(this.ExpensesBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.HomeBtn.Location = new System.Drawing.Point(224, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(74, 53);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DebtsBtn
            // 
            this.DebtsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DebtsBtn.FlatAppearance.BorderSize = 0;
            this.DebtsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.DebtsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebtsBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DebtsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.DebtsBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DebtsBtn.Location = new System.Drawing.Point(147, 0);
            this.DebtsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DebtsBtn.Name = "DebtsBtn";
            this.DebtsBtn.Size = new System.Drawing.Size(74, 53);
            this.DebtsBtn.TabIndex = 2;
            this.DebtsBtn.Text = "Debts";
            this.DebtsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DebtsBtn.UseVisualStyleBackColor = true;
            this.DebtsBtn.Click += new System.EventHandler(this.DebtsBtn_Click);
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.BodyPanel.Controls.Add(this.AddBalanceBtn);
            this.BodyPanel.Controls.Add(this.RemoveBalanceBtn);
            this.BodyPanel.Controls.Add(this.WithdrawBtn);
            this.BodyPanel.Controls.Add(this.AddSavingBtn);
            this.BodyPanel.Controls.Add(this.BalancePanel);
            this.BodyPanel.Controls.Add(this.ExpensesPanel);
            this.BodyPanel.Controls.Add(this.SavingsPanel);
            this.BodyPanel.Controls.Add(this.DebtsPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 61);
            this.BodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(517, 336);
            this.BodyPanel.TabIndex = 2;
            // 
            // AddBalanceBtn
            // 
            this.AddBalanceBtn.FlatAppearance.BorderSize = 0;
            this.AddBalanceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddBalanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.AddBalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBalanceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddBalanceBtn.Location = new System.Drawing.Point(403, 307);
            this.AddBalanceBtn.Name = "AddBalanceBtn";
            this.AddBalanceBtn.Size = new System.Drawing.Size(102, 23);
            this.AddBalanceBtn.TabIndex = 4;
            this.AddBalanceBtn.Text = "Add Balance";
            this.AddBalanceBtn.UseVisualStyleBackColor = true;
            this.AddBalanceBtn.Click += new System.EventHandler(this.AddBalanceBtn_Click);
            // 
            // RemoveBalanceBtn
            // 
            this.RemoveBalanceBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBalanceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RemoveBalanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.RemoveBalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBalanceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RemoveBalanceBtn.Location = new System.Drawing.Point(293, 307);
            this.RemoveBalanceBtn.Name = "RemoveBalanceBtn";
            this.RemoveBalanceBtn.Size = new System.Drawing.Size(104, 23);
            this.RemoveBalanceBtn.TabIndex = 4;
            this.RemoveBalanceBtn.Text = "Remove Balance";
            this.RemoveBalanceBtn.UseVisualStyleBackColor = true;
            this.RemoveBalanceBtn.Click += new System.EventHandler(this.RemoveBalanceBtn_Click);
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.FlatAppearance.BorderSize = 0;
            this.WithdrawBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.WithdrawBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.WithdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.WithdrawBtn.Location = new System.Drawing.Point(122, 307);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(104, 23);
            this.WithdrawBtn.TabIndex = 4;
            this.WithdrawBtn.Text = "Withdraw Saving";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // AddSavingBtn
            // 
            this.AddSavingBtn.FlatAppearance.BorderSize = 0;
            this.AddSavingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.AddSavingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.AddSavingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSavingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.AddSavingBtn.Location = new System.Drawing.Point(12, 307);
            this.AddSavingBtn.Name = "AddSavingBtn";
            this.AddSavingBtn.Size = new System.Drawing.Size(104, 23);
            this.AddSavingBtn.TabIndex = 4;
            this.AddSavingBtn.Text = "Add Savings";
            this.AddSavingBtn.UseVisualStyleBackColor = true;
            this.AddSavingBtn.Click += new System.EventHandler(this.AddSavingBtn_Click);
            // 
            // BalancePanel
            // 
            this.BalancePanel.Controls.Add(this.BalanceAmountLb);
            this.BalancePanel.Controls.Add(this.BalanceLb);
            this.BalancePanel.Location = new System.Drawing.Point(302, 162);
            this.BalancePanel.Name = "BalancePanel";
            this.BalancePanel.Size = new System.Drawing.Size(209, 100);
            this.BalancePanel.TabIndex = 3;
            // 
            // BalanceAmountLb
            // 
            this.BalanceAmountLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.BalanceAmountLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.BalanceAmountLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceAmountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.BalanceAmountLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BalanceAmountLb.Location = new System.Drawing.Point(0, 0);
            this.BalanceAmountLb.Name = "BalanceAmountLb";
            this.BalanceAmountLb.Size = new System.Drawing.Size(209, 81);
            this.BalanceAmountLb.TabIndex = 1;
            this.BalanceAmountLb.Text = "Total Amount";
            this.BalanceAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceLb
            // 
            this.BalanceLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BalanceLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BalanceLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.BalanceLb.Location = new System.Drawing.Point(0, 81);
            this.BalanceLb.Name = "BalanceLb";
            this.BalanceLb.Size = new System.Drawing.Size(209, 19);
            this.BalanceLb.TabIndex = 0;
            this.BalanceLb.Text = "Total Balance";
            this.BalanceLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExpensesPanel
            // 
            this.ExpensesPanel.Controls.Add(this.ExpenseLb);
            this.ExpensesPanel.Controls.Add(this.ExpenseAmountLb);
            this.ExpensesPanel.Location = new System.Drawing.Point(302, 13);
            this.ExpensesPanel.Name = "ExpensesPanel";
            this.ExpensesPanel.Size = new System.Drawing.Size(204, 100);
            this.ExpensesPanel.TabIndex = 3;
            // 
            // ExpenseLb
            // 
            this.ExpenseLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExpenseLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExpenseLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ExpenseLb.Location = new System.Drawing.Point(0, 81);
            this.ExpenseLb.Name = "ExpenseLb";
            this.ExpenseLb.Size = new System.Drawing.Size(204, 19);
            this.ExpenseLb.TabIndex = 0;
            this.ExpenseLb.Text = "Total Expenses";
            this.ExpenseLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExpenseAmountLb
            // 
            this.ExpenseAmountLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ExpenseAmountLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpenseAmountLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpenseAmountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ExpenseAmountLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExpenseAmountLb.Location = new System.Drawing.Point(0, 0);
            this.ExpenseAmountLb.Name = "ExpenseAmountLb";
            this.ExpenseAmountLb.Size = new System.Drawing.Size(204, 81);
            this.ExpenseAmountLb.TabIndex = 1;
            this.ExpenseAmountLb.Text = "Total Amount";
            this.ExpenseAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingsPanel
            // 
            this.SavingsPanel.Controls.Add(this.SavingAmountLb);
            this.SavingsPanel.Controls.Add(this.SavingLb);
            this.SavingsPanel.Location = new System.Drawing.Point(13, 162);
            this.SavingsPanel.Name = "SavingsPanel";
            this.SavingsPanel.Size = new System.Drawing.Size(209, 100);
            this.SavingsPanel.TabIndex = 3;
            // 
            // SavingAmountLb
            // 
            this.SavingAmountLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.SavingAmountLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.SavingAmountLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavingAmountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.SavingAmountLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SavingAmountLb.Location = new System.Drawing.Point(0, 0);
            this.SavingAmountLb.Name = "SavingAmountLb";
            this.SavingAmountLb.Size = new System.Drawing.Size(209, 81);
            this.SavingAmountLb.TabIndex = 1;
            this.SavingAmountLb.Text = "Total Amount";
            this.SavingAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingLb
            // 
            this.SavingLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SavingLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SavingLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.SavingLb.Location = new System.Drawing.Point(0, 81);
            this.SavingLb.Name = "SavingLb";
            this.SavingLb.Size = new System.Drawing.Size(209, 19);
            this.SavingLb.TabIndex = 0;
            this.SavingLb.Text = "Total Savings";
            this.SavingLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DebtsPanel
            // 
            this.DebtsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtsPanel.Controls.Add(this.DebtAmountLb);
            this.DebtsPanel.Controls.Add(this.DebtLb);
            this.DebtsPanel.Location = new System.Drawing.Point(13, 13);
            this.DebtsPanel.Name = "DebtsPanel";
            this.DebtsPanel.Size = new System.Drawing.Size(209, 100);
            this.DebtsPanel.TabIndex = 3;
            // 
            // DebtAmountLb
            // 
            this.DebtAmountLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.DebtAmountLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebtAmountLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DebtAmountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.DebtAmountLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DebtAmountLb.Location = new System.Drawing.Point(0, 0);
            this.DebtAmountLb.Name = "DebtAmountLb";
            this.DebtAmountLb.Size = new System.Drawing.Size(209, 81);
            this.DebtAmountLb.TabIndex = 1;
            this.DebtAmountLb.Text = "Total Amount";
            this.DebtAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DebtLb
            // 
            this.DebtLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DebtLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DebtLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.DebtLb.Location = new System.Drawing.Point(0, 81);
            this.DebtLb.Name = "DebtLb";
            this.DebtLb.Size = new System.Drawing.Size(209, 19);
            this.DebtLb.TabIndex = 0;
            this.DebtLb.Text = "Total Debt";
            this.DebtLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BalancePanel.ResumeLayout(false);
            this.ExpensesPanel.ResumeLayout(false);
            this.SavingsPanel.ResumeLayout(false);
            this.DebtsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Label WelcomeLb;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button ExpensesBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DebtsBtn;
        private System.Windows.Forms.Panel YellowPanel;
        private System.Windows.Forms.Panel LightBluePanel;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Panel ExpensesPanel;
        private System.Windows.Forms.Label ExpenseLb;
        private System.Windows.Forms.Label ExpenseAmountLb;
        private System.Windows.Forms.Panel SavingsPanel;
        private System.Windows.Forms.Panel DebtsPanel;
        private System.Windows.Forms.Label DebtAmountLb;
        private System.Windows.Forms.Label DebtLb;
        private System.Windows.Forms.Label SavingAmountLb;
        private System.Windows.Forms.Label SavingLb;
        private System.Windows.Forms.Panel BalancePanel;
        private System.Windows.Forms.Label BalanceAmountLb;
        private System.Windows.Forms.Label BalanceLb;
        private System.Windows.Forms.Button AddBalanceBtn;
        private System.Windows.Forms.Button RemoveBalanceBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button AddSavingBtn;
    }
}