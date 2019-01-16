using NSGTransportManagement.Classes;
using NSGTransportManagement.DAL;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MsExl = Microsoft.Office.Interop.Excel;

namespace NSGTransportManagement.Forms
{
    public partial class frmPassHolderSearch : Form
    {
        private bool beenHere;
        private DataSet DSExcel = new DataSet();

        private NSGTransportManagementEntities DB = new NSGTransportManagementEntities();
        
        public frmPassHolderSearch()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "frmStudentPass")
                {
                    form.Close();
                    break;
                }
            }

            frmStudentPass studentPassForm = new frmStudentPass();
            studentPassForm.MdiParent = this.MdiParent;
            studentPassForm.Show();

            beenHere = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisitorSearch_Load(object sender, EventArgs e)
        {
            //FillCombos();
            beenHere = false;
            btnExcelExport.Visible = true;
            btnExcelExport.Enabled = false;
        }

        //private void FillCombos()
        //{
        //    var passTypes = DB.CorePassTypes.ToList();

        //    cmbPassType.DisplayMember = "PassTypeName";
        //    cmbPassType.ValueMember = "PassTypeID";
        //    cmbPassType.DataSource = passTypes;
        //    cmbPassType.SelectedIndex = -1;
        //}

        private void frmVisitorSearch_Activated(object sender, EventArgs e)
        {
            if (!beenHere)
            {
                LoadValues();
            }
        }

        private void LoadValues()
        {
            long? passNumber = null;
            DateTime? issueDate = null;
            DateTime? expiryDate = null;

            if(dteIssueDate.Checked)
            {
                issueDate = dteIssueDate.Value.Date;
            }

            if(dteExpiryDate.Checked)
            {
                expiryDate = dteExpiryDate.Value.Date;
            }

            if (dteIssueDate.Checked && dteExpiryDate.Checked)
            {
                string Message = Validation.ValidateDateSelection(dteIssueDate, dteExpiryDate);

                if (Message != String.Empty)
                {
                    MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if(txtPassNumber.Text.Length > 0 && Validation.ValidateTextIsNumeric(txtPassNumber))
            {
                passNumber = long.Parse(txtPassNumber.Text);
            }
            
            var passHoldersDetail = DB.PassHolderDetailsGet(issueDate, expiryDate, passNumber, txtStudentName.Text, txtSchoolName.Text, chkActiveOnly.Checked);
            
            grdPassHolderDetails.DataSource = passHoldersDetail;
            
            if (grdPassHolderDetails.Rows.Count > 0)
            {
                grdPassHolderDetails.Rows[0].Selected = false;
            }
            
            if (grdPassHolderDetails.Rows.Count > 0)
            {
                lblTotalRecordCount.Text = "Total Records Found: (" + Convert.ToString(grdPassHolderDetails.Rows.Count) + ") out of [" + Convert.ToString(DB.NSGStudents.Count()) + "]";
            }
            else
            {
                lblTotalRecordCount.Text = "Total Records Found: (0)";
            }

            btnExcelExport.Enabled = false;

            if (grdPassHolderDetails.Rows.Count > 0)
            {
                btnExcelExport.Enabled = true;
            }

            beenHere = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadValues();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdPassHolderDetails.Rows.Count <= 0 || grdPassHolderDetails.CurrentRow == null)
            {
                return;
            }

            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "frmStudentPass")
                {
                    form.Close();
                    break;
                }
            }

            frmStudentPass studentPassForm = new frmStudentPass(int.Parse(grdPassHolderDetails.CurrentRow.Cells[0].Value.ToString()));
            studentPassForm.MdiParent = this.MdiParent;
            studentPassForm.Show();

            beenHere = false;
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
                for (int i = 0; i < grdPassHolderDetails.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = grdPassHolderDetails.Columns[i].Name;
                }

                // Content.  
                for (int i = 0; i < grdPassHolderDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < grdPassHolderDetails.Columns.Count; j++)
                    {
                        if (grdPassHolderDetails.Rows[i].Cells[j].Value != null)
                        {
                            ws.Cells[i + 2, j + 1] = grdPassHolderDetails.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                
                // Autofit Cells,Column and Rows Width.
                ws.Columns.AutoFit();
                ws.Rows.WrapText = true;

                ws.Range[ws.Cells[1, 1], ws.Cells[grdPassHolderDetails.Rows.Count + 1, grdPassHolderDetails.Columns.Count]].Borders.LineStyle = true;
                ws.Range[ws.Cells[1, 1], ws.Cells[1, grdPassHolderDetails.Columns.Count]].Font.Bold = true;

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
            catch(Exception ex)
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

            fileName = dir + @"\NSGStudentDetails" + DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss") + ".xls";

            return fileName;
        }

        private void grdPassHolderDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEdit_Click(null, null);
        }
    }
}
