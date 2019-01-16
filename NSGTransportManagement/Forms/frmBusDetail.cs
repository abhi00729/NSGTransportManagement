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
    public partial class frmBusDetail : Form
    {
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();
        CoreBus nsgBus;
        long nsgBusId = 0;
        bool loading = false;
        public frmBusDetail()
        {
            InitializeComponent();
        }

        public frmBusDetail(long busId)
        {
            nsgBusId = busId;
            InitializeComponent();
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
                if (nsgBus == null)
                {
                    nsgBus = new CoreBus();
                    nsgBus.EntryDate = DateTime.Now;
                    nsgBus.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    nsgBus.UpdateDate = DateTime.Now;
                    nsgBus.UpdateUserID = GlobalClass.LoggedInUserID;
                }

                nsgBus.RegistrationNumber = txtRegistrationNumber.Text;
                nsgBus.MaxPassengerAllowed = int.Parse(txtMaxSeatingAllowed.Text);
                nsgBus.TotalSeatCount = int.Parse(txtTotalSeatCount.Text);
                nsgBus.KilometerRun = int.Parse(txtKMRun.Text);
                nsgBus.DriverName = txtDriverName.Text;
                nsgBus.DriverContactNumber = txtDriverMobileNumber.Text;
                nsgBus.CoDriverName = txtCoDriverName.Text;
                nsgBus.CoDriverContactNumber = txtCoDriverMobileNumber.Text;
                nsgBus.BusRouteID = long.Parse(cmbRouteNumbers.SelectedValue.ToString());

                if (nsgBus.BusID == 0)
                {
                    DB.CoreBus.Add(nsgBus);
                }

                DB.SaveChanges();

                var msgResponse = MessageBox.Show("Bus details saved successfully. Do you want to continue with bus entry?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

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

        private void cmbRouteNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loading)
            {
                return;
            }

            if(cmbRouteNumbers.SelectedIndex == -1)
            {
                grdBusRouteDetails.DataSource = null;
            }
            else
            {
                long busRouteId = long.Parse(cmbRouteNumbers.SelectedValue.ToString());

                var nsgBusRouteDetails = (from brd in DB.CoreBusRouteDetails
                                          where brd.BusRouteID == busRouteId
                                          select new
                                          {
                                              brd.BusStopNumber,
                                              brd.BusStopName,
                                              brd.PickUpTime,
                                              brd.DropTime
                                          }).ToList(); 
                    
                grdBusRouteDetails.DataSource = nsgBusRouteDetails;
            }
        }

        private void frmBusDetail_Load(object sender, EventArgs e)
        {
            LoadCombos();
            RefreshMe();
        }

        private void LoadCombos()
        {
            loading = true;
            var busRoutes = DB.CoreBusRoutes.ToList();

            cmbRouteNumbers.DisplayMember = "RouteNo";
            cmbRouteNumbers.ValueMember = "BusRouteID";
            cmbRouteNumbers.DataSource = busRoutes;
            cmbRouteNumbers.SelectedIndex = -1;
            loading = false;
        }

        private void RefreshMe(bool reEntry = false)
        {
            if (reEntry)
            {
                nsgBusId = 0;
            }

            nsgBus = null;
            
            txtRegistrationNumber.Text = string.Empty;
            txtMaxSeatingAllowed.Text = string.Empty;
            txtTotalSeatCount.Text = string.Empty;
            txtKMRun.Text = string.Empty;
            txtDriverName.Text = string.Empty;
            txtDriverMobileNumber.Text = string.Empty;
            txtCoDriverName.Text = string.Empty;
            txtCoDriverMobileNumber.Text = string.Empty;
            cmbRouteNumbers.SelectedIndex = -1;
            
            if (nsgBusId > 0)
            {
                this.Text = "Bus Route Detail [EDIT] - ";
                LoadData();
                btnDelete.Visible = true;
            }
            else
            {
                this.Text = "Bus Route Detail [ADD]";
                btnDelete.Visible = false;
            }
        }

        private void LoadData()
        {
            nsgBus = DB.CoreBus.Where(b => b.BusID == nsgBusId).FirstOrDefault();

            txtRegistrationNumber.Text = nsgBus.RegistrationNumber;
            txtMaxSeatingAllowed.Text = nsgBus.MaxPassengerAllowed.ToString();
            txtTotalSeatCount.Text = nsgBus.TotalSeatCount.ToString();
            txtKMRun.Text = nsgBus.KilometerRun.ToString();
            txtDriverName.Text = nsgBus.DriverName;
            txtDriverMobileNumber.Text = nsgBus.DriverContactNumber;
            txtCoDriverName.Text = nsgBus.CoDriverName;
            txtCoDriverMobileNumber.Text = nsgBus.CoDriverContactNumber;
            cmbRouteNumbers.SelectedValue = nsgBus.BusRouteID;
            this.Text += nsgBus.RegistrationNumber;
        }

        private bool ValidateMainControls()
        {
            bool isDataValid = true;

            if (txtRegistrationNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Registration Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtMaxSeatingAllowed.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Max Seating Allowed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtTotalSeatCount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Total Seat Count.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtKMRun.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Kilometers Run.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtDriverName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Driver Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtDriverMobileNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Driver Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtCoDriverName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Co-Driver Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (txtCoDriverMobileNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Co-Driver Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (cmbRouteNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Route Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }
            
            return isDataValid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Are you sure you want to delete this Bus?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgResult == DialogResult.Yes)
            {
                try
                {
                    DB.CoreBus.Remove(nsgBus);
                    DB.SaveChanges();

                    MessageBox.Show("Bus deleted successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnClose_Click(null, null);
                }
                catch
                {
                    MessageBox.Show("Unable to delete this Bus right now.\nIt might have linked records, please delete them first then try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
