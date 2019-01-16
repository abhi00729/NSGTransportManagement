namespace NSGTransportManagement
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListViewSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListViewBuses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListViewBusRoutes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassManagementSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassManagementCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersStates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersCities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersRelationships = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersRanks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersQuarterTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBusRoutes = new System.Windows.Forms.ToolStripButton();
            this.tsbSchools = new System.Windows.Forms.ToolStripButton();
            this.tsbBuses = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStudentPass = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuListView,
            this.mnuPassManagement,
            this.mnuMasters,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuFileChangePassword,
            this.toolStripSeparator5,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileChangePassword
            // 
            this.mnuFileChangePassword.Name = "mnuFileChangePassword";
            this.mnuFileChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuFileChangePassword.Text = "C&hange Password";
            this.mnuFileChangePassword.Click += new System.EventHandler(this.mnuFileChangePassword_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(168, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuListView
            // 
            this.mnuListView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListViewSchools,
            this.mnuListViewBuses,
            this.mnuListViewBusRoutes});
            this.mnuListView.Name = "mnuListView";
            this.mnuListView.Size = new System.Drawing.Size(65, 20);
            this.mnuListView.Text = "List View";
            // 
            // mnuListViewSchools
            // 
            this.mnuListViewSchools.Name = "mnuListViewSchools";
            this.mnuListViewSchools.Size = new System.Drawing.Size(132, 22);
            this.mnuListViewSchools.Text = "Schools";
            this.mnuListViewSchools.Click += new System.EventHandler(this.mnuListViewSchools_Click);
            // 
            // mnuListViewBuses
            // 
            this.mnuListViewBuses.Name = "mnuListViewBuses";
            this.mnuListViewBuses.Size = new System.Drawing.Size(132, 22);
            this.mnuListViewBuses.Text = "Buses";
            this.mnuListViewBuses.Click += new System.EventHandler(this.mnuListViewBuses_Click);
            // 
            // mnuListViewBusRoutes
            // 
            this.mnuListViewBusRoutes.Name = "mnuListViewBusRoutes";
            this.mnuListViewBusRoutes.Size = new System.Drawing.Size(132, 22);
            this.mnuListViewBusRoutes.Text = "Bus Routes";
            this.mnuListViewBusRoutes.Click += new System.EventHandler(this.mnuListViewBusRoutes_Click);
            // 
            // mnuPassManagement
            // 
            this.mnuPassManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassManagementSearch,
            this.mnuPassManagementCreate});
            this.mnuPassManagement.Name = "mnuPassManagement";
            this.mnuPassManagement.Size = new System.Drawing.Size(86, 20);
            this.mnuPassManagement.Text = "Student Pass";
            // 
            // mnuPassManagementSearch
            // 
            this.mnuPassManagementSearch.Name = "mnuPassManagementSearch";
            this.mnuPassManagementSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuPassManagementSearch.Size = new System.Drawing.Size(183, 22);
            this.mnuPassManagementSearch.Text = "&Search / Find";
            this.mnuPassManagementSearch.Click += new System.EventHandler(this.mnuPassManagementSearch_Click);
            // 
            // mnuPassManagementCreate
            // 
            this.mnuPassManagementCreate.Name = "mnuPassManagementCreate";
            this.mnuPassManagementCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuPassManagementCreate.Size = new System.Drawing.Size(183, 22);
            this.mnuPassManagementCreate.Text = "Create &New";
            this.mnuPassManagementCreate.Click += new System.EventHandler(this.mnuPassManagementCreate_Click);
            // 
            // mnuMasters
            // 
            this.mnuMasters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMastersStates,
            this.mnuMastersCities,
            this.mnuMastersUsers,
            this.mnuMastersRelationships,
            this.mnuMastersRanks,
            this.mnuMastersUnits,
            this.mnuMastersQuarterTypes});
            this.mnuMasters.Name = "mnuMasters";
            this.mnuMasters.Size = new System.Drawing.Size(60, 20);
            this.mnuMasters.Text = "&Masters";
            // 
            // mnuMastersStates
            // 
            this.mnuMastersStates.Name = "mnuMastersStates";
            this.mnuMastersStates.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersStates.Text = "&States";
            this.mnuMastersStates.Click += new System.EventHandler(this.mnuMastersStates_Click);
            // 
            // mnuMastersCities
            // 
            this.mnuMastersCities.Name = "mnuMastersCities";
            this.mnuMastersCities.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersCities.Text = "&Cities";
            this.mnuMastersCities.Click += new System.EventHandler(this.mnuMastersCities_Click);
            // 
            // mnuMastersUsers
            // 
            this.mnuMastersUsers.Name = "mnuMastersUsers";
            this.mnuMastersUsers.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersUsers.Text = "&Users";
            this.mnuMastersUsers.Click += new System.EventHandler(this.mnuMastersUsers_Click);
            // 
            // mnuMastersRelationships
            // 
            this.mnuMastersRelationships.Name = "mnuMastersRelationships";
            this.mnuMastersRelationships.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersRelationships.Text = "&Relationships";
            this.mnuMastersRelationships.Click += new System.EventHandler(this.mnuMastersRelationships_Click);
            // 
            // mnuMastersRanks
            // 
            this.mnuMastersRanks.Name = "mnuMastersRanks";
            this.mnuMastersRanks.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersRanks.Text = "Ra&nks";
            this.mnuMastersRanks.Click += new System.EventHandler(this.mnuMastersRanks_Click);
            // 
            // mnuMastersUnits
            // 
            this.mnuMastersUnits.Name = "mnuMastersUnits";
            this.mnuMastersUnits.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersUnits.Text = "Uni&ts";
            this.mnuMastersUnits.Click += new System.EventHandler(this.mnuMastersUnits_Click);
            // 
            // mnuMastersQuarterTypes
            // 
            this.mnuMastersQuarterTypes.Name = "mnuMastersQuarterTypes";
            this.mnuMastersQuarterTypes.Size = new System.Drawing.Size(147, 22);
            this.mnuMastersQuarterTypes.Text = "&Quarter Types";
            this.mnuMastersQuarterTypes.Click += new System.EventHandler(this.mnuMastersQuarterTypes_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuHelpAbout.Text = "&About...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSchools,
            this.tsbBusRoutes,
            this.tsbBuses,
            this.toolStripSeparator2,
            this.tsbStudentPass,
            this.tsbSearchStudent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1115, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBusRoutes
            // 
            this.tsbBusRoutes.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusRoutes.Image")));
            this.tsbBusRoutes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusRoutes.Name = "tsbBusRoutes";
            this.tsbBusRoutes.Size = new System.Drawing.Size(69, 35);
            this.tsbBusRoutes.Text = "Bus Routes";
            this.tsbBusRoutes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBusRoutes.Click += new System.EventHandler(this.tsbBusRoutes_Click);
            // 
            // tsbSchools
            // 
            this.tsbSchools.Image = ((System.Drawing.Image)(resources.GetObject("tsbSchools.Image")));
            this.tsbSchools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSchools.Name = "tsbSchools";
            this.tsbSchools.Size = new System.Drawing.Size(52, 35);
            this.tsbSchools.Text = "Schools";
            this.tsbSchools.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbSchools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSchools.Click += new System.EventHandler(this.tsbSchools_Click);
            // 
            // tsbBuses
            // 
            this.tsbBuses.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuses.Image")));
            this.tsbBuses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuses.Name = "tsbBuses";
            this.tsbBuses.Size = new System.Drawing.Size(41, 35);
            this.tsbBuses.Text = "Buses";
            this.tsbBuses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuses.Click += new System.EventHandler(this.tsbBuses_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbStudentPass
            // 
            this.tsbStudentPass.Image = ((System.Drawing.Image)(resources.GetObject("tsbStudentPass.Image")));
            this.tsbStudentPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStudentPass.Name = "tsbStudentPass";
            this.tsbStudentPass.Size = new System.Drawing.Size(105, 35);
            this.tsbStudentPass.Text = "New Student Pass";
            this.tsbStudentPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStudentPass.Click += new System.EventHandler(this.tsbStudentPass_Click);
            // 
            // tsbSearchStudent
            // 
            this.tsbSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchStudent.Image")));
            this.tsbSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchStudent.Name = "tsbSearchStudent";
            this.tsbSearchStudent.Size = new System.Drawing.Size(90, 35);
            this.tsbSearchStudent.Text = "Search Student";
            this.tsbSearchStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSearchStudent.Click += new System.EventHandler(this.tsbSearchStudent_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NSGTransportManagement.Properties.Resources.NSGLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1115, 523);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainPage";
            this.Text = "NSG Transport Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainPage_FormClosing);
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuMasters;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersStates;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersCities;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersRelationships;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersRanks;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersUnits;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersQuarterTypes;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuPassManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuPassManagementSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuPassManagementCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuListView;
        private System.Windows.Forms.ToolStripMenuItem mnuListViewSchools;
        private System.Windows.Forms.ToolStripMenuItem mnuListViewBuses;
        private System.Windows.Forms.ToolStripMenuItem mnuListViewBusRoutes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSchools;
        private System.Windows.Forms.ToolStripButton tsbBuses;
        private System.Windows.Forms.ToolStripButton tsbBusRoutes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbStudentPass;
        private System.Windows.Forms.ToolStripButton tsbSearchStudent;
    }
}



