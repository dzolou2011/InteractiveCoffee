namespace WPC.Forms
{
    partial class FrmAdd
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
            this.label17 = new System.Windows.Forms.Label();
            this.dvDepartments = new System.Windows.Forms.DataGridView();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtMemberSince = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cbMemberType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbOccupation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCivilStatus = new System.Windows.Forms.ComboBox();
            this.tbLandLine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbBarangay = new System.Windows.Forms.TextBox();
            this.tbStreetAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dvMinistries = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMinistryDelete = new System.Windows.Forms.Button();
            this.btnMinistryAdd = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cbMinistries = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnDepartment = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvDepartments)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMinistries)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnDepartment.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Departments";
            // 
            // dvDepartments
            // 
            this.dvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dvDepartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDepartments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDepartments.Location = new System.Drawing.Point(0, 0);
            this.dvDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.dvDepartments.Name = "dvDepartments";
            this.dvDepartments.RowTemplate.Height = 31;
            this.dvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDepartments.Size = new System.Drawing.Size(1332, 314);
            this.dvDepartments.TabIndex = 12;
            // 
            // cbDepartment
            // 
            this.cbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(192, 29);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(237, 32);
            this.cbDepartment.TabIndex = 14;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(500, 29);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(166, 29);
            this.dtStart.TabIndex = 16;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(730, 29);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(159, 29);
            this.dtEnd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Start";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(675, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 25);
            this.label16.TabIndex = 19;
            this.label16.Text = "End";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1181, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1038, 26);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 42);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 919);
            this.panel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtBirthDate);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.dtMemberSince);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbMemberType);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbOccupation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbCivilStatus);
            this.groupBox1.Controls.Add(this.tbLandLine);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMobile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.tbBarangay);
            this.groupBox1.Controls.Add(this.tbStreetAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMiddleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(529, 919);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new System.Drawing.Point(28, 487);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(237, 29);
            this.dtBirthDate.TabIndex = 29;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(273, 414);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(239, 29);
            this.tbCountry.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Country";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(28, 203);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(484, 29);
            this.tbLastName.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Last Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(270, 678);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(273, 705);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(237, 32);
            this.cbStatus.TabIndex = 24;
            this.cbStatus.Text = "Active";
            // 
            // dtMemberSince
            // 
            this.dtMemberSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMemberSince.Location = new System.Drawing.Point(26, 779);
            this.dtMemberSince.Margin = new System.Windows.Forms.Padding(4);
            this.dtMemberSince.Name = "dtMemberSince";
            this.dtMemberSince.Size = new System.Drawing.Size(237, 29);
            this.dtMemberSince.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 678);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 25);
            this.label19.TabIndex = 21;
            this.label19.Text = "Member Type";
            // 
            // cbMemberType
            // 
            this.cbMemberType.FormattingEnabled = true;
            this.cbMemberType.Items.AddRange(new object[] {
            "Member - Homegrown",
            "Member - Adopted",
            "Visitor",
            "Pastor",
            "Staff"});
            this.cbMemberType.Location = new System.Drawing.Point(26, 705);
            this.cbMemberType.Margin = new System.Windows.Forms.Padding(4);
            this.cbMemberType.Name = "cbMemberType";
            this.cbMemberType.Size = new System.Drawing.Size(237, 32);
            this.cbMemberType.TabIndex = 21;
            this.cbMemberType.Text = "Member - Homegrown";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 751);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 25);
            this.label18.TabIndex = 22;
            this.label18.Text = "Member Since";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 460);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Birthdate";
            // 
            // tbOccupation
            // 
            this.tbOccupation.Location = new System.Drawing.Point(28, 635);
            this.tbOccupation.Margin = new System.Windows.Forms.Padding(4);
            this.tbOccupation.Name = "tbOccupation";
            this.tbOccupation.Size = new System.Drawing.Size(484, 29);
            this.tbOccupation.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 607);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Occupation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 460);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Civil Status";
            // 
            // cbCivilStatus
            // 
            this.cbCivilStatus.FormattingEnabled = true;
            this.cbCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Windower"});
            this.cbCivilStatus.Location = new System.Drawing.Point(273, 487);
            this.cbCivilStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbCivilStatus.Name = "cbCivilStatus";
            this.cbCivilStatus.Size = new System.Drawing.Size(239, 32);
            this.cbCivilStatus.TabIndex = 5;
            this.cbCivilStatus.Text = "Single";
            // 
            // tbLandLine
            // 
            this.tbLandLine.Location = new System.Drawing.Point(275, 563);
            this.tbLandLine.Margin = new System.Windows.Forms.Padding(4);
            this.tbLandLine.Name = "tbLandLine";
            this.tbLandLine.Size = new System.Drawing.Size(237, 29);
            this.tbLandLine.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 535);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Landline";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(28, 563);
            this.tbMobile.Margin = new System.Windows.Forms.Padding(4);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(237, 29);
            this.tbMobile.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 535);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mobile Number";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(28, 415);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(235, 29);
            this.tbCity.TabIndex = 8;
            // 
            // tbBarangay
            // 
            this.tbBarangay.Location = new System.Drawing.Point(28, 345);
            this.tbBarangay.Margin = new System.Windows.Forms.Padding(4);
            this.tbBarangay.Name = "tbBarangay";
            this.tbBarangay.Size = new System.Drawing.Size(484, 29);
            this.tbBarangay.TabIndex = 6;
            // 
            // tbStreetAddress
            // 
            this.tbStreetAddress.Location = new System.Drawing.Point(28, 277);
            this.tbStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbStreetAddress.Name = "tbStreetAddress";
            this.tbStreetAddress.Size = new System.Drawing.Size(484, 29);
            this.tbStreetAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Street Address";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(28, 135);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(484, 29);
            this.tbMiddleName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(26, 65);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(484, 29);
            this.tbFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barangay/Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "City/Province";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(529, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 919);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1334, 528);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dvMinistries);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1332, 459);
            this.panel7.TabIndex = 31;
            // 
            // dvMinistries
            // 
            this.dvMinistries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dvMinistries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dvMinistries.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvMinistries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvMinistries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMinistries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMinistries.Location = new System.Drawing.Point(0, 0);
            this.dvMinistries.Margin = new System.Windows.Forms.Padding(4);
            this.dvMinistries.Name = "dvMinistries";
            this.dvMinistries.RowTemplate.Height = 31;
            this.dvMinistries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMinistries.Size = new System.Drawing.Size(1332, 459);
            this.dvMinistries.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnMinistryDelete);
            this.panel6.Controls.Add(this.btnMinistryAdd);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.cbMinistries);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1332, 67);
            this.panel6.TabIndex = 30;
            // 
            // btnMinistryDelete
            // 
            this.btnMinistryDelete.BackgroundImage = global::WPC.Properties.Resources.minus;
            this.btnMinistryDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinistryDelete.FlatAppearance.BorderSize = 0;
            this.btnMinistryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinistryDelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMinistryDelete.Location = new System.Drawing.Point(690, 6);
            this.btnMinistryDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinistryDelete.Name = "btnMinistryDelete";
            this.btnMinistryDelete.Size = new System.Drawing.Size(52, 52);
            this.btnMinistryDelete.TabIndex = 32;
            this.btnMinistryDelete.UseVisualStyleBackColor = true;
            this.btnMinistryDelete.Click += new System.EventHandler(this.BtnMinistryDeleteClick);
            // 
            // btnMinistryAdd
            // 
            this.btnMinistryAdd.AutoSize = true;
            this.btnMinistryAdd.BackgroundImage = global::WPC.Properties.Resources.plus;
            this.btnMinistryAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinistryAdd.FlatAppearance.BorderSize = 0;
            this.btnMinistryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinistryAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMinistryAdd.Location = new System.Drawing.Point(634, 6);
            this.btnMinistryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinistryAdd.Name = "btnMinistryAdd";
            this.btnMinistryAdd.Size = new System.Drawing.Size(52, 52);
            this.btnMinistryAdd.TabIndex = 31;
            this.btnMinistryAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinistryAdd.UseVisualStyleBackColor = true;
            this.btnMinistryAdd.Click += new System.EventHandler(this.btnMinistryAdd_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 22);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 25);
            this.label21.TabIndex = 22;
            this.label21.Text = "Ministries Involved";
            // 
            // cbMinistries
            // 
            this.cbMinistries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinistries.FormattingEnabled = true;
            this.cbMinistries.Location = new System.Drawing.Point(230, 20);
            this.cbMinistries.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinistries.Name = "cbMinistries";
            this.cbMinistries.Size = new System.Drawing.Size(396, 32);
            this.cbMinistries.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnDepartment);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 391);
            this.panel3.TabIndex = 0;
            // 
            // pnDepartment
            // 
            this.pnDepartment.Controls.Add(this.dvDepartments);
            this.pnDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDepartment.Location = new System.Drawing.Point(0, 75);
            this.pnDepartment.Name = "pnDepartment";
            this.pnDepartment.Size = new System.Drawing.Size(1332, 314);
            this.pnDepartment.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.cbDepartment);
            this.panel8.Controls.Add(this.dtEnd);
            this.panel8.Controls.Add(this.btnDeptDelete);
            this.panel8.Controls.Add(this.dtStart);
            this.panel8.Controls.Add(this.btnDeptAdd);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1332, 75);
            this.panel8.TabIndex = 31;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // btnDeptDelete
            // 
            this.btnDeptDelete.BackgroundImage = global::WPC.Properties.Resources.minus;
            this.btnDeptDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeptDelete.FlatAppearance.BorderSize = 0;
            this.btnDeptDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptDelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeptDelete.Location = new System.Drawing.Point(953, 18);
            this.btnDeptDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeptDelete.Name = "btnDeptDelete";
            this.btnDeptDelete.Size = new System.Drawing.Size(52, 52);
            this.btnDeptDelete.TabIndex = 30;
            this.btnDeptDelete.UseVisualStyleBackColor = true;
            this.btnDeptDelete.Click += new System.EventHandler(this.btnDeptDelete_Click);
            // 
            // btnDeptAdd
            // 
            this.btnDeptAdd.AutoSize = true;
            this.btnDeptAdd.BackgroundImage = global::WPC.Properties.Resources.plus;
            this.btnDeptAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeptAdd.FlatAppearance.BorderSize = 0;
            this.btnDeptAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeptAdd.Location = new System.Drawing.Point(897, 18);
            this.btnDeptAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeptAdd.Name = "btnDeptAdd";
            this.btnDeptAdd.Size = new System.Drawing.Size(52, 52);
            this.btnDeptAdd.TabIndex = 15;
            this.btnDeptAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeptAdd.UseVisualStyleBackColor = true;
            this.btnDeptAdd.Click += new System.EventHandler(this.btnDeptAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(529, 836);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1334, 83);
            this.panel5.TabIndex = 35;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 919);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAdd_Activated);
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDepartments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMinistries)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnDepartment.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dvDepartments;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnDeptAdd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtMemberSince;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbMemberType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbOccupation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCivilStatus;
        private System.Windows.Forms.TextBox tbLandLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbBarangay;
        private System.Windows.Forms.TextBox tbStreetAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dvMinistries;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbMinistries;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnDepartment;
        private System.Windows.Forms.Button btnMinistryDelete;
        private System.Windows.Forms.Button btnMinistryAdd;
    }
}

