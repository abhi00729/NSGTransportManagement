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
    public partial class frmBusRouteDetail : Form
    {
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();
        CoreBusRoute nsgBusRoute;
        List<CoreBusRouteDetail> nsgBusRouteDetails;
        List<CoreBusRouteSchool> nsgBusRouteSchools;

        long busRouteId = 0;
        public frmBusRouteDetail()
        {
            InitializeComponent();
        }

        public frmBusRouteDetail(long routeId)
        {
            busRouteId = routeId;
            InitializeComponent();
        }

        private void frmBusRouteDetail_Load(object sender, EventArgs e)
        {
            grdPickupPoints.AutoGenerateColumns = false;
            grdPickupPoints.Columns[0].DataPropertyName = "BusStopNumber";
            grdPickupPoints.Columns[1].DataPropertyName = "BusStopName";
            grdPickupPoints.Columns[2].DataPropertyName = "PickUpTime";
            grdPickupPoints.Columns[3].DataPropertyName = "DropTime";

            grdSchools.AutoGenerateColumns = false;
            grdSchools.Columns[0].DataPropertyName = "SchoolID";
            grdSchools.Columns[1].DataPropertyName = "SchoolName";
            grdSchools.Columns[2].DataPropertyName = "Selected";

            RefreshMe();
        }

        private void RefreshMe(bool reEntry = false)
        {
            if (reEntry)
            {
                busRouteId = 0;
            }

            nsgBusRoute = null;
            nsgBusRouteDetails = null;

            txtBusRouteNumber.Text = string.Empty;
            grdPickupPoints.Rows.Clear();

            if (busRouteId > 0)
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

            var busRouteSchools = DB.BusRouteSchoolsGet(int.Parse(busRouteId.ToString()));

            grdSchools.DataSource = busRouteSchools;
        }

        private void LoadData()
        {
            nsgBusRoute = DB.CoreBusRoutes.Where(br => br.BusRouteID == busRouteId).FirstOrDefault();

            txtBusRouteNumber.Text = nsgBusRoute.RouteNo;

            this.Text += nsgBusRoute.RouteNo;
            
            nsgBusRouteDetails = DB.CoreBusRouteDetails.Where(brd => brd.BusRouteID == busRouteId).ToList();

            if (nsgBusRouteDetails != null)
            {
                foreach (var nsgBusRouteDetail in nsgBusRouteDetails)
                {
                    grdPickupPoints.Rows.Add(new[] { nsgBusRouteDetail.BusStopNumber.ToString(), nsgBusRouteDetail.BusStopName, nsgBusRouteDetail.PickUpTime, nsgBusRouteDetail.DropTime });
                }
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
                if (nsgBusRoute == null)
                {
                    nsgBusRoute = new CoreBusRoute();
                    nsgBusRoute.EntryDate = DateTime.Now;
                    nsgBusRoute.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    nsgBusRoute.UpdateDate = DateTime.Now;
                    nsgBusRoute.UpdateUserID = GlobalClass.LoggedInUserID;
                }

                nsgBusRoute.RouteNo = txtBusRouteNumber.Text;

                if(nsgBusRoute.BusRouteID == 0)
                {
                    DB.CoreBusRoutes.Add(nsgBusRoute);
                }

                DB.SaveChanges();

                busRouteId = nsgBusRoute.BusRouteID;

                nsgBusRouteDetails = DB.CoreBusRouteDetails.Where(d => d.BusRouteID == busRouteId).ToList();

                if (nsgBusRouteDetails != null)
                {
                    DB.CoreBusRouteDetails.RemoveRange(nsgBusRouteDetails);
                    DB.SaveChanges();
                }
                nsgBusRouteDetails = new List<CoreBusRouteDetail>();

                for(int i = 0; i < grdPickupPoints.RowCount; i++)
                {
                    if (grdPickupPoints.Rows[i].Cells[0].Value != null)
                    {
                        nsgBusRouteDetails.Add(new CoreBusRouteDetail()
                        {
                            BusRouteID = busRouteId,
                            BusStopNumber = int.Parse(grdPickupPoints.Rows[i].Cells[0].Value.ToString()),
                            BusStopName = grdPickupPoints.Rows[i].Cells[1].Value.ToString(),
                            PickUpTime = grdPickupPoints.Rows[i].Cells[2].Value.ToString(),
                            DropTime = grdPickupPoints.Rows[i].Cells[3].Value.ToString(),
                            EntryUserID = GlobalClass.LoggedInUserID,
                            EntryDate = DateTime.Now
                        });
                    }
                }

                DB.CoreBusRouteDetails.AddRange(nsgBusRouteDetails);
                DB.SaveChanges();

                nsgBusRouteSchools = DB.CoreBusRouteSchools.Where(s => s.BusRouteID == busRouteId).ToList();

                DB.CoreBusRouteSchools.RemoveRange(nsgBusRouteSchools);
                DB.SaveChanges();

                nsgBusRouteSchools = new List<CoreBusRouteSchool>();

                for (int i = 0; i < grdSchools.Rows.Count; i++)
                {
                    if (bool.Parse(grdSchools.Rows[i].Cells[2].Value.ToString()) == true)
                    {
                        nsgBusRouteSchools.Add(new CoreBusRouteSchool()
                        {
                            BusRouteID = busRouteId,
                            SchoolID = long.Parse(grdSchools.Rows[i].Cells[0].Value.ToString()),
                            EntryUserID = GlobalClass.LoggedInUserID,
                            EntryDate = DateTime.Now
                        });
                    }
                }

                DB.CoreBusRouteSchools.AddRange(nsgBusRouteSchools);
                DB.SaveChanges();

                var msgResponse = MessageBox.Show("Bus Route Details saved successfully. Do you want to continue with new route entry?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

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

            if (txtBusRouteNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Bus Route Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            if (grdPickupPoints.RowCount == 0)
            {
                MessageBox.Show("Please enter the Pickup Points.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            int schoolCount = 0;
            for(int i = 0; i < grdSchools.Rows.Count; i++)
            {
                if(bool.Parse(grdSchools.Rows[i].Cells[2].Value.ToString()) == true)
                {
                    schoolCount++;
                }
            } 

            if(schoolCount == 0)
            {
                MessageBox.Show("Please select at least one school.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDataValid = false;
            }

            return isDataValid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Are you sure you want to delete this Bus Route?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgResult == DialogResult.Yes)
            {
                try
                {
                    var delBusRouteSchools = DB.CoreBusRouteSchools.Where(brs => brs.BusRouteID == busRouteId).ToList();

                    if (delBusRouteSchools != null)
                    {
                        DB.CoreBusRouteSchools.RemoveRange(delBusRouteSchools);
                        DB.SaveChanges();
                    }

                    if(nsgBusRouteDetails != null)
                    {
                        DB.CoreBusRouteDetails.RemoveRange(nsgBusRouteDetails);
                        DB.SaveChanges();
                    }
                    
                    DB.CoreBusRoutes.Remove(nsgBusRoute);
                    DB.SaveChanges();

                    MessageBox.Show("Bus Route deleted successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnClose_Click(null, null);
                }
                catch
                {
                    MessageBox.Show("Unable to delete this Bus Route right now.\nIt might have linked records, please delete them first then try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
