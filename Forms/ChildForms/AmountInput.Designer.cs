namespace Forms.ChildForms
{
    partial class AmountInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmountInput));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.SumbitBtn = new System.Windows.Forms.Button();
            this.AmountTBox = new System.Windows.Forms.TextBox();
            this.InputAmountLb = new System.Windows.Forms.Label();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.Black;
            this.BodyPanel.Controls.Add(this.ExitBtn);
            this.BodyPanel.Controls.Add(this.SumbitBtn);
            this.BodyPanel.Controls.Add(this.AmountTBox);
            this.BodyPanel.Controls.Add(this.InputAmountLb);
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(259, 93);
            this.BodyPanel.TabIndex = 0;
            this.BodyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BodyPanel_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(228, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(18, 10);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SumbitBtn
            // 
            this.SumbitBtn.FlatAppearance.BorderSize = 0;
            this.SumbitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.SumbitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.SumbitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumbitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.SumbitBtn.Location = new System.Drawing.Point(171, 61);
            this.SumbitBtn.Name = "SumbitBtn";
            this.SumbitBtn.Size = new System.Drawing.Size(75, 23);
            this.SumbitBtn.TabIndex = 2;
            this.SumbitBtn.Text = "Sumbit";
            this.SumbitBtn.UseVisualStyleBackColor = true;
            this.SumbitBtn.Click += new System.EventHandler(this.SumbitBtn_Click);
            // 
            // AmountTBox
            // 
            this.AmountTBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.AmountTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTBox.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.AmountTBox.Location = new System.Drawing.Point(12, 34);
            this.AmountTBox.Name = "AmountTBox";
            this.AmountTBox.Size = new System.Drawing.Size(234, 21);
            this.AmountTBox.TabIndex = 1;
            this.AmountTBox.Text = "Ex: 1500";
            this.AmountTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AmountTBox_MouseDown);
            // 
            // InputAmountLb
            // 
            this.InputAmountLb.AutoSize = true;
            this.InputAmountLb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputAmountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.InputAmountLb.Location = new System.Drawing.Point(12, 9);
            this.InputAmountLb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.InputAmountLb.Name = "InputAmountLb";
            this.InputAmountLb.Size = new System.Drawing.Size(121, 19);
            this.InputAmountLb.TabIndex = 0;
            this.InputAmountLb.Text = "Enter an Amount:";
            // 
            // AmountInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 91);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmountInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AmountInput";
            this.Load += new System.EventHandler(this.AmountInput_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label InputAmountLb;
        private System.Windows.Forms.TextBox AmountTBox;
        private System.Windows.Forms.Button SumbitBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
    }
}