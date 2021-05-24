namespace Forms.ChildForms
{
    partial class DebtsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.AddDebtBtn = new System.Windows.Forms.Button();
            this.DebtsView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtsView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(477, 224);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.BodyPanel.Controls.Add(this.EditBtn);
            this.BodyPanel.Controls.Add(this.UndoBtn);
            this.BodyPanel.Controls.Add(this.PayBtn);
            this.BodyPanel.Controls.Add(this.AddDebtBtn);
            this.BodyPanel.Controls.Add(this.DebtsView);
            this.BodyPanel.Location = new System.Drawing.Point(-1, 0);
            this.BodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(522, 336);
            this.BodyPanel.TabIndex = 0;
            this.BodyPanel.Click += new System.EventHandler(this.BodyPanel_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.EditBtn.Location = new System.Drawing.Point(296, 301);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(102, 23);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Edit Debt";
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
            this.UndoBtn.Location = new System.Drawing.Point(404, 301);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(102, 23);
            this.UndoBtn.TabIndex = 7;
            this.UndoBtn.Text = "Undo Payment";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.FlatAppearance.BorderSize = 0;
            this.PayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.PayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.PayBtn.Location = new System.Drawing.Point(108, 301);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(102, 23);
            this.PayBtn.TabIndex = 6;
            this.PayBtn.Text = "Pay Debt";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // AddDebtBtn
            // 
            this.AddDebtBtn.FlatAppearance.BorderSize = 0;
            this.AddDebtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddDebtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.AddDebtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDebtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AddDebtBtn.Location = new System.Drawing.Point(0, 301);
            this.AddDebtBtn.Name = "AddDebtBtn";
            this.AddDebtBtn.Size = new System.Drawing.Size(102, 23);
            this.AddDebtBtn.TabIndex = 5;
            this.AddDebtBtn.Text = "Add Debt";
            this.AddDebtBtn.UseVisualStyleBackColor = true;
            this.AddDebtBtn.Click += new System.EventHandler(this.AddDebtBtn_Click);
            // 
            // DebtsView
            // 
            this.DebtsView.AllowUserToOrderColumns = true;
            this.DebtsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DebtsView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.DebtsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebtsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DebtsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DebtsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.Amount,
            this.DeadLine});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DebtsView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DebtsView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DebtsView.Location = new System.Drawing.Point(13, 12);
            this.DebtsView.Name = "DebtsView";
            this.DebtsView.ReadOnly = true;
            this.DebtsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DebtsView.Size = new System.Drawing.Size(493, 188);
            this.DebtsView.TabIndex = 0;
            this.DebtsView.Text = "dataGridView3";
            this.DebtsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebtsView_CellClick);
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
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.DeadLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeadLine.HeaderText = "Dead Line";
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            // 
            // DebtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebtsForm";
            this.Text = "DebtsForm";
            this.Load += new System.EventHandler(this.DebtsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebtsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.DataGridView DebtsView;
        private System.Windows.Forms.Button AddDebtBtn;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
    }
}