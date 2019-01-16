using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NSGTransportManagement.Forms;
using System.Data.SqlClient;
using NSGTransportManagement.Classes;

namespace NSGTransportManagement
{
    public partial class frmMainPage : Form
    {
        Form formToOpen;
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void mnuFileChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmChangePassword"))
            {
                return;
            }

            formToOpen = new frmChangePassword();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }
        
        private bool CheckIsFormOpen(string frmName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == frmName)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.Text = " Welcome " + GlobalClass.EmployeeName + " [ "+ GlobalClass.LoggedInUserRank +" ] " + " [" + GlobalClass.LoggedInUserUnit + "] " + " | " + GlobalClass.ProductName + " [" + GlobalClass.BuildVersion + "]";
        }

        private void mnuFileNSGEmployees_Click(object sender, EventArgs e)
        {
            formToOpen = new frmCreateUser();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuVisitorBookVisitorSearch_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmVisitorSearch"))
            {
                return;
            }

            formToOpen = new frmPassHolderSearch();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout af = new frmAbout();
            af.MdiParent = this;
            af.Show();
        }

        private void frmMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure your want to close this Application?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuMastersStates_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.States);
        }

        private void mnuMastersCities_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Cities);
        }

        private void mnuMastersUsers_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Users);
        }
        
        private void mnuMastersRelationships_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Relationships);
        }

        private void mnuMastersRanks_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Ranks);
        }

        private void mnuMastersUnits_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Units);
        }

        private void mnuMastersQuarterTypes_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.QuarterTypes);
        }

        private void OpenMasterList(MasterTypes masterType)
        {
            if (CheckIsFormOpen("frmMasterList"))
            {
                return;
            }

            formToOpen = new frmMasterList(masterType);
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuPassManagementCreate_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmStudentPass"))
            {
                return;
            }

            formToOpen = new frmStudentPass();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuPassManagementSearch_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmPassHolderSearch"))
            {
                return;
            }

            formToOpen = new frmPassHolderSearch();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuListViewSchools_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmSchoolList"))
            {
                return;
            }

            formToOpen = new frmSchoolList();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void tsbSchools_Click(object sender, EventArgs e)
        {
            mnuListViewSchools_Click(sender, e);
        }

        private void mnuListViewBuses_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmBusList"))
            {
                return;
            }

            formToOpen = new frmBusList();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void tsbBuses_Click(object sender, EventArgs e)
        {
            mnuListViewBuses_Click(sender, e);
        }

        private void mnuListViewBusRoutes_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmBusRouteList"))
            {
                return;
            }

            formToOpen = new frmBusRouteList();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void tsbBusRoutes_Click(object sender, EventArgs e)
        {
            mnuListViewBusRoutes_Click(sender, e);
        }

        private void tsbSearchStudent_Click(object sender, EventArgs e)
        {
            mnuPassManagementSearch_Click(sender, e);
        }

        private void tsbStudentPass_Click(object sender, EventArgs e)
        {
            mnuPassManagementCreate_Click(sender, e);
        }
    }
}
