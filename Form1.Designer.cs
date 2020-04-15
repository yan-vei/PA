namespace PA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flightsInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBox2 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.flightsBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.MonthCalendar();
            this.booking = new System.Windows.Forms.Button();
            this.checkSeatButton = new System.Windows.Forms.Button();
            this.seatBox = new System.Windows.Forms.ComboBox();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.twoWayButton = new System.Windows.Forms.RadioButton();
            this.oneWayButton = new System.Windows.Forms.RadioButton();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.passBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.flightChange = new System.Windows.Forms.Button();
            this.mealProvidedBox = new System.Windows.Forms.TextBox();
            this.numOfRowsBox = new System.Windows.Forms.TextBox();
            this.airplaneBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.stopoverBox = new System.Windows.Forms.TextBox();
            this.destPortBox = new System.Windows.Forms.TextBox();
            this.takeOffPortBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flightIDBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flightOptList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flightDateBox = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.allFlightsInfo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flightsInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flightsInfo
            // 
            this.flightsInfo.Controls.Add(this.tabPage1);
            this.flightsInfo.Controls.Add(this.tabPage2);
            this.flightsInfo.Controls.Add(this.tabPage3);
            this.flightsInfo.Controls.Add(this.tabPage4);
            this.flightsInfo.Location = new System.Drawing.Point(-2, 1);
            this.flightsInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flightsInfo.Name = "flightsInfo";
            this.flightsInfo.SelectedIndex = 0;
            this.flightsInfo.Size = new System.Drawing.Size(899, 740);
            this.flightsInfo.TabIndex = 4;
            this.flightsInfo.Click += new System.EventHandler(this.flightsInfo_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.flightsBox);
            this.tabPage1.Controls.Add(this.dateBox);
            this.tabPage1.Controls.Add(this.booking);
            this.tabPage1.Controls.Add(this.checkSeatButton);
            this.tabPage1.Controls.Add(this.seatBox);
            this.tabPage1.Controls.Add(this.SeatLabel);
            this.tabPage1.Controls.Add(this.rowBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.twoWayButton);
            this.tabPage1.Controls.Add(this.oneWayButton);
            this.tabPage1.Controls.Add(this.lnameBox);
            this.tabPage1.Controls.Add(this.fnameBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(891, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Booking";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.SteelBlue;
            this.label22.Location = new System.Drawing.Point(757, 675);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "About program";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.AliceBlue;
            this.label21.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(574, 261);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 28);
            this.label21.TabIndex = 17;
            this.label21.Text = "Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "There";
            // 
            // dateBox2
            // 
            this.dateBox2.Enabled = false;
            this.dateBox2.Location = new System.Drawing.Point(636, 300);
            this.dateBox2.Margin = new System.Windows.Forms.Padding(11);
            this.dateBox2.MaxSelectionCount = 1;
            this.dateBox2.Name = "dateBox2";
            this.dateBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Available flights";
            // 
            // flightsBox
            // 
            this.flightsBox.BackColor = System.Drawing.SystemColors.Menu;
            this.flightsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightsBox.FormattingEnabled = true;
            this.flightsBox.Location = new System.Drawing.Point(324, 78);
            this.flightsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flightsBox.Name = "flightsBox";
            this.flightsBox.Size = new System.Drawing.Size(216, 28);
            this.flightsBox.TabIndex = 14;
            this.flightsBox.Click += new System.EventHandler(this.flights_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(636, 43);
            this.dateBox.Margin = new System.Windows.Forms.Padding(11);
            this.dateBox.MaxSelectionCount = 1;
            this.dateBox.Name = "dateBox";
            this.dateBox.TabIndex = 13;
            // 
            // booking
            // 
            this.booking.BackColor = System.Drawing.Color.AliceBlue;
            this.booking.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking.Location = new System.Drawing.Point(153, 619);
            this.booking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(558, 53);
            this.booking.TabIndex = 12;
            this.booking.Text = "Book";
            this.booking.UseVisualStyleBackColor = false;
            this.booking.Click += new System.EventHandler(this.booking_Click);
            // 
            // checkSeatButton
            // 
            this.checkSeatButton.BackColor = System.Drawing.Color.AliceBlue;
            this.checkSeatButton.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSeatButton.Location = new System.Drawing.Point(579, 526);
            this.checkSeatButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSeatButton.Name = "checkSeatButton";
            this.checkSeatButton.Size = new System.Drawing.Size(209, 52);
            this.checkSeatButton.TabIndex = 11;
            this.checkSeatButton.Text = "Check Seat";
            this.checkSeatButton.UseVisualStyleBackColor = false;
            this.checkSeatButton.Click += new System.EventHandler(this.checkSeatButton_Click);
            // 
            // seatBox
            // 
            this.seatBox.BackColor = System.Drawing.SystemColors.Menu;
            this.seatBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seatBox.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatBox.FormattingEnabled = true;
            this.seatBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seatBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.seatBox.Location = new System.Drawing.Point(367, 458);
            this.seatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seatBox.Name = "seatBox";
            this.seatBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seatBox.Size = new System.Drawing.Size(175, 31);
            this.seatBox.Sorted = true;
            this.seatBox.TabIndex = 10;
            this.seatBox.Text = "Choose Seat";
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.SeatLabel.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.Location = new System.Drawing.Point(401, 419);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(53, 28);
            this.SeatLabel.TabIndex = 9;
            this.SeatLabel.Text = "Seat";
            // 
            // rowBox
            // 
            this.rowBox.BackColor = System.Drawing.SystemColors.Menu;
            this.rowBox.DropDownHeight = 120;
            this.rowBox.DropDownWidth = 150;
            this.rowBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rowBox.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowBox.FormattingEnabled = true;
            this.rowBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rowBox.IntegralHeight = false;
            this.rowBox.ItemHeight = 23;
            this.rowBox.Location = new System.Drawing.Point(112, 458);
            this.rowBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rowBox.MaxDropDownItems = 25;
            this.rowBox.Name = "rowBox";
            this.rowBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rowBox.Size = new System.Drawing.Size(183, 31);
            this.rowBox.TabIndex = 8;
            this.rowBox.Text = "Choose Row";
            this.rowBox.Click += new System.EventHandler(this.rowBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seating";
            // 
            // twoWayButton
            // 
            this.twoWayButton.AutoSize = true;
            this.twoWayButton.BackColor = System.Drawing.Color.AliceBlue;
            this.twoWayButton.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoWayButton.Location = new System.Drawing.Point(99, 104);
            this.twoWayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.twoWayButton.Name = "twoWayButton";
            this.twoWayButton.Size = new System.Drawing.Size(125, 32);
            this.twoWayButton.TabIndex = 5;
            this.twoWayButton.Text = "Two-way";
            this.twoWayButton.UseVisualStyleBackColor = false;
            this.twoWayButton.CheckedChanged += new System.EventHandler(this.twoWayButton_CheckedChanged);
            // 
            // oneWayButton
            // 
            this.oneWayButton.AutoSize = true;
            this.oneWayButton.BackColor = System.Drawing.Color.AliceBlue;
            this.oneWayButton.Checked = true;
            this.oneWayButton.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneWayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oneWayButton.Location = new System.Drawing.Point(99, 28);
            this.oneWayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oneWayButton.Name = "oneWayButton";
            this.oneWayButton.Size = new System.Drawing.Size(120, 32);
            this.oneWayButton.TabIndex = 4;
            this.oneWayButton.TabStop = true;
            this.oneWayButton.Text = "One-way";
            this.oneWayButton.UseVisualStyleBackColor = false;
            // 
            // lnameBox
            // 
            this.lnameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lnameBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnameBox.Location = new System.Drawing.Point(250, 272);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnameBox.MaxLength = 50;
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(193, 27);
            this.lnameBox.TabIndex = 3;
            this.lnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.lnameBox_Validating);
            // 
            // fnameBox
            // 
            this.fnameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fnameBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fnameBox.Location = new System.Drawing.Point(250, 209);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnameBox.MaxLength = 50;
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(193, 27);
            this.fnameBox.TabIndex = 2;
            this.fnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.fnameBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.passBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(891, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tickets";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.SystemColors.Menu;
            this.passBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passBox.FormattingEnabled = true;
            this.passBox.Location = new System.Drawing.Point(101, 120);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(192, 28);
            this.passBox.TabIndex = 1;
            this.passBox.SelectedValueChanged += new System.EventHandler(this.passBox_SelectedValueChanged);
            this.passBox.Click += new System.EventHandler(this.passBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Check passenger";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.flightChange);
            this.tabPage3.Controls.Add(this.mealProvidedBox);
            this.tabPage3.Controls.Add(this.numOfRowsBox);
            this.tabPage3.Controls.Add(this.airplaneBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.stopoverBox);
            this.tabPage3.Controls.Add(this.destPortBox);
            this.tabPage3.Controls.Add(this.takeOffPortBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.flightIDBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.flightOptList);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.flightDateBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(891, 707);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Flights";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.AliceBlue;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(116, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Meal provided";
            // 
            // flightChange
            // 
            this.flightChange.BackColor = System.Drawing.Color.AliceBlue;
            this.flightChange.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightChange.Location = new System.Drawing.Point(168, 519);
            this.flightChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flightChange.Name = "flightChange";
            this.flightChange.Size = new System.Drawing.Size(229, 51);
            this.flightChange.TabIndex = 19;
            this.flightChange.Text = "Save changes";
            this.flightChange.UseVisualStyleBackColor = false;
            this.flightChange.Click += new System.EventHandler(this.flightChange_Click);
            // 
            // mealProvidedBox
            // 
            this.mealProvidedBox.Location = new System.Drawing.Point(312, 451);
            this.mealProvidedBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mealProvidedBox.Name = "mealProvidedBox";
            this.mealProvidedBox.Size = new System.Drawing.Size(160, 27);
            this.mealProvidedBox.TabIndex = 18;
            // 
            // numOfRowsBox
            // 
            this.numOfRowsBox.Location = new System.Drawing.Point(312, 409);
            this.numOfRowsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOfRowsBox.Name = "numOfRowsBox";
            this.numOfRowsBox.Size = new System.Drawing.Size(160, 27);
            this.numOfRowsBox.TabIndex = 17;
            // 
            // airplaneBox
            // 
            this.airplaneBox.Location = new System.Drawing.Point(312, 368);
            this.airplaneBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.airplaneBox.Name = "airplaneBox";
            this.airplaneBox.Size = new System.Drawing.Size(160, 27);
            this.airplaneBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.AliceBlue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(116, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Number of rows";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 14;
            // 
            // stopoverBox
            // 
            this.stopoverBox.Location = new System.Drawing.Point(312, 327);
            this.stopoverBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopoverBox.Name = "stopoverBox";
            this.stopoverBox.Size = new System.Drawing.Size(160, 27);
            this.stopoverBox.TabIndex = 13;
            // 
            // destPortBox
            // 
            this.destPortBox.Location = new System.Drawing.Point(312, 288);
            this.destPortBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destPortBox.Name = "destPortBox";
            this.destPortBox.Size = new System.Drawing.Size(160, 27);
            this.destPortBox.TabIndex = 12;
            // 
            // takeOffPortBox
            // 
            this.takeOffPortBox.Location = new System.Drawing.Point(312, 251);
            this.takeOffPortBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.takeOffPortBox.Name = "takeOffPortBox";
            this.takeOffPortBox.Size = new System.Drawing.Size(160, 27);
            this.takeOffPortBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "Landing airport";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Stopover";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(116, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Airplane";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Take-off airport";
            // 
            // flightIDBox
            // 
            this.flightIDBox.Location = new System.Drawing.Point(312, 209);
            this.flightIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flightIDBox.Name = "flightIDBox";
            this.flightIDBox.Size = new System.Drawing.Size(160, 27);
            this.flightIDBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Flight ID";
            // 
            // flightOptList
            // 
            this.flightOptList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.flightOptList.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightOptList.FormattingEnabled = true;
            this.flightOptList.ItemHeight = 23;
            this.flightOptList.Items.AddRange(new object[] {
            "Create",
            "Edit",
            "Delete"});
            this.flightOptList.Location = new System.Drawing.Point(38, 40);
            this.flightOptList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flightOptList.Name = "flightOptList";
            this.flightOptList.Size = new System.Drawing.Size(148, 96);
            this.flightOptList.TabIndex = 4;
            this.flightOptList.SelectedIndexChanged += new System.EventHandler(this.flightOptList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Take-off date";
            // 
            // flightDateBox
            // 
            this.flightDateBox.Location = new System.Drawing.Point(592, 209);
            this.flightDateBox.Margin = new System.Windows.Forms.Padding(11);
            this.flightDateBox.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.flightDateBox.MaxSelectionCount = 1;
            this.flightDateBox.Name = "flightDateBox";
            this.flightDateBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage4.Controls.Add(this.allFlightsInfo);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(891, 707);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Schedule";
            // 
            // allFlightsInfo
            // 
            this.allFlightsInfo.AllowDrop = true;
            this.allFlightsInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.allFlightsInfo.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFlightsInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allFlightsInfo.Location = new System.Drawing.Point(12, 74);
            this.allFlightsInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allFlightsInfo.Multiline = true;
            this.allFlightsInfo.Name = "allFlightsInfo";
            this.allFlightsInfo.ReadOnly = true;
            this.allFlightsInfo.ShortcutsEnabled = false;
            this.allFlightsInfo.Size = new System.Drawing.Size(862, 613);
            this.allFlightsInfo.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.AliceBlue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(91, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 25);
            this.label20.TabIndex = 9;
            this.label20.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.AliceBlue;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(512, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "To";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.AliceBlue;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(297, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "From";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(704, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 25);
            this.label17.TabIndex = 6;
            this.label17.Text = "Flight";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 736);
            this.Controls.Add(this.flightsInfo);
            this.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline\'s Reservation System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.flightsInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl flightsInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton twoWayButton;
        private System.Windows.Forms.RadioButton oneWayButton;
        private System.Windows.Forms.ComboBox rowBox;
        private System.Windows.Forms.ComboBox seatBox;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.MonthCalendar dateBox;
        private System.Windows.Forms.Button booking;
        private System.Windows.Forms.Button checkSeatButton;
        private System.Windows.Forms.ComboBox passBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox flightOptList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar flightDateBox;
        private System.Windows.Forms.TextBox numOfRowsBox;
        private System.Windows.Forms.TextBox airplaneBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox stopoverBox;
        private System.Windows.Forms.TextBox destPortBox;
        private System.Windows.Forms.TextBox takeOffPortBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flightIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button flightChange;
        private System.Windows.Forms.TextBox mealProvidedBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox flightsBox;
        private System.Windows.Forms.Label label16;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox allFlightsInfo;
        private System.Windows.Forms.MonthCalendar dateBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
    }
}

