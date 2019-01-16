using NSGTransportManagement.Classes;
using NSGTransportManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSGTransportManagement.Forms
{
    public partial class frmSchoolDetail : Form
    {
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();
        CoreSchool nsgSchool;
        long nsgSchoolId;
        
        public frmSchoolDetail(int schoolId)
        {
            nsgSchoolId = schoolId;
            InitializeComponent();
        }
        public frmSchoolDetail()
        {
            nsgSchoolId = 0;
            InitializeComponent();
        }

        private void frmSchoolDetail_Load(object sender, EventArgs e)
        {
            FillCombos();
            RefreshMe();
        }

        private void FillCombos()
        {
            var coreStates = DB.CoreStates.ToList();

            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "StateID";
            cmbState.DataSource = coreStates;
            cmbState.SelectedIndex = -1;
        }

        private void RefreshMe(bool reEntry = false)
        {
            if (reEntry)
            {
                nsgSchoolId = 0;
            }

            nsgSchool = null;

            txtSchoolName.Text = string.Empty;
            txtSchoolAddress.Text = string.Empty;
            txtAdminContactNumbers.Text = string.Empty;
            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            dtSummerDateFrom.Value = new DateTime(DateTime.Today.Year, 2, 1);
            dtSummerDateTo.Value = new DateTime(DateTime.Today.Year, 10, 31);
            dtSummerTimeFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
            dtSummerTimeTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 14, 0, 0);

            dtWinterDateFrom.Value = new DateTime(DateTime.Today.Year, 11, 1);
            dtWinterDateTo.Value = new DateTime(DateTime.Today.Year + 1, 1, 31);
            dtWinterTimeFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
            dtWinterTimeTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 15, 0, 0);

            txtDistanceFromGarage.Text = string.Empty;
            txtBusRoutes.Text = string.Empty;

            if (nsgSchoolId > 0)
            {
                this.Text = "School Detail [EDIT] - ";
                LoadData();
                btnDelete.Visible = true;
            }
            else
            {
                this.Text = "School Detail [ADD]";
                btnDelete.Visible = false;
            }
        }

        private void LoadData()
        {
            nsgSchool = DB.CoreSchools.Where(cs => cs.SchoolID == nsgSchoolId).FirstOrDefault();

            var busRoutes = (from cbr in DB.CoreBusRoutes
                             join cbrs in DB.CoreBusRouteSchools on cbr.BusRouteID equals cbrs.BusRouteID
                             where cbrs.SchoolID == nsgSchoolId
                             select cbr.RouteNo).ToArray();
            
            nsgSchoolId = nsgSchool.SchoolID;
            txtSchoolName.Text = nsgSchool.SchoolName;
            this.Text += nsgSchool.SchoolName;
            txtSchoolAddress.Text = nsgSchool.SchoolAddress;
            txtAdminContactNumbers.Text = nsgSchool.AdminContactNumbers;
            cmbState.SelectedValue = nsgSchool.StateID;
            cmbCity.SelectedValue = nsgSchool.CityID;
            dtSummerDateFrom.Value = nsgSchool.SummerTimingStart;
            dtSummerDateTo.Value = nsgSchool.SummerTimingEnd;
            dtSummerTimeFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, nsgSchool.SummerTimingFrom.Hours, nsgSchool.SummerTimingFrom.Minutes, nsgSchool.SummerTimingFrom.Seconds);
            dtSummerTimeTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, nsgSchool.SummerTimingTo.Hours, nsgSchool.SummerTimingTo.Minutes, nsgSchool.SummerTimingTo.Seconds);

            dtWinterDateFrom.Value = nsgSchool.WinterTimingStart;
            dtWinterDateTo.Value = nsgSchool.WinterTimingEnd;
            dtWinterTimeFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, nsgSchool.WinterTimingFrom.Hours, nsgSchool.WinterTimingFrom.Minutes, nsgSchool.WinterTimingFrom.Seconds);
            dtWinterTimeTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, nsgSchool.WinterTimingTo.Hours, nsgSchool.WinterTimingTo.Minutes, nsgSchool.WinterTimingTo.Seconds);

            txtDistanceFromGarage.Text = nsgSchool.DistanceFromGarage.ToString();

            if (busRoutes.Length > 0)
            {
                txtBusRoutes.Text = string.Join(", ", busRoutes);
            }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMainControls())
            {
                return;
            }

            try
            {
                if (nsgSchool == null)
                {
                    nsgSchool = new CoreSchool();
                    nsgSchool.EntryDate = DateTime.Now;
                    nsgSchool.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    nsgSchool.UpdateDate = DateTime.Now;
                    nsgSchool.UpdateUserID = GlobalClass.LoggedInUserID;
                }

                nsgSchool.SchoolName = txtSchoolName.Text;
                nsgSchool.SchoolAddress = txtSchoolAddress.Text;
                nsgSchool.StateID = int.Parse(cmbState.SelectedValue.ToString());
                nsgSchool.CityID = int.Parse(cmbCity.SelectedValue.ToString());
                nsgSchool.AdminContactNumbers = txtAdminContactNumbers.Text;

                nsgSchool.SummerTimingStart = dtSummerDateFrom.Value.Date;
                nsgSchool.SummerTimingEnd = dtSummerDateTo.Value.Date;
                nsgSchool.SummerTimingFrom = new TimeSpan(dtSummerTimeFrom.Value.Hour, dtSummerTimeFrom.Value.Minute, dtSummerTimeFrom.Value.Second);
                nsgSchool.SummerTimingTo = new TimeSpan(dtSummerTimeTo.Value.Hour, dtSummerTimeTo.Value.Minute, dtSummerTimeTo.Value.Second);

                nsgSchool.WinterTimingStart = dtWinterDateFrom.Value.Date;
                nsgSchool.WinterTimingEnd = dtWinterDateTo.Value.Date;
                nsgSchool.WinterTimingFrom = new TimeSpan(dtWinterTimeFrom.Value.Hour, dtWinterTimeFrom.Value.Minute, dtWinterTimeFrom.Value.Second);
                nsgSchool.WinterTimingTo = new TimeSpan(dtWinterTimeTo.Value.Hour, dtWinterTimeTo.Value.Minute, dtWinterTimeTo.Value.Second);

                nsgSchool.DistanceFromGarage = decimal.Parse(txtDistanceFromGarage.Text);

                if(nsgSchool.SchoolID == 0)
                {
                    DB.CoreSchools.Add(nsgSchool);
                }

                DB.SaveChanges();

                var msgResponse = MessageBox.Show("School details saved successfully. Do you want to continue with school entry?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (msgResponse == DialogResult.Yes)
                {
                    RefreshMe(true);
                }
                else
                {
                    btnClose_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, this.Text + " : btnSave_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateMainControls()
        {
            bool isDataValid = true;

            if(txtSchoolName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the School Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtSchoolAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the School Address.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (cmbState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the state.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (cmbCity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the city.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtAdminContactNumbers.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Admin Contact Numbers.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtDistanceFromGarage.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Distance From Garage.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            return isDataValid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Are you sure you want to delete this School?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgResult == DialogResult.Yes)
            {
                try
                {
                    DB.CoreSchools.Remove(nsgSchool);
                    DB.SaveChanges();

                    MessageBox.Show("School deleted successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnClose_Click(null, null);
                }
                catch
                {
                    MessageBox.Show("Unable to delete this School right now.\nIt might have linked records, please delete them first then try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
