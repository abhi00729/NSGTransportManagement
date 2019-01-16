namespace NSGTransportManagement.Forms
{
    partial class frmSchoolDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolDetail));
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtSchoolAddress = new System.Windows.Forms.TextBox();
            this.lblSchoolAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtSummerTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSummerTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtSummerDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSummerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtWinterTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtWinterTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtWinterDateTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtWinterDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDistanceFromGarage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdminContactNumbers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBusRoutes = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.Location = new System.Drawing.Point(124, 7);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(507, 23);
            this.txtSchoolName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(4, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 16);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "School Name :";
            // 
            // txtSchoolAddress
            // 
            this.txtSchoolAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSchoolAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolAddress.Location = new System.Drawing.Point(124, 33);
            this.txtSchoolAddress.Multiline = true;
            this.txtSchoolAddress.Name = "txtSchoolAddress";
            this.txtSchoolAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSchoolAddress.Size = new System.Drawing.Size(507, 48);
            this.txtSchoolAddress.TabIndex = 150;
            // 
            // lblSchoolAddress
            // 
            this.lblSchoolAddress.AutoSize = true;
            this.lblSchoolAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolAddress.Location = new System.Drawing.Point(4, 49);
            this.lblSchoolAddress.Name = "lblSchoolAddress";
            this.lblSchoolAddress.Size = new System.Drawing.Size(114, 16);
            this.lblSchoolAddress.TabIndex = 151;
            this.lblSchoolAddress.Text = "School Address :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtSummerTimeTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtSummerTimeFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtSummerDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtSummerDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 90);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summer Timings";
            // 
            // dtSummerTimeTo
            // 
            this.dtSummerTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSummerTimeTo.Location = new System.Drawing.Point(372, 52);
            this.dtSummerTimeTo.Name = "dtSummerTimeTo";
            this.dtSummerTimeTo.Size = new System.Drawing.Size(135, 20);
            this.dtSummerTimeTo.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 142;
            this.label3.Text = "Time To :";
            // 
            // dtSummerTimeFrom
            // 
            this.dtSummerTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSummerTimeFrom.Location = new System.Drawing.Point(104, 52);
            this.dtSummerTimeFrom.Name = "dtSummerTimeFrom";
            this.dtSummerTimeFrom.Size = new System.Drawing.Size(135, 20);
            this.dtSummerTimeFrom.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 140;
            this.label4.Text = "Time From :";
            // 
            // dtSummerDateTo
            // 
            this.dtSummerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSummerDateTo.Location = new System.Drawing.Point(372, 23);
            this.dtSummerDateTo.Name = "dtSummerDateTo";
            this.dtSummerDateTo.Size = new System.Drawing.Size(135, 20);
            this.dtSummerDateTo.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Date To :";
            // 
            // dtSummerDateFrom
            // 
            this.dtSummerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSummerDateFrom.Location = new System.Drawing.Point(104, 23);
            this.dtSummerDateFrom.Name = "dtSummerDateFrom";
            this.dtSummerDateFrom.Size = new System.Drawing.Size(135, 20);
            this.dtSummerDateFrom.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "Date From :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtWinterTimeTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtWinterTimeFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtWinterDateTo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtWinterDateFrom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(7, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 90);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winter Timings";
            // 
            // dtWinterTimeTo
            // 
            this.dtWinterTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtWinterTimeTo.Location = new System.Drawing.Point(372, 52);
            this.dtWinterTimeTo.Name = "dtWinterTimeTo";
            this.dtWinterTimeTo.Size = new System.Drawing.Size(135, 20);
            this.dtWinterTimeTo.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 142;
            this.label5.Text = "Time To :";
            // 
            // dtWinterTimeFrom
            // 
            this.dtWinterTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtWinterTimeFrom.Location = new System.Drawing.Point(104, 52);
            this.dtWinterTimeFrom.Name = "dtWinterTimeFrom";
            this.dtWinterTimeFrom.Size = new System.Drawing.Size(135, 20);
            this.dtWinterTimeFrom.TabIndex = 141;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 140;
            this.label6.Text = "Time From :";
            // 
            // dtWinterDateTo
            // 
            this.dtWinterDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWinterDateTo.Location = new System.Drawing.Point(372, 23);
            this.dtWinterDateTo.Name = "dtWinterDateTo";
            this.dtWinterDateTo.Size = new System.Drawing.Size(135, 20);
            this.dtWinterDateTo.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 138;
            this.label7.Text = "Date To :";
            // 
            // dtWinterDateFrom
            // 
            this.dtWinterDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWinterDateFrom.Location = new System.Drawing.Point(104, 23);
            this.dtWinterDateFrom.Name = "dtWinterDateFrom";
            this.dtWinterDateFrom.Size = new System.Drawing.Size(135, 20);
            this.dtWinterDateFrom.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 136;
            this.label8.Text = "Date From :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 157;
            this.label9.Text = "Distance From Garage :";
            // 
            // txtDistanceFromGarage
            // 
            this.txtDistanceFromGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDistanceFromGarage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistanceFromGarage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceFromGarage.Location = new System.Drawing.Point(166, 385);
            this.txtDistanceFromGarage.MaxLength = 999;
            this.txtDistanceFromGarage.Name = "txtDistanceFromGarage";
            this.txtDistanceFromGarage.Size = new System.Drawing.Size(46, 23);
            this.txtDistanceFromGarage.TabIndex = 156;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 158;
            this.label10.Text = "K. M.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(556, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 160;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(447, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 159;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 36);
            this.label11.TabIndex = 162;
            this.label11.Text = "Admin Contact Numbers :";
            // 
            // txtAdminContactNumbers
            // 
            this.txtAdminContactNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdminContactNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminContactNumbers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminContactNumbers.Location = new System.Drawing.Point(124, 141);
            this.txtAdminContactNumbers.Multiline = true;
            this.txtAdminContactNumbers.Name = "txtAdminContactNumbers";
            this.txtAdminContactNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdminContactNumbers.Size = new System.Drawing.Size(507, 49);
            this.txtAdminContactNumbers.TabIndex = 161;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 164;
            this.label12.Text = "Bus Routes :";
            // 
            // txtBusRoutes
            // 
            this.txtBusRoutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBusRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusRoutes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusRoutes.Location = new System.Drawing.Point(124, 414);
            this.txtBusRoutes.Name = "txtBusRoutes";
            this.txtBusRoutes.ReadOnly = true;
            this.txtBusRoutes.Size = new System.Drawing.Size(507, 23);
            this.txtBusRoutes.TabIndex = 163;
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(124, 85);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(507, 23);
            this.cmbState.TabIndex = 165;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 168;
            this.label13.Text = "State :";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(124, 113);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(507, 23);
            this.cmbCity.TabIndex = 166;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 167;
            this.label14.Text = "City :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(7, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 169;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSchoolDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 470);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBusRoutes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdminContactNumbers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDistanceFromGarage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSchoolAddress);
            this.Controls.Add(this.lblSchoolAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSchoolName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchoolDetail";
            this.Text = "School Details";
            this.Load += new System.EventHandler(this.frmSchoolDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtSchoolAddress;
        private System.Windows.Forms.Label lblSchoolAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtSummerTimeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSummerTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtSummerDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSummerDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtWinterTimeTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtWinterTimeFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtWinterDateTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtWinterDateFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDistanceFromGarage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdminContactNumbers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBusRoutes;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
    }
}