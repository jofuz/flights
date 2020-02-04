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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsDataSet = new flights.flightsDataSet();
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTableAdapter = new flights.flightsDataSetTableAdapters.ScheduleTableAdapter();
            this.exitBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.flightNoDataGridViewTextBoxColumn,
            this.departingDataGridViewTextBoxColumn,
            this.arrivingDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.economyDataGridViewTextBoxColumn,
            this.businessDataGridViewTextBoxColumn,
            this.firstDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            // 
            // departingDataGridViewTextBoxColumn
            // 
            this.departingDataGridViewTextBoxColumn.DataPropertyName = "Departing";
            this.departingDataGridViewTextBoxColumn.HeaderText = "Departing";
            this.departingDataGridViewTextBoxColumn.Name = "departingDataGridViewTextBoxColumn";
            // 
            // arrivingDataGridViewTextBoxColumn
            // 
            this.arrivingDataGridViewTextBoxColumn.DataPropertyName = "Arriving";
            this.arrivingDataGridViewTextBoxColumn.HeaderText = "Arriving";
            this.arrivingDataGridViewTextBoxColumn.Name = "arrivingDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // economyDataGridViewTextBoxColumn
            // 
            this.economyDataGridViewTextBoxColumn.DataPropertyName = "Economy";
            this.economyDataGridViewTextBoxColumn.HeaderText = "Economy";
            this.economyDataGridViewTextBoxColumn.Name = "economyDataGridViewTextBoxColumn";
            // 
            // businessDataGridViewTextBoxColumn
            // 
            this.businessDataGridViewTextBoxColumn.DataPropertyName = "Business";
            this.businessDataGridViewTextBoxColumn.HeaderText = "Business";
            this.businessDataGridViewTextBoxColumn.Name = "businessDataGridViewTextBoxColumn";
            // 
            // firstDataGridViewTextBoxColumn
            // 
            this.firstDataGridViewTextBoxColumn.DataPropertyName = "First";
            this.firstDataGridViewTextBoxColumn.HeaderText = "First";
            this.firstDataGridViewTextBoxColumn.Name = "firstDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(524, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cyanair";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(478, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modifying the flight schedule";
            this.label2.UseWaitCursor = true;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveChangesBtn.Location = new System.Drawing.Point(995, 505);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(130, 30);
            this.saveChangesBtn.TabIndex = 3;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.UseWaitCursor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(313, 505);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.UseWaitCursor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // flightNoBox
            // 
            this.flightNoBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "FlightNo", true));
            this.flightNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flightNoBox.Location = new System.Drawing.Point(48, 442);
            this.flightNoBox.Margin = new System.Windows.Forms.Padding(2);
            this.flightNoBox.Name = "flightNoBox";
            this.flightNoBox.Size = new System.Drawing.Size(76, 26);
            this.flightNoBox.TabIndex = 5;
            this.flightNoBox.UseWaitCursor = true;
            // 
            // flightNoLabel
            // 
            this.flightNoLabel.AutoSize = true;
            this.flightNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flightNoLabel.Location = new System.Drawing.Point(48, 423);
            this.flightNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flightNoLabel.Name = "flightNoLabel";
            this.flightNoLabel.Size = new System.Drawing.Size(85, 15);
            this.flightNoLabel.TabIndex = 6;
            this.flightNoLabel.Text = "Flight Number";
            this.flightNoLabel.UseWaitCursor = true;
            // 
            // departingLabel
            // 
            this.departingLabel.AutoSize = true;
            this.departingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.departingLabel.Location = new System.Drawing.Point(139, 423);
            this.departingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departingLabel.Name = "departingLabel";
            this.departingLabel.Size = new System.Drawing.Size(61, 15);
            this.departingLabel.TabIndex = 8;
            this.departingLabel.Text = "Departing";
            this.departingLabel.UseWaitCursor = true;
            // 
            // departingBox
            // 
            this.departingBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Departing", true));
            this.departingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departingBox.Location = new System.Drawing.Point(131, 442);
            this.departingBox.Margin = new System.Windows.Forms.Padding(2);
            this.departingBox.Name = "departingBox";
            this.departingBox.Size = new System.Drawing.Size(70, 26);
            this.departingBox.TabIndex = 7;
            this.departingBox.UseWaitCursor = true;
            // 
            // arrivingLabel
            // 
            this.arrivingLabel.AutoSize = true;
            this.arrivingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.arrivingLabel.Location = new System.Drawing.Point(221, 423);
            this.arrivingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivingLabel.Name = "arrivingLabel";
            this.arrivingLabel.Size = new System.Drawing.Size(47, 15);
            this.arrivingLabel.TabIndex = 10;
            this.arrivingLabel.Text = "Arriving";
            this.arrivingLabel.UseWaitCursor = true;
            // 
            // arrivingBox
            // 
            this.arrivingBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Arriving", true));
            this.arrivingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.arrivingBox.Location = new System.Drawing.Point(210, 442);
            this.arrivingBox.Margin = new System.Windows.Forms.Padding(2);
            this.arrivingBox.Name = "arrivingBox";
            this.arrivingBox.Size = new System.Drawing.Size(65, 26);
            this.arrivingBox.TabIndex = 9;
            this.arrivingBox.UseWaitCursor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateLabel.Location = new System.Drawing.Point(312, 423);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 15);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date";
            this.dateLabel.UseWaitCursor = true;
            // 
            // dateBox
            // 
            this.dateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Date", true));
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateBox.Location = new System.Drawing.Point(284, 442);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(92, 26);
            this.dateBox.TabIndex = 11;
            this.dateBox.UseWaitCursor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timeLabel.Location = new System.Drawing.Point(396, 423);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 15);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Time";
            this.timeLabel.UseWaitCursor = true;
            // 
            // timeBox
            // 
            this.timeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "t"));
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeBox.Location = new System.Drawing.Point(386, 442);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(58, 26);
            this.timeBox.TabIndex = 13;
            this.timeBox.UseWaitCursor = true;
            // 
            // economyLabel
            // 
            this.economyLabel.AutoSize = true;
            this.economyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.economyLabel.Location = new System.Drawing.Point(833, 423);
            this.economyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.economyLabel.Name = "economyLabel";
            this.economyLabel.Size = new System.Drawing.Size(58, 15);
            this.economyLabel.TabIndex = 16;
            this.economyLabel.Text = "Economy";
            this.economyLabel.UseWaitCursor = true;
            // 
            // economyBox
            // 
            this.economyBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Economy", true));
            this.economyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.economyBox.Location = new System.Drawing.Point(831, 442);
            this.economyBox.Margin = new System.Windows.Forms.Padding(2);
            this.economyBox.Name = "economyBox";
            this.economyBox.Size = new System.Drawing.Size(58, 26);
            this.economyBox.TabIndex = 15;
            this.economyBox.UseWaitCursor = true;
            // 
            // seatsGroup
            // 
            this.seatsGroup.Location = new System.Drawing.Point(820, 402);
            this.seatsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.seatsGroup.Name = "seatsGroup";
            this.seatsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.seatsGroup.Size = new System.Drawing.Size(210, 84);
            this.seatsGroup.TabIndex = 17;
            this.seatsGroup.TabStop = false;
            this.seatsGroup.Text = "Seats";
            this.seatsGroup.UseWaitCursor = true;
            this.seatsGroup.Visible = false;
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.businessLabel.Location = new System.Drawing.Point(896, 423);
            this.businessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(57, 15);
            this.businessLabel.TabIndex = 19;
            this.businessLabel.Text = "Business";
            this.businessLabel.UseWaitCursor = true;
            // 
            // businessBox
            // 
            this.businessBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Business", true));
            this.businessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.businessBox.Location = new System.Drawing.Point(895, 442);
            this.businessBox.Margin = new System.Windows.Forms.Padding(2);
            this.businessBox.Name = "businessBox";
            this.businessBox.Size = new System.Drawing.Size(58, 26);
            this.businessBox.TabIndex = 18;
            this.businessBox.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(971, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "First";
            this.label3.UseWaitCursor = true;
            // 
            // firstSeatBox
            // 
            this.firstSeatBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "First", true));
            this.firstSeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstSeatBox.Location = new System.Drawing.Point(960, 442);
            this.firstSeatBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstSeatBox.Name = "firstSeatBox";
            this.firstSeatBox.Size = new System.Drawing.Size(58, 26);
            this.firstSeatBox.TabIndex = 20;
            this.firstSeatBox.UseWaitCursor = true;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.durationLabel.Location = new System.Drawing.Point(1067, 423);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(54, 15);
            this.durationLabel.TabIndex = 23;
            this.durationLabel.Text = "Duration";
            this.durationLabel.UseWaitCursor = true;
            // 
            // durationBox
            // 
            this.durationBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Duration", true));
            this.durationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durationBox.Location = new System.Drawing.Point(1062, 442);
            this.durationBox.Margin = new System.Windows.Forms.Padding(2);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(58, 26);
            this.durationBox.TabIndex = 22;
            this.durationBox.UseWaitCursor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.scheduleBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1162, 36);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.UseWaitCursor = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.LightGreen;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(79, 33);
            this.bindingNavigatorAddNewItem.Text = "Add New";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.Salmon;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(48, 505);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 30);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.UseWaitCursor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitAppBtn.FlatAppearance.BorderSize = 4;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitAppBtn.Location = new System.Drawing.Point(0, 60);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(115, 29);
            this.exitAppBtn.TabIndex = 27;
            this.exitAppBtn.Text = "Exit Application";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.UseWaitCursor = true;
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
            this.helpBtn.Location = new System.Drawing.Point(1047, 60);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(115, 29);
            this.helpBtn.TabIndex = 29;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.UseWaitCursor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // adminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 558);
            this.ControlBox = false;
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.bindingNavigator1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair - Admin Screen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private flightsDataSet flightsDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private flightsDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}