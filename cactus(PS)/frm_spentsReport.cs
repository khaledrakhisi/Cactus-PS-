using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using Persia;

namespace cactus_PS_
{
    public partial class frm_spentsReport : Form
    {
        SunDate shamsiDate = new SunDate();

        private DataSet dSet = new DataSet();
        private SqlDataAdapter dAdapter;
        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private string s_currentProjectTitle;
        public string currentProjectTitle
        {
            get { return s_currentProjectTitle; }
            set { s_currentProjectTitle = value; }
        }
        private int n_currentProjectID;
        public int currentPrjectID
        {
            get { return n_currentProjectID; }
            set { n_currentProjectID = value; }
        }

        private int n_spentDefID;
        public int spentDefID
        {
            get { return n_spentDefID; }
            set { n_spentDefID = value; }
        }

        public frm_spentsReport()
        {
            InitializeComponent();
        }

        private void SetParametersFieldInfo(String fieldName, String fieldValue, String field2Name, String field2Value)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = fieldValue;
            parameterDiscreteValue2.Value = field2Value;

            ParameterValues currentParameterValues = new ParameterValues();
            ParameterValues currentParameterValues2 = new ParameterValues();

            currentParameterValues.Add(parameterDiscreteValue);
            currentParameterValues2.Add(parameterDiscreteValue2);

            ParameterField parameterField = new ParameterField();
            ParameterField parameterField2 = new ParameterField();

            parameterField.Name = fieldName;
            parameterField.CurrentValues = currentParameterValues;
            parameterField2.Name = field2Name;
            parameterField2.CurrentValues = currentParameterValues2;

            ParameterFields parameterFields = new ParameterFields();

            parameterFields.Add(parameterField);
            parameterFields.Add(parameterField2);

            crystalReportViewer1.ParameterFieldInfo = parameterFields;
        }

        private void frm_spentsReport_Load(object sender, EventArgs e)
        {
            SetParametersFieldInfo("projectTitle2", currentProjectTitle, "nowDate", shamsiDate.Persian);

            shamsiDate = Calendar.ConvertToPersian(DateTime.Now);

            string sqlCmd = "";
            if (spentDefID > -1)
            {
                sqlCmd = "SELECT dbo.spentsTable.nRow, dbo.spentsTable.dDate, dbo.spentDef.spentDefName, dbo.spentsTable.event, dbo.spentsTable.indebtedPrice, " +
                          "dbo.spentsTable.creditorPrice, dbo.spentsTable.remainPrice, dbo.detectsTable.detectText, dbo.spentsTable.byCheque, " +
                          "dbo.projectsTable.projectTitle " +
                          "FROM dbo.spentsTable INNER JOIN " +
                          "dbo.spentDef ON dbo.spentsTable.spentDefID = dbo.spentDef.spentDefID INNER JOIN " +
                          "dbo.detectsTable ON dbo.spentsTable.detectID = dbo.detectsTable.detectID INNER JOIN " +
                          "dbo.projectsTable ON dbo.spentsTable.projectID = dbo.projectsTable.projectID " +
                          "WHERE (dbo.spentsTable.projectID = @nProjectID) AND (dbo.spentsTable.spentDefID = @nSpentDefID);";
            }
            else
            {
                sqlCmd = "SELECT dbo.spentsTable.nRow, dbo.spentsTable.dDate, dbo.spentDef.spentDefName, dbo.spentsTable.event, dbo.spentsTable.indebtedPrice, " +
                          "dbo.spentsTable.creditorPrice, dbo.spentsTable.remainPrice, dbo.detectsTable.detectText, dbo.spentsTable.byCheque, " +
                          "dbo.projectsTable.projectTitle " +
                          "FROM dbo.spentsTable INNER JOIN " +
                          "dbo.spentDef ON dbo.spentsTable.spentDefID = dbo.spentDef.spentDefID INNER JOIN " +
                          "dbo.detectsTable ON dbo.spentsTable.detectID = dbo.detectsTable.detectID INNER JOIN " +
                          "dbo.projectsTable ON dbo.spentsTable.projectID = dbo.projectsTable.projectID " +
                          "WHERE (dbo.spentsTable.projectID = @nProjectID);";
            }

            dAdapter = new SqlDataAdapter(sqlCmd, connectionString);
            dAdapter.SelectCommand.Parameters.Clear();
            dAdapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
            dAdapter.SelectCommand.Parameters.AddWithValue("@nSpentDefID", spentDefID);
            dAdapter.Fill(dSet, "spentsView");
            
            CrystalDecisions.CrystalReports.Engine.ReportDocument rp = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            rp.Load(@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_spents.rpt");
            rp.SetDataSource(dSet);
            crystalReportViewer1.ReportSource = rp;

            
    
        }
    }
}
