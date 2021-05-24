
namespace Forms.ChildForms
{
    partial class ExpenseChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseChild));
            this.Body = new System.Windows.Forms.Panel();
            this.Counterlb = new System.Windows.Forms.Label();
            this.ExpenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SumbitbBtn = new System.Windows.Forms.Button();
            this.BalanceLb = new System.Windows.Forms.Label();
            this.AmountTBox = new System.Windows.Forms.TextBox();
            this.ExpenseDateLb = new System.Windows.Forms.Label();
            this.DescriptionTBox = new System.Windows.Forms.TextBox();
            this.DescriptionLb = new System.Windows.Forms.Label();
            this.IDTBox = new System.Windows.Forms.TextBox();
            this.IDLb = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Black;
            this.Body.Controls.Add(this.Counterlb);
            this.Body.Controls.Add(this.ExpenseDatePicker);
            this.Body.Controls.Add(this.SumbitbBtn);
            this.Body.Controls.Add(this.BalanceLb);
            this.Body.Controls.Add(this.AmountTBox);
            this.Body.Controls.Add(this.ExpenseDateLb);
            this.Body.Controls.Add(this.DescriptionTBox);
            this.Body.Controls.Add(this.DescriptionLb);
            this.Body.Controls.Add(this.IDTBox);
            this.Body.Controls.Add(this.IDLb);
            this.Body.Controls.Add(this.TitleLb);
            this.Body.Controls.Add(this.ExitBtn);
            this.Body.Controls.Add(this.MinimizeBtn);
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(264, 390);
            this.Body.TabIndex = 2;
            this.Body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BodyPanel_MouseDown);
            // 
            // Counterlb
            // 
            this.Counterlb.AutoSize = true;
            this.Counterlb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Counterlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.Counterlb.Location = new System.Drawing.Point(223, 182);
            this.Counterlb.Name = "Counterlb";
            this.Counterlb.Size = new System.Drawing.Size(21, 14);
            this.Counterlb.TabIndex = 8;
            this.Counterlb.Text = "20";
            // 
            // ExpenseDatePicker
            // 
            this.ExpenseDatePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpenseDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.ExpenseDatePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.ExpenseDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ExpenseDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ExpenseDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.ExpenseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpenseDatePicker.Location = new System.Drawing.Point(29, 292);
            this.ExpenseDatePicker.Name = "ExpenseDatePicker";
            this.ExpenseDatePicker.Size = new System.Drawing.Size(175, 23);
            this.ExpenseDatePicker.TabIndex = 3;
            // 
            // SumbitbBtn
            // 
            this.SumbitbBtn.BackColor = System.Drawing.Color.Black;
            this.SumbitbBtn.FlatAppearance.BorderSize = 0;
            this.SumbitbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.SumbitbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.SumbitbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumbitbBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SumbitbBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.SumbitbBtn.Location = new System.Drawing.Point(152, 339);
            this.SumbitbBtn.Name = "SumbitbBtn";
            this.SumbitbBtn.Size = new System.Drawing.Size(98, 30);
            this.SumbitbBtn.TabIndex = 4;
            this.SumbitbBtn.Text = "Add";
            this.SumbitbBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SumbitbBtn.UseVisualStyleBackColor = false;
            this.SumbitbBtn.Click += new System.EventHandler(this.SumbitbBtn_Click);
            // 
            // BalanceLb
            // 
            this.BalanceLb.AutoSize = true;
            this.BalanceLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.BalanceLb.Location = new System.Drawing.Point(29, 208);
            this.BalanceLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.BalanceLb.Name = "BalanceLb";
            this.BalanceLb.Size = new System.Drawing.Size(75, 18);
            this.BalanceLb.TabIndex = 3;
            this.BalanceLb.Text = "Amount:";
            // 
            // AmountTBox
            // 
            this.AmountTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.AmountTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AmountTBox.Location = new System.Drawing.Point(29, 234);
            this.AmountTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AmountTBox.Name = "AmountTBox";
            this.AmountTBox.Size = new System.Drawing.Size(175, 22);
            this.AmountTBox.TabIndex = 2;
            this.AmountTBox.Text = "Ex: 1000";
            this.AmountTBox.Click += new System.EventHandler(this.AmountTBox_Click);
            // 
            // ExpenseDateLb
            // 
            this.ExpenseDateLb.AutoSize = true;
            this.ExpenseDateLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpenseDateLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.ExpenseDateLb.Location = new System.Drawing.Point(29, 266);
            this.ExpenseDateLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ExpenseDateLb.Name = "ExpenseDateLb";
            this.ExpenseDateLb.Size = new System.Drawing.Size(123, 18);
            this.ExpenseDateLb.TabIndex = 3;
            this.ExpenseDateLb.Text = "Expense Date:";
            // 
            // DescriptionTBox
            // 
            this.DescriptionTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DescriptionTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.DescriptionTBox.Location = new System.Drawing.Point(29, 176);
            this.DescriptionTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DescriptionTBox.MaxLength = 20;
            this.DescriptionTBox.Name = "DescriptionTBox";
            this.DescriptionTBox.Size = new System.Drawing.Size(175, 22);
            this.DescriptionTBox.TabIndex = 1;
            this.DescriptionTBox.Text = "Ex: Electricity";
            this.DescriptionTBox.Click += new System.EventHandler(this.DescriptionTBox_Click);
            this.DescriptionTBox.TextChanged += new System.EventHandler(this.DescriptionTBox_TextChanged);
            // 
            // DescriptionLb
            // 
            this.DescriptionLb.AutoSize = true;
            this.DescriptionLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.DescriptionLb.Location = new System.Drawing.Point(29, 150);
            this.DescriptionLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DescriptionLb.Name = "DescriptionLb";
            this.DescriptionLb.Size = new System.Drawing.Size(105, 18);
            this.DescriptionLb.TabIndex = 3;
            this.DescriptionLb.Text = "Description:";
            // 
            // IDTBox
            // 
            this.IDTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.IDTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.IDTBox.Location = new System.Drawing.Point(29, 118);
            this.IDTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.IDTBox.Name = "IDTBox";
            this.IDTBox.ReadOnly = true;
            this.IDTBox.Size = new System.Drawing.Size(175, 22);
            this.IDTBox.TabIndex = 10;
            // 
            // IDLb
            // 
            this.IDLb.AutoSize = true;
            this.IDLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.IDLb.Location = new System.Drawing.Point(29, 92);
            this.IDLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.IDLb.Name = "IDLb";
            this.IDLb.Size = new System.Drawing.Size(30, 18);
            this.IDLb.TabIndex = 3;
            this.IDLb.Text = "ID:";
            // 
            // TitleLb
            // 
            this.TitleLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.TitleLb.Location = new System.Drawing.Point(12, 30);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(214, 48);
            this.TitleLb.TabIndex = 1;
            this.TitleLb.Text = "Create Expense";
            this.TitleLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(230, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(14, 15);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(204, 14);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 13);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 0;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExpenseChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 390);
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExpenseChild";
            this.Load += new System.EventHandler(this.ExpenseChild_Load);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Label Counterlb;
        private System.Windows.Forms.DateTimePicker ExpenseDatePicker;
        private System.Windows.Forms.Button SumbitbBtn;
        private System.Windows.Forms.Label BalanceLb;
        private System.Windows.Forms.TextBox AmountTBox;
        private System.Windows.Forms.Label ExpenseDateLb;
        private System.Windows.Forms.TextBox DescriptionTBox;
        private System.Windows.Forms.Label DescriptionLb;
        private System.Windows.Forms.TextBox IDTBox;
        private System.Windows.Forms.Label IDLb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox MinimizeBtn;
    }
}