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
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cyanairTitle
            // 
            this.cyanairTitle.AutoSize = true;
            this.cyanairTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cyanairTitle.Location = new System.Drawing.Point(165, 41);
            this.cyanairTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cyanairTitle.Name = "cyanairTitle";
            this.cyanairTitle.Size = new System.Drawing.Size(108, 31);
            this.cyanairTitle.TabIndex = 0;
            this.cyanairTitle.Text = "Cyanair";
            this.cyanairTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookFlightBtn
            // 
            this.bookFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookFlightBtn.Location = new System.Drawing.Point(24, 126);
            this.bookFlightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookFlightBtn.Name = "bookFlightBtn";
            this.bookFlightBtn.Size = new System.Drawing.Size(117, 29);
            this.bookFlightBtn.TabIndex = 1;
            this.bookFlightBtn.Text = "Book A Flight";
            this.bookFlightBtn.UseVisualStyleBackColor = true;
            this.bookFlightBtn.Click += new System.EventHandler(this.bookFlightBtn_Click);
            // 
            // adminScreenBtn
            // 
            this.adminScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminScreenBtn.Location = new System.Drawing.Point(271, 126);
            this.adminScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.adminScreenBtn.Name = "adminScreenBtn";
            this.adminScreenBtn.Size = new System.Drawing.Size(117, 29);
            this.adminScreenBtn.TabIndex = 2;
            this.adminScreenBtn.Text = "Admin Screen";
            this.adminScreenBtn.UseVisualStyleBackColor = true;
            this.adminScreenBtn.Click += new System.EventHandler(this.adminScreenBtn_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderSize = 4;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitAppBtn.Location = new System.Drawing.Point(0, 0);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(115, 29);
            this.exitAppBtn.TabIndex = 27;
            this.exitAppBtn.Text = "Exit Application";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Yellow;
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.helpBtn.FlatAppearance.BorderSize = 4;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.helpBtn.Location = new System.Drawing.Point(295, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(115, 29);
            this.helpBtn.TabIndex = 28;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 180);
            this.ControlBox = false;
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.adminScreenBtn);
            this.Controls.Add(this.bookFlightBtn);
            this.Controls.Add(this.cyanairTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cyanairTitle;
        private System.Windows.Forms.Button bookFlightBtn;
        private System.Windows.Forms.Button adminScreenBtn;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}

