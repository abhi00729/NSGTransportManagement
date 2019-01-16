using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSGTransportManagement.DAL;
using NSGTransportManagement.Classes;
using System.Configuration;

namespace NSGTransportManagement.Forms
{
    public partial class frmNSGPass : Form
    {
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();

        ImageConverter imgConverter = new ImageConverter();

        NSGPass nsgPass;
        CivilianPassDetail civilianPassDetail;
        GuestDependantPassDetail guestDependantPassDetail;
        VehiclePassDetail vehiclePassDetail;
        OutlivingPassDetail outlivingPassDetail;
        List<PassDocument> passDocuments;
        List<long> deletedDocuments = new List<long>();

        long nsgPassId;

        public frmNSGPass(long passId)
        {
            nsgPassId = passId;
            InitializeComponent();
        }

        public frmNSGPass()
        {
            nsgPassId = 0;
            InitializeComponent();
        }

        private void frmNSGPass_Load(object sender, EventArgs e)
        {
            FillCombos();
            RefreshMe();
        }

        private void LoadData()
        {
            nsgPass = DB.NSGPasses.Where(p => p.NSGPassID == nsgPassId).OrderByDescending(p => p.NSGPassID).FirstOrDefault();

            nsgPassId = nsgPass.NSGPassID;
            cmbPassType.SelectedValue = nsgPass.PassTypeID;
            txtFirstName.Text = nsgPass.FirstName;
            txtLastName.Text = nsgPass.LastName;
            cmbGender.Text = nsgPass.Gender;
            txtMobileNo.Text = nsgPass.MobileNo;
            txtGuardianName.Text = nsgPass.GuardianName;
            txtPassHolderAddress.Text = nsgPass.PassHolderAddress;
            cmbState.SelectedValue = nsgPass.StateID;
            cmbCity.SelectedValue = nsgPass.CityID;
            dteIssueDate.Value = nsgPass.IssueDate;
            dteExpiryDate.Value = Convert.ToDateTime(nsgPass.ExpiryDate);
            dteBirthDate.Value = Convert.ToDateTime(nsgPass.BirthDate);

            if (nsgPass.PassHolderPhoto.Length > 0)
            {
                picVisitorPhoto.Image = (Image)imgConverter.ConvertFrom(nsgPass.PassHolderPhoto);
            }

            switch (cmbPassType.Text)
            {
                case "Civilian Labour Pass":
                case "Civilian Regular Pass":
                    LoadCivilianPassDetail();
                    break;
                case "Dependent Pass":
                case "Guest Pass":
                    LoadGuestDependantPassDetail();
                    break;
                case "NSG Personal Vehicle Pass":
                case "Civilian Vehicle Pass":
                    LoadVehiclePassDetail();
                    break;
                case "Outliving Pass":
                    LoadOutlivingPassDetail();
                    break;
                default:
                    break;
            }

            LoadDocuments();
        }

        private void LoadDocuments()
        {
            dgvDocuments.Rows.Clear();

            passDocuments = DB.PassDocuments.Where(pd => pd.NSGPassID == nsgPassId).ToList();

            if (passDocuments != null)
            {
                foreach (var passDocument in passDocuments)
                {
                    dgvDocuments.Rows.Add(new[] { passDocument.PassDocumentID.ToString(), passDocument.DocumentName });
                }
            }
        }

        private void LoadCivilianPassDetail()
        {
            civilianPassDetail = DB.CivilianPassDetails.Where(cpd => cpd.NSGPassID == nsgPassId).FirstOrDefault();

            txtDesignation.Text = civilianPassDetail.Designation;
            txtContractorName.Text = civilianPassDetail.ContractorName;
        }

