namespace Forms
{
    partial class UserDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataForm));
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.TitleLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Panel();
            this.CurrencyLb = new System.Windows.Forms.Label();
            this.CurrencyTBox = new System.Windows.Forms.TextBox();
            this.SumbitbBtn = new System.Windows.Forms.Button();
            this.BalanceLb = new System.Windows.Forms.Label();
            this.BalanceTBox = new System.Windows.Forms.TextBox();
            this.SaveLb = new System.Windows.Forms.Label();
            this.SaveTBox = new System.Windows.Forms.TextBox();
            this.LastNameTBox = new System.Windows.Forms.TextBox();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.Body.SuspendLayout();
            this.SuspendLayout();
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
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.TitleLb.Location = new System.Drawing.Point(15, 32);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(97, 37);
            this.TitleLb.TabIndex = 1;
            this.TitleLb.Text = "SaveX";
            this.TitleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.NameLb.Location = new System.Drawing.Point(29, 92);
            this.NameLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(59, 18);
            this.NameLb.TabIndex = 3;
            this.NameLb.Text = "Name:";
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Black;
            this.Body.Controls.Add(this.CurrencyLb);
            this.Body.Controls.Add(this.CurrencyTBox);
            this.Body.Controls.Add(this.SumbitbBtn);
            this.Body.Controls.Add(this.BalanceLb);
            this.Body.Controls.Add(this.BalanceTBox);
            this.Body.Controls.Add(this.SaveLb);
            this.Body.Controls.Add(this.SaveTBox);
            this.Body.Controls.Add(this.LastNameTBox);
            this.Body.Controls.Add(this.LastNameLb);
            this.Body.Controls.Add(this.NameTBox);
            this.Body.Controls.Add(this.NameLb);
            this.Body.Controls.Add(this.TitleLb);
            this.Body.Controls.Add(this.ExitBtn);
            this.Body.Controls.Add(this.MinimizeBtn);
            this.Body.Location = new System.Drawing.Point(-3, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(259, 452);
            this.Body.TabIndex = 0;
            this.Body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Body_MouseDown);
            // 
            // CurrencyLb
            // 
            this.CurrencyLb.AutoSize = true;
            this.CurrencyLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrencyLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.CurrencyLb.Location = new System.Drawing.Point(29, 324);
            this.CurrencyLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.CurrencyLb.Name = "CurrencyLb";
            this.CurrencyLb.Size = new System.Drawing.Size(88, 18);
            this.CurrencyLb.TabIndex = 3;
            this.CurrencyLb.Text = "Currency:";
            // 
            // CurrencyTBox
            // 
            this.CurrencyTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.CurrencyTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrencyTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrencyTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.CurrencyTBox.Location = new System.Drawing.Point(29, 350);
            this.CurrencyTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CurrencyTBox.Name = "CurrencyTBox";
            this.CurrencyTBox.Size = new System.Drawing.Size(175, 22);
            this.CurrencyTBox.TabIndex = 6;
            this.CurrencyTBox.Text = "Ex: USD, EUR, BTC";
            this.CurrencyTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CurrencyTBox_MouseDown);
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
            this.SumbitbBtn.Location = new System.Drawing.Point(146, 408);
            this.SumbitbBtn.Name = "SumbitbBtn";
            this.SumbitbBtn.Size = new System.Drawing.Size(98, 30);
            this.SumbitbBtn.TabIndex = 6;
            this.SumbitbBtn.Text = "Sumbit";
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
            this.BalanceLb.Size = new System.Drawing.Size(135, 18);
            this.BalanceLb.TabIndex = 3;
            this.BalanceLb.Text = "Actual Balance:";
            // 
            // BalanceTBox
            // 
            this.BalanceTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.BalanceTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalanceTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.BalanceTBox.Location = new System.Drawing.Point(29, 234);
            this.BalanceTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BalanceTBox.Name = "BalanceTBox";
            this.BalanceTBox.Size = new System.Drawing.Size(175, 22);
            this.BalanceTBox.TabIndex = 4;
            this.BalanceTBox.Text = "Ex: 1000";
            this.BalanceTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BalanceTBox_MouseDown);
            // 
            // SaveLb
            // 
            this.SaveLb.AutoSize = true;
            this.SaveLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.SaveLb.Location = new System.Drawing.Point(29, 266);
            this.SaveLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.SaveLb.Name = "SaveLb";
            this.SaveLb.Size = new System.Drawing.Size(109, 18);
            this.SaveLb.TabIndex = 3;
            this.SaveLb.Text = "Actual Save:";
            // 
            // SaveTBox
            // 
            this.SaveTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.SaveTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.SaveTBox.Location = new System.Drawing.Point(29, 292);
            this.SaveTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.SaveTBox.Name = "SaveTBox";
            this.SaveTBox.Size = new System.Drawing.Size(175, 22);
            this.SaveTBox.TabIndex = 5;
            this.SaveTBox.Text = "Ex: 1500";
            this.SaveTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveTbox_MouseDown);
            // 
            // LastNameTBox
            // 
            this.LastNameTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.LastNameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.LastNameTBox.Location = new System.Drawing.Point(29, 176);
            this.LastNameTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LastNameTBox.Name = "LastNameTBox";
            this.LastNameTBox.Size = new System.Drawing.Size(175, 22);
            this.LastNameTBox.TabIndex = 3;
            this.LastNameTBox.Text = "Ex: Swain";
            this.LastNameTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LastNameTbox_MouseDown);
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.LastNameLb.Location = new System.Drawing.Point(29, 150);
            this.LastNameLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(98, 18);
            this.LastNameLb.TabIndex = 3;
            this.LastNameLb.Text = "Last Name:";
            // 
            // NameTBox
            // 
            this.NameTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.NameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.NameTBox.Location = new System.Drawing.Point(29, 118);
            this.NameTBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(175, 22);
            this.NameTBox.TabIndex = 2;
            this.NameTBox.Text = "Ex: Josh";
            this.NameTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameTbox_MouseDown);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserData";
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.TextBox LastNameTBox;
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.Label BalanceLb;
        private System.Windows.Forms.TextBox BalanceTBox;
        private System.Windows.Forms.Label SaveLb;
        private System.Windows.Forms.TextBox SaveTBox;
        private System.Windows.Forms.Button SumbitbBtn;
        private System.Windows.Forms.Label CurrencyLb;
        private System.Windows.Forms.TextBox CurrencyTBox;
    }
}