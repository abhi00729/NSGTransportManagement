namespace NSGTransportManagement.Forms
{
    partial class frmStudentPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentPass));
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.PassDocumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnScanDoc = new System.Windows.Forms.Button();
            this.dteBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnScanPic = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picVisitorPhoto = new System.Windows.Forms.PictureBox();
            this.dteExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dteIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbBusRouteNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPickupPoint = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPickTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDropTime = new System.Windows.Forms.TextBox();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGuestDependantPassDetail = new System.Windows.Forms.GroupBox();
            this.txtQuarterNumber = new System.Windows.Forms.TextBox();
            this.cmbQuarterType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.lblIdentityType = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chkActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).BeginInit();
            this.grpGuestDependantPassDetail.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvDocuments.Location = new System.Drawing.Point(346, 273);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(384, 153);
            this.dgvDocuments.TabIndex = 192;
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
            // btnScanDoc
            // 
            this.btnScanDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnScanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanDoc.Location = new System.Drawing.Point(465, 432);
            this.btnScanDoc.Name = "btnScanDoc";
            this.btnScanDoc.Size = new System.Drawing.Size(147, 28);
            this.btnScanDoc.TabIndex = 191;
            this.btnScanDoc.Text = "Add &Documents";
            this.btnScanDoc.UseVisualStyleBackColor = false;
            this.btnScanDoc.Click += new System.EventHandler(this.btnScanDoc_Click);
            // 
            // dteBirthDate
            // 
            this.dteBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteBirthDate.CustomFormat = "dd-MMM-yyyy";
            this.dteBirthDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteBirthDate.Location = new System.Drawing.Point(424, 63);
            this.dteBirthDate.Name = "dteBirthDate";
            this.dteBirthDate.Size = new System.Drawing.Size(132, 23);
            this.dteBirthDate.TabIndex = 189;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(331, 66);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(91, 16);
            this.lblBirthDate.TabIndex = 190;
            this.lblBirthDate.Text = "Date of Birth:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(376, 466);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 35);
            this.btnPrint.TabIndex = 187;
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
            this.btnCancel.Location = new System.Drawing.Point(556, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 35);
            this.btnCancel.TabIndex = 188;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(196, 466);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(174, 35);
            this.btnEnter.TabIndex = 186;
            this.btnEnter.Text = "&Save Entry";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnScanPic);
            this.groupBox6.Controls.Add(this.btnCapture);
            this.groupBox6.Controls.Add(this.picVisitorPhoto);
            this.groupBox6.Location = new System.Drawing.Point(562, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 268);
            this.groupBox6.TabIndex = 179;
            this.groupBox6.TabStop = false;
            // 
            // btnScanPic
            // 
            this.btnScanPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanPic.Image = ((System.Drawing.Image)(resources.GetObject("btnScanPic.Image")));
            this.btnScanPic.Location = new System.Drawing.Point(86, 203);
            this.btnScanPic.Name = "btnScanPic";
            this.btnScanPic.Size = new System.Drawing.Size(76, 60);
            this.btnScanPic.TabIndex = 210;
            this.btnScanPic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanPic.UseVisualStyleBackColor = true;
            this.btnScanPic.Click += new System.EventHandler(this.btnScanPic_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnCapture.Image")));
            this.btnCapture.Location = new System.Drawing.Point(6, 203);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(76, 60);
            this.btnCapture.TabIndex = 20;
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
            this.picVisitorPhoto.Size = new System.Drawing.Size(155, 184);
            this.picVisitorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisitorPhoto.TabIndex = 0;
            this.picVisitorPhoto.TabStop = false;
            // 
            // dteExpiryDate
            // 
            this.dteExpiryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteExpiryDate.CustomFormat = "dd-MMM-yyyy";
            this.dteExpiryDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteExpiryDate.Location = new System.Drawing.Point(424, 34);
            this.dteExpiryDate.Name = "dteExpiryDate";
            this.dteExpiryDate.Size = new System.Drawing.Size(132, 23);
            this.dteExpiryDate.TabIndex = 176;
            // 
            // dteIssueDate
            // 
            this.dteIssueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteIssueDate.CustomFormat = "dd-MMM-yyyy";
            this.dteIssueDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteIssueDate.Location = new System.Drawing.Point(424, 7);
            this.dteIssueDate.Name = "dteIssueDate";
            this.dteIssueDate.Size = new System.Drawing.Size(132, 23);
            this.dteIssueDate.TabIndex = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 177;
            this.label3.Text = "Valid Upto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 178;
            this.label2.Text = "Issue Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.cmbGender.Location = new System.Drawing.Point(93, 63);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(238, 23);
            this.cmbGender.TabIndex = 167;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 170;
            this.label11.Text = "Gender:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(93, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 21);
            this.txtLastName.TabIndex = 166;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 16);
            this.lblLastName.TabIndex = 169;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(93, 8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 21);
            this.txtFirstName.TabIndex = 165;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 168;
            this.lblFirstName.Text = "First Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 194;
            this.label5.Text = "Class :";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Pre-Nursery",
            "Nursery",
            "Mont-1",
            "Mont-2",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbClass.Location = new System.Drawing.Point(93, 92);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(238, 23);
            this.cmbClass.TabIndex = 195;
            // 
            // cmbBusRouteNumber
            // 
            this.cmbBusRouteNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbBusRouteNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusRouteNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBusRouteNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusRouteNumber.FormattingEnabled = true;
            this.cmbBusRouteNumber.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbBusRouteNumber.Location = new System.Drawing.Point(93, 150);
            this.cmbBusRouteNumber.Name = "cmbBusRouteNumber";
            this.cmbBusRouteNumber.Size = new System.Drawing.Size(238, 23);
            this.cmbBusRouteNumber.TabIndex = 197;
            this.cmbBusRouteNumber.SelectedIndexChanged += new System.EventHandler(this.cmbBusRouteNumber_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 196;
            this.label6.Text = "Route No :";
            // 
            // cmbPickupPoint
            // 
            this.cmbPickupPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbPickupPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPickupPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPickupPoint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPickupPoint.FormattingEnabled = true;
            this.cmbPickupPoint.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbPickupPoint.Location = new System.Drawing.Point(104, 178);
            this.cmbPickupPoint.Name = "cmbPickupPoint";
            this.cmbPickupPoint.Size = new System.Drawing.Size(227, 23);
            this.cmbPickupPoint.TabIndex = 199;
            this.cmbPickupPoint.SelectedIndexChanged += new System.EventHandler(this.cmbPickupPoint_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 198;
            this.label7.Text = "Pickup Point :";
            // 
            // txtPickTime
            // 
            this.txtPickTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPickTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickTime.Location = new System.Drawing.Point(337, 179);
            this.txtPickTime.MaxLength = 10;
            this.txtPickTime.Name = "txtPickTime";
            this.txtPickTime.ReadOnly = true;
            this.txtPickTime.Size = new System.Drawing.Size(78, 21);
            this.txtPickTime.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 201;
            this.label8.Text = "PkUp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 203;
            this.label9.Text = "Drp";
            // 
            // txtDropTime
            // 
            this.txtDropTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDropTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDropTime.Location = new System.Drawing.Point(454, 179);
            this.txtDropTime.MaxLength = 10;
            this.txtDropTime.Name = "txtDropTime";
            this.txtDropTime.ReadOnly = true;
            this.txtDropTime.Size = new System.Drawing.Size(78, 21);
            this.txtDropTime.TabIndex = 202;
            // 
            // cmbSchool
            // 
            this.cmbSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSchool.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchool.FormattingEnabled = true;
            this.cmbSchool.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbSchool.Location = new System.Drawing.Point(93, 121);
            this.cmbSchool.Name = "cmbSchool";
            this.cmbSchool.Size = new System.Drawing.Size(464, 23);
            this.cmbSchool.TabIndex = 207;
            this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "School :";
            // 
            // grpGuestDependantPassDetail
            // 
            this.grpGuestDependantPassDetail.Controls.Add(this.txtQuarterNumber);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbQuarterType);
            this.grpGuestDependantPassDetail.Controls.Add(this.label10);
            this.grpGuestDependantPassDetail.Controls.Add(this.label4);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtGuardianName);
            this.grpGuestDependantPassDetail.Controls.Add(this.lblGuardianName);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtMobileNo);
            this.grpGuestDependantPassDetail.Controls.Add(this.label12);
            this.grpGuestDependantPassDetail.Controls.Add(this.label14);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbRelationship);
            this.grpGuestDependantPassDetail.Controls.Add(this.lblIdentityType);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbUnit);
            this.grpGuestDependantPassDetail.Controls.Add(this.cmbRank);
            this.grpGuestDependantPassDetail.Controls.Add(this.label13);
            this.grpGuestDependantPassDetail.Controls.Add(this.txtEmployeeId);
            this.grpGuestDependantPassDetail.Controls.Add(this.label15);
            this.grpGuestDependantPassDetail.Location = new System.Drawing.Point(8, 206);
            this.grpGuestDependantPassDetail.Name = "grpGuestDependantPassDetail";
            this.grpGuestDependantPassDetail.Size = new System.Drawing.Size(334, 247);
            this.grpGuestDependantPassDetail.TabIndex = 208;
            this.grpGuestDependantPassDetail.TabStop = false;
            this.grpGuestDependantPassDetail.Text = "Guardian Detail";
            // 
            // txtQuarterNumber
            // 
            this.txtQuarterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuarterNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuarterNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarterNumber.Location = new System.Drawing.Point(122, 213);
            this.txtQuarterNumber.MaxLength = 4;
            this.txtQuarterNumber.Name = "txtQuarterNumber";
            this.txtQuarterNumber.Size = new System.Drawing.Size(203, 23);
            this.txtQuarterNumber.TabIndex = 211;
            // 
            // cmbQuarterType
            // 
            this.cmbQuarterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbQuarterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuarterType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbQuarterType.FormattingEnabled = true;
            this.cmbQuarterType.Location = new System.Drawing.Point(122, 186);
            this.cmbQuarterType.Name = "cmbQuarterType";
            this.cmbQuarterType.Size = new System.Drawing.Size(203, 21);
            this.cmbQuarterType.TabIndex = 210;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 213;
            this.label10.Text = "Quarter Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 212;
            this.label4.Text = "Quarter Type:";
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGuardianName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianName.Location = new System.Drawing.Point(122, 15);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(203, 21);
            this.txtGuardianName.TabIndex = 208;
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(8, 17);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(116, 16);
            this.lblGuardianName.TabIndex = 209;
            this.lblGuardianName.Text = "Guardian Name :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMobileNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(122, 43);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(203, 21);
            this.txtMobileNo.TabIndex = 206;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 207;
            this.label12.Text = "Mobile Number :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 186;
            this.label14.Text = "Unit:";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRelationship.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(122, 71);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(203, 23);
            this.cmbRelationship.TabIndex = 159;
            // 
            // lblIdentityType
            // 
            this.lblIdentityType.AutoSize = true;
            this.lblIdentityType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityType.Location = new System.Drawing.Point(8, 73);
            this.lblIdentityType.Name = "lblIdentityType";
            this.lblIdentityType.Size = new System.Drawing.Size(95, 16);
            this.lblIdentityType.TabIndex = 160;
            this.lblIdentityType.Text = "Relationship :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(122, 158);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(203, 21);
            this.cmbUnit.TabIndex = 153;
            // 
            // cmbRank
            // 
            this.cmbRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(122, 130);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(203, 21);
            this.cmbRank.TabIndex = 152;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 156;
            this.label13.Text = "Rank:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(122, 101);
            this.txtEmployeeId.MaxLength = 15;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(203, 23);
            this.txtEmployeeId.TabIndex = 151;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 154;
            this.label15.Text = "Employee ID:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(424, 94);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(121, 19);
            this.chkActive.TabIndex = 209;
            this.chkActive.Text = "Is Student Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // frmStudentPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(732, 501);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.grpGuestDependantPassDetail);
            this.Controls.Add(this.cmbSchool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDropTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPickTime);
            this.Controls.Add(this.cmbPickupPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBusRouteNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.btnScanDoc);
            this.Controls.Add(this.dteBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dteExpiryDate);
            this.Controls.Add(this.dteIssueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentPass";
            this.Text = "Student Pass";
            this.Load += new System.EventHandler(this.frmStudentPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).EndInit();
            this.grpGuestDependantPassDetail.ResumeLayout(false);
            this.grpGuestDependantPassDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassDocumentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Button btnScanDoc;
        private System.Windows.Forms.DateTimePicker dteBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picVisitorPhoto;
        private System.Windows.Forms.DateTimePicker dteExpiryDate;
        private System.Windows.Forms.DateTimePicker dteIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbBusRouteNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPickupPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPickTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDropTime;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGuestDependantPassDetail;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Label lblIdentityType;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuarterNumber;
        private System.Windows.Forms.ComboBox cmbQuarterType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnScanPic;
    }
}