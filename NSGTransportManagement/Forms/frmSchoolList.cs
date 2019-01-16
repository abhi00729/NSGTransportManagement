using NSGTransportManagement.Classes;
using NSGTransportManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsExl = Microsoft.Office.Interop.Excel;

namespace NSGTransportManagement.Forms
{
    public partial class frmSchoolList : Form
    {
        private bool beenHere;
        private DataSet DSExcel = new DataSet();
        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();

        public frmSchoolList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmSchoolDetail")
                {
                    form.Close();
                    break;
                }
            }

            frmSchoolDetail schoolDetailForm = new frmSchoolDetail();
            schoolDetailForm.MdiParent = this.MdiParent;
            schoolDetailForm.Show();
            beenHere = false;
        }

        private void frmSchoolList_Load(object sender, EventArgs e)
        {
            btnExcelExport.Visible = true;
            btnExcelExport.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdSchoolList.Rows.Count <= 0 || grdSchoolList.CurrentRow == null)
            {
                return;
            }

            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "frmSchoolDetail")
                {
                    form.Close();
                    break;
                }
            }

            frmSchoolDetail schoolDetailForm = new frmSchoolDetail(int.Parse(grdSchoolList.CurrentRow.Cells[0].Value.ToString()));
            schoolDetailForm.MdiParent = this.MdiParent;
            schoolDetailForm.Show();
            beenHere = false;
        }

        private void frmSchoolList_Activated(object sender, EventArgs e)
        {
            if (!beenHere)
            {
                LoadValues();
            }
        }

        private void LoadValues()
        {
            string routeNumber = "";
            btnExcelExport.Enabled = false;

            if (txtRouteNumber.Text.Length > 0 && Validation.ValidateTextIsNumeric(txtRouteNumber))
            {
                routeNumber = txtRouteNumber.Text;
            }

            var schoolDetails = DB.SchoolDetailsGet(txtSchoolName.Text, routeNumber);

            grdSchoolList.DataSource = schoolDetails;
            
            if (grdSchoolList.Rows.Count > 0)
            {
                grdSchoolList.Rows[0].Selected = false;
                lblTotalRecordCount.Text = "Total Records Found: (" + Convert.ToString(grdSchoolList.Rows.Count) + ") out of [" + Convert.ToString(DB.CoreSchools.Count()) + "]";
                btnExcelExport.Enabled = true;
            }
            else
            {
                lblTotalRecordCount.Text = "Total Records Found: (0)";
            }

            beenHere = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadValues();
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            MsExl.Application app = null;
            MsExl.Workbook wb = null;
            MsExl.Worksheet ws = null;

            if (MessageBox.Show("This process will take few minutes to generate file. \n Click OK to Continue.", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }

            try
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                app = new MsExl.Application();
                app.Visible = false;

                wb = app.Workbooks.Add(MsExl.XlWBATemplate.xlWBATWorksheet);
                ws = (MsExl.Worksheet)wb.ActiveSheet;

                // Headers. 
                for (int i = 0; i < grdSchoolList.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = grdSchoolList.Columns[i].Name;
                }

                // Content.  
                for (int i = 0; i < grdSchoolList.Rows.Count; i++)
                {
                    for (int j = 0; j < grdSchoolList.Columns.Count; j++)
                    {
                        if (grdSchoolList.Rows[i].Cells[j].Value != null)
                        {
                            ws.Cells[i + 2, j + 1] = grdSchoolList.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // Autofit Cells,Column and Rows Width.
                ws.Columns.AutoFit();
                ws.Rows.WrapText = true;

                ws.Range[ws.Cells[1, 1], ws.Cells[grdSchoolList.Rows.Count + 1, grdSchoolList.Columns.Count]].Borders.LineStyle = true;
                ws.Range[ws.Cells[1, 1], ws.Cells[1, grdSchoolList.Columns.Count]].Font.Bold = true;

                wb.SaveAs(GetExportFileName(".xls"), MsExl.XlFileFormat.xlWorkbookNormal,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);

                wb.Close(Missing.Value, Missing.Value, Missing.Value);
                app.Quit();
                app = null;
                wb = null;
                ws = null;

                MessageBox.Show("Export Excel file successfully created at below mentioned path. \n " + GetExportFileName(".xls"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;

                if (app != null)
                {
                    wb = null;
                    ws = null;
                    app.Quit();
                    app = null;
                }

                MessageBox.Show(ex.Message, this.Text + " : btnExcelExport_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetExportFileName(string format)
        {
            string dirChar = AppDomain.CurrentDomain.BaseDirectory.Substring(0, 1);

            string dir = dirChar + @":\NSGExports";
            string fileName = "";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            fileName = dir + @"\NSGSchoolDetails" + DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss") + ".xls";

            return fileName;
        }

        private void grdSchoolList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEdit_Click(null, null);
        }
    }
}
