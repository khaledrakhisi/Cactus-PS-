using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace cactus_PS_
{
    public partial class frm_printAccDoc : Form
    {
        public frm_printAccDoc()
        {
            s_ind = "0";
            s_cre = "0";
            s_rem = "0";
            s_detect = "";
            s_total = "";
            s_dateString = "";
            InitializeComponent();
        }
        public DataSet dSet = new DataSet();
        public string sFilePath;

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }
        private string s_total;
        public string TotalOfInvoice
        {
            set { s_total = value; }
        }

        private string s_dateString;
        public string dateString
        {
            set { s_dateString = value; }
        }
        public string s_ind, s_cre, s_rem, s_detect;

        private void SetParametersFieldInfo(String fieldName, String fieldValue, String field2Name, long field2Value, String field3Name, long field3Value, String field4Name, long field4Value, String field5Name, String field5Value)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue3 = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue4 = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue5 = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = fieldValue;
            parameterDiscreteValue2.Value = field2Value;
            parameterDiscreteValue3.Value = field3Value;
            parameterDiscreteValue4.Value = field4Value;
            parameterDiscreteValue5.Value = field5Value;

            ParameterValues currentParameterValues = new ParameterValues();
            ParameterValues currentParameterValues2 = new ParameterValues();
            ParameterValues currentParameterValues3 = new ParameterValues();
            ParameterValues currentParameterValues4 = new ParameterValues();
            ParameterValues currentParameterValues5 = new ParameterValues();

            currentParameterValues.Add(parameterDiscreteValue);
            currentParameterValues2.Add(parameterDiscreteValue2);
            currentParameterValues3.Add(parameterDiscreteValue3);
            currentParameterValues4.Add(parameterDiscreteValue4);
            currentParameterValues5.Add(parameterDiscreteValue5);

            ParameterField parameterField = new ParameterField();
            ParameterField parameterField2 = new ParameterField();
            ParameterField parameterField3 = new ParameterField();
            ParameterField parameterField4 = new ParameterField();
            ParameterField parameterField5 = new ParameterField();

            parameterField.Name = fieldName;
            parameterField.CurrentValues = currentParameterValues;

            parameterField2.Name = field2Name;
            parameterField2.CurrentValues = currentParameterValues2;

            parameterField3.Name = field3Name;
            parameterField3.CurrentValues = currentParameterValues3;

            parameterField4.Name = field4Name;
            parameterField4.CurrentValues = currentParameterValues4;

            parameterField5.Name = field5Name;
            parameterField5.CurrentValues = currentParameterValues5;

            ParameterFields parameterFields = new ParameterFields();

            parameterFields.Add(parameterField);
            parameterFields.Add(parameterField2);
            parameterFields.Add(parameterField3);
            parameterFields.Add(parameterField4);
            parameterFields.Add(parameterField5);

            crystalReportViewer1.ParameterFieldInfo = parameterFields;
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
                
        private void frm_printAccDoc_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rp = new ReportDocument();
                rp.Load(sFilePath);
                rp.SetDataSource(dSet);                
                crystalReportViewer1.ReportSource = rp;
                if (s_dateString == "")
                {
                    if (s_total != "" && s_rem != "0")//ledger
                    {
                        if (s_ind == "")
                            s_ind = "0";
                        if (s_cre == "")
                            s_cre = "0";
                        if (s_rem == "")
                            s_rem = "0";
                        SetParametersFieldInfo("TotalInChars", numberConvertor.convertToChars(s_total) + " ریال ", "fromPriorPageIndebted", long.Parse(s_ind), "fromPriorPageCreditor", long.Parse(s_cre), "fromPriorPageRemain", long.Parse(s_rem), "fromPriorPageDetect", s_detect);
                        crystalReportViewer1.Zoom(110);
                    }
                    else if (s_total != "" && s_rem == "0")//journal
                    {
                        SetParameterFieldInfo("TotalInChars", numberConvertor.convertToChars(s_total) + " ریال ");
                        crystalReportViewer1.Zoom(100);
                    }
                    else if (s_total == "")//accDoc
                    {
                        crystalReportViewer1.Zoom(100);
                    }
                }
                else//balance or Taraznameh
                {
                    SetParameterFieldInfo("dateString", s_dateString);                    
                    crystalReportViewer1.DisplayGroupTree = false;
                    crystalReportViewer1.ShowGroupTreeButton = false;
                    crystalReportViewer1.Zoom(120);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_printAccDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
