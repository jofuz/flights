namespace flights
{
    partial class bookFlight
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
            this.components = new System.ComponentModel.Container();
            this.pageDescription = new System.Windows.Forms.Label();
            this.cyanAirTitle = new System.Windows.Forms.Label();
            this.departingLabel = new System.Windows.Forms.Label();
            this.arrivingLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.departingMenu = new System.Windows.Forms.ComboBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsDataSet = new flights.flightsDataSet();
            this.arrivingMenu = new System.Windows.Forms.ComboBox();
            this.seatMenu = new System.Windows.Forms.ComboBox();
            this.timeMenu = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateMenu = new System.Windows.Forms.ComboBox();
            this.scheduleTableAdapter = new flights.flightsDataSetTableAdapters.ScheduleTableAdapter();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.flightNoComboBox = new System.Windows.Forms.ComboBox();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pageDescription
            // 
            this.pageDescription.AutoSize = true;
            this.pageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pageDescription.Location = new System.Drawing.Point(177, 59);
            this.pageDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageDescription.Name = "pageDescription";
            this.pageDescription.Size = new System.Drawing.Size(104, 20);
            this.pageDescription.TabIndex = 4;
            this.pageDescription.Text = "Book A Flight";
            // 
            // cyanAirTitle
            // 
            this.cyanAirTitle.AutoSize = true;
            this.cyanAirTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cyanAirTitle.Location = new System.Drawing.Point(173, 9);
            this.cyanAirTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cyanAirTitle.Name = "cyanAirTitle";
            this.cyanAirTitle.Size = new System.Drawing.Size(108, 31);
            this.cyanAirTitle.TabIndex = 3;
            this.cyanAirTitle.Text = "Cyanair";
            // 
            // departingLabel
            // 
            this.departingLabel.AutoSize = true;
            this.departingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departingLabel.Location = new System.Drawing.Point(85, 135);
            this.departingLabel.Name = "departingLabel";
            this.departingLabel.Size = new System.Drawing.Size(79, 20);
            this.departingLabel.TabIndex = 5;
            this.departingLabel.Text = "Departing";
            // 
            // arrivingLabel
            // 
            this.arrivingLabel.AutoSize = true;
            this.arrivingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.arrivingLabel.Location = new System.Drawing.Point(306, 135);
            this.arrivingLabel.Name = "arrivingLabel";
            this.arrivingLabel.Size = new System.Drawing.Size(61, 20);
            this.arrivingLabel.TabIndex = 6;
            this.arrivingLabel.Text = "Arriving";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateLabel.Location = new System.Drawing.Point(106, 231);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatLabel.Location = new System.Drawing.Point(82, 321);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(86, 20);
            this.seatLabel.TabIndex = 8;
            this.seatLabel.Text = "Seat Class";
            // 
            // departingMenu
            // 
            this.departingMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departingMenu.FormattingEnabled = true;
            this.departingMenu.Location = new System.Drawing.Point(38, 159);
            this.departingMenu.Name = "departingMenu";
            this.departingMenu.Size = new System.Drawing.Size(184, 28);
            this.departingMenu.TabIndex = 0;
            this.departingMenu.SelectedIndexChanged += new System.EventHandler(this.departingMenu_SelectedIndexChanged);
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.flightsDataSet;
            // 
            // flightsDataSet
            // 
            this.flightsDataSet.DataSetName = "flightsDataSet";
            this.flightsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arrivingMenu
            // 
            this.arrivingMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.arrivingMenu.FormattingEnabled = true;
            this.arrivingMenu.Location = new System.Drawing.Point(242, 159);
            this.arrivingMenu.Name = "arrivingMenu";
            this.arrivingMenu.Size = new System.Drawing.Size(188, 28);
            this.arrivingMenu.TabIndex = 1;
            this.arrivingMenu.SelectedIndexChanged += new System.EventHandler(this.arrivingMenu_SelectedIndexChanged);
            // 
            // seatMenu
            // 
            this.seatMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatMenu.FormattingEnabled = true;
            this.seatMenu.Location = new System.Drawing.Point(38, 344);
            this.seatMenu.Name = "seatMenu";
            this.seatMenu.Size = new System.Drawing.Size(184, 28);
            this.seatMenu.TabIndex = 4;
            // 
            // timeMenu
            // 
            this.timeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeMenu.FormatString = "t";
            this.timeMenu.FormattingEnabled = true;
            this.timeMenu.Location = new System.Drawing.Point(246, 254);
            this.timeMenu.Name = "timeMenu";
            this.timeMenu.Size = new System.Drawing.Size(184, 28);
            this.timeMenu.TabIndex = 3;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeLabel.Location = new System.Drawing.Point(315, 231);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 20);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Time";
            // 
            // dateMenu
            // 
            this.dateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateMenu.FormattingEnabled = true;
            this.dateMenu.Location = new System.Drawing.Point(38, 254);
            this.dateMenu.Name = "dateMenu";
            this.dateMenu.Size = new System.Drawing.Size(184, 28);
            this.dateMenu.TabIndex = 2;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.continueBtn.Location = new System.Drawing.Point(340, 424);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(90, 34);
            this.continueBtn.TabIndex = 15;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(38, 424);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 34);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // idComboBox
            // 
            this.idComboBox.Enabled = false;
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(38, 19);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(0, 21);
            this.idComboBox.TabIndex = 17;
            this.idComboBox.TabStop = false;
            // 
            // flightNoComboBox
            // 
            this.flightNoComboBox.Enabled = false;
            this.flightNoComboBox.FormattingEnabled = true;
            this.flightNoComboBox.Location = new System.Drawing.Point(38, 58);
            this.flightNoComboBox.Name = "flightNoComboBox";
            this.flightNoComboBox.Size = new System.Drawing.Size(0, 21);
            this.flightNoComboBox.TabIndex = 18;
            this.flightNoComboBox.TabStop = false;
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderSize = 4;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitAppBtn.Location = new System.Drawing.Point(1, 1);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(115, 29);
            this.exitAppBtn.TabIndex = 28;
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
            this.helpBtn.Location = new System.Drawing.Point(350, 1);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(115, 29);
            this.helpBtn.TabIndex = 29;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // bookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 487);
            this.ControlBox = false;
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.flightNoComboBox);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.dateMenu);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeMenu);
            this.Controls.Add(this.seatMenu);
            this.Controls.Add(this.arrivingMenu);
            this.Controls.Add(this.departingMenu);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.arrivingLabel);
            this.Controls.Add(this.departingLabel);
            this.Controls.Add(this.pageDescription);
            this.Controls.Add(this.cyanAirTitle);
            this.Name = "bookFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair - Book A Flight";
            this.Load += new System.EventHandler(this.bookFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageDescription;
        private System.Windows.Forms.Label cyanAirTitle;
        private System.Windows.Forms.Label departingLabel;
        private System.Windows.Forms.Label arrivingLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.ComboBox departingMenu;
        private System.Windows.Forms.ComboBox arrivingMenu;
        private System.Windows.Forms.ComboBox seatMenu;
        private System.Windows.Forms.ComboBox timeMenu;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox dateMenu;
        private flightsDataSet flightsDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private flightsDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.ComboBox flightNoComboBox;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}