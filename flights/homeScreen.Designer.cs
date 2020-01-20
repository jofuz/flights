namespace flights
{
    partial class homeScreen
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
            this.cyanairTitle = new System.Windows.Forms.Label();
            this.bookFlightBtn = new System.Windows.Forms.Button();
            this.adminScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cyanairTitle
            // 
            this.cyanairTitle.AutoSize = true;
            this.cyanairTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cyanairTitle.Location = new System.Drawing.Point(220, 50);
            this.cyanairTitle.Name = "cyanairTitle";
            this.cyanairTitle.Size = new System.Drawing.Size(135, 39);
            this.cyanairTitle.TabIndex = 0;
            this.cyanairTitle.Text = "Cyanair";
            this.cyanairTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookFlightBtn
            // 
            this.bookFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookFlightBtn.Location = new System.Drawing.Point(32, 155);
            this.bookFlightBtn.Name = "bookFlightBtn";
            this.bookFlightBtn.Size = new System.Drawing.Size(156, 36);
            this.bookFlightBtn.TabIndex = 1;
            this.bookFlightBtn.Text = "Book A Flight";
            this.bookFlightBtn.UseVisualStyleBackColor = true;
            this.bookFlightBtn.Click += new System.EventHandler(this.bookFlightBtn_Click);
            // 
            // adminScreenBtn
            // 
            this.adminScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminScreenBtn.Location = new System.Drawing.Point(361, 155);
            this.adminScreenBtn.Name = "adminScreenBtn";
            this.adminScreenBtn.Size = new System.Drawing.Size(156, 36);
            this.adminScreenBtn.TabIndex = 2;
            this.adminScreenBtn.Text = "Admin Screen";
            this.adminScreenBtn.UseVisualStyleBackColor = true;
            this.adminScreenBtn.Click += new System.EventHandler(this.adminScreenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 221);
            this.Controls.Add(this.adminScreenBtn);
            this.Controls.Add(this.bookFlightBtn);
            this.Controls.Add(this.cyanairTitle);
            this.Name = "Form1";
            this.Text = "Cyanair - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cyanairTitle;
        private System.Windows.Forms.Button bookFlightBtn;
        private System.Windows.Forms.Button adminScreenBtn;
    }
}

