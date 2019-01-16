namespace NSGTransportManagement.Forms
{
    partial class frmReportViewer
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
            this.rvReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvReportViewer
            // 
            this.rvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvReportViewer.Location = new System.Drawing.Point(0, 0);
            this.rvReportViewer.Margin = new System.Windows.Forms.Padding(0);
            this.rvReportViewer.Name = "rvReportViewer";
            this.rvReportViewer.Size = new System.Drawing.Size(670, 316);
            this.rvReportViewer.TabIndex = 0;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 316);
            this.Controls.Add(this.rvReportViewer);
            this.Name = "frmReportViewer";
            this.Text = "Report Viewer";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReportViewer;
    }
}