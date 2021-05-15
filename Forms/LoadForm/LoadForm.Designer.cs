namespace Forms
{
    partial class LoadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Body = new System.Windows.Forms.Panel();
            this.ReportLb = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Black;
            this.Body.Controls.Add(this.ReportLb);
            this.Body.Controls.Add(this.progressBar1);
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(255, 320);
            this.Body.TabIndex = 0;
            // 
            // ReportLb
            // 
            this.ReportLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.ReportLb.Location = new System.Drawing.Point(12, 32);
            this.ReportLb.Name = "ReportLb";
            this.ReportLb.Size = new System.Drawing.Size(231, 20);
            this.ReportLb.TabIndex = 2;
            this.ReportLb.Text = "Testing...";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 120);
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.LoadForm_Shown);
            this.Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ReportLb;
    }
}