        private void LoadGuestDependantPassDetail()
        {
            guestDependantPassDetail = DB.GuestDependantPassDetails.Where(gdp => gdp.NSGPassID == nsgPassId).FirstOrDefault();

            txtIdentificationMark_Guest.Text = guestDependantPassDetail.IdentificationMark;
            txtRelativeOfName.Text = guestDependantPassDetail.RelativeOf;
            txtEmployeeId_Guest.Text = guestDependantPassDetail.NSGEmployeeCode;
            cmbRank_Guest.SelectedValue = guestDependantPassDetail.RankID;
            cmbUnit_Guest.SelectedValue = guestDependantPassDetail.UnitID;
            cmbRelationship.SelectedValue = guestDependantPassDetail.RelationshipID;
        }

        private void LoadVehiclePassDetail()
        {
            vehiclePassDetail = DB.VehiclePassDetails.Where(vpd => vpd.NSGPassID == nsgPassId).FirstOrDefault();

            txtRegistrationNumber.Text = vehiclePassDetail.RegistrationNumber;
            txtVehicleType.Text = vehiclePassDetail.VehicleType;
            txtVehicleMake.Text = vehiclePassDetail.VehicleMake;

            if (cmbPassType.Text == "NSG Personal Vehicle Pass")
            {
                txtEmployeeId_Vehicle.Text = vehiclePassDetail.NSGEmployeeCode;
                cmbRank_Vehicle.SelectedValue = vehiclePassDetail.RankID;
                cmbUnit_Vehicle.SelectedValue = vehiclePassDetail.UnitID;
            }
            else
            {
                txtDesignation_Vehicle.Text = vehiclePassDetail.Designation;
            }
        }

        private void LoadOutlivingPassDetail()
        {
            outlivingPassDetail = DB.OutlivingPassDetails.Where(opd => opd.NSGPassID == nsgPassId).FirstOrDefault();

            txtIdentificationMark_Outliving.Text = outlivingPassDetail.IdentificationMark;
            txtBloodGroup.Text = outlivingPassDetail.BloodGroup;
            txtEmployeeId_Outliving.Text = outlivingPassDetail.NSGEmployeeCode;
            cmbRank_Outliving.SelectedValue = outlivingPassDetail.RankID;
            cmbUnit_Outliving.SelectedValue = outlivingPassDetail.UnitID;
        }

