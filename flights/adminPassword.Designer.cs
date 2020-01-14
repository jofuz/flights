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
            this.confirmPasswordBtn.Location = new System.Drawing.Point(372, 162);
            this.confirmPasswordBtn.Name = "confirmPasswordBtn";
            this.confirmPasswordBtn.Size = new System.Drawing.Size(123, 37);
            this.confirmPasswordBtn.TabIndex = 0;
            this.confirmPasswordBtn.Text = "Continue";
            this.confirmPasswordBtn.UseVisualStyleBackColor = true;
            this.confirmPasswordBtn.Click += new System.EventHandler(this.confirmPasswordBtn_Click);
            // 
            // adminPasswordBox
            // 
            this.adminPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminPasswordBox.Location = new System.Drawing.Point(41, 165);
            this.adminPasswordBox.Name = "adminPasswordBox";
            this.adminPasswordBox.PasswordChar = '*';
            this.adminPasswordBox.Size = new System.Drawing.Size(244, 30);
            this.adminPasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(195, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cyanair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(101, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the admin password to continue";
            // 
            // returnToHomeBtn
            // 
            this.returnToHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnToHomeBtn.Location = new System.Drawing.Point(12, 255);
            this.returnToHomeBtn.Name = "returnToHomeBtn";
            this.returnToHomeBtn.Size = new System.Drawing.Size(116, 37);
            this.returnToHomeBtn.TabIndex = 4;
            this.returnToHomeBtn.Text = "Back";
            this.returnToHomeBtn.UseVisualStyleBackColor = true;
            // 
            // wrongPasswordNote
            // 
            this.wrongPasswordNote.AutoSize = true;
            this.wrongPasswordNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wrongPasswordNote.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordNote.Location = new System.Drawing.Point(36, 214);
            this.wrongPasswordNote.Name = "wrongPasswordNote";
            this.wrongPasswordNote.Size = new System.Drawing.Size(0, 25);
            this.wrongPasswordNote.TabIndex = 5;
            // 
            // adminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 304);
            this.Controls.Add(this.wrongPasswordNote);
            this.Controls.Add(this.returnToHomeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminPasswordBox);
            this.Controls.Add(this.confirmPasswordBtn);
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