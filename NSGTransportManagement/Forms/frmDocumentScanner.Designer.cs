using System.Windows.Forms;

namespace NSGTransportManagement.Forms
{
    partial class frmDocumentScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentScanner));
            this.showImages = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_capture = new System.Windows.Forms.Panel();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.lblDocumentName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.pnl_capture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.SuspendLayout();
            // 
            // showImages
            // 
            this.showImages.Location = new System.Drawing.Point(242, 216);
            this.showImages.Name = "showImages";
            this.showImages.Size = new System.Drawing.Size(85, 23);
            this.showImages.TabIndex = 5;
            this.showImages.Text = "Show Images";
            this.showImages.UseVisualStyleBackColor = true;
            this.showImages.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(555, 3);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // pnl_capture
            // 
            this.pnl_capture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnl_capture.Controls.Add(this.txtDocumentName);
            this.pnl_capture.Controls.Add(this.lblDocumentName);
            this.pnl_capture.Controls.Add(this.btnCancel);
            this.pnl_capture.Controls.Add(this.btnEnter);
            this.pnl_capture.Controls.Add(this.pic_scan);
            this.pnl_capture.Controls.Add(this.btnScan);
            this.pnl_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_capture.Location = new System.Drawing.Point(0, 3);
            this.pnl_capture.Name = "pnl_capture";
            this.pnl_capture.Size = new System.Drawing.Size(555, 564);
            this.pnl_capture.TabIndex = 39;
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDocumentName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentName.Location = new System.Drawing.Point(174, 15);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(369, 21);
            this.txtDocumentName.TabIndex = 161;
            // 
            // lblDocumentName
            // 
            this.lblDocumentName.AutoSize = true;
            this.lblDocumentName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentName.ForeColor = System.Drawing.Color.Black;
            this.lblDocumentName.Location = new System.Drawing.Point(16, 17);
            this.lblDocumentName.Name = "lblDocumentName";
            this.lblDocumentName.Size = new System.Drawing.Size(121, 16);
            this.lblDocumentName.TabIndex = 162;
            this.lblDocumentName.Text = "Document Name :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 35);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEnter.Location = new System.Drawing.Point(12, 90);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(156, 35);
            this.btnEnter.TabIndex = 159;
            this.btnEnter.Text = "&Done";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pic_scan
            // 
            this.pic_scan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_scan.BackColor = System.Drawing.Color.White;
            this.pic_scan.Location = new System.Drawing.Point(174, 49);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(369, 503);
            this.pic_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_scan.TabIndex = 6;
            this.pic_scan.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnScan.Location = new System.Drawing.Point(12, 49);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(156, 35);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // frmDocumentScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 567);
            this.Controls.Add(this.pnl_capture);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDocumentScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocumentScanner_FormClosing);
            this.Load += new System.EventHandler(this.frmDocumentScanner_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.pnl_capture.ResumeLayout(false);
            this.pnl_capture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        //camera
        private System.Windows.Forms.Button showImages;
        private Splitter splitter1;
        private Panel pnl_capture;
        private PictureBox pic_scan;
        private Button btnScan;
        private Button btnCancel;
        private Button btnEnter;
        private TextBox txtDocumentName;
        private Label lblDocumentName;
    }
}

