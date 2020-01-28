namespace flights
{
    partial class adminPassword
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
            this.confirmPasswordBtn = new System.Windows.Forms.Button();
            this.adminPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnToHomeBtn = new System.Windows.Forms.Button();
            this.wrongPasswordNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmPasswordBtn
            // 
            this.confirmPasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmPasswordBtn.Location = new System.Drawing.Point(279, 132);
            this.confirmPasswordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordBtn.Name = "confirmPasswordBtn";
            this.confirmPasswordBtn.Size = new System.Drawing.Size(92, 30);
            this.confirmPasswordBtn.TabIndex = 0;
            this.confirmPasswordBtn.Text = "Continue";
            this.confirmPasswordBtn.UseVisualStyleBackColor = true;
            this.confirmPasswordBtn.Click += new System.EventHandler(this.confirmPasswordBtn_Click);
            // 
            // adminPasswordBox
            // 
            this.adminPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminPasswordBox.Location = new System.Drawing.Point(31, 134);
            this.adminPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminPasswordBox.Name = "adminPasswordBox";
            this.adminPasswordBox.PasswordChar = '*';
            this.adminPasswordBox.Size = new System.Drawing.Size(184, 26);
            this.adminPasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(146, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cyanair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(76, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the admin password to continue";
            // 
            // returnToHomeBtn
            // 
            this.returnToHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnToHomeBtn.Location = new System.Drawing.Point(9, 207);
            this.returnToHomeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnToHomeBtn.Name = "returnToHomeBtn";
            this.returnToHomeBtn.Size = new System.Drawing.Size(87, 30);
            this.returnToHomeBtn.TabIndex = 4;
            this.returnToHomeBtn.Text = "Back";
            this.returnToHomeBtn.UseVisualStyleBackColor = true;
            this.returnToHomeBtn.Click += new System.EventHandler(this.returnToHomeBtn_Click);
            // 
            // wrongPasswordNote
            // 
            this.wrongPasswordNote.AutoSize = true;
            this.wrongPasswordNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wrongPasswordNote.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordNote.Location = new System.Drawing.Point(27, 174);
            this.wrongPasswordNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPasswordNote.Name = "wrongPasswordNote";
            this.wrongPasswordNote.Size = new System.Drawing.Size(0, 20);
            this.wrongPasswordNote.TabIndex = 5;
            // 
            // adminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 247);
            this.Controls.Add(this.wrongPasswordNote);
            this.Controls.Add(this.returnToHomeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminPasswordBox);
            this.Controls.Add(this.confirmPasswordBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminPassword";
            this.Text = "Confirm Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmPasswordBtn;
        private System.Windows.Forms.TextBox adminPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnToHomeBtn;
        private System.Windows.Forms.Label wrongPasswordNote;
    }
}