        private void FillCombos()
        {
            var passTypes = DB.CorePassTypes.ToList();
            var coreRanks_Guest = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            var coreRanks_Vehicle = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            var coreRanks_Outliving = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            var coreUnits_Guest = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();
            var coreUnits_Outliving = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();
            var coreUnits_Vehicle = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();

            var coreStates = DB.CoreStates.ToList();
            var coreRelationships = DB.CoreRelationships.ToList();

            cmbPassType.DisplayMember = "PassTypeName";
            cmbPassType.ValueMember = "PassTypeID";
            cmbPassType.DataSource = passTypes;
            cmbPassType.SelectedIndex = -1;

            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "StateID";
            cmbState.DataSource = coreStates;
            cmbState.SelectedIndex = -1;

            cmbRank_Guest.DisplayMember = "RankName";
            cmbRank_Guest.ValueMember = "RankID";
            cmbRank_Guest.DataSource = coreRanks_Guest;
            cmbRank_Guest.SelectedIndex = -1;

            cmbUnit_Guest.DisplayMember = "UnitName";
            cmbUnit_Guest.ValueMember = "UnitID";
            cmbUnit_Guest.DataSource = coreUnits_Guest;
            cmbUnit_Guest.SelectedIndex = -1;

            cmbRank_Outliving.DisplayMember = "RankName";
            cmbRank_Outliving.ValueMember = "RankID";
            cmbRank_Outliving.DataSource = coreRanks_Outliving;
            cmbRank_Outliving.SelectedIndex = -1;

            cmbUnit_Outliving.DisplayMember = "UnitName";
            cmbUnit_Outliving.ValueMember = "UnitID";
            cmbUnit_Outliving.DataSource = coreUnits_Outliving;
            cmbUnit_Outliving.SelectedIndex = -1;

            cmbRank_Vehicle.DisplayMember = "RankName";
            cmbRank_Vehicle.ValueMember = "RankID";
            cmbRank_Vehicle.DataSource = coreRanks_Vehicle;
            cmbRank_Vehicle.SelectedIndex = -1;

            cmbUnit_Vehicle.DisplayMember = "UnitName";
            cmbUnit_Vehicle.ValueMember = "UnitID";
            cmbUnit_Vehicle.DataSource = coreUnits_Vehicle;
            cmbUnit_Vehicle.SelectedIndex = -1;

            cmbRelationship.DisplayMember = "Relationship";
            cmbRelationship.ValueMember = "RelationshipID";
            cmbRelationship.DataSource = coreRelationships;
            cmbRelationship.SelectedIndex = -1;

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

                    if (passDocuments == null)
                    {
                        passDocuments = new List<PassDocument>();
                    }

                    passDocuments.Add(new PassDocument() { EntryDate = DateTime.Now, EntryUserID = GlobalClass.LoggedInUserID, NSGPassID = nsgPassId, DocumentName = GlobalClass.CurrentDocumentName, DocumentPhoto = (byte[])imgConverter.ConvertTo(GlobalClass.CurrentDocument, typeof(byte[])) });

                    dgvDocuments.Rows.Add(new[] { "0", GlobalClass.CurrentDocumentName });
                }
            }
            else
            {
                openFileDialog.Filter = "JPG Files (*.jpg)";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image document = (Image)imgConverter.ConvertFrom((object)openFileDialog.OpenFile());

                    passDocuments.Add(new PassDocument() { EntryDate = DateTime.Now, EntryUserID = GlobalClass.LoggedInUserID, NSGPassID = nsgPassId, DocumentName = openFileDialog.FileName, DocumentPhoto = (byte[])imgConverter.ConvertTo(document, typeof(byte[])) });

                    dgvDocuments.Rows.Add(new[] { "0", openFileDialog.FileName });
                }
            }
        }

        private void cmbPassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPassType.SelectedIndex == -1)
            {
                return;
            }

            int passTypeID = int.Parse(cmbPassType.SelectedValue.ToString());

            CorePassType passType = DB.CorePassTypes.Where(pt => pt.PassTypeID == passTypeID).FirstOrDefault();

            grpCivilianPassDetail.BackColor = Color.Gray;
            grpCivilianPassDetail.Enabled = false;

            grpGuestDependantPassDetail.BackColor = Color.Gray;
            grpGuestDependantPassDetail.Enabled = false;

            grpOutlivingPassDetail.BackColor = Color.Gray;
            grpOutlivingPassDetail.Enabled = false;

            grpVehiclePassDetail.BackColor = Color.Gray;
            grpVehiclePassDetail.Enabled = false;

            Color detailColor = Color.LightGreen;

            switch (passType.PassTypeName)
            {
                case "Civilian Labour Pass":
                case "Civilian Regular Pass":
                    grpCivilianPassDetail.BackColor = detailColor;
                    grpCivilianPassDetail.Enabled = true;
                    break;
                case "Dependent Pass":
                case "Guest Pass":
                    grpGuestDependantPassDetail.BackColor = detailColor;
                    grpGuestDependantPassDetail.Enabled = true;
                    break;
                case "NSG Personal Vehicle Pass":
                case "Civilian Vehicle Pass":
                    grpVehiclePassDetail.BackColor = detailColor;
                    grpVehiclePassDetail.Enabled = true;
                    break;
                case "Outliving Pass":
                    grpOutlivingPassDetail.BackColor = detailColor;
                    grpOutlivingPassDetail.Enabled = true;
                    break;
                default:
                    break;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            object reportDataSource = null;

            string reportName = cmbPassType.Text.Replace(" ", "");

            switch (cmbPassType.Text)
            {
                case "Civilian Labour Pass":
                case "Civilian Regular Pass":
                    reportDataSource = DB.CivilianPassDetailViews.Where(clp => clp.NSGPassID == nsgPassId).FirstOrDefault();
                    break;
                case "Dependent Pass":
                case "Guest Pass":
                    reportDataSource = DB.GuestDependentPassDetailViews.Where(gdpd => gdpd.NSGPassID == nsgPassId).FirstOrDefault();
                    break;
                case "NSG Personal Vehicle Pass":
                    reportDataSource = DB.NSGPersonalVehiclePassViews.Where(npv => npv.NSGPassID == nsgPassId).FirstOrDefault();
                    break;
                case "Civilian Vehicle Pass":
                    reportDataSource = DB.CivilianVehiclePassViews.Where(cvp => cvp.NSGPassID == nsgPassId).FirstOrDefault();
                    break;
                case "Outliving Pass":
                    reportDataSource = DB.OutlivingPassViews.Where(opv => opv.NSGPassID == nsgPassId).FirstOrDefault();
                    break;
                default:
                    break;
            }

            frmReportViewer reportViewer = new frmReportViewer(reportName, reportDataSource);
            reportViewer.MdiParent = this.MdiParent;
            reportViewer.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbState.SelectedIndex > -1)
            {
                var coreCities = DB.CoreCities.Where(cc => cc.StateID.ToString() == cmbState.SelectedValue.ToString()).ToList();

                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityID";
                cmbCity.DataSource = coreCities;
                cmbCity.SelectedIndex = -1;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isDetailsValid = true;

            if (!ValidateMainControls())
            {
                return;
            }

            switch (cmbPassType.Text)
            {
                case "Civilian Labour Pass":
                case "Civilian Regular Pass":
                    isDetailsValid = ValidateCivilialPass();
                    break;
                case "Dependent Pass":
                case "Guest Pass":
                    isDetailsValid = ValidateDependentGuestPass();
                    break;
                case "NSG Personal Vehicle Pass":
                case "Civilian Vehicle Pass":
                    isDetailsValid = ValidateVehiclePass();
                    break;
                case "Outliving Pass":
                    isDetailsValid = ValidateOutlivingPass();
                    break;
                default:
                    break;
            }

            if (!isDetailsValid)
            {
                return;
            }

            try
            {
                if (nsgPass == null)
                {
                    nsgPass = new NSGPass();
                    nsgPass.EntryDate = DateTime.Now;
                    nsgPass.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    nsgPass.UpdateDate = DateTime.Now;
                    nsgPass.UpdateUserID = GlobalClass.LoggedInUserID;
                }

                nsgPass.PassTypeID = Convert.ToInt16(cmbPassType.SelectedValue);
                nsgPass.MachineID = GlobalClass.MachineName;
                nsgPass.FirstName = txtFirstName.Text;
                nsgPass.LastName = txtLastName.Text;
                nsgPass.BirthDate = dteBirthDate.Value;
                nsgPass.Gender = cmbGender.Text;
                nsgPass.MobileNo = txtMobileNo.Text;
                nsgPass.GuardianName = txtGuardianName.Text;
                nsgPass.IssueDate = dteIssueDate.Value;
                nsgPass.ExpiryDate = dteExpiryDate.Value;
                nsgPass.PassHolderAddress = txtPassHolderAddress.Text;
                nsgPass.CityID = Convert.ToInt16(cmbCity.SelectedValue);
                nsgPass.StateID = Convert.ToInt16(cmbState.SelectedValue);

                byte[] passHolderImage = (byte[])imgConverter.ConvertTo(picVisitorPhoto.Image, typeof(byte[]));
                nsgPass.PassHolderPhoto = passHolderImage;

                if (nsgPass.NSGPassID == 0)
                {
                    DB.NSGPasses.Add(nsgPass);
                }

                DB.SaveChanges();

                nsgPassId = nsgPass.NSGPassID;

                switch (cmbPassType.Text)
                {
                    case "Civilian Labour Pass":
                    case "Civilian Regular Pass":
                        SaveCivilialPass();
                        break;
                    case "Dependent Pass":
                    case "Guest Pass":
                        SaveDependentGuestPass();
                        break;
                    case "NSG Personal Vehicle Pass":
                    case "Civilian Vehicle Pass":
                        SaveVehiclePass();
                        break;
                    case "Outliving Pass":
                        SaveOutlivingPass();
                        break;
                    default:
                        break;
                }

                SaveDocuments();

                DialogResult msgResponse = MessageBox.Show("Pass information saved successfully.\nDo you want to continue with Print?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

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

        private void SaveCivilialPass()
        {
            if (civilianPassDetail == null)
            {
                civilianPassDetail = new CivilianPassDetail();
                civilianPassDetail.NSGPassID = nsgPassId;
                civilianPassDetail.EntryDate = DateTime.Now;
                civilianPassDetail.EntryUserID = GlobalClass.LoggedInUserID;
            }
            else
            {
                civilianPassDetail.UpdateDate = DateTime.Now;
                civilianPassDetail.UpdateUserID = GlobalClass.LoggedInUserID;
            }

            civilianPassDetail.Designation = txtDesignation.Text;
            civilianPassDetail.ContractorName = txtContractorName.Text;

            if (civilianPassDetail.CivilianPassDetailID == 0)
            {
                DB.CivilianPassDetails.Add(civilianPassDetail);
            }

            DB.SaveChanges();
        }

        private void SaveDependentGuestPass()
        {
            if (guestDependantPassDetail == null)
            {
                guestDependantPassDetail = new GuestDependantPassDetail();
                guestDependantPassDetail.NSGPassID = nsgPassId;
                guestDependantPassDetail.EntryDate = DateTime.Now;
                guestDependantPassDetail.EntryUserID = GlobalClass.LoggedInUserID;
            }
            else
            {
                guestDependantPassDetail.UpdateDate = DateTime.Now;
                guestDependantPassDetail.UpdateUserID = GlobalClass.LoggedInUserID;
            }

            guestDependantPassDetail.IdentificationMark = txtIdentificationMark_Guest.Text;
            guestDependantPassDetail.RelativeOf = txtRelativeOfName.Text;
            guestDependantPassDetail.NSGEmployeeCode = txtEmployeeId_Guest.Text;
            guestDependantPassDetail.RankID = Convert.ToInt16(cmbRank_Guest.SelectedValue);
            guestDependantPassDetail.UnitID = Convert.ToInt16(cmbUnit_Guest.SelectedValue);
            guestDependantPassDetail.RelationshipID = Convert.ToInt16(cmbRelationship.SelectedValue);

            if (guestDependantPassDetail.GuestDependantPassDetailID == 0)
            {
                DB.GuestDependantPassDetails.Add(guestDependantPassDetail);
            }

            DB.SaveChanges();
        }

        private void SaveVehiclePass()
        {
            try
            {
                if (vehiclePassDetail == null)
                {
                    vehiclePassDetail = new VehiclePassDetail();
                    vehiclePassDetail.NSGPassID = nsgPassId;
                    vehiclePassDetail.EntryDate = DateTime.Now;
                    vehiclePassDetail.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    vehiclePassDetail.UpdateDate = DateTime.Now;
                    vehiclePassDetail.UpdateUserID = GlobalClass.LoggedInUserID;
                }

                vehiclePassDetail.RegistrationNumber = txtRegistrationNumber.Text;
                vehiclePassDetail.VehicleType = txtVehicleType.Text;
                vehiclePassDetail.VehicleMake = txtVehicleMake.Text;

                if (cmbPassType.Text == "NSG Personal Vehicle Pass")
                {
                    vehiclePassDetail.NSGEmployeeCode = txtEmployeeId_Vehicle.Text;
                    vehiclePassDetail.RankID = Convert.ToInt16(cmbRank_Vehicle.SelectedValue);
                    vehiclePassDetail.UnitID = Convert.ToInt16(cmbUnit_Vehicle.SelectedValue);
                }
                else
                {
                    vehiclePassDetail.Designation = txtDesignation_Vehicle.Text;
                }

                if (vehiclePassDetail.VehiclePassDetailID == 0)
                {
                    DB.VehiclePassDetails.Add(vehiclePassDetail);
                }

                DB.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, this.Text + " : SaveVehiclePass : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOutlivingPass()
        {
            if (outlivingPassDetail == null)
            {
                outlivingPassDetail = new OutlivingPassDetail();
                outlivingPassDetail.NSGPassID = nsgPassId;
                outlivingPassDetail.EntryDate = DateTime.Now;
                outlivingPassDetail.EntryUserID = GlobalClass.LoggedInUserID;
            }
            else
            {
                outlivingPassDetail.UpdateDate = DateTime.Now;
                outlivingPassDetail.UpdateUserID = GlobalClass.LoggedInUserID;
            }

            outlivingPassDetail.IdentificationMark = txtIdentificationMark_Outliving.Text;
            outlivingPassDetail.BloodGroup = txtBloodGroup.Text;
            outlivingPassDetail.NSGEmployeeCode = txtEmployeeId_Outliving.Text;
            outlivingPassDetail.RankID = Convert.ToInt16(cmbRank_Outliving.SelectedValue);
            outlivingPassDetail.UnitID = Convert.ToInt16(cmbUnit_Outliving.SelectedValue);

            if (outlivingPassDetail.OutlivingPassDetailID == 0)
            {
                DB.OutlivingPassDetails.Add(outlivingPassDetail);
            }

            DB.SaveChanges();
        }

        private void SaveDocuments()
        {
            List<PassDocument> documentsToDelete = new List<PassDocument>();

            foreach (long id in deletedDocuments)
            {
                PassDocument passDocument = passDocuments.Where(pd => pd.PassDocumentID == id).FirstOrDefault();
                documentsToDelete.Add(passDocument);
                passDocuments.Remove(passDocument);
            }

            if (documentsToDelete.Any())
            {
                DB.PassDocuments.RemoveRange(documentsToDelete);
            }

            foreach (PassDocument passDocument in passDocuments.Where(pd => pd.PassDocumentID == 0).ToList())
            {
                passDocument.NSGPassID = nsgPassId;
                DB.PassDocuments.Add(passDocument);
            }

            DB.SaveChanges();
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

            if (string.IsNullOrEmpty(txtGuardianName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Father's Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Gender.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (txtMobileNo.Text.Length > 0 && txtMobileNo.Text.Length < 10)
            {
                MessageBox.Show("Please enter valid Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtPassHolderAddress.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Visitor Address.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbState.SelectedIndex < 0)
            {
                MessageBox.Show("Please select State.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool ValidateCivilialPass()
        {
            bool dataIsValid = true;

            if (string.IsNullOrEmpty(txtDesignation.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Designation.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtContractorName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Contractor Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            return dataIsValid;
        }

        private bool ValidateDependentGuestPass()
        {
            bool dataIsValid = true;

            if (string.IsNullOrEmpty(txtIdentificationMark_Guest.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Registration Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtRelativeOfName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Relative Of Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtEmployeeId_Guest.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Employee ID.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRank_Guest.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbUnit_Guest.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRelationship.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Relationship.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            return dataIsValid;
        }

        private bool ValidateVehiclePass()
        {
            bool dataIsValid = true;

            if (string.IsNullOrEmpty(txtRegistrationNumber.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Registration Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtVehicleType.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Vehicle Type.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtVehicleMake.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Vehicle Make.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbPassType.Text == "NSG Personal Vehicle Pass")
            {
                if (string.IsNullOrEmpty(txtEmployeeId_Vehicle.Text.TrimEnd()))
                {
                    MessageBox.Show("Please enter the Employee ID.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataIsValid = false;
                }

                if (cmbRank_Vehicle.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataIsValid = false;
                }

                if (cmbUnit_Vehicle.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataIsValid = false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtDesignation_Vehicle.Text.TrimEnd()))
                {
                    MessageBox.Show("Please enter the Designation.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataIsValid = false;
                }
            }

            return dataIsValid;
        }

        private bool ValidateOutlivingPass()
        {
            bool dataIsValid = true;

            if (string.IsNullOrEmpty(txtIdentificationMark_Outliving.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Registration Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtBloodGroup.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Blood Group.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtEmployeeId_Outliving.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Employee ID.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRank_Outliving.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbUnit_Outliving.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            return dataIsValid;
        }

        private void RefreshMe(bool reEntry = false)
        {
            if (reEntry)
            {
                nsgPassId = 0;
            }

            nsgPass = null;
            civilianPassDetail = null;
            guestDependantPassDetail = null;
            vehiclePassDetail = null;
            outlivingPassDetail = null;
            passDocuments = null;

            cmbPassType.SelectedIndex = -1;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            txtMobileNo.Text = string.Empty;
            txtGuardianName.Text = string.Empty;
            txtPassHolderAddress.Text = string.Empty;
            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;

            dteIssueDate.Value = DateTime.Today;
            dteExpiryDate.Value = DateTime.Today.AddDays(30);

            dteBirthDate.Value = DateTime.Today;

            txtDesignation.Text = string.Empty;
            txtContractorName.Text = string.Empty;

            txtIdentificationMark_Guest.Text = string.Empty;
            txtRelativeOfName.Text = string.Empty;
            txtEmployeeId_Guest.Text = string.Empty;
            cmbRank_Guest.SelectedIndex = -1;
            cmbUnit_Guest.SelectedIndex = -1;
            cmbRelationship.SelectedIndex = -1;

            txtRegistrationNumber.Text = string.Empty;
            txtVehicleType.Text = string.Empty;
            txtVehicleMake.Text = string.Empty;
            txtEmployeeId_Vehicle.Text = string.Empty;
            cmbRank_Vehicle.SelectedIndex = -1;
            cmbUnit_Vehicle.SelectedIndex = -1;

            txtIdentificationMark_Outliving.Text = string.Empty;
            txtBloodGroup.Text = string.Empty;
            txtEmployeeId_Outliving.Text = string.Empty;
            cmbRank_Outliving.SelectedIndex = -1;
            cmbUnit_Outliving.SelectedIndex = -1;

            picVisitorPhoto.Image = null;

            grpCivilianPassDetail.BackColor = Color.Gray;
            grpCivilianPassDetail.Enabled = false;

            grpGuestDependantPassDetail.BackColor = Color.Gray;
            grpGuestDependantPassDetail.Enabled = false;

            grpOutlivingPassDetail.BackColor = Color.Gray;
            grpOutlivingPassDetail.Enabled = false;

            grpVehiclePassDetail.BackColor = Color.Gray;
            grpVehiclePassDetail.Enabled = false;


            if (nsgPassId > 0)
            {
                LoadData();
                this.Text = "NSG Pass [EDIT] - " + (nsgPassId).ToString().PadLeft(6, '0');
            }
            else
            {
                var nsgLastPass = DB.NSGPasses.OrderByDescending(p => p.NSGPassID).FirstOrDefault();

                if (nsgLastPass == null)
                {
                    this.Text = "NSG Pass [ADD] - 000001";
                }
                else
                {
                    this.Text = "NSG Pass [ADD] - " + (nsgLastPass.NSGPassID + 1).ToString().PadLeft(6, '0');
                }

                dteIssueDate.Value = DateTime.Today;
                dteExpiryDate.Value = DateTime.Today.AddDays(30);
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
                GlobalClass.CurrentDocument = (Image)imgConverter.ConvertFrom(passDocuments.Where(pd => pd.DocumentName == senderGrid.Rows[e.RowIndex].Cells["DocumentName"].Value.ToString()).FirstOrDefault().DocumentPhoto);

                frmDocumentScanner documentScanner = new frmDocumentScanner();
                documentScanner.ShowDialog();
            }
        }

        private void dgvDocuments_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["DocumentName"].Value != null)
            {
                var passDocument = passDocuments.Where(pd => pd.DocumentName == e.Row.Cells["DocumentName"].Value.ToString()).FirstOrDefault();
                if (passDocument.PassDocumentID > 0)
                {
                    deletedDocuments.Add(passDocument.PassDocumentID);
                }
            }
        }
    }
}
