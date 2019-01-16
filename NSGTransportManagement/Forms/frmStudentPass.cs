using NSGTransportManagement.Classes;
using NSGTransportManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSGTransportManagement.Forms
{
    public partial class frmStudentPass : Form
    {
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();
        ImageConverter imgConverter = new ImageConverter();
        List<NSGStudentDocument> studentDocuments;
        NSGStudent nsgStudent;

        List<PickDropLocationDetail> currentPickDropLocations;

        long nsgStudentId;
        bool loading = false;
        List<long> deletedDocuments = new List<long>();

        public frmStudentPass()
        {
            nsgStudentId = 0;
            InitializeComponent();
        }
        public frmStudentPass(int studentId)
        {
            nsgStudentId = studentId;
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmCapturePhoto")
                {
                    form.Activate();
                    return;
                }
            }

            GlobalClass.VisitorImage = null;
            frmCapturePhoto capturePhoto = new frmCapturePhoto();

            DialogResult capturePhotoResult = capturePhoto.ShowDialog();

            if (capturePhotoResult == DialogResult.OK)
            {
                if (GlobalClass.VisitorImage == null)
                {
                    MessageBox.Show("Please Capture Photo Again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                picVisitorPhoto.Image = GlobalClass.VisitorImage;
            }
        }

        private void frmStudentPass_Load(object sender, EventArgs e)
        {
            LoadCombos();
            RefreshMe();
        }

        private void LoadCombos()
        {
            loading = true;

            var nsgSchoools = DB.CoreSchools.ToList();

            cmbSchool.DisplayMember = "SchoolName";
            cmbSchool.ValueMember = "SchoolID";
            cmbSchool.DataSource = nsgSchoools;
            cmbSchool.SelectedIndex = -1;

            var coreRanks = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            
            cmbRank.DisplayMember = "RankName";
            cmbRank.ValueMember = "RankID";
            cmbRank.DataSource = coreRanks;
            cmbRank.SelectedIndex = -1;

            var coreUnits = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();

            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = coreUnits;
            cmbUnit.SelectedIndex = -1;

            var coreQuarterTypes = DB.CoreQuarterTypes.Where(qt => qt.IsActive == true).ToList();

            cmbQuarterType.DisplayMember = "QuarterTypeName";
            cmbQuarterType.ValueMember = "QuarterTypeID";
            cmbQuarterType.DataSource = coreQuarterTypes;
            cmbQuarterType.SelectedIndex = -1;

            var coreRelationships = DB.CoreRelationships.ToList();

            cmbRelationship.DisplayMember = "Relationship";
            cmbRelationship.ValueMember = "RelationshipID";
            cmbRelationship.DataSource = coreRelationships;
            cmbRelationship.SelectedIndex = -1;

            loading = false;
        }

        private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loading)
            {
                return;
            }

            if (cmbSchool.SelectedIndex == -1)
            {
                cmbBusRouteNumber.SelectedIndex = -1;
            }
            else
            {
                long schoolID = long.Parse(cmbSchool.SelectedValue.ToString());

                var busRoutes = (from br in DB.CoreBusRoutes
                                 join sr in DB.CoreBusRouteSchools on br.BusRouteID equals sr.BusRouteID
                                 where sr.SchoolID == schoolID
                                 select new
                                 {
                                     br.BusRouteID,
                                     br.RouteNo
                                 }).ToList();

                cmbBusRouteNumber.DisplayMember = "RouteNo";
                cmbBusRouteNumber.ValueMember = "BusRouteID";
                cmbBusRouteNumber.DataSource = busRoutes;
                cmbBusRouteNumber.SelectedIndex = -1;
            }

        }

        private void cmbBusRouteNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                return;
            }

            if (cmbBusRouteNumber.SelectedIndex == -1)
            {
                cmbPickupPoint.SelectedIndex = -1;
            }
            else
            {
                long busRouteId = long.Parse(cmbBusRouteNumber.SelectedValue.ToString());

                currentPickDropLocations = (from brd in DB.CoreBusRouteDetails
                                            where brd.BusRouteID == busRouteId
                                            select new PickDropLocationDetail()
                                            {
                                                BusRouteDetailID = brd.BusRouteDetailID,
                                                Location = brd.BusStopName,
                                                PickupTime = brd.PickUpTime,
                                                DropTime = brd.DropTime
                                            }).ToList();

                cmbPickupPoint.DisplayMember = "Location";
                cmbPickupPoint.ValueMember = "BusRouteDetailID";
                cmbPickupPoint.DataSource = currentPickDropLocations;
                cmbPickupPoint.SelectedIndex = -1;
            }
        }

        private void cmbPickupPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                return;
            }

            if (cmbPickupPoint.SelectedIndex == -1)
            {
                txtPickTime.Text = string.Empty;
                txtDropTime.Text = string.Empty;
            }
            else
            {
                long busRouteDetailId = long.Parse(cmbPickupPoint.SelectedValue.ToString());

                var selectedPickDropLocation = currentPickDropLocations.Where(l => l.BusRouteDetailID == busRouteDetailId).FirstOrDefault();

                txtPickTime.Text = selectedPickDropLocation.PickupTime;
                txtDropTime.Text = selectedPickDropLocation.DropTime;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScanDoc_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmDocumentScanner")
                {
                    form.Activate();
                    return;
                }
            }

            if (bool.Parse(ConfigurationManager.AppSettings["UseScanner"].ToString()))
            {
                GlobalClass.CurrentDocument = null;
                GlobalClass.CurrentDocumentName = string.Empty;

                frmDocumentScanner documentScanner = new frmDocumentScanner();

                DialogResult docScanResult = documentScanner.ShowDialog();

                if (docScanResult == DialogResult.OK)
                {
                    if (GlobalClass.CurrentDocument == null)
                    {
                        MessageBox.Show("Please scan document again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (studentDocuments == null)
                    {
                        studentDocuments = new List<NSGStudentDocument>();
                    }

                    studentDocuments.Add(new NSGStudentDocument()
                    {
                        EntryDate = DateTime.Now,
                        EntryUserID = GlobalClass.LoggedInUserID,
                        NSGStudentID = nsgStudentId,
                        DocumentName = GlobalClass.CurrentDocumentName,
                        DocumentPhoto = (byte[])imgConverter.ConvertTo(GlobalClass.CurrentDocument, typeof(byte[]))
                    });

                    dgvDocuments.Rows.Add(new[] { "0", GlobalClass.CurrentDocumentName });
                }
            }
            else
            {
                openFileDialog.Title = "Open Images";
                openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image document = new Bitmap(openFileDialog.FileName);

                    if (studentDocuments == null)
                    {
                        studentDocuments = new List<NSGStudentDocument>();
                    }

                    studentDocuments.Add(new NSGStudentDocument()
                    {
                        EntryDate = DateTime.Now,
                        EntryUserID = GlobalClass.LoggedInUserID,
                        NSGStudentID = nsgStudentId,
                        DocumentName = openFileDialog.SafeFileName,
                        DocumentPhoto = (byte[])imgConverter.ConvertTo(document, typeof(byte[]))
                    });

                    dgvDocuments.Rows.Add(new[] { "0", openFileDialog.SafeFileName });
                }
            }
        }

        private void LoadData()
        {
            nsgStudent = DB.NSGStudents.Where(s => s.NSGStudentID == nsgStudentId).FirstOrDefault();
            
            txtFirstName.Text = nsgStudent.FirstName;
            txtLastName.Text = nsgStudent.LastName;
            cmbGender.Text = nsgStudent.Gender;
            cmbClass.Text = nsgStudent.Class;
            cmbSchool.SelectedValue = nsgStudent.SchoolID;
            cmbBusRouteNumber.SelectedValue = nsgStudent.BusRouteID;
            cmbPickupPoint.SelectedValue = nsgStudent.BusRouteDetailID;
            txtGuardianName.Text = nsgStudent.GuardianName;
            txtMobileNo.Text = nsgStudent.MobileNo;
            cmbRelationship.SelectedValue = nsgStudent.RelationshipID;
            txtEmployeeId.Text = nsgStudent.NSGEmployeeCode;
            cmbRank.SelectedValue = nsgStudent.RankID;
            cmbUnit.SelectedValue = nsgStudent.UnitID;
            cmbQuarterType.SelectedValue = nsgStudent.QuarterTypeID;
            txtQuarterNumber.Text = nsgStudent.QuarterNumber.ToString();
            dteIssueDate.Value = nsgStudent.IssueDate;
            dteExpiryDate.Value = Convert.ToDateTime(nsgStudent.ExpiryDate);
            dteBirthDate.Value = nsgStudent.BirthDate;

            chkActive.Checked = nsgStudent.IsActive;

            if (nsgStudent.PassHolderPhoto.Length > 0)
            {
                picVisitorPhoto.Image = (Image)imgConverter.ConvertFrom(nsgStudent.PassHolderPhoto);
            }

            LoadDocuments();
        }

        private void LoadDocuments()
        {
            dgvDocuments.Rows.Clear();

            studentDocuments = DB.NSGStudentDocuments.Where(pd => pd.NSGStudentID == nsgStudentId).ToList();

            if (studentDocuments != null)
            {
                foreach (var studentDocument in studentDocuments)
                {
                    dgvDocuments.Rows.Add(new[] { studentDocument.NSGStudentID.ToString(), studentDocument.DocumentName });
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            object reportDataSource = null;

            reportDataSource = DB.StudentPassDetailViews.Where(opv => opv.PassId == nsgStudentId).FirstOrDefault();

            frmReportViewer reportViewer = new frmReportViewer("NSGStudentBusPass", reportDataSource);
            reportViewer.MdiParent = this.MdiParent;
            reportViewer.Show();
        }

        private void SaveDocuments()
        {
            List<NSGStudentDocument> documentsToDelete = new List<NSGStudentDocument>();

            foreach (long id in deletedDocuments)
            {
                NSGStudentDocument studentDocument = studentDocuments.Where(pd => pd.NSGStudentDocumentID == id).FirstOrDefault();
                documentsToDelete.Add(studentDocument);
                studentDocuments.Remove(studentDocument);
            }

            if (documentsToDelete.Any())
            {
                DB.NSGStudentDocuments.RemoveRange(documentsToDelete);
            }

            if (studentDocuments != null)
            {
                foreach (NSGStudentDocument studentDocument in studentDocuments.Where(pd => pd.NSGStudentDocumentID == 0).ToList())
                {
                    studentDocument.NSGStudentID = nsgStudentId;
                    DB.NSGStudentDocuments.Add(studentDocument);
                }
            }

            DB.SaveChanges();
        }

        private void RefreshMe(bool reEntry = false)
        {
            if (reEntry)
            {
                nsgStudentId = 0;
            }

            nsgStudent = null;
            studentDocuments = null;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbSchool.SelectedIndex = -1;

            txtGuardianName.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            cmbRelationship.SelectedIndex = -1;
            txtEmployeeId.Text = string.Empty;
            cmbRank.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
            cmbQuarterType.SelectedIndex = -1;
            txtQuarterNumber.Text = string.Empty;

            dteIssueDate.Value = DateTime.Today;
            dteExpiryDate.Value = new DateTime(DateTime.Today.Year + 1, 3, 31);

            dteBirthDate.Value = DateTime.Today;

            chkActive.Checked = true;

            picVisitorPhoto.Image = null;
                        
            if (nsgStudentId > 0)
            {
                LoadData();
                this.Text = "NSG Pass [EDIT] - " + (nsgStudentId).ToString().PadLeft(6, '0');
            }
            else
            {
                var nsgLastStudent = DB.NSGStudents.OrderByDescending(s => s.NSGStudentID).FirstOrDefault();

                if (nsgLastStudent == null)
                {
                    this.Text = "NSG Pass [ADD] - 000001";
                }
                else
                {
                    this.Text = "NSG Pass [ADD] - " + (nsgLastStudent.NSGStudentID + 1).ToString().PadLeft(6, '0');
                }
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateTextIsNumeric(txtMobileNo, e);
        }

        private void dgvDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                GlobalClass.CurrentDocumentName = senderGrid.Rows[e.RowIndex].Cells["DocumentName"].Value.ToString();
                GlobalClass.CurrentDocument = (Image)imgConverter.ConvertFrom(studentDocuments.Where(pd => pd.DocumentName == senderGrid.Rows[e.RowIndex].Cells["DocumentName"].Value.ToString()).FirstOrDefault().DocumentPhoto);

                frmDocumentScanner documentScanner = new frmDocumentScanner();
                documentScanner.ShowDialog();
            }
        }

        private void dgvDocuments_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["DocumentName"].Value != null)
            {
                var studentDocument = studentDocuments.Where(pd => pd.DocumentName == e.Row.Cells["DocumentName"].Value.ToString()).FirstOrDefault();
                if (studentDocument.NSGStudentDocumentID > 0)
                {
                    deletedDocuments.Add(studentDocument.NSGStudentDocumentID);
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!ValidateMainControls())
            {
                return;
            }
            
            try
            {
                if (nsgStudent == null)
                {
                    nsgStudent = new NSGStudent();
                    nsgStudent.EntryDate = DateTime.Now;
                    nsgStudent.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    nsgStudent.UpdateDate = DateTime.Now;
                    nsgStudent.UpdateUserID = GlobalClass.LoggedInUserID;
                }
                
                nsgStudent.FirstName = txtFirstName.Text;
                nsgStudent.LastName = txtLastName.Text;
                nsgStudent.BirthDate = dteBirthDate.Value;

                nsgStudent.Gender = cmbGender.Text;
                nsgStudent.Class = cmbClass.Text;
                nsgStudent.SchoolID = Convert.ToInt16(cmbSchool.SelectedValue);
                nsgStudent.BusRouteID = Convert.ToInt16(cmbBusRouteNumber.SelectedValue);
                nsgStudent.BusRouteDetailID = Convert.ToInt16(cmbPickupPoint.SelectedValue);

                nsgStudent.GuardianName = txtGuardianName.Text;
                nsgStudent.MobileNo = txtMobileNo.Text;
                nsgStudent.RelationshipID = Convert.ToInt16(cmbRelationship.SelectedValue);
                nsgStudent.NSGEmployeeCode = txtEmployeeId.Text;

                nsgStudent.RankID = Convert.ToInt16(cmbRank.SelectedValue);
                nsgStudent.UnitID = Convert.ToInt16(cmbUnit.SelectedValue);
                nsgStudent.QuarterTypeID = Convert.ToInt16(cmbQuarterType.SelectedValue);
                nsgStudent.QuarterNumber = Convert.ToInt16(txtQuarterNumber.Text);

                nsgStudent.IssueDate = dteIssueDate.Value;
                nsgStudent.ExpiryDate = dteExpiryDate.Value;
                nsgStudent.IsActive = chkActive.Checked;

                byte[] passHolderImage = (byte[])imgConverter.ConvertTo(picVisitorPhoto.Image, typeof(byte[]));

                nsgStudent.PassHolderPhoto = passHolderImage;

                if (nsgStudent.NSGStudentID == 0)
                {
                    DB.NSGStudents.Add(nsgStudent);
                }

                DB.SaveChanges();

                nsgStudentId = nsgStudent.NSGStudentID;

                SaveDocuments();

                DialogResult msgResponse = MessageBox.Show("Student Pass information saved successfully.\nDo you want to continue with Print?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (msgResponse == DialogResult.Yes)
                {
                    btnPrint_Click(null, null);
                }

                msgResponse = MessageBox.Show("Do you want to continue with Pass Entry?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (msgResponse == DialogResult.Yes)
                {
                    RefreshMe(true);
                }
                else
                {
                    btnCancel_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, this.Text + " : btnEnter_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateMainControls()
        {
            bool dataIsValid = true;

            if (picVisitorPhoto.Image == null)
            {
                MessageBox.Show("Please capture the Photo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the First Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Last Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Gender.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Class.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbSchool.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the School.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbBusRouteNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Bus Route Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbPickupPoint.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Pickup Point.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtGuardianName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Guardian Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (txtMobileNo.Text.Length > 0 && txtMobileNo.Text.Length < 10)
            {
                MessageBox.Show("Please enter valid Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRelationship.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Relationship.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }
            
            if (string.IsNullOrEmpty(txtEmployeeId.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the NSG Employee Code.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRank.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbQuarterType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Quarter Type.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtQuarterNumber.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Quarter Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            string Message = Validation.ValidateDateSelection(dteIssueDate, dteExpiryDate);

            if (Message != String.Empty)
            {
                MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataIsValid = false;
            }

            return dataIsValid;
        }

        private void btnScanPic_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmDocumentScanner")
                {
                    form.Close();
                    return;
                }
            }
            
            if (bool.Parse(ConfigurationManager.AppSettings["UseScanner"].ToString()))
            {
                GlobalClass.VisitorImage = null;

                GlobalClass.CurrentDocument = null;
                GlobalClass.CurrentDocumentName = string.Empty;

                frmDocumentScanner documentScanner = new frmDocumentScanner(true);

                DialogResult docScanResult = documentScanner.ShowDialog();

                if (docScanResult == DialogResult.OK)
                {
                    if (GlobalClass.VisitorImage == null)
                    {
                        MessageBox.Show("Please scan image again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    picVisitorPhoto.Image = GlobalClass.VisitorImage;
                }
            }
            else
            {
                openFileDialog.Title = "Open Images";
                openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picVisitorPhoto.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
    }

    class PickDropLocationDetail
    {
        public long BusRouteDetailID { get; set; }
        public string Location { get; set; }
        public string PickupTime { get; set; }
        public string DropTime { get; set; }
    }
}
