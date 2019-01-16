using Microsoft.Reporting.WinForms;
using NSGTransportManagement.DAL;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace NSGTransportManagement.Forms
{
    public partial class frmReportViewer : Form
    {
        private string currentReportName;
        private object currentReportDataSource;

        public frmReportViewer(string reportName, object reportDataSource)
        {
            currentReportName = reportName;
            currentReportDataSource = reportDataSource;
            InitializeComponent();
        }

        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            string reportDataQuery = string.Empty;
            string reportPath = string.Empty;
            //ReportParameterCollection rpc = null;

            try
            {
                reportPath = AppDomain.CurrentDomain.BaseDirectory.ToLower();

                reportPath = reportPath.Replace(@"\bin", "");

                reportPath = reportPath.Replace(@"\debug", "");

                reportPath = reportPath.Replace(@"\release", "");

                reportPath += @"\Reports\" + currentReportName + ".rdlc";

                rvReportViewer.LocalReport.ReportPath = reportPath;

                rvReportViewer.LocalReport.DataSources.Clear();

                var reportDataSource = ConvertToDataTable((StudentPassDetailView)currentReportDataSource);

                rvReportViewer.LocalReport.DataSources.Add(new ReportDataSource("reportDataSource", reportDataSource));

                //ReportParameterInfo[] rpic = rvReportViewer.LocalReport.GetParameters().ToArray();

                //if (rpic.Length > 0)
                //{
                //    rpc = new ReportParameterCollection();

                //    for (int i = 0; i < rpic.Length; i++)
                //    {
                //        rpc.Add(new ReportParameter(rpic[i].Name, ReportParameters[i]));
                //    }

                //    rvReportViewer.LocalReport.SetParameters(rpc);
                //}

                rvReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private DataTable ConvertToReportDataSource(object dataSource)
        //{
        //    DataTable returnValue = null;

        //    switch (currentReportName)
        //    {
        //        case "CivilianLabourPass":
        //        case "CivilianRegularPass":
        //            //reportDataSource = DB.CivilianPassDetailViews.Where(clp => clp.NSGPassID == nsgPassId).FirstOrDefault();
        //            returnValue = ConvertToDataTable((CivilianPassDetailView)dataSource);
        //            break;
        //        case "DependentPass":
        //        case "GuestPass":
        //            //reportDataSource = DB.GuestDependentPassDetailViews.Where(gdpd => gdpd.NSGPassID == nsgPassId).FirstOrDefault();
        //            returnValue = ConvertToDataTable((GuestDependentPassDetailView)dataSource);
        //            break;
        //        case "NSGPersonalVehiclePass":
        //            //reportDataSource = DB.NSGPersonalVehiclePassViews.Where(npv => npv.NSGPassID == nsgPassId).FirstOrDefault();
        //            returnValue = ConvertToDataTable((NSGPersonalVehiclePassView)dataSource);
        //            break;
        //        case "CivilianVehiclePass":
        //            //reportDataSource = DB.CivilianVehiclePassViews.Where(cvp => cvp.NSGPassID == nsgPassId).FirstOrDefault();
        //            returnValue = ConvertToDataTable((CivilianVehiclePassView)dataSource);
        //            break;
        //        case "OutlivingPass":
        //            //reportDataSource = DB.OutlivingPassViews.Where(opv => opv.NSGPassID == nsgPassId).FirstOrDefault();
        //            returnValue = ConvertToDataTable((OutlivingPassView)dataSource);
        //            break;
        //        default:
        //            break;
        //    }

        //    return returnValue;
        //}

        private DataTable ConvertToDataTable<T>(T item, bool treatEmptyStringAsNull = false)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            //foreach (T item in data)
            //{
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                if (prop.PropertyType == typeof(string) && treatEmptyStringAsNull)
                {
                    row[prop.Name] = (prop.GetValue(item).ToString() == string.Empty ? DBNull.Value : prop.GetValue(item));
                }
                else
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
            }
            table.Rows.Add(row);
            //}
            return table;
        }

        public string[] ReportParameters { get; set; }
    }
}
