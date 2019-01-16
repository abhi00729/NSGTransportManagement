namespace NSGTransportManagement.Forms
{
    partial class frmBusDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusDetail));
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMaxSeatingAllowed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalSeatCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKMRun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdBusRouteDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriverMobileNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoDriverName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoDriverMobileNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbRouteNumbers = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusRouteDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationNumber.Location = new System.Drawing.Point(192, 3);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(228, 21);
            this.txtRegistrationNumber.TabIndex = 137;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 5);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(146, 16);
            this.lblLastName.TabIndex = 139;
            this.lblLastName.Text = "Registration Number :";
            // 
            // txtMaxSeatingAllowed
            // 
            this.txtMaxSeatingAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaxSeatingAllowed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSeatingAllowed.Location = new System.Drawing.Point(192, 28);
            this.txtMaxSeatingAllowed.Name = "txtMaxSeatingAllowed";
            this.txtMaxSeatingAllowed.Size = new System.Drawing.Size(228, 21);
            this.txtMaxSeatingAllowed.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 141;
            this.label1.Text = "Max Seating Allowed :";
            // 
            // txtTotalSeatCount
            // 
            this.txtTotalSeatCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalSeatCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSeatCount.Location = new System.Drawing.Point(192, 53);
            this.txtTotalSeatCount.Name = "txtTotalSeatCount";
            this.txtTotalSeatCount.Size = new System.Drawing.Size(228, 21);
            this.txtTotalSeatCount.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 143;
            this.label2.Text = "Total Seat Count :";
            // 
            // txtKMRun
            // 
            this.txtKMRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKMRun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKMRun.Location = new System.Drawing.Point(192, 78);
            this.txtKMRun.Name = "txtKMRun";
            this.txtKMRun.Size = new System.Drawing.Size(228, 21);
            this.txtKMRun.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 145;
            this.label3.Text = "Kilometer Run :";
            // 
            // grdBusRouteDetails
            // 
            this.grdBusRouteDetails.AllowUserToAddRows = false;
            this.grdBusRouteDetails.AllowUserToDeleteRows = false;
            this.grdBusRouteDetails.AllowUserToResizeRows = false;
            this.grdBusRouteDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusRouteDetails.Location = new System.Drawing.Point(5, 229);
            this.grdBusRouteDetails.Name = "grdBusRouteDetails";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusRouteDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBusRouteDetails.RowHeadersVisible = false;
            this.grdBusRouteDetails.Size = new System.Drawing.Size(415, 183);
            this.grdBusRouteDetails.TabIndex = 146;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(345, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 162;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(255, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 161;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDriverName
            // 
            this.txtDriverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDriverName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(192, 102);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(228, 21);
            this.txtDriverName.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 164;
            this.label4.Text = "Driver Name :";
            // 
            // txtDriverMobileNumber
            // 
            this.txtDriverMobileNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDriverMobileNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverMobileNumber.Location = new System.Drawing.Point(192, 126);
            this.txtDriverMobileNumber.Name = "txtDriverMobileNumber";
            this.txtDriverMobileNumber.Size = new System.Drawing.Size(228, 21);
            this.txtDriverMobileNumber.TabIndex = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 166;
            this.label5.Text = "Driver Mobile Number :";
            // 
            // txtCoDriverName
            // 
            this.txtCoDriverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCoDriverName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoDriverName.Location = new System.Drawing.Point(192, 150);
            this.txtCoDriverName.Name = "txtCoDriverName";
            this.txtCoDriverName.Size = new System.Drawing.Size(228, 21);
            this.txtCoDriverName.TabIndex = 167;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 168;
            this.label6.Text = "Co-Driver Name :";
            // 
            // txtCoDriverMobileNumber
            // 
            this.txtCoDriverMobileNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCoDriverMobileNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoDriverMobileNumber.Location = new System.Drawing.Point(192, 174);
            this.txtCoDriverMobileNumber.Name = "txtCoDriverMobileNumber";
            this.txtCoDriverMobileNumber.Size = new System.Drawing.Size(228, 21);
            this.txtCoDriverMobileNumber.TabIndex = 169;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 16);
            this.label7.TabIndex = 170;
            this.label7.Text = "Co-Driver Mobile Number :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 201);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(107, 16);
            this.lblFirstName.TabIndex = 171;
            this.lblFirstName.Text = "Route Number :";
            // 
            // cmbRouteNumbers
            // 
            this.cmbRouteNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRouteNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRouteNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRouteNumbers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRouteNumbers.FormattingEnabled = true;
            this.cmbRouteNumbers.Location = new System.Drawing.Point(192, 199);
            this.cmbRouteNumbers.Name = "cmbRouteNumbers";
            this.cmbRouteNumbers.Size = new System.Drawing.Size(228, 23);
            this.cmbRouteNumbers.TabIndex = 172;
            this.cmbRouteNumbers.SelectedIndexChanged += new System.EventHandler(this.cmbRouteNumbers_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(5, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 177;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmBusDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 441);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbRouteNumbers);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCoDriverMobileNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCoDriverName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDriverMobileNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdBusRouteDetails);
            this.Controls.Add(this.txtKMRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalSeatCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxSeatingAllowed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.lblLastName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusDetail";
            this.Text = "Bus Detail";
            this.Load += new System.EventHandler(this.frmBusDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusRouteDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMaxSeatingAllowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSeatCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKMRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdBusRouteDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDriverMobileNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoDriverName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoDriverMobileNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbRouteNumbers;
        private System.Windows.Forms.Button btnDelete;
    }
}