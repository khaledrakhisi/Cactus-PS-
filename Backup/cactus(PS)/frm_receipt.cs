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

namespace cactus_PS_
{
    public partial class frm_receipt : Form
    {
        private DataSet dSet = new DataSet();
        private SqlDataAdapter dAdapter;

        private string s_price;
        public string price
        {
            get { return s_price; }
            set { s_price = value; }
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }
        private int n_currentDocID;
        public int currentDocID
        {
            get { return n_currentDocID; }
            set { n_currentDocID = value; }
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
        private int n_currentPersonID;
        public int currentPersonID
        {
            get { return n_currentPersonID; }
            set { n_currentPersonID = value; }
        }
        private bool b_INReceipt;
        public bool INReceipt
        {
            get { return b_INReceipt; }
            set { b_INReceipt = value; }
        }

        public frm_receipt()
        {
            InitializeComponent();
        }

        private void SetParameterFieldInfo(String fieldName, String fieldValue)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            parameterDiscreteValue.Value = fieldValue;
            ParameterValues currentParameterValues = new ParameterValues();
            currentParameterValues.Add(parameterDiscreteValue);
            ParameterField parameterField = new ParameterField();
            parameterField.Name = fieldName;
            parameterField.CurrentValues = currentParameterValues;
            ParameterFields parameterFields = new ParameterFields();
            parameterFields.Add(parameterField);
            crystalReportViewer1.ParameterFieldInfo = parameterFields;
        }


        private void frm_receipt_Load(object sender, EventArgs e)
        {
            try
            {
                SetParameterFieldInfo("priceInChar", numberConvertor.convertToChars(s_price));

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                dAdapter.SelectCommand.CommandText = "SELECT dbo.docsTable.price, dbo.docsTable.docComment, dbo.personsTable.personFamilyAndName, dbo.docsTable.dDate, dbo.docsTable.docID, dbo.personsTable.personNO, dbo.personsTable.personBorn, dbo.personsTable.fatherName " +
                                                     "FROM dbo.docsTable INNER JOIN " +
                                                     "dbo.personsTable ON dbo.docsTable.personID = dbo.personsTable.personID " +
                                                     "WHERE (dbo.docsTable.docID = @nDocID)";
                dAdapter.SelectCommand.Parameters.Clear();
                dAdapter.SelectCommand.Parameters.AddWithValue("@nDocID", currentDocID);
                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "INReceiptView");
                dAdapter.SelectCommand.Connection.Close();

                dAdapter.SelectCommand.CommandText = "SELECT dbo.chequesTable.chequeNumber, dbo.BanksTable.bankName, dbo.chequesTable.chequePrice, dbo.chequesTable.usanceDate " +
                                                     "FROM dbo.chequesTable INNER JOIN " +
                                                     "dbo.BanksTable ON dbo.chequesTable.bankID = dbo.BanksTable.bankID " +
                                                     "WHERE (dbo.chequesTable.accDoc_id = @nDocID)";
                dAdapter.SelectCommand.Parameters.Clear();
                dAdapter.SelectCommand.Parameters.AddWithValue("@nDocID", numberConvertor.getAccDoc_id(currentDocID, "doc", connectionString));
                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "chequesView");
                dAdapter.SelectCommand.Connection.Close();

                CrystalDecisions.CrystalReports.Engine.ReportDocument rp = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                if (b_INReceipt)
                {
                    rp.Load(Application.StartupPath + "\\rpt_receiptIN.rpt");//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_receiptIN.rpt");
                }
                else
                {
                    rp.Load(Application.StartupPath + "\\rpt_receiptOUT.rpt");//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_receiptOUT.rpt");
                }
                rp.SetDataSource(dSet);
                crystalReportViewer1.ReportSource = rp;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
