namespace NSGTransportManagement.Forms
{
    partial class frmNSGPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNSGPass));
            this.cmbPassType = new System.Windows.Forms.ComboBox();
            this.lblPassType = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.dteExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dteIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picVisitorPhoto = new System.Windows.Forms.PictureBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassHolderAddress = new System.Windows.Forms.TextBox();
            this.lblPassHolderAddress = new System.Windows.Forms.Label();
            this.grpCivilianPassDetail = new System.Windows.Forms.GroupBox();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpGuestDependantPassDetail = new System.Windows.Forms.GroupBox();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.lblIdentityType = new System.Windows.Forms.Label();
            this.cmbUnit_Guest = new System.Windows.Forms.ComboBox();
            this.cmbRank_Guest = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmployeeId_Guest = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRelativeOfName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdentificationMark_Guest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpOutlivingPassDetail = new System.Windows.Forms.GroupBox();
            this.cmbUnit_Outliving = new System.Windows.Forms.ComboBox();
            this.cmbRank_Outliving = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmployeeId_Outliving = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIdentificationMark_Outliving = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.grpVehiclePassDetail = new System.Windows.Forms.GroupBox();
            this.txtDesignation_Vehicle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVehicleMake = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnit_Vehicle = new System.Windows.Forms.ComboBox();
            this.cmbRank_Vehicle = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEmployeeId_Vehicle = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.dteBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnScanDoc = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PassDocumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).BeginInit();
            this.grpCivilianPassDetail.SuspendLayout();
            this.grpGuestDependantPassDetail.SuspendLayout();
            this.grpOutlivingPassDetail.SuspendLayout();
            this.grpVehiclePassDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPassType
            // 
            this.cmbPassType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbPassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPassType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPassType.FormattingEnabled = true;
            this.cmbPassType.Location = new System.Drawing.Point(102, 9);
            this.cmbPassType.Name = "cmbPassType";
            this.cmbPassType.Size = new System.Drawing.Size(237, 23);
            this.cmbPassType.TabIndex = 127;
            this.cmbPassType.SelectedIndexChanged += new System.EventHandler(this.cmbPassType_SelectedIndexChanged);
            // 
            // lblPassType
            // 
            this.lblPassType.AutoSize = true;
            this.lblPassType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassType.Location = new System.Drawing.Point(12, 14);
            this.lblPassType.Name = "lblPassType";
            this.lblPassType.Size = new System.Drawing.Size(79, 16);
            this.lblPassType.TabIndex = 128;
            this.lblPassType.Text = "Pass Type :";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(101, 106);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(238, 23);
            this.cmbGender.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 136;
            this.label11.Text = "Gender:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(101, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 21);
            this.txtLastName.TabIndex = 132;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 16);
            this.lblLastName.TabIndex = 135;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(102, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 21);
            this.txtFirstName.TabIndex = 131;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 134;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMobileNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(128, 139);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(211, 21);
            this.txtMobileNo.TabIndex = 137;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 138;
            this.label12.Text = "Mobile Number :";
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGuardianName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianName.Location = new System.Drawing.Point(117, 168);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(222, 21);
            this.txtGuardianName.TabIndex = 139;
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(12, 170);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(98, 16);
            this.lblGuardianName.TabIndex = 140;
            this.lblGuardianName.Text = "Father Name :";
            // 
            // dteExpiryDate
            // 
            this.dteExpiryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteExpiryDate.CustomFormat = "dd-MMM-yyyy";
            this.dteExpiryDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteExpiryDate.Location = new System.Drawing.Point(429, 41);
            this.dteExpiryDate.Name = "dteExpiryDate";
            this.dteExpiryDate.Size = new System.Drawing.Size(132, 23);
            this.dteExpiryDate.TabIndex = 142;
            // 
            // dteIssueDate
            // 
            this.dteIssueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteIssueDate.CustomFormat = "dd-MMM-yyyy";
            this.dteIssueDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteIssueDate.Location = new System.Drawing.Point(429, 9);
            this.dteIssueDate.Name = "dteIssueDate";
            this.dteIssueDate.Size = new System.Drawing.Size(132, 23);
            this.dteIssueDate.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 143;
            this.label3.Text = "Valid Upto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 144;
            this.label2.Text = "Issue Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapture);
            this.groupBox6.Controls.Add(this.picVisitorPhoto);
            this.groupBox6.Location = new System.Drawing.Point(567, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 306);
            this.groupBox6.TabIndex = 145;
            this.groupBox6.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnCapture.Image")));
            this.btnCapture.Location = new System.Drawing.Point(7, 238);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(193, 60);
            this.btnCapture.TabIndex = 20;
            this.btnCapture.Text = "&Capture Photo";
            this.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // picVisitorPhoto
            // 
            this.picVisitorPhoto.AccessibleDescription = "";
            this.picVisitorPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVisitorPhoto.InitialImage = null;
            this.picVisitorPhoto.Location = new System.Drawing.Point(7, 15);
            this.picVisitorPhoto.Name = "picVisitorPhoto";
            this.picVisitorPhoto.Size = new System.Drawing.Size(193, 215);
            this.picVisitorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisitorPhoto.TabIndex = 0;
            this.picVisitorPhoto.TabStop = false;
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(67, 272);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(272, 23);
            this.cmbState.TabIndex = 147;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "State :";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(58, 304);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(281, 23);
            this.cmbCity.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 150;
            this.label4.Text = "City :";
            // 
            // txtPassHolderAddress
            // 
            this.txtPassHolderAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassHolderAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassHolderAddress.Location = new System.Drawing.Point(15, 216);
            this.txtPassHolderAddress.Multiline = true;
            this.txtPassHolderAddress.Name = "txtPassHolderAddress";
            this.txtPassHolderAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassHolderAddress.Size = new System.Drawing.Size(324, 48);
            this.txtPassHolderAddress.TabIndex = 146;
            // 
            // lblPassHolderAddress
            // 
            this.lblPassHolderAddress.AutoSize = true;
            this.lblPassHolderAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassHolderAddress.Location = new System.Drawing.Point(12, 197);
            this.lblPassHolderAddress.Name = "lblPassHolderAddress";
            this.lblPassHolderAddress.Size = new System.Drawing.Size(154, 16);
            this.lblPassHolderAddress.TabIndex = 149;
            this.lblPassHolderAddress.Text = "Pass Holder\'s Address :";
            // 
            // grpCivilianPassDetail
            // 
            this.grpCivilianPassDetail.Controls.Add(this.txtContractorName);
            this.grpCivilianPassDetail.Controls.Add(this.label7);
            this.grpCivilianPassDetail.Controls.Add(this.txtDesignation);
            this.grpCivilianPassDetail.Controls.Add(this.label6);
            this.grpCivilianPassDetail.Location = new System.Drawing.Point(706, 338);
            this.grpCivilianPassDetail.Name = "grpCivilianPassDetail";
            this.grpCivilianPassDetail.Size = new System.Drawing.Size(353, 75);
            this.grpCivilianPassDetail.TabIndex = 152;
            this.grpCivilianPassDetail.TabStop = false;
            this.grpCivilianPassDetail.Text = "Civilian Pass Detail";
            // 
            // txtContractorName
            // 
            this.txtContractorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContractorName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractorName.Location = new System.Drawing.Point(148, 44);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(193, 21);
            this.txtContractorName.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 146;
            this.label7.Text = "Contractor Name :";
            // 
            // txtDesignation
            // 
            this.txtDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDesignation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(148, 15);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(193, 21);
            this.txtDesignation.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 144;
            this.label6.Text = "Designation :";
            // 
            // grpGuestDependantPassDetail
            // 
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbRelationship);
            this.grpGuestDependantPassDetail.Controls.Add(this.lblIdentityType);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbUnit_Guest);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbRank_Guest);
            this.grpGuestDependantPassDetail.Controls.Add(this.label13);
            this.grpGuestDependantPassDetail.Controls.Add(this.label14);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtEmployeeId_Guest);
            this.grpGuestDependantPassDetail.Controls.Add(this.label15);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtRelativeOfName);
            this.grpGuestDependantPassDetail.Controls.Add(this.label10);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtIdentificationMark_Guest);
            this.grpGuestDependantPassDetail.Controls.Add(this.label9);
            this.grpGuestDependantPassDetail.Location = new System.Drawing.Point(355, 338);
            this.grpGuestDependantPassDetail.Name = "grpGuestDependantPassDetail";
            this.grpGuestDependantPassDetail.Size = new System.Drawing.Size(345, 198);
            this.grpGuestDependantPassDetail.TabIndex = 153;
            this.grpGuestDependantPassDetail.TabStop = false;
            this.grpGuestDependantPassDetail.Text = "Guest Dependant Pass Detail";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRelationship.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(148, 162);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(188, 23);
            this.cmbRelationship.TabIndex = 157;
            // 
            // lblIdentityType
            // 
            this.lblIdentityType.AutoSize = true;
            this.lblIdentityType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityType.Location = new System.Drawing.Point(8, 164);
            this.lblIdentityType.Name = "lblIdentityType";
            this.lblIdentityType.Size = new System.Drawing.Size(95, 16);
            this.lblIdentityType.TabIndex = 158;
            this.lblIdentityType.Text = "Relationship :";
            // 
            // cmbUnit_Guest
            // 
            this.cmbUnit_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit_Guest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit_Guest.FormattingEnabled = true;
            this.cmbUnit_Guest.Location = new System.Drawing.Point(148, 133);
            this.cmbUnit_Guest.Name = "cmbUnit_Guest";
            this.cmbUnit_Guest.Size = new System.Drawing.Size(188, 21);
            this.cmbUnit_Guest.TabIndex = 153;
            // 
            // cmbRank_Guest
            // 
            this.cmbRank_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank_Guest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank_Guest.FormattingEnabled = true;
            this.cmbRank_Guest.Location = new System.Drawing.Point(148, 102);
            this.cmbRank_Guest.Name = "cmbRank_Guest";
            this.cmbRank_Guest.Size = new System.Drawing.Size(188, 21);
            this.cmbRank_Guest.TabIndex = 152;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 156;
            this.label13.Text = "Rank:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 155;
            this.label14.Text = "Unit:";
            // 
            // txtEmployeeId_Guest
            // 
            this.txtEmployeeId_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeId_Guest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId_Guest.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId_Guest.Location = new System.Drawing.Point(148, 73);
            this.txtEmployeeId_Guest.MaxLength = 15;
            this.txtEmployeeId_Guest.Name = "txtEmployeeId_Guest";
            this.txtEmployeeId_Guest.Size = new System.Drawing.Size(188, 23);
            this.txtEmployeeId_Guest.TabIndex = 151;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 154;
            this.label15.Text = "Employee ID:";
            // 
            // txtRelativeOfName
            // 
            this.txtRelativeOfName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRelativeOfName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelativeOfName.Location = new System.Drawing.Point(148, 47);
            this.txtRelativeOfName.Name = "txtRelativeOfName";
            this.txtRelativeOfName.Size = new System.Drawing.Size(188, 21);
            this.txtRelativeOfName.TabIndex = 149;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 150;
            this.label10.Text = "Relative Of :";
            // 
            // txtIdentificationMark_Guest
            // 
            this.txtIdentificationMark_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdentificationMark_Guest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificationMark_Guest.Location = new System.Drawing.Point(148, 19);
            this.txtIdentificationMark_Guest.Name = "txtIdentificationMark_Guest";
            this.txtIdentificationMark_Guest.Size = new System.Drawing.Size(188, 21);
            this.txtIdentificationMark_Guest.TabIndex = 145;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "Identification Mark :";
            // 
            // grpOutlivingPassDetail
            // 
            this.grpOutlivingPassDetail.Controls.Add(this.cmbUnit_Outliving);
            this.grpOutlivingPassDetail.Controls.Add(this.cmbRank_Outliving);
            this.grpOutlivingPassDetail.Controls.Add(this.label17);
            this.grpOutlivingPassDetail.Controls.Add(this.label18);
            this.grpOutlivingPassDetail.Controls.Add(this.txtEmployeeId_Outliving);
            this.grpOutlivingPassDetail.Controls.Add(this.label19);
            this.grpOutlivingPassDetail.Controls.Add(this.txtBloodGroup);
            this.grpOutlivingPassDetail.Controls.Add(this.label21);
            this.grpOutlivingPassDetail.Controls.Add(this.txtIdentificationMark_Outliving);
            this.grpOutlivingPassDetail.Controls.Add(this.label22);
            this.grpOutlivingPassDetail.Location = new System.Drawing.Point(706, 418);
            this.grpOutlivingPassDetail.Name = "grpOutlivingPassDetail";
            this.grpOutlivingPassDetail.Size = new System.Drawing.Size(353, 168);
            this.grpOutlivingPassDetail.TabIndex = 154;
            this.grpOutlivingPassDetail.TabStop = false;
            this.grpOutlivingPassDetail.Text = "Outliving Pass Detail";
            // 
            // cmbUnit_Outliving
            // 
            this.cmbUnit_Outliving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit_Outliving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit_Outliving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit_Outliving.FormattingEnabled = true;
            this.cmbUnit_Outliving.Location = new System.Drawing.Point(148, 135);
            this.cmbUnit_Outliving.Name = "cmbUnit_Outliving";
            this.cmbUnit_Outliving.Size = new System.Drawing.Size(195, 21);
            this.cmbUnit_Outliving.TabIndex = 153;
            // 
            // cmbRank_Outliving
            // 
            this.cmbRank_Outliving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank_Outliving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank_Outliving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank_Outliving.FormattingEnabled = true;
            this.cmbRank_Outliving.Location = new System.Drawing.Point(148, 104);
            this.cmbRank_Outliving.Name = "cmbRank_Outliving";
            this.cmbRank_Outliving.Size = new System.Drawing.Size(195, 21);
            this.cmbRank_Outliving.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 156;
            this.label17.Text = "Rank:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 155;
            this.label18.Text = "Unit:";
            // 
            // txtEmployeeId_Outliving
            // 
            this.txtEmployeeId_Outliving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeId_Outliving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId_Outliving.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId_Outliving.Location = new System.Drawing.Point(148, 75);
            this.txtEmployeeId_Outliving.MaxLength = 15;
            this.txtEmployeeId_Outliving.Name = "txtEmployeeId_Outliving";
            this.txtEmployeeId_Outliving.Size = new System.Drawing.Size(195, 23);
            this.txtEmployeeId_Outliving.TabIndex = 151;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 16);
            this.label19.TabIndex = 154;
            this.label19.Text = "Employee ID:";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBloodGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGroup.Location = new System.Drawing.Point(148, 46);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(195, 21);
            this.txtBloodGroup.TabIndex = 147;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 16);
            this.label21.TabIndex = 148;
            this.label21.Text = "Blood Group :";
            // 
            // txtIdentificationMark_Outliving
            // 
            this.txtIdentificationMark_Outliving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdentificationMark_Outliving.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificationMark_Outliving.Location = new System.Drawing.Point(148, 19);
            this.txtIdentificationMark_Outliving.Name = "txtIdentificationMark_Outliving";
            this.txtIdentificationMark_Outliving.Size = new System.Drawing.Size(195, 21);
            this.txtIdentificationMark_Outliving.TabIndex = 145;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 16);
            this.label22.TabIndex = 146;
            this.label22.Text = "Identification Mark :";
            // 
            // grpVehiclePassDetail
            // 
            this.grpVehiclePassDetail.Controls.Add(this.txtDesignation_Vehicle);
            this.grpVehiclePassDetail.Controls.Add(this.label8);
            this.grpVehiclePassDetail.Controls.Add(this.txtVehicleMake);
            this.grpVehiclePassDetail.Controls.Add(this.label5);
            this.grpVehiclePassDetail.Controls.Add(this.cmbUnit_Vehicle);
            this.grpVehiclePassDetail.Controls.Add(this.cmbRank_Vehicle);
            this.grpVehiclePassDetail.Controls.Add(this.label23);
            this.grpVehiclePassDetail.Controls.Add(this.label24);
            this.grpVehiclePassDetail.Controls.Add(this.txtEmployeeId_Vehicle);
            this.grpVehiclePassDetail.Controls.Add(this.label25);
            this.grpVehiclePassDetail.Controls.Add(this.txtVehicleType);
            this.grpVehiclePassDetail.Controls.Add(this.label26);
            this.grpVehiclePassDetail.Controls.Add(this.txtRegistrationNumber);
            this.grpVehiclePassDetail.Controls.Add(this.label27);
            this.grpVehiclePassDetail.Location = new System.Drawing.Point(2, 338);
            this.grpVehiclePassDetail.Name = "grpVehiclePassDetail";
            this.grpVehiclePassDetail.Size = new System.Drawing.Size(347, 224);
            this.grpVehiclePassDetail.TabIndex = 155;
            this.grpVehiclePassDetail.TabStop = false;
            this.grpVehiclePassDetail.Text = "Vehicle Pass Detail";
            // 
            // txtDesignation_Vehicle
            // 
            this.txtDesignation_Vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDesignation_Vehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation_Vehicle.Location = new System.Drawing.Point(141, 103);
            this.txtDesignation_Vehicle.Name = "txtDesignation_Vehicle";
            this.txtDesignation_Vehicle.Size = new System.Drawing.Size(197, 21);
            this.txtDesignation_Vehicle.TabIndex = 159;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 160;
            this.label8.Text = "Designation :";
            // 
            // txtVehicleMake
            // 
            this.txtVehicleMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVehicleMake.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleMake.Location = new System.Drawing.Point(141, 74);
            this.txtVehicleMake.Name = "txtVehicleMake";
            this.txtVehicleMake.Size = new System.Drawing.Size(197, 21);
            this.txtVehicleMake.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 158;
            this.label5.Text = "Vehicle Make :";
            // 
            // cmbUnit_Vehicle
            // 
            this.cmbUnit_Vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit_Vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit_Vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit_Vehicle.FormattingEnabled = true;
            this.cmbUnit_Vehicle.Location = new System.Drawing.Point(141, 191);
            this.cmbUnit_Vehicle.Name = "cmbUnit_Vehicle";
            this.cmbUnit_Vehicle.Size = new System.Drawing.Size(197, 21);
            this.cmbUnit_Vehicle.TabIndex = 153;
            // 
            // cmbRank_Vehicle
            // 
            this.cmbRank_Vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank_Vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank_Vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank_Vehicle.FormattingEnabled = true;
            this.cmbRank_Vehicle.Location = new System.Drawing.Point(141, 160);
            this.cmbRank_Vehicle.Name = "cmbRank_Vehicle";
            this.cmbRank_Vehicle.Size = new System.Drawing.Size(197, 21);
            this.cmbRank_Vehicle.TabIndex = 152;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 161);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 16);
            this.label23.TabIndex = 156;
            this.label23.Text = "Rank:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 192);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 16);
            this.label24.TabIndex = 155;
            this.label24.Text = "Unit:";
            // 
            // txtEmployeeId_Vehicle
            // 
            this.txtEmployeeId_Vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeId_Vehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId_Vehicle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId_Vehicle.Location = new System.Drawing.Point(141, 131);
            this.txtEmployeeId_Vehicle.MaxLength = 15;
            this.txtEmployeeId_Vehicle.Name = "txtEmployeeId_Vehicle";
            this.txtEmployeeId_Vehicle.Size = new System.Drawing.Size(197, 23);
            this.txtEmployeeId_Vehicle.TabIndex = 151;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 131);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 16);
            this.label25.TabIndex = 154;
            this.label25.Text = "Employee ID:";
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVehicleType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleType.Location = new System.Drawing.Point(141, 46);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(197, 21);
            this.txtVehicleType.TabIndex = 147;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(8, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 16);
            this.label26.TabIndex = 148;
            this.label26.Text = "Vehicle Type :";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationNumber.Location = new System.Drawing.Point(155, 19);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(183, 21);
            this.txtRegistrationNumber.TabIndex = 145;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 16);
            this.label27.TabIndex = 146;
            this.label27.Text = "Registration Number :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(390, 246);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 35);
            this.btnPrint.TabIndex = 157;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(390, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 35);
            this.btnCancel.TabIndex = 158;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(390, 204);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(174, 35);
            this.btnEnter.TabIndex = 156;
            this.btnEnter.Text = "&Save Entry";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // dteBirthDate
            // 
            this.dteBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteBirthDate.CustomFormat = "dd-MMM-yyyy";
            this.dteBirthDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteBirthDate.Location = new System.Drawing.Point(429, 74);
            this.dteBirthDate.Name = "dteBirthDate";
            this.dteBirthDate.Size = new System.Drawing.Size(132, 23);
            this.dteBirthDate.TabIndex = 159;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(342, 78);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(81, 15);
            this.lblBirthDate.TabIndex = 160;
            this.lblBirthDate.Text = "Date of Birth:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnScanDoc
            // 
            this.btnScanDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnScanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanDoc.Location = new System.Drawing.Point(838, 306);
            this.btnScanDoc.Name = "btnScanDoc";
            this.btnScanDoc.Size = new System.Drawing.Size(174, 30);
            this.btnScanDoc.TabIndex = 161;
            this.btnScanDoc.Text = "Add &Documents";
            this.btnScanDoc.UseVisualStyleBackColor = false;
            this.btnScanDoc.Click += new System.EventHandler(this.btnScanDoc_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassDocumentID,
            this.DocumentName,
            this.View});
            this.dgvDocuments.Location = new System.Drawing.Point(779, 9);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(280, 291);
            this.dgvDocuments.TabIndex = 162;
            this.dgvDocuments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellContentClick);
            this.dgvDocuments.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDocuments_UserDeletingRow);
            // 
            // PassDocumentID
            // 
            this.PassDocumentID.HeaderText = "PassDocumentID";
            this.PassDocumentID.Name = "PassDocumentID";
            this.PassDocumentID.Visible = false;
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "Document Name";
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.Width = 150;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.View.Text = "View";
            this.View.Width = 50;
            // 
            // frmNSGPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1065, 593);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.btnScanDoc);
            this.Controls.Add(this.dteBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.grpVehiclePassDetail);
            this.Controls.Add(this.grpOutlivingPassDetail);
            this.Controls.Add(this.grpGuestDependantPassDetail);
            this.Controls.Add(this.grpCivilianPassDetail);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassHolderAddress);
            this.Controls.Add(this.lblPassHolderAddress);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dteExpiryDate);
            this.Controls.Add(this.dteIssueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.lblGuardianName);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cmbPassType);
            this.Controls.Add(this.lblPassType);
            this.MaximizeBox = false;
            this.Name = "frmNSGPass";
            this.Text = "NSG Pass";
            this.Load += new System.EventHandler(this.frmNSGPass_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).EndInit();
            this.grpCivilianPassDetail.ResumeLayout(false);
            this.grpCivilianPassDetail.PerformLayout();
            this.grpGuestDependantPassDetail.ResumeLayout(false);
            this.grpGuestDependantPassDetail.PerformLayout();
            this.grpOutlivingPassDetail.ResumeLayout(false);
            this.grpOutlivingPassDetail.PerformLayout();
            this.grpVehiclePassDetail.ResumeLayout(false);
            this.grpVehiclePassDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPassType;
        private System.Windows.Forms.Label lblPassType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.DateTimePicker dteExpiryDate;
        private System.Windows.Forms.DateTimePicker dteIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picVisitorPhoto;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassHolderAddress;
        private System.Windows.Forms.Label lblPassHolderAddress;
        private System.Windows.Forms.GroupBox grpCivilianPassDetail;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpGuestDependantPassDetail;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Label lblIdentityType;
        private System.Windows.Forms.ComboBox cmbUnit_Guest;
        private System.Windows.Forms.ComboBox cmbRank_Guest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmployeeId_Guest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRelativeOfName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdentificationMark_Guest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpOutlivingPassDetail;
        private System.Windows.Forms.ComboBox cmbUnit_Outliving;
        private System.Windows.Forms.ComboBox cmbRank_Outliving;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmployeeId_Outliving;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIdentificationMark_Outliving;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grpVehiclePassDetail;
        private System.Windows.Forms.ComboBox cmbUnit_Vehicle;
        private System.Windows.Forms.ComboBox cmbRank_Vehicle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtEmployeeId_Vehicle;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dteBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtDesignation_Vehicle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnScanDoc;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassDocumentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}