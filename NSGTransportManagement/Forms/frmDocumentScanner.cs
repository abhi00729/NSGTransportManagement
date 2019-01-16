using System;
using System.Drawing;
using System.Windows.Forms;
using NSGTransportManagement.Classes;
using WIA;
using System.IO;

namespace NSGTransportManagement.Forms
{
    public partial class frmDocumentScanner : Form
    {
        bool IsPhoto;
        bool CanClose = true;

        public frmDocumentScanner()
        {
            InitializeComponent();
        }

        public frmDocumentScanner(bool isPhoto)
        {
            IsPhoto = isPhoto;
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Scanner oScanner = new Scanner();
                ImageFile scannedImage = oScanner.Scann();

                var imageBytes = (byte[])scannedImage.FileData.get_BinaryData();
                var ms = new MemoryStream(imageBytes);
                
                pic_scan.Image = Image.FromStream(ms);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        private void Home_SizeChanged(object sender, EventArgs e)
        {
            //int pheight = this.Size.Height - 153;
            //pic_scan.Size = new Size(pheight - 150, pheight);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {   
            if (IsPhoto)
            {
                GlobalClass.VisitorImage = pic_scan.Image;
            }
            else
            {
                if (string.IsNullOrEmpty(txtDocumentName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the document name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CanClose = false;
                    return;
                }

                GlobalClass.CurrentDocumentName = txtDocumentName.Text;
                GlobalClass.CurrentDocument = pic_scan.Image;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDocumentScanner_Load(object sender, EventArgs e)
        {
            if(GlobalClass.CurrentDocumentName != string.Empty && GlobalClass.CurrentDocument != null)
            {
                btnScan.Enabled = false;
                btnEnter.Enabled = false;

                txtDocumentName.Text = GlobalClass.CurrentDocumentName;
                pic_scan.Image = GlobalClass.CurrentDocument;
            }

            if(IsPhoto)
            {
                txtDocumentName.Visible = false;
                lblDocumentName.Visible = false;
            }
        }

        private void frmDocumentScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!CanClose)
            {
                e.Cancel = true;
            }
            
            CanClose = true;
        }
    }
}
