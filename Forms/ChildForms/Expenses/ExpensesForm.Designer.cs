namespace Forms.ChildForms
{
    partial class ExpensesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.ExpensesView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesView)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.BodyPanel.Controls.Add(this.EditBtn);
            this.BodyPanel.Controls.Add(this.UndoBtn);
            this.BodyPanel.Controls.Add(this.RemoveBtn);
            this.BodyPanel.Controls.Add(this.AddExpenseBtn);
            this.BodyPanel.Controls.Add(this.ExpensesView);
            this.BodyPanel.Location = new System.Drawing.Point(-1, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(518, 336);
            this.BodyPanel.TabIndex = 0;
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.EditBtn.Location = new System.Drawing.Point(307, 301);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(102, 23);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Edit Expense";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.FlatAppearance.BorderSize = 0;
            this.UndoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.UndoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.UndoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.UndoBtn.Location = new System.Drawing.Point(415, 301);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(102, 23);
            this.UndoBtn.TabIndex = 12;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RemoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.RemoveBtn.Location = new System.Drawing.Point(108, 301);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(108, 23);
            this.RemoveBtn.TabIndex = 11;
            this.RemoveBtn.Text = "Remove Expense";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddExpenseBtn
            // 
            this.AddExpenseBtn.FlatAppearance.BorderSize = 0;
            this.AddExpenseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddExpenseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.AddExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpenseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddExpenseBtn.Location = new System.Drawing.Point(0, 301);
            this.AddExpenseBtn.Name = "AddExpenseBtn";
            this.AddExpenseBtn.Size = new System.Drawing.Size(102, 23);
            this.AddExpenseBtn.TabIndex = 10;
            this.AddExpenseBtn.Text = "Add Expense";
            this.AddExpenseBtn.UseVisualStyleBackColor = true;
            this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // ExpensesView
            // 
            this.ExpensesView.AllowUserToOrderColumns = true;
            this.ExpensesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpensesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ExpensesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpensesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExpensesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ExpensesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpensesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.Amount,
            this.ExpenseDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ExpensesView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ExpensesView.Location = new System.Drawing.Point(13, 12);
            this.ExpensesView.Name = "ExpensesView";
            this.ExpensesView.ReadOnly = true;
            this.ExpensesView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ExpensesView.Size = new System.Drawing.Size(493, 188);
            this.ExpensesView.TabIndex = 9;
            this.ExpensesView.Text = "dataGridView3";
            this.ExpensesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesView_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MaxInputLength = 20;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.DataPropertyName = "ExpenseDate";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.ExpenseDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExpenseDate.HeaderText = "Expense Date";
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.ReadOnly = true;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddExpenseBtn;
        private System.Windows.Forms.DataGridView ExpensesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDate;
    }
}