namespace flights
{
    partial class adminScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flightNoBox = new System.Windows.Forms.TextBox();
            this.flightNoLabel = new System.Windows.Forms.Label();
            this.departingLabel = new System.Windows.Forms.Label();
            this.departingBox = new System.Windows.Forms.TextBox();
            this.arrivingLabel = new System.Windows.Forms.Label();
            this.arrivingBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.economyLabel = new System.Windows.Forms.Label();
            this.economyBox = new System.Windows.Forms.TextBox();
            this.seatsGroup = new System.Windows.Forms.GroupBox();
            this.businessLabel = new System.Windows.Forms.Label();
            this.businessBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstSeatBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.flightsDataSet = new flights.flightsDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new flights.flightsDataSetTableAdapters.ScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cyanair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(427, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modifying the flight schedule";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveChangesBtn.Location = new System.Drawing.Point(853, 621);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(173, 37);
            this.saveChangesBtn.TabIndex = 3;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(52, 621);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 37);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // flightNoBox
            // 
            this.flightNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flightNoBox.Location = new System.Drawing.Point(64, 544);
            this.flightNoBox.Name = "flightNoBox";
            this.flightNoBox.Size = new System.Drawing.Size(100, 30);
            this.flightNoBox.TabIndex = 5;
            // 
            // flightNoLabel
            // 
            this.flightNoLabel.AutoSize = true;
            this.flightNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flightNoLabel.Location = new System.Drawing.Point(64, 521);
            this.flightNoLabel.Name = "flightNoLabel";
            this.flightNoLabel.Size = new System.Drawing.Size(100, 18);
            this.flightNoLabel.TabIndex = 6;
            this.flightNoLabel.Text = "Flight Number";
            // 
            // departingLabel
            // 
            this.departingLabel.AutoSize = true;
            this.departingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.departingLabel.Location = new System.Drawing.Point(185, 521);
            this.departingLabel.Name = "departingLabel";
            this.departingLabel.Size = new System.Drawing.Size(71, 18);
            this.departingLabel.TabIndex = 8;
            this.departingLabel.Text = "Departing";
            // 
            // departingBox
            // 
            this.departingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departingBox.Location = new System.Drawing.Point(175, 544);
            this.departingBox.Name = "departingBox";
            this.departingBox.Size = new System.Drawing.Size(92, 30);
            this.departingBox.TabIndex = 7;
            // 
            // arrivingLabel
            // 
            this.arrivingLabel.AutoSize = true;
            this.arrivingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.arrivingLabel.Location = new System.Drawing.Point(295, 521);
            this.arrivingLabel.Name = "arrivingLabel";
            this.arrivingLabel.Size = new System.Drawing.Size(56, 18);
            this.arrivingLabel.TabIndex = 10;
            this.arrivingLabel.Text = "Arriving";
            // 
            // arrivingBox
            // 
            this.arrivingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.arrivingBox.Location = new System.Drawing.Point(280, 544);
            this.arrivingBox.Name = "arrivingBox";
            this.arrivingBox.Size = new System.Drawing.Size(85, 30);
            this.arrivingBox.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateLabel.Location = new System.Drawing.Point(416, 521);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 18);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date";
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateBox.Location = new System.Drawing.Point(379, 544);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(122, 30);
            this.dateBox.TabIndex = 11;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timeLabel.Location = new System.Drawing.Point(528, 521);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 18);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Time";
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeBox.Location = new System.Drawing.Point(515, 544);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(76, 30);
            this.timeBox.TabIndex = 13;
            // 
            // economyLabel
            // 
            this.economyLabel.AutoSize = true;
            this.economyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.economyLabel.Location = new System.Drawing.Point(638, 521);
            this.economyLabel.Name = "economyLabel";
            this.economyLabel.Size = new System.Drawing.Size(72, 18);
            this.economyLabel.TabIndex = 16;
            this.economyLabel.Text = "Economy";
            // 
            // economyBox
            // 
            this.economyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.economyBox.Location = new System.Drawing.Point(634, 544);
            this.economyBox.Name = "economyBox";
            this.economyBox.Size = new System.Drawing.Size(76, 30);
            this.economyBox.TabIndex = 15;
            // 
            // seatsGroup
            // 
            this.seatsGroup.Location = new System.Drawing.Point(620, 495);
            this.seatsGroup.Name = "seatsGroup";
            this.seatsGroup.Size = new System.Drawing.Size(280, 104);
            this.seatsGroup.TabIndex = 17;
            this.seatsGroup.TabStop = false;
            this.seatsGroup.Text = "Seats";
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.businessLabel.Location = new System.Drawing.Point(721, 521);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(69, 18);
            this.businessLabel.TabIndex = 19;
            this.businessLabel.Text = "Business";
            // 
            // businessBox
            // 
            this.businessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.businessBox.Location = new System.Drawing.Point(720, 544);
            this.businessBox.Name = "businessBox";
            this.businessBox.Size = new System.Drawing.Size(76, 30);
            this.businessBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(821, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "First";
            // 
            // firstSeatBox
            // 
            this.firstSeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstSeatBox.Location = new System.Drawing.Point(807, 544);
            this.firstSeatBox.Name = "firstSeatBox";
            this.firstSeatBox.Size = new System.Drawing.Size(76, 30);
            this.firstSeatBox.TabIndex = 20;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.durationLabel.Location = new System.Drawing.Point(950, 521);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(64, 18);
            this.durationLabel.TabIndex = 23;
            this.durationLabel.Text = "Duration";
            // 
            // durationBox
            // 
            this.durationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durationBox.Location = new System.Drawing.Point(943, 544);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(76, 30);
            this.durationBox.TabIndex = 22;
            // 
            // flightsDataSet
            // 
            this.flightsDataSet.DataSetName = "flightsDataSet";
            this.flightsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.flightsDataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // adminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 687);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstSeatBox);
            this.Controls.Add(this.businessLabel);
            this.Controls.Add(this.businessBox);
            this.Controls.Add(this.economyLabel);
            this.Controls.Add(this.economyBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.arrivingLabel);
            this.Controls.Add(this.arrivingBox);
            this.Controls.Add(this.departingLabel);
            this.Controls.Add(this.departingBox);
            this.Controls.Add(this.flightNoLabel);
            this.Controls.Add(this.flightNoBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seatsGroup);
            this.Name = "adminScreen";
            this.Text = "Cyanair - Admin";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox flightNoBox;
        private System.Windows.Forms.Label flightNoLabel;
        private System.Windows.Forms.Label departingLabel;
        private System.Windows.Forms.TextBox departingBox;
        private System.Windows.Forms.Label arrivingLabel;
        private System.Windows.Forms.TextBox arrivingBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label economyLabel;
        private System.Windows.Forms.TextBox economyBox;
        private System.Windows.Forms.GroupBox seatsGroup;
        private System.Windows.Forms.Label businessLabel;
        private System.Windows.Forms.TextBox businessBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstSeatBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationBox;
        private flightsDataSet flightsDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private flightsDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
    }
